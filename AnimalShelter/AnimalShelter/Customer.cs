using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    //클래스 앞에 아무런 접근 제한자가 없으면 자동으로 internal.
    // internal은 같은 네임스페이스 안에서만 사용 가능.
    // public은 다른 네임스페이스에서도 사용 가능
    public class Customer
    {
        #region field and property

        public string FirstName;
        public string LastName;
        public string FullName { get => $"{FirstName} {LastName}"; }

        public int Age { get => DateTime.Now.Year - _Birthday.Year; }

        private DateTime _Birthday;
        public DateTime Birthday
        {
            get => _Birthday;
            set
            {
                _Birthday = value;
                _IsQualified = Age >= 18;
            }
        }

        private bool _IsQualified;
        public bool IsQualified { get => _IsQualified; }

        public string Address;
        public string Description;

        private List<Pet> _MyPets = new List<Pet>();
        public List<Pet> Mypets { get => _MyPets; }

        public Customer(string firstName, string lastName, DateTime birthday)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this._Birthday = birthday;
            this._IsQualified = Age >= 18;
        }

        #endregion

        public bool Adopt(Pet pet)
        {
            if (_IsQualified == true)
            {
                _MyPets.Add(pet);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
