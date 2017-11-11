using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Cat
    {
        public int PetId;
        public string Name;
        public string Color;
        public string Gender;
        public string Description;

        public Cat(int petid, string name, string color, string gender)
        {
            this.PetId = petid;
            this.Name = name;
            this.Color = color;
            this.Gender = gender;
        }

        public string MakeSound()
        {
            return "야옹";
        }

        public string Scratch()
        {
            return "할퀴기";
        }
     }
}
