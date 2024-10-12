namespace Supermarket_mvp.views
{
    partial class CategoriesView
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
            tabPageCategoriesList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgCategories = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageCategoriesDetails = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            label5 = new Label();
            TxtCategoriesDescription = new TextBox();
            label4 = new Label();
            TxtCategoriesName = new TextBox();
            TxtCategoriesId = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCategoriesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategories).BeginInit();
            tabPageCategoriesDetails.SuspendLayout();
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
            pictureBox1.Image = Properties.Resources.categorias;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(121, 31);
            label1.Name = "label1";
            label1.Size = new Size(155, 37);
            label1.TabIndex = 0;
            label1.Text = "Categories";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCategoriesList);
            tabControl1.Controls.Add(tabPageCategoriesDetails);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 1;
            // 
            // tabPageCategoriesList
            // 
            tabPageCategoriesList.Controls.Add(BtnClose);
            tabPageCategoriesList.Controls.Add(BtnDelete);
            tabPageCategoriesList.Controls.Add(BtnEdit);
            tabPageCategoriesList.Controls.Add(BtnNew);
            tabPageCategoriesList.Controls.Add(DgCategories);
            tabPageCategoriesList.Controls.Add(BtnSearch);
            tabPageCategoriesList.Controls.Add(TxtSearch);
            tabPageCategoriesList.Controls.Add(label2);
            tabPageCategoriesList.Location = new Point(4, 24);
            tabPageCategoriesList.Name = "tabPageCategoriesList";
            tabPageCategoriesList.Padding = new Padding(3);
            tabPageCategoriesList.Size = new Size(792, 322);
            tabPageCategoriesList.TabIndex = 0;
            tabPageCategoriesList.Text = "Categories List";
            tabPageCategoriesList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(621, 260);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(163, 56);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(621, 194);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(163, 56);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(621, 132);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(163, 56);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(621, 70);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(163, 56);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgCategories
            // 
            DgCategories.AllowUserToAddRows = false;
            DgCategories.AllowUserToDeleteRows = false;
            DgCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategories.Location = new Point(8, 70);
            DgCategories.Name = "DgCategories";
            DgCategories.ReadOnly = true;
            DgCategories.Size = new Size(607, 249);
            DgCategories.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(540, 21);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(75, 43);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(8, 32);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to Categories";
            TxtSearch.Size = new Size(516, 23);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 12);
            label2.Name = "label2";
            label2.Size = new Size(117, 17);
            label2.TabIndex = 0;
            label2.Text = "Search Categories";
            // 
            // tabPageCategoriesDetails
            // 
            tabPageCategoriesDetails.Controls.Add(BtnCancel);
            tabPageCategoriesDetails.Controls.Add(BtnSave);
            tabPageCategoriesDetails.Controls.Add(label5);
            tabPageCategoriesDetails.Controls.Add(TxtCategoriesDescription);
            tabPageCategoriesDetails.Controls.Add(label4);
            tabPageCategoriesDetails.Controls.Add(TxtCategoriesName);
            tabPageCategoriesDetails.Controls.Add(TxtCategoriesId);
            tabPageCategoriesDetails.Controls.Add(label3);
            tabPageCategoriesDetails.Location = new Point(4, 24);
            tabPageCategoriesDetails.Name = "tabPageCategoriesDetails";
            tabPageCategoriesDetails.Padding = new Padding(3);
            tabPageCategoriesDetails.Size = new Size(792, 322);
            tabPageCategoriesDetails.TabIndex = 1;
            tabPageCategoriesDetails.Text = "Categories Detail";
            tabPageCategoriesDetails.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(173, 235);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(99, 69);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(33, 235);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(99, 69);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 142);
            label5.Name = "label5";
            label5.Size = new Size(167, 20);
            label5.TabIndex = 5;
            label5.Text = "Categories Description";
            // 
            // TxtCategoriesDescription
            // 
            TxtCategoriesDescription.Location = new Point(8, 165);
            TxtCategoriesDescription.Multiline = true;
            TxtCategoriesDescription.Name = "TxtCategoriesDescription";
            TxtCategoriesDescription.PlaceholderText = "Categories Description";
            TxtCategoriesDescription.Size = new Size(326, 64);
            TxtCategoriesDescription.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 82);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 3;
            label4.Text = "Categories Name";
            // 
            // TxtCategoriesName
            // 
            TxtCategoriesName.Location = new Point(8, 105);
            TxtCategoriesName.Name = "TxtCategoriesName";
            TxtCategoriesName.PlaceholderText = "Categories Name";
            TxtCategoriesName.Size = new Size(326, 23);
            TxtCategoriesName.TabIndex = 2;
            // 
            // TxtCategoriesId
            // 
            TxtCategoriesId.Location = new Point(8, 43);
            TxtCategoriesId.Name = "TxtCategoriesId";
            TxtCategoriesId.ReadOnly = true;
            TxtCategoriesId.Size = new Size(172, 23);
            TxtCategoriesId.TabIndex = 1;
            TxtCategoriesId.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 20);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 0;
            label3.Text = "Categories Id";
            // 
            // CategoriesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CategoriesView";
            Text = "Categories Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCategoriesList.ResumeLayout(false);
            tabPageCategoriesList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategories).EndInit();
            tabPageCategoriesDetails.ResumeLayout(false);
            tabPageCategoriesDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPageCategoriesList;
        private TabPage tabPageCategoriesDetails;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgCategories;
        private TextBox TxtCategoriesId;
        private Label label3;
        private Label label4;
        private TextBox TxtCategoriesName;
        private Label label5;
        private TextBox TxtCategoriesDescription;
        private Button BtnSave;
        private Button BtnCancel;
    }
}