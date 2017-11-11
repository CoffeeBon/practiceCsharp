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
            //
            // Data Grid View의 각 행에 고객 정보 입력
            CusList.Rows.Add(cus.FirstName, cus.Age, cus.IsQualified);
            //
            // Customer의 정보를 List에 Add
            Customers.Add(cus);
            //
            // 생성한 뒤 초기화
            CusNewFirstName.Text = "";
            CusNewLastName.Text = "";
            CusNewBirthday.Text = "";
            CusNewAddress.Text = "";
            CusNewDescription.Text = "";
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
        // 셀을 클릭하면 그의 정보가 나오게 함!
        //
        private void CusList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //
            // 클릭을 하면 매개변수 e에 이벤트 데이터가 저장된다.!!!!!!
            string firstName = CusList.Rows[e.RowIndex].Cells[0].Value.ToString();

            foreach (Customer cus in Customers)
            {
                if (cus.FirstName == firstName)
                {
                    ShowDetails(cus);
                    break;
                }
            }
            //
            //셀을 클릭할때 New Panel을 숨기고 Detail Panel을 보여준다.
            CusDetailPanel.Show();
            CusNewPanel.Hide();
        }
        //
        // form1을 실행하면 자리를 알아서 맞춰간다!
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            CusListPanel.Dock = DockStyle.Fill;
            CusDetailPanel.Dock = DockStyle.Right;
            CusNewPanel.Dock = DockStyle.Right;
        }
        //
        // 생성자 메뉴
        //
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CusNewPanel.Show();
            CusDetailPanel.Hide();
        }
    }
}
