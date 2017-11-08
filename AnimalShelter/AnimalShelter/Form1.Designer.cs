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
            this.button1 = new System.Windows.Forms.Button();
            this.CusDetailPanel = new System.Windows.Forms.Panel();
            this.CusDescription = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CusAddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CusAge = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CusFullName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CusIsQualified = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CusDetailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateCustomer
            // 
            this.CreateCustomer.Location = new System.Drawing.Point(0, 0);
            this.CreateCustomer.Name = "CreateCustomer";
            this.CreateCustomer.Size = new System.Drawing.Size(151, 47);
            this.CreateCustomer.TabIndex = 0;
            this.CreateCustomer.Text = "입양자 생성";
            this.CreateCustomer.UseVisualStyleBackColor = true;
            this.CreateCustomer.Click += new System.EventHandler(this.CreateCustomer_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            this.CusDetailPanel.Location = new System.Drawing.Point(493, 12);
            this.CusDetailPanel.Name = "CusDetailPanel";
            this.CusDetailPanel.Size = new System.Drawing.Size(533, 566);
            this.CusDetailPanel.TabIndex = 2;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 601);
            this.Controls.Add(this.CusDetailPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CreateCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.CusDetailPanel.ResumeLayout(false);
            this.CusDetailPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateCustomer;
        private System.Windows.Forms.Button button1;
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
    }
}

