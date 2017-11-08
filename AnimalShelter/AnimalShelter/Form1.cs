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
            DateTime birthday = new DateTime(2000, 1, 1);

            Customer cus = new Customer("Ian", "Na", birthday)
            {
                //원래는 
                //cus.Address = "123 Wilshire Blvd.";인데, 
                //단순화 시킬 수 있음
                Address = "123 Wilshire Blvd."
            };

            CusFullName.Text = cus.FullName;
            CusAge.Text = cus.Age.ToString();
            //CusAge.Text = cus.Age.ToString();
            // Age가 private이기 때문에 접근 불가!!

            CusAddress.Text = cus.Address;
            CusDescription.Text = cus.Description;
            if (cus.IsQualified == true)
            {
                CusIsQualified.Text = "입양 가능";
            }
            else
            {
                CusIsQualified.Text = "입양 불가";
            }
            

            DateTime date = new DateTime(2016, 2, 5);
            DateTime current = DateTime.Now;
            


        }
    }
}
