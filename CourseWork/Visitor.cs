using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CourseWork
{
    [Serializable]
    public abstract class Visitor
    {
        public string Name = "";
        public string Surname = "";
        public string Passport = "";
        public bool Settled = false;
        public Room Room;
        public int VisitorsNumber = 1;

        public void Unsettle()
        {
            Settled = false;
            Room.Occupied = false;
        }

        public abstract string GetData(int type);
    }
}
