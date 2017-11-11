using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Pet
    {
        public int PetId;
        public string Name;
        public string Color;
        public string Gender;
        public string Description;

        public Pet(int petid, string name, string color, string gender)
        {
            this.PetId = petid;
            this.Name = name;
            this.Color = color;
            this.Gender = gender;
        }
        //
        // 대부분의 pet은 소리를 내는것은 맞다. 하지만 자식 클래스에서 구체화 된다면
        // 가상 메소드(virtual method)로 만들어준다.
        // 가상 메소드를 호출하면, 자식 클래스가 있는 것으로 간주하고
        // 자식 클래스에 재정의된 메소드가 존재하면 그것을 호출하라!
        public virtual string MakeSound()
        {
            return "";
        }
        // 본문식으로 항상 {retren } 은 => 로 표시가능
    }
}
