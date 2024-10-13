namespace Supermarket_mvp.views
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            panel1 = new Panel();
            BtnCategories = new Button();
            BtCustomers = new Button();
            BtnExit = new Button();
            BtPayMode = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnCategories);
            panel1.Controls.Add(BtCustomers);
            panel1.Controls.Add(BtnExit);
            panel1.Controls.Add(BtPayMode);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 493);
            panel1.TabIndex = 0;
            // 
            // BtnCategories
            // 
            BtnCategories.BackgroundImage = Properties.Resources.categorias;
            BtnCategories.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCategories.Location = new Point(0, 254);
            BtnCategories.Name = "BtnCategories";
            BtnCategories.Size = new Size(197, 76);
            BtnCategories.TabIndex = 4;
            BtnCategories.UseVisualStyleBackColor = true;
            // 
            // BtCustomers
            // 
            BtCustomers.BackgroundImage = (Image)resources.GetObject("BtCustomers.BackgroundImage");
            BtCustomers.BackgroundImageLayout = ImageLayout.Zoom;
            BtCustomers.Location = new Point(0, 172);
            BtCustomers.Name = "BtCustomers";
            BtCustomers.Size = new Size(197, 76);
            BtCustomers.TabIndex = 3;
            BtCustomers.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            BtnExit.BackgroundImage = Properties.Resources.cerrar_sesion;
            BtnExit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnExit.Dock = DockStyle.Bottom;
            BtnExit.Location = new Point(0, 414);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(200, 79);
            BtnExit.TabIndex = 2;
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // BtPayMode
            // 
            BtPayMode.BackgroundImage = Properties.Resources.buy;
            BtPayMode.BackgroundImageLayout = ImageLayout.Zoom;
            BtPayMode.Location = new Point(0, 90);
            BtPayMode.Name = "BtPayMode";
            BtPayMode.Size = new Size(197, 76);
            BtPayMode.TabIndex = 1;
            BtPayMode.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sell;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 493);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "Supermarket";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtPayMode;
        private PictureBox pictureBox1;
        private Button BtnExit;
        private Button BtnCategories;
        private Button BtCustomers;
    }
}