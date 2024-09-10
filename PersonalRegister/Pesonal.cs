using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PersonalRegister
{
    public class Pesonal
    {
        string name;
        float lon;

        public Pesonal(string name, float lon) 
        {
            this.name = name;
            this.lon = lon;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Lön: {lon}");
        }
        
    }
}
