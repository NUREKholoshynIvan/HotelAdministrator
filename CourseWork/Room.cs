using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CourseWork
{
    [Serializable]
    public class Room
    {
        public int Floor;
        public int RoomNumber;
        public Visitor Visitor;
        public bool Occupied = false;
        public DateTime SettlingDate;
        public DateTime UnSettlingDate;

        public void Unsettle()
        {
            Occupied = false;
            Visitor.Settled = false;
        }
    }
}
