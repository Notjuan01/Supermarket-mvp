namespace Supermarket_mvp.views
{
    partial class CustomersView
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
            Tabcontrol = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgCustomers = new DataGridView();
            BtnSearchC = new Button();
            TxtSearchC = new TextBox();
            LblSearch = new Label();
            tabPageCustomersDetail = new TabPage();
            BtnCancelC = new Button();
            BtnSaveC = new Button();
            TxtEmailC = new TextBox();
            LblEmailC = new Label();
            TxtPhoneC = new TextBox();
            LblPhone = new Label();
            TxtBirthdayC = new TextBox();
            LblBirthday = new Label();
            TxtAddress = new TextBox();
            LblAddress = new Label();
            TxtLastName = new TextBox();
            LblLastName = new Label();
            textBox2 = new TextBox();
            TxtcName = new Label();
            TxtCId = new TextBox();
            TxtCustomersId = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            Tabcontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomers).BeginInit();
            tabPageCustomersDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.satisfaccion_del_consumidor;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(113, 28);
            label1.Name = "label1";
            label1.Size = new Size(153, 37);
            label1.TabIndex = 0;
            label1.Text = "Customers";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Tabcontrol);
            tabControl1.Controls.Add(tabPageCustomersDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 2;
            // 
            // Tabcontrol
            // 
            Tabcontrol.Controls.Add(BtnClose);
            Tabcontrol.Controls.Add(BtnDelete);
            Tabcontrol.Controls.Add(BtnEdit);
            Tabcontrol.Controls.Add(BtnNew);
            Tabcontrol.Controls.Add(DgCustomers);
            Tabcontrol.Controls.Add(BtnSearchC);
            Tabcontrol.Controls.Add(TxtSearchC);
            Tabcontrol.Controls.Add(LblSearch);
            Tabcontrol.Location = new Point(4, 24);
            Tabcontrol.Name = "Tabcontrol";
            Tabcontrol.Padding = new Padding(3);
            Tabcontrol.Size = new Size(792, 322);
            Tabcontrol.TabIndex = 0;
            Tabcontrol.Text = "Customers List";
            Tabcontrol.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.BackColor = Color.Silver;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(591, 261);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(193, 55);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = false;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.BackColor = Color.Silver;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(591, 197);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(193, 55);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = false;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.BackColor = Color.Silver;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(591, 136);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(193, 55);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = false;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.BackColor = Color.Silver;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(591, 75);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(193, 55);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = false;
            // 
            // DgCustomers
            // 
            DgCustomers.AllowUserToAddRows = false;
            DgCustomers.AllowUserToDeleteRows = false;
            DgCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCustomers.Location = new Point(10, 75);
            DgCustomers.Name = "DgCustomers";
            DgCustomers.ReadOnly = true;
            DgCustomers.Size = new Size(575, 241);
            DgCustomers.TabIndex = 3;
            // 
            // BtnSearchC
            // 
            BtnSearchC.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearchC.BackgroundImage = Properties.Resources.search_small;
            BtnSearchC.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSearchC.Location = new Point(528, 33);
            BtnSearchC.Name = "BtnSearchC";
            BtnSearchC.Size = new Size(59, 36);
            BtnSearchC.TabIndex = 2;
            BtnSearchC.UseVisualStyleBackColor = true;
            // 
            // TxtSearchC
            // 
            TxtSearchC.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearchC.Location = new Point(10, 37);
            TxtSearchC.Name = "TxtSearchC";
            TxtSearchC.PlaceholderText = "Data to Search";
            TxtSearchC.Size = new Size(512, 23);
            TxtSearchC.TabIndex = 1;
            // 
            // LblSearch
            // 
            LblSearch.AutoSize = true;
            LblSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSearch.Location = new Point(8, 14);
            LblSearch.Name = "LblSearch";
            LblSearch.Size = new Size(117, 17);
            LblSearch.TabIndex = 0;
            LblSearch.Text = "Search Customers";
            // 
            // tabPageCustomersDetail
            // 
            tabPageCustomersDetail.Controls.Add(BtnCancelC);
            tabPageCustomersDetail.Controls.Add(BtnSaveC);
            tabPageCustomersDetail.Controls.Add(TxtEmailC);
            tabPageCustomersDetail.Controls.Add(LblEmailC);
            tabPageCustomersDetail.Controls.Add(TxtPhoneC);
            tabPageCustomersDetail.Controls.Add(LblPhone);
            tabPageCustomersDetail.Controls.Add(TxtBirthdayC);
            tabPageCustomersDetail.Controls.Add(LblBirthday);
            tabPageCustomersDetail.Controls.Add(TxtAddress);
            tabPageCustomersDetail.Controls.Add(LblAddress);
            tabPageCustomersDetail.Controls.Add(TxtLastName);
            tabPageCustomersDetail.Controls.Add(LblLastName);
            tabPageCustomersDetail.Controls.Add(textBox2);
            tabPageCustomersDetail.Controls.Add(TxtcName);
            tabPageCustomersDetail.Controls.Add(TxtCId);
            tabPageCustomersDetail.Controls.Add(TxtCustomersId);
            tabPageCustomersDetail.Location = new Point(4, 24);
            tabPageCustomersDetail.Name = "tabPageCustomersDetail";
            tabPageCustomersDetail.Padding = new Padding(3);
            tabPageCustomersDetail.Size = new Size(792, 322);
            tabPageCustomersDetail.TabIndex = 1;
            tabPageCustomersDetail.Text = "Customers Detail";
            tabPageCustomersDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancelC
            // 
            BtnCancelC.BackgroundImage = Properties.Resources.boton_x;
            BtnCancelC.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCancelC.Location = new Point(485, 178);
            BtnCancelC.Name = "BtnCancelC";
            BtnCancelC.Size = new Size(88, 73);
            BtnCancelC.TabIndex = 15;
            BtnCancelC.UseVisualStyleBackColor = true;
            // 
            // BtnSaveC
            // 
            BtnSaveC.BackgroundImage = Properties.Resources.guardar_el_archivo;
            BtnSaveC.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSaveC.Location = new Point(342, 178);
            BtnSaveC.Name = "BtnSaveC";
            BtnSaveC.Size = new Size(88, 73);
            BtnSaveC.TabIndex = 14;
            BtnSaveC.UseVisualStyleBackColor = true;
            // 
            // TxtEmailC
            // 
            TxtEmailC.Location = new Point(319, 94);
            TxtEmailC.Name = "TxtEmailC";
            TxtEmailC.Size = new Size(254, 23);
            TxtEmailC.TabIndex = 13;
            TxtEmailC.Text = "Phone Email";
            // 
            // LblEmailC
            // 
            LblEmailC.AutoSize = true;
            LblEmailC.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblEmailC.Location = new Point(319, 74);
            LblEmailC.Name = "LblEmailC";
            LblEmailC.Size = new Size(111, 17);
            LblEmailC.TabIndex = 12;
            LblEmailC.Text = "Customers Email";
            // 
            // TxtPhoneC
            // 
            TxtPhoneC.Location = new Point(319, 37);
            TxtPhoneC.Name = "TxtPhoneC";
            TxtPhoneC.Size = new Size(254, 23);
            TxtPhoneC.TabIndex = 11;
            TxtPhoneC.Text = "Phone Number";
            // 
            // LblPhone
            // 
            LblPhone.AutoSize = true;
            LblPhone.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblPhone.Location = new Point(319, 17);
            LblPhone.Name = "LblPhone";
            LblPhone.Size = new Size(170, 17);
            LblPhone.TabIndex = 10;
            LblPhone.Text = "Customers Phone Number";
            // 
            // TxtBirthdayC
            // 
            TxtBirthdayC.Location = new Point(10, 264);
            TxtBirthdayC.Name = "TxtBirthdayC";
            TxtBirthdayC.Size = new Size(254, 23);
            TxtBirthdayC.TabIndex = 9;
            TxtBirthdayC.Text = "Birthday";
            // 
            // LblBirthday
            // 
            LblBirthday.AutoSize = true;
            LblBirthday.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblBirthday.Location = new Point(10, 244);
            LblBirthday.Name = "LblBirthday";
            LblBirthday.Size = new Size(129, 17);
            LblBirthday.TabIndex = 8;
            LblBirthday.Text = "Customers Birthday";
            // 
            // TxtAddress
            // 
            TxtAddress.Location = new Point(10, 204);
            TxtAddress.Name = "TxtAddress";
            TxtAddress.Size = new Size(254, 23);
            TxtAddress.TabIndex = 7;
            TxtAddress.Text = "Address";
            // 
            // LblAddress
            // 
            LblAddress.AutoSize = true;
            LblAddress.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblAddress.Location = new Point(10, 184);
            LblAddress.Name = "LblAddress";
            LblAddress.Size = new Size(126, 17);
            LblAddress.TabIndex = 6;
            LblAddress.Text = "Customers Address";
            // 
            // TxtLastName
            // 
            TxtLastName.Location = new Point(8, 149);
            TxtLastName.Name = "TxtLastName";
            TxtLastName.Size = new Size(254, 23);
            TxtLastName.TabIndex = 5;
            TxtLastName.Text = "Last Name";
            // 
            // LblLastName
            // 
            LblLastName.AutoSize = true;
            LblLastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblLastName.Location = new Point(8, 129);
            LblLastName.Name = "LblLastName";
            LblLastName.Size = new Size(142, 17);
            LblLastName.TabIndex = 4;
            LblLastName.Text = "Customers Last Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(8, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(254, 23);
            textBox2.TabIndex = 3;
            textBox2.Text = "First Name";
            // 
            // TxtcName
            // 
            TxtcName.AutoSize = true;
            TxtcName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtcName.Location = new Point(8, 74);
            TxtcName.Name = "TxtcName";
            TxtcName.Size = new Size(144, 17);
            TxtcName.TabIndex = 2;
            TxtcName.Text = "Customers Firts Name";
            // 
            // TxtCId
            // 
            TxtCId.Location = new Point(8, 37);
            TxtCId.Name = "TxtCId";
            TxtCId.Size = new Size(158, 23);
            TxtCId.TabIndex = 1;
            TxtCId.Text = "Id";
            // 
            // TxtCustomersId
            // 
            TxtCustomersId.AutoSize = true;
            TxtCustomersId.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtCustomersId.Location = new Point(8, 17);
            TxtCustomersId.Name = "TxtCustomersId";
            TxtCustomersId.Size = new Size(89, 17);
            TxtCustomersId.TabIndex = 0;
            TxtCustomersId.Text = "Customers Id";
            // 
            // CustomersView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CustomersView";
            Text = "Customers Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            Tabcontrol.ResumeLayout(false);
            Tabcontrol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomers).EndInit();
            tabPageCustomersDetail.ResumeLayout(false);
            tabPageCustomersDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage Tabcontrol;
        private TabPage tabPageCustomersDetail;
        private Label LblSearch;
        private TextBox TxtSearchC;
        private Button BtnSearchC;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgCustomers;
        private TextBox textBox2;
        private Label TxtcName;
        private TextBox TxtCId;
        private Label TxtCustomersId;
        private TextBox TxtLastName;
        private Label LblLastName;
        private TextBox TxtBirthdayC;
        private Label LblBirthday;
        private TextBox TxtAddress;
        private Label LblAddress;
        private TextBox TxtEmailC;
        private Label LblEmailC;
        private TextBox TxtPhoneC;
        private Label LblPhone;
        private Button BtnCancelC;
        private Button BtnSaveC;
    }
}