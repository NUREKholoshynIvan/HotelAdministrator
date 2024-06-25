using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CourseWork
{
    [Serializable]
    public class Couple : Visitor
    {
        public string SecondName;
        public string SecondSurname;

        public override string GetData(int type)
        {
            string result = $"{Name} {Surname}, {SecondName} {SecondSurname}, {Passport}, етаж {Room.Floor} кімната {Room.RoomNumber}, заїхали {Room.SettlingDate.ToString("dd-MM-yyyy")}";
            if(type == 1)
            {
                result += $", від'їжджають {Room.UnSettlingDate.ToString("dd-MM-yyyy")}";
            }
            return result + ".";
        }
    }
}
