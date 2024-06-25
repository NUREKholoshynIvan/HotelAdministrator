using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CourseWork
{
    [Serializable]
    public class Hotel
    {
        public Room[,] Rooms = new Room[4,16];
        public DateTime ThisDay = DateTime.Today;
        public List<Room> UnsettlingToday = new List<Room>();
        public int price = 150;
        public void CreateHotel()
        {
            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 16; j++)
                {
                    Rooms[i, j] = new Room();
                    Rooms[i, j].RoomNumber = j+1;
                    Rooms[i, j].Floor = i+1;
                }
            }
        }
        
        public void Settle(int floor, int room, Visitor visitor, int days)
        {
            Rooms[floor - 1, room - 1].Visitor = visitor;
            visitor.Room = Rooms[floor - 1, room - 1];
            visitor.Settled = true;
            Rooms[floor - 1, room - 1].Occupied = true;
            Rooms[floor - 1, room - 1].SettlingDate = ThisDay;
            Rooms[floor - 1, room - 1].UnSettlingDate = ThisDay.AddDays(days);
        }
        public void UnSettle(int floor, int room)
        {
            Rooms[floor - 1, room - 1].Occupied = false;
            Rooms[floor - 1, room - 1].Visitor.Settled = false;
            if(Rooms[floor - 1, room - 1].UnSettlingDate == ThisDay)
            {
                UnsettlingToday.Remove(Rooms[floor - 1, room - 1]);
            }
            Rooms[floor - 1, room - 1].UnSettlingDate = ThisDay;
        }
        public void Replace(int floor1, int room1, int floor2, int room2)
        {
            Rooms[floor1 - 1, room1 - 1].Occupied = false;
            Rooms[floor2 - 1, room2 - 1].Occupied = true;
            Rooms[floor2 - 1, room2 - 1].Visitor = Rooms[floor1 - 1, room1 - 1].Visitor;
            Rooms[floor1 - 1, room1 - 1].Visitor.Settled = false;
            Rooms[floor2 - 1, room2 - 1].Visitor.Room = Rooms[floor2 - 1, room2 - 1];
            Rooms[floor2 - 1, room2 - 1].SettlingDate = Rooms[floor1 - 1, room1 - 1].SettlingDate;
            Rooms[floor2 - 1, room2 - 1].UnSettlingDate = Rooms[floor1 - 1, room1 - 1].UnSettlingDate;
            if (Rooms[floor1 - 1, room1 - 1].UnSettlingDate == ThisDay)
            {
                UnsettlingToday.Remove(Rooms[floor1 - 1, room1 - 1]);
                UnsettlingToday.Add(Rooms[floor2 - 1, room2 - 1]);
            }
        }

        public void AddDays(int floor, int room, int days)
        {
            Rooms[floor - 1, room - 1].UnSettlingDate = Rooms[floor - 1, room - 1].UnSettlingDate.AddDays(days);
        }
        /*public List<Visitor> FindVisitors(string name, string surname)
        {
            List<Visitor> foundVisitors = new List<Visitor>();

            foreach (Room room in Rooms)
            {
                if (room.Occupied)
                {
                    if ((name != null && room.Visitor.Name.StartsWith(name)) ||
                        (surname != null && room.Visitor.Surname.StartsWith(surname)))
                    {
                        foundVisitors.Add(room.Visitor);
                    }
                }
            }

            return foundVisitors;
        }*/
        public List<Visitor> FindVisitors(string name, string surname)
        {
            List<Visitor> foundVisitors = new List<Visitor>();

            foreach (Room room in Rooms)
            {
                if (room.Occupied)
                {
                    bool matches = true;

                    if (name != null)
                    {
                        matches = matches && room.Visitor.Name.StartsWith(name);
                    }

                    if (surname != null)
                    {
                        matches = matches && room.Visitor.Surname.StartsWith(surname);
                    }

                    if (matches)
                    {
                        foundVisitors.Add(room.Visitor);
                    }
                }
            }

            return foundVisitors;
        }
        public void NextDay()
        {
            foreach(Room room in UnsettlingToday)
            {
                room.Unsettle();
            }
            UnsettlingToday.Clear();
            ThisDay = ThisDay.AddDays(1);
            foreach(Room room in Rooms)
            {
                if (room.Occupied)
                {
                    if(room.UnSettlingDate == ThisDay) UnsettlingToday.Add(room);
                }
            }
        }
        // Метод для сохранения отеля в файл
        public void SaveToFile(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, this);
            }
        }

        public static Hotel LoadFromFile(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (Hotel)formatter.Deserialize(fs);
            }
        }
    }

}
