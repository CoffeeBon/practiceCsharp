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
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            DateTime birthday = DateTime.Parse(CusNewBirthday.Text);
            
            Customer cus = new Customer(CusNewFirstName.Text, CusNewLastName.Text, birthday)
            {
                //
                //원래는 cus.Address = "123 Wilshire Blvd.";인데, 
                //단순화 시킬 수 있음
                Address = CusNewAddress.Text,
                Description = CusNewDescription.Text
            };
            //
            //CusAge.Text = cus.Age.ToString();
            // Age가 private이기 때문에 접근 불가!!
            CusAge.Text = cus.Age.ToString();
            CusFullName.Text = cus.FullName;
            CusAddress.Text = cus.Address;
            CusDescription.Text = cus.Description;
            //
            //summary
            //입양 가능한지 글자 표시
            if (cus.IsQualified == true)
            {
                CusIsQualified.Text = "입양 가능";
            }
            else
            {
                CusIsQualified.Text = "입양 불가";
            }

        }
    }
}
