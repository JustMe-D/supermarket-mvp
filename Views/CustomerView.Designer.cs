namespace Supermarket_mvp.Views
{
    partial class CustomerView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageCustomerList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgCustomer = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageCustomerDetail = new TabPage();
            DtpCustomerBirthday = new DateTimePicker();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtCustomerPhoneNumber = new TextBox();
            label10 = new Label();
            TxtCustomerEmail = new TextBox();
            label9 = new Label();
            label8 = new Label();
            TxtCustomerAddress = new TextBox();
            label7 = new Label();
            TxtCustomerDocument = new TextBox();
            label6 = new Label();
            TxtCustomerLastName = new TextBox();
            label5 = new Label();
            TxtCustomerFirstName = new TextBox();
            label4 = new Label();
            TxtCustomerId = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCustomerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomer).BeginInit();
            tabPageCustomerDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 105);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.client;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 18F, FontStyle.Bold);
            label1.Location = new Point(179, 30);
            label1.Name = "label1";
            label1.Size = new Size(175, 42);
            label1.TabIndex = 0;
            label1.Text = "Customer";
            label1.Click += label1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCustomerList);
            tabControl1.Controls.Add(tabPageCustomerDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 105);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 345);
            tabControl1.TabIndex = 1;
            // 
            // tabPageCustomerList
            // 
            tabPageCustomerList.Controls.Add(BtnClose);
            tabPageCustomerList.Controls.Add(BtnDelete);
            tabPageCustomerList.Controls.Add(BtnEdit);
            tabPageCustomerList.Controls.Add(BtnNew);
            tabPageCustomerList.Controls.Add(DgCustomer);
            tabPageCustomerList.Controls.Add(BtnSearch);
            tabPageCustomerList.Controls.Add(TxtSearch);
            tabPageCustomerList.Controls.Add(label2);
            tabPageCustomerList.Location = new Point(4, 29);
            tabPageCustomerList.Name = "tabPageCustomerList";
            tabPageCustomerList.Padding = new Padding(3);
            tabPageCustomerList.Size = new Size(792, 312);
            tabPageCustomerList.TabIndex = 0;
            tabPageCustomerList.Text = "Customer List";
            tabPageCustomerList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(565, 227);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(191, 64);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(565, 157);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(191, 64);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(565, 87);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(191, 64);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(565, 17);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(191, 64);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgCustomer
            // 
            DgCustomer.AllowUserToAddRows = false;
            DgCustomer.AllowUserToDeleteRows = false;
            DgCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCustomer.Location = new Point(21, 86);
            DgCustomer.Name = "DgCustomer";
            DgCustomer.ReadOnly = true;
            DgCustomer.RowHeadersWidth = 51;
            DgCustomer.Size = new Size(514, 217);
            DgCustomer.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(492, 39);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(43, 42);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(21, 47);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(376, 27);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 24);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 0;
            label2.Text = "Search Customer";
            // 
            // tabPageCustomerDetail
            // 
            tabPageCustomerDetail.Controls.Add(DtpCustomerBirthday);
            tabPageCustomerDetail.Controls.Add(BtnCancel);
            tabPageCustomerDetail.Controls.Add(BtnSave);
            tabPageCustomerDetail.Controls.Add(TxtCustomerPhoneNumber);
            tabPageCustomerDetail.Controls.Add(label10);
            tabPageCustomerDetail.Controls.Add(TxtCustomerEmail);
            tabPageCustomerDetail.Controls.Add(label9);
            tabPageCustomerDetail.Controls.Add(label8);
            tabPageCustomerDetail.Controls.Add(TxtCustomerAddress);
            tabPageCustomerDetail.Controls.Add(label7);
            tabPageCustomerDetail.Controls.Add(TxtCustomerDocument);
            tabPageCustomerDetail.Controls.Add(label6);
            tabPageCustomerDetail.Controls.Add(TxtCustomerLastName);
            tabPageCustomerDetail.Controls.Add(label5);
            tabPageCustomerDetail.Controls.Add(TxtCustomerFirstName);
            tabPageCustomerDetail.Controls.Add(label4);
            tabPageCustomerDetail.Controls.Add(TxtCustomerId);
            tabPageCustomerDetail.Controls.Add(label3);
            tabPageCustomerDetail.Location = new Point(4, 29);
            tabPageCustomerDetail.Name = "tabPageCustomerDetail";
            tabPageCustomerDetail.Padding = new Padding(3);
            tabPageCustomerDetail.Size = new Size(792, 312);
            tabPageCustomerDetail.TabIndex = 1;
            tabPageCustomerDetail.Text = "Customer Detail";
            tabPageCustomerDetail.UseVisualStyleBackColor = true;
            // 
            // DtpCustomerBirthday
            // 
            DtpCustomerBirthday.Location = new Point(536, 113);
            DtpCustomerBirthday.Name = "DtpCustomerBirthday";
            DtpCustomerBirthday.Size = new Size(205, 27);
            DtpCustomerBirthday.TabIndex = 18;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(653, 189);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(84, 72);
            BtnCancel.TabIndex = 17;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(550, 189);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(84, 72);
            BtnSave.TabIndex = 16;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtCustomerPhoneNumber
            // 
            TxtCustomerPhoneNumber.Location = new Point(300, 179);
            TxtCustomerPhoneNumber.Name = "TxtCustomerPhoneNumber";
            TxtCustomerPhoneNumber.Size = new Size(205, 27);
            TxtCustomerPhoneNumber.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(300, 156);
            label10.Name = "label10";
            label10.Size = new Size(104, 20);
            label10.TabIndex = 14;
            label10.Text = "PhoneNumber";
            // 
            // TxtCustomerEmail
            // 
            TxtCustomerEmail.Location = new Point(23, 179);
            TxtCustomerEmail.Name = "TxtCustomerEmail";
            TxtCustomerEmail.Size = new Size(242, 27);
            TxtCustomerEmail.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 156);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 12;
            label9.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(536, 90);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 10;
            label8.Text = "BirthDay";
            // 
            // TxtCustomerAddress
            // 
            TxtCustomerAddress.Location = new Point(300, 113);
            TxtCustomerAddress.Name = "TxtCustomerAddress";
            TxtCustomerAddress.Size = new Size(205, 27);
            TxtCustomerAddress.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(300, 90);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 8;
            label7.Text = "Address";
            // 
            // TxtCustomerDocument
            // 
            TxtCustomerDocument.Location = new Point(23, 113);
            TxtCustomerDocument.Name = "TxtCustomerDocument";
            TxtCustomerDocument.Size = new Size(242, 27);
            TxtCustomerDocument.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 90);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 6;
            label6.Text = "Document";
            // 
            // TxtCustomerLastName
            // 
            TxtCustomerLastName.Location = new Point(507, 45);
            TxtCustomerLastName.Name = "TxtCustomerLastName";
            TxtCustomerLastName.Size = new Size(230, 27);
            TxtCustomerLastName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(507, 22);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 4;
            label5.Text = "Last Name";
            // 
            // TxtCustomerFirstName
            // 
            TxtCustomerFirstName.Location = new Point(261, 45);
            TxtCustomerFirstName.Name = "TxtCustomerFirstName";
            TxtCustomerFirstName.Size = new Size(205, 27);
            TxtCustomerFirstName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(261, 22);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 2;
            label4.Text = "First Name";
            // 
            // TxtCustomerId
            // 
            TxtCustomerId.Location = new Point(23, 45);
            TxtCustomerId.Name = "TxtCustomerId";
            TxtCustomerId.Size = new Size(195, 27);
            TxtCustomerId.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 22);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 0;
            label3.Text = "Customer Id";
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CustomerView";
            Text = "Customer Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCustomerList.ResumeLayout(false);
            tabPageCustomerList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomer).EndInit();
            tabPageCustomerDetail.ResumeLayout(false);
            tabPageCustomerDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPageCustomerList;
        private TabPage tabPageCustomerDetail;
        private Button BtnNew;
        private DataGridView DgCustomer;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private TextBox TxtCustomerId;
        private Label label3;
        private TextBox TxtCustomerLastName;
        private Label label5;
        private TextBox TxtCustomerFirstName;
        private Label label4;
        private TextBox TxtCustomerDocument;
        private Label label6;
        private Label label7;
        private TextBox TxtCustomerAddress;
        private Label label8;
        private TextBox textBox6;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtCustomerPhoneNumber;
        private Label label10;
        private TextBox TxtCustomerEmail;
        private Label label9;
        private DateTimePicker DtpCustomerBirthday;
    }
}