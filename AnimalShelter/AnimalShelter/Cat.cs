using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Cat : Pet //Cat은 Pet으로부터 상속받음(base)
    {
        //
        // 자식 클래스의 생성자가 호출될 때, 부모 클래스의 생성자가 항상 먼저 호출된다.
        // 그래서 부모 클래스에서 어떤 생성자가 호출될지 선택해야 한다.
        // 아무것도 선택 안하면 부모의 매개변수가 없는 기본 생성자가 호출된다.
        public Cat(int petid, string name, string color, string gender) 
            : base(petid: petid, name: name, color: color, gender: gender)
        {

        }
        //
        // virtual method에서 재정의 할 때, override 키워드를 붙인다!!
        public override string MakeSound() => "야옹";
        //
        // 부모 클래스에서는 없는 메소드기 때문에 Cat 클래스의 독자적인 메소드
        public string Scratch() => "할퀴기";
    }
}
