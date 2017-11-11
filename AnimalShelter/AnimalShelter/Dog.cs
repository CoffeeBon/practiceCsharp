using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public enum DogBreed { Mixed, Bulldog, Jindo, Yorkshire }

    public class Dog : Pet
    {
        public DogBreed Breed;

        public Dog(int petid, string name, string color, string gender, DogBreed breed)
            : base(petid: petid, name: name, color: color, gender: gender)
        {
            this.Breed = breed;
        }

        public override string MakeSound() => "멍멍";

        public string Bite() => "물어뜯기";
    }
}
