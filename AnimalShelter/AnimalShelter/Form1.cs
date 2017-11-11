using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class Form1 : Form
    {
        //
        // Array를 List로 교체!!
        public List<Customer> Customers = new List<Customer>();

        public Form1()
        {
            InitializeComponent();
        }
        //
        // 고객 정보 생성 버튼 클릭!
        //
        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            DateTime birthday = DateTime.Parse(CusNewBirthday.Text);

            Customer cus = new Customer(CusNewFirstName.Text, CusNewLastName.Text, birthday)
            {
                Address = CusNewAddress.Text,
                Description = CusNewDescription.Text
            };

            CustomerList.Items.Add(cus.FirstName);

            Customers.Add(cus);
        }
        //
        // 오른쪽 창에 정보(Detail)이 보이게 하는 함수.
        //
        public void ShowDetails(Customer cus)
        {
            CusFullName.Text = cus.FullName;
            CusAge.Text = cus.Age.ToString();
            CusAddress.Text = cus.Address;
            CusDescription.Text = cus.Description;
            //
            //summary
            //입양 가능한지 글자 표시
            if (cus.IsQualified == true)
            {
                CusIsQualified.Text = "입양 가능!!";
            }
            else
            {
                CusIsQualified.Text = "입양 불가!!";
            }
        }
        //
        // ListBox에 이름을 클릭하면 그의 정보가 나오게 함!
        //
        private void CustomerList_Click(object sender, EventArgs e)
        {
            string firstName = CustomerList.SelectedItem.ToString();

            foreach (Customer cus in Customers)
            {
                if (cus.FirstName == firstName)
                {
                    ShowDetails(cus);
                    break;
                }
            }
        }
        //
        // ArrayList, List<T>, foreach 예제
        //
        private void button1_Click(object sender, EventArgs e)
        {
            #region ArrayList
            //
            //ArrayList 만들기 #1
            ArrayList arrayList = new ArrayList
            {
                0,  //arrayList[0] = 0;
                1,  //arrayList[1] = 1;
                3   //arrayList[2] = 3;
            };
            //
            //ArrayList 만들기 #2
            ArrayList arrayList2 = new ArrayList();
            arrayList.Add(0);   //arrayList[0] = 0;
            arrayList.Add(1);   //arrayList[1] = 1;
            arrayList.Add(3);   //arrayList[2] = 3;
            //
            // 데이터 (인덱스, 값) 삽입
            arrayList.Insert(2, 2);     //arrayList[] {0, 1, 2, 3};
            //
            // 데이터 값 찾아서 삭제 
            arrayList.Remove(2);  //  arrayList[] {0, 1, 3};
            //
            // 데이터 인덱스 찾아서 삭제
            arrayList.RemoveAt(1);  //  arrayList[] {0, 3};
            //
            // summary
            // 형 변환이 많아질수록 퍼포먼스가 떨어진다!!
            // ArrayList 클래스는 Object 타입!!
            // 타입을 지정해주는 일반화 컬렉션(Generic Collection)를 사용 권장. -----> List<T>
            int sum = 0;

            for (int index = 0; index < arrayList.Count; index++)
            {
                int num = (int)arrayList[index];
                sum += num;
            }
            #endregion

            #region Generic Collection
            //
            // List<T>에서 T는 Data Type을 의미함. <T>가 들어가있는 것들은 Generic이라 읽는다.
            // 컬렉션 초기화 방법 #1
            List<int> intList = new List<int>();
            intList.Add(1);
            intList.Add(2);
            intList.Add(4);
            //
            // 컬렉션 초기화 방법 #2
            List<int> intList2 = new List<int>
            {
                1,
                2
            };
            //
            // Insert, Remove, RemoveAt
            intList.Insert(2, 3);
            intList.Remove(2);
            intList.RemoveAt(0);
            //
            // for문을 이용해서 값을 합함
            int sum2 = 0;
            for (int index = 0; index < intList.Count; index++)
            {
                int value = intList[index];
                sum2 += value;
            }
            #endregion

            #region foreach Loop
            //
            // summary
            // intList라는 컬렉션(배열)에서 하나씩 value 값이 채워진다.
            // for문과 다르게 index가 없다.
            foreach (var value in intList)
            {
                sum += value;
            }
            #endregion
        }
    }
}
