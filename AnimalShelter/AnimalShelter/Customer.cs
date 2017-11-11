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
        public string FirstName;
        public string LastName;

        //Age와 IsQualified는 서로 연관되어 있기 때문. IsQualified에 접근 불가능하게 만든다.
        private DateTime _Birthday;
        private bool _IsQualified;

        public string Address;
        public string Description;

        /// <summary>
        ///  Customer 클래스 생성자
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="birthday"></param>
        public Customer(string firstName, string lastName, DateTime birthday)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this._Birthday = birthday;
            //
            //DateTime.Now.Year - birthday.Year 을 Age 속성으로 바꿔줄 수 있다.
            //this._IsQualified = (DateTime.Now.Year - birthday.Year) >= 18;
            this._IsQualified = Age >= 18;
        }


        /// <summary>
        /// 속성(Property) 만들기
        /// 
        ///public int GetAge()
        ///{
        ///    return _Age;
        ///}
        ///public void SetAge(int age)
        ///{
        ///    _Age = age;
        ///    _IsQualified = age >= 18;
        ///}
        ///public int Age
        ///{
        ///    get
        ///    {
        ///        return _Age;
        ///    }
        ///    set {
        ///        _Age = value;
        ///        _IsQualified = value >= 18;
        ///    }
        ///}
        /// </summary>

        #region 속성
        //
        // public bool IsQualified { get => _IsQualified; } 위랑 동일한 식
        // public bool IsQualified => _IsQualified;  위랑 동일한 식
        public bool IsQualified => _IsQualified;
        //
        // get 속성으로 성과 이름을 붙임
        public string FullName => $"{FirstName} {LastName}";
        //
        // _Age 대신 Birthday 속성(DateTime type)으로 속성 생성
        public DateTime Birthday
        {
            get { return _Birthday; }
            set
            {
                _Birthday = value;
                //
                //_IsQualified = DateTime.Now.Year - value.Year >= 18;
                _IsQualified = Age >= 18;
            }
        }
        //
        //public int Age
        //{
        //    get
        //    {
        //        return DateTime.Now.Year - _Birthday.Year;
        //    }
        //}
        // Age 속성도 필요하다!!!!
        public int Age => DateTime.Now.Year - _Birthday.Year;

        #endregion
    }
}
