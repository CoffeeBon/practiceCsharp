using System;
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
        // Customer 클래스 타입의 Cus1 변수는 Form1의 스코프가 끝날때까지 존재한다.
        public Customer[] CustomerArray = new Customer[10];
        public int CustomerArrayIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            #region Create Array
            //
            //배열 생성 #1
            int[] numberArray = new int[5];
            numberArray[0] = 1;
            numberArray[1] = 2;
            numberArray[2] = 3;
            numberArray[3] = 4;
            numberArray[4] = 5;
            //
            //배열 생성 #2
            int[] numberArray2 = new int[5] { 1, 2, 3, 4, 5 };
            //
            //배열 생성 #3
            int[] numberArray3 =
            {
                1,
                2,
                3,
                4,
                5
            };
            #endregion
            #region Create Object(or Struct) Array
            //
            //오브젝트(클래스) 배열 생성 #1
            // 오브젝트는 항상 new 키워드를 사용해서 생성자를 만들어야 한다!!!!
            Customer[] customerArray = new Customer[5];
            customerArray[0] = new Customer("first", "last", new DateTime(2000, 1, 1));
            customerArray[1] = new Customer("first", "last", new DateTime(2000, 1, 2));
            customerArray[2] = new Customer("first", "last", new DateTime(2000, 1, 3));
            customerArray[3] = new Customer("first", "last", new DateTime(2000, 1, 1));
            customerArray[4] = new Customer("first", "last", new DateTime(2000, 1, 1));
            //
            //오브젝트(클래스) 배열 생성 #2
            // new 키워드는 반드시 삽입!! 그리고 반드시 ,(콤마)를 찍어준다.
            Customer[] customerArray2 =
            {
                new Customer("first", "last", new DateTime(2000, 1, 1)),
                new Customer("first", "last", new DateTime(2000, 1, 2)),
                new Customer("first", "last", new DateTime(2000, 1, 3)),
                new Customer("first", "last", new DateTime(2000, 1, 4)),
                new Customer("first", "last", new DateTime(2000, 1, 5)),
            };
            #endregion
            #region Loop
            //
            // For Loop syntax
            int sum = 0;
            for (int index = 0; index <= 10; index++)
            {
                sum += index;
            }
            #endregion

            DateTime birthday = DateTime.Parse(CusNewBirthday.Text);

            CustomerArray[CustomerArrayIndex] = new Customer(CusNewFirstName.Text, CusNewLastName.Text, birthday)
            {
                //
                //원래는 cus.Address = "123 Wilshire Blvd.";인데, 
                //단순화 시킬 수 있음
                Address = CusNewAddress.Text,
                Description = CusNewDescription.Text
            };
            CustomerList.Items.Add(CustomerArray[CustomerArrayIndex].FirstName);

            CustomerArrayIndex++;
        }

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
        //ListBox에 이름을 클릭하면 그의 정보가 나오게 함!
        private void CustomerList_Click(object sender, EventArgs e)
        {
            string firstName = CustomerList.SelectedItem.ToString();

            for (int index = 0; index < CustomerArrayIndex; index++)
            {
                if (CustomerArray[index].FirstName == firstName)
                {
                    ShowDetails(CustomerArray[index]);
                    break;
                } 
            }
        }
    }
}
