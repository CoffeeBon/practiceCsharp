using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuteCat
{
    public class Cat
    {
        public string Name;
        public int Age;
        
        private int Happiness = 50;

        //생성자는 무조건 public... 외부에서 호출용이기 때문에
        //생성자는 return type이 없다(void, int... 등 아예 없다)
        public Cat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        //this는 그 클래스의 현재 인스턴스를 말한다.
        //Cat이라는 클래스에 생성자를 만들면 그 순간 인스턴스화 된다.
        //그 인스턴스 자체가 this라는 키워드.1111
        
        public void GetBored()
        {
            Happiness = Happiness - 10;
            if (Happiness < 0)
            {
                Happiness = 0;
            }
        }
        public void Play()
        {
            Happiness = Happiness + 10;

            if (Happiness > 100)
            {
                Happiness = 100;
            }
        }
        public void Eat()
        {
            Happiness = Happiness + 50;

            if (Happiness > 100)
            {
                Happiness = 100;
            }
        }
        public string Express()
        {
            string message = "";

            if (Happiness >= 80)
            {
                message = "I'm very happy.";
            }
            else if (Happiness >= 60)
            {
                message = "I'm happy.";
            }
            else if (Happiness >= 40)
            {
                message = "I'm so so.";
            }
            else if (Happiness >= 20)
            {
                message = "I'm gloomy.";
            }
            else
            {
                message = "I'm sad.";
            }

            return this.Name + ": " + message;
        }
    }
}
