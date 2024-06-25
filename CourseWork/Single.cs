using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CourseWork
{
    [Serializable]
    public  class Single : Visitor
    {
        public override string GetData(int type)
        {
            string result = $"{Name} {Surname}, {Passport}, етаж {Room.Floor} кімната {Room.RoomNumber}, заїхав {Room.SettlingDate.ToString("dd-MM-yyyy")}";
            if(type == 1)
            {
                result += $", від'їжджає {Room.UnSettlingDate.ToString("dd-MM-yyyy")}";
            }
            return result + ".";
        }
    }
}
