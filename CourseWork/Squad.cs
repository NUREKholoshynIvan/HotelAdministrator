using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CourseWork
{
    [Serializable]
    public class Squad : Visitor
    {
        public List<string> squadNames = new List<string>();
        public List<string> squadSurnames = new List<string>();

        public override string GetData(int type)
        {
            string result = $"{Name} {Surname}, ";
            for (int i = 0; i < squadNames.Count(); i++)
            {
                result += $"{squadNames[i]} {squadSurnames[i]}, " ;
            }
            result += $"{Passport}, етаж {Room.Floor} кімната {Room.RoomNumber}, заїхали {Room.SettlingDate.ToString("dd-MM-yyyy")}";
            if(type == 1)
            {
                result += $", від'їжджають {Room.UnSettlingDate.ToString("dd-MM-yyyy")}";
            }
            return result + ".";
        }
    }
}
