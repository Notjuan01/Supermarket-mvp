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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            Tabcontrol = new TabPage();
            tabPage2 = new TabPage();
            LblSearch = new Label();
            TxtSearchC = new TextBox();
            BtnSearchC = new Button();
            DgCustomers = new DataGridView();
            BtnNew = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnClose = new Button();
            TxtCustomersId = new Label();
            TxtCIde = new TextBox();
            textBox2 = new TextBox();
            TxtcName = new Label();
            TxtLastName = new TextBox();
            LblLastName = new Label();
            TxtAddress = new TextBox();
            LblAddress = new Label();
            TxtBirthdayC = new TextBox();
            LblBirthday = new Label();
            TxtPhoneC = new TextBox();
            LblPhone = new Label();
            TxtEmailC = new TextBox();
            LblEmailC = new Label();
            BtnSaveC = new Button();
            BtnCancelC = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            Tabcontrol.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomers).BeginInit();
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
            // tabControl1
            // 
            tabControl1.Controls.Add(Tabcontrol);
            tabControl1.Controls.Add(tabPage2);
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
            // tabPage2
            // 
            tabPage2.Controls.Add(BtnCancelC);
            tabPage2.Controls.Add(BtnSaveC);
            tabPage2.Controls.Add(TxtEmailC);
            tabPage2.Controls.Add(LblEmailC);
            tabPage2.Controls.Add(TxtPhoneC);
            tabPage2.Controls.Add(LblPhone);
            tabPage2.Controls.Add(TxtBirthdayC);
            tabPage2.Controls.Add(LblBirthday);
            tabPage2.Controls.Add(TxtAddress);
            tabPage2.Controls.Add(LblAddress);
            tabPage2.Controls.Add(TxtLastName);
            tabPage2.Controls.Add(LblLastName);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(TxtcName);
            tabPage2.Controls.Add(TxtCIde);
            tabPage2.Controls.Add(TxtCustomersId);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 322);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Customers Detail";
            tabPage2.UseVisualStyleBackColor = true;
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
            // TxtSearchC
            // 
            TxtSearchC.Location = new Point(10, 37);
            TxtSearchC.Name = "TxtSearchC";
            TxtSearchC.PlaceholderText = "Data to Search";
            TxtSearchC.Size = new Size(512, 23);
            TxtSearchC.TabIndex = 1;
            // 
            // BtnSearchC
            // 
            BtnSearchC.BackgroundImage = Properties.Resources.search_small;
            BtnSearchC.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSearchC.Location = new Point(528, 33);
            BtnSearchC.Name = "BtnSearchC";
            BtnSearchC.Size = new Size(59, 36);
            BtnSearchC.TabIndex = 2;
            BtnSearchC.UseVisualStyleBackColor = true;
            // 
            // DgCustomers
            // 
            DgCustomers.AllowUserToAddRows = false;
            DgCustomers.AllowUserToDeleteRows = false;
            DgCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCustomers.Location = new Point(10, 75);
            DgCustomers.Name = "DgCustomers";
            DgCustomers.ReadOnly = true;
            DgCustomers.Size = new Size(575, 241);
            DgCustomers.TabIndex = 3;
            // 
            // BtnNew
            // 
            BtnNew.BackColor = Color.Silver;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(591, 75);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(193, 55);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = false;
            // 
            // BtnEdit
            // 
            BtnEdit.BackColor = Color.Silver;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(591, 136);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(193, 55);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = false;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = Color.Silver;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(591, 197);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(193, 55);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = false;
            // 
            // BtnClose
            // 
            BtnClose.BackColor = Color.Silver;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(591, 261);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(193, 55);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = false;
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
            // TxtCIde
            // 
            TxtCIde.Location = new Point(8, 37);
            TxtCIde.Name = "TxtCIde";
            TxtCIde.Size = new Size(158, 23);
            TxtCIde.TabIndex = 1;
            TxtCIde.Text = "Id";
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
            // BtnSaveC
            // 
            BtnSaveC.BackgroundImage = Properties.Resources.guardar_el_archivo;
            BtnSaveC.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSaveC.Location = new Point(342, 137);
            BtnSaveC.Name = "BtnSaveC";
            BtnSaveC.Size = new Size(88, 73);
            BtnSaveC.TabIndex = 14;
            BtnSaveC.UseVisualStyleBackColor = true;
            // 
            // BtnCancelC
            // 
            BtnCancelC.BackgroundImage = Properties.Resources.boton_x;
            BtnCancelC.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCancelC.Location = new Point(485, 137);
            BtnCancelC.Name = "BtnCancelC";
            BtnCancelC.Size = new Size(88, 73);
            BtnCancelC.TabIndex = 15;
            BtnCancelC.UseVisualStyleBackColor = true;
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
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage Tabcontrol;
        private TabPage tabPage2;
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
        private TextBox TxtCIde;
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