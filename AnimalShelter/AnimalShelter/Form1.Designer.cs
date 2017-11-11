namespace AnimalShelter
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateCustomer = new System.Windows.Forms.Button();
            this.CusDetailPanel = new System.Windows.Forms.Panel();
            this.CusIsQualified = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CusDescription = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CusAddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CusAge = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CusFullName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CusNewPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CusNewLastName = new System.Windows.Forms.TextBox();
            this.CusNewFirstName = new System.Windows.Forms.TextBox();
            this.CusNewBirthday = new System.Windows.Forms.TextBox();
            this.CusNewAddress = new System.Windows.Forms.TextBox();
            this.CusNewDescription = new System.Windows.Forms.TextBox();
            this.CustomerList = new System.Windows.Forms.ListBox();
            this.CusDetailPanel.SuspendLayout();
            this.CusNewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateCustomer
            // 
            this.CreateCustomer.Location = new System.Drawing.Point(86, 437);
            this.CreateCustomer.Name = "CreateCustomer";
            this.CreateCustomer.Size = new System.Drawing.Size(151, 47);
            this.CreateCustomer.TabIndex = 0;
            this.CreateCustomer.Text = "입양자 생성";
            this.CreateCustomer.UseVisualStyleBackColor = true;
            this.CreateCustomer.Click += new System.EventHandler(this.CreateCustomer_Click);
            // 
            // CusDetailPanel
            // 
            this.CusDetailPanel.Controls.Add(this.CusIsQualified);
            this.CusDetailPanel.Controls.Add(this.label2);
            this.CusDetailPanel.Controls.Add(this.CusDescription);
            this.CusDetailPanel.Controls.Add(this.label6);
            this.CusDetailPanel.Controls.Add(this.CusAddress);
            this.CusDetailPanel.Controls.Add(this.label5);
            this.CusDetailPanel.Controls.Add(this.CusAge);
            this.CusDetailPanel.Controls.Add(this.label4);
            this.CusDetailPanel.Controls.Add(this.CusFullName);
            this.CusDetailPanel.Controls.Add(this.label3);
            this.CusDetailPanel.Location = new System.Drawing.Point(721, 12);
            this.CusDetailPanel.Name = "CusDetailPanel";
            this.CusDetailPanel.Size = new System.Drawing.Size(305, 566);
            this.CusDetailPanel.TabIndex = 2;
            // 
            // CusIsQualified
            // 
            this.CusIsQualified.AutoSize = true;
            this.CusIsQualified.BackColor = System.Drawing.Color.Bisque;
            this.CusIsQualified.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CusIsQualified.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CusIsQualified.Font = new System.Drawing.Font("나눔고딕", 14F, System.Drawing.FontStyle.Bold);
            this.CusIsQualified.Location = new System.Drawing.Point(126, 101);
            this.CusIsQualified.Name = "CusIsQualified";
            this.CusIsQualified.Size = new System.Drawing.Size(66, 23);
            this.CusIsQualified.TabIndex = 14;
            this.CusIsQualified.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(17, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "입양 가능?";
            // 
            // CusDescription
            // 
            this.CusDescription.AutoSize = true;
            this.CusDescription.BackColor = System.Drawing.Color.Bisque;
            this.CusDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CusDescription.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CusDescription.Font = new System.Drawing.Font("나눔고딕", 14F, System.Drawing.FontStyle.Bold);
            this.CusDescription.Location = new System.Drawing.Point(126, 165);
            this.CusDescription.Name = "CusDescription";
            this.CusDescription.Size = new System.Drawing.Size(66, 23);
            this.CusDescription.TabIndex = 12;
            this.CusDescription.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(57, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "설명 :";
            // 
            // CusAddress
            // 
            this.CusAddress.AutoSize = true;
            this.CusAddress.BackColor = System.Drawing.Color.Bisque;
            this.CusAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CusAddress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CusAddress.Font = new System.Drawing.Font("나눔고딕", 14F, System.Drawing.FontStyle.Bold);
            this.CusAddress.Location = new System.Drawing.Point(126, 133);
            this.CusAddress.Name = "CusAddress";
            this.CusAddress.Size = new System.Drawing.Size(66, 23);
            this.CusAddress.TabIndex = 10;
            this.CusAddress.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(57, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "주소 :";
            // 
            // CusAge
            // 
            this.CusAge.AutoSize = true;
            this.CusAge.BackColor = System.Drawing.Color.Bisque;
            this.CusAge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CusAge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CusAge.Font = new System.Drawing.Font("나눔고딕", 14F, System.Drawing.FontStyle.Bold);
            this.CusAge.Location = new System.Drawing.Point(126, 70);
            this.CusAge.Name = "CusAge";
            this.CusAge.Size = new System.Drawing.Size(66, 23);
            this.CusAge.TabIndex = 8;
            this.CusAge.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(57, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "나이 :";
            // 
            // CusFullName
            // 
            this.CusFullName.AutoSize = true;
            this.CusFullName.BackColor = System.Drawing.Color.Bisque;
            this.CusFullName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CusFullName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CusFullName.Font = new System.Drawing.Font("나눔고딕", 14F, System.Drawing.FontStyle.Bold);
            this.CusFullName.Location = new System.Drawing.Point(126, 40);
            this.CusFullName.Name = "CusFullName";
            this.CusFullName.Size = new System.Drawing.Size(66, 23);
            this.CusFullName.TabIndex = 6;
            this.CusFullName.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(57, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "이름 :";
            // 
            // CusNewPanel
            // 
            this.CusNewPanel.Controls.Add(this.CusNewDescription);
            this.CusNewPanel.Controls.Add(this.CusNewAddress);
            this.CusNewPanel.Controls.Add(this.CreateCustomer);
            this.CusNewPanel.Controls.Add(this.CusNewBirthday);
            this.CusNewPanel.Controls.Add(this.CusNewFirstName);
            this.CusNewPanel.Controls.Add(this.CusNewLastName);
            this.CusNewPanel.Controls.Add(this.label1);
            this.CusNewPanel.Controls.Add(this.label7);
            this.CusNewPanel.Controls.Add(this.label9);
            this.CusNewPanel.Controls.Add(this.label11);
            this.CusNewPanel.Controls.Add(this.label15);
            this.CusNewPanel.Location = new System.Drawing.Point(351, 12);
            this.CusNewPanel.Name = "CusNewPanel";
            this.CusNewPanel.Size = new System.Drawing.Size(364, 566);
            this.CusNewPanel.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(23, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "생일 :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔고딕", 14F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(23, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 21);
            this.label9.TabIndex = 11;
            this.label9.Text = "설명 :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("나눔고딕", 14F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(23, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 21);
            this.label11.TabIndex = 9;
            this.label11.Text = "주소 :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("나눔고딕", 14F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(23, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 21);
            this.label15.TabIndex = 5;
            this.label15.Text = "이름 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(41, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "성 :";
            // 
            // CusNewLastName
            // 
            this.CusNewLastName.Location = new System.Drawing.Point(86, 41);
            this.CusNewLastName.Name = "CusNewLastName";
            this.CusNewLastName.Size = new System.Drawing.Size(100, 21);
            this.CusNewLastName.TabIndex = 15;
            // 
            // CusNewFirstName
            // 
            this.CusNewFirstName.Location = new System.Drawing.Point(86, 71);
            this.CusNewFirstName.Name = "CusNewFirstName";
            this.CusNewFirstName.Size = new System.Drawing.Size(100, 21);
            this.CusNewFirstName.TabIndex = 16;
            // 
            // CusNewBirthday
            // 
            this.CusNewBirthday.Location = new System.Drawing.Point(86, 101);
            this.CusNewBirthday.Name = "CusNewBirthday";
            this.CusNewBirthday.Size = new System.Drawing.Size(100, 21);
            this.CusNewBirthday.TabIndex = 17;
            // 
            // CusNewAddress
            // 
            this.CusNewAddress.Location = new System.Drawing.Point(86, 131);
            this.CusNewAddress.Name = "CusNewAddress";
            this.CusNewAddress.Size = new System.Drawing.Size(255, 21);
            this.CusNewAddress.TabIndex = 18;
            // 
            // CusNewDescription
            // 
            this.CusNewDescription.Location = new System.Drawing.Point(86, 161);
            this.CusNewDescription.Multiline = true;
            this.CusNewDescription.Name = "CusNewDescription";
            this.CusNewDescription.Size = new System.Drawing.Size(255, 247);
            this.CusNewDescription.TabIndex = 19;
            // 
            // CustomerList
            // 
            this.CustomerList.FormattingEnabled = true;
            this.CustomerList.ItemHeight = 12;
            this.CustomerList.Location = new System.Drawing.Point(12, 12);
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.Size = new System.Drawing.Size(333, 568);
            this.CustomerList.TabIndex = 4;
            this.CustomerList.Click += new System.EventHandler(this.CustomerList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 601);
            this.Controls.Add(this.CustomerList);
            this.Controls.Add(this.CusNewPanel);
            this.Controls.Add(this.CusDetailPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.CusDetailPanel.ResumeLayout(false);
            this.CusDetailPanel.PerformLayout();
            this.CusNewPanel.ResumeLayout(false);
            this.CusNewPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateCustomer;
        private System.Windows.Forms.Panel CusDetailPanel;
        private System.Windows.Forms.Label CusDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CusAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CusAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CusFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CusIsQualified;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel CusNewPanel;
        private System.Windows.Forms.TextBox CusNewDescription;
        private System.Windows.Forms.TextBox CusNewAddress;
        private System.Windows.Forms.TextBox CusNewBirthday;
        private System.Windows.Forms.TextBox CusNewFirstName;
        private System.Windows.Forms.TextBox CusNewLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox CustomerList;
    }
}

