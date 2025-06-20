namespace Cantinaa
{
    partial class TelaBalcao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaBalcao));
            listBox1 = new ListBox();
            button1 = new Button();
            listBox2 = new ListBox();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            label14 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Cursor = Cursors.Hand;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(109, 140);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(305, 244);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(80, 416);
            button1.Name = "button1";
            button1.Size = new Size(78, 33);
            button1.TabIndex = 1;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox2
            // 
            listBox2.Enabled = false;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(489, 170);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(210, 214);
            listBox2.TabIndex = 2;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(626, 417);
            button2.Name = "button2";
            button2.Size = new Size(90, 32);
            button2.TabIndex = 3;
            button2.Text = "COZINHA";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(737, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(465, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 34);
            panel1.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Cursor = Cursors.Hand;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(193, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 34;
            label1.Text = "Chamada";
            label1.Click += label1_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Black;
            label14.Cursor = Cursors.Hand;
            label14.ForeColor = SystemColors.ControlLightLight;
            label14.Location = new Point(24, 9);
            label14.Name = "label14";
            label14.Size = new Size(55, 15);
            label14.TabIndex = 33;
            label14.Text = "Produtos";
            label14.Click += label14_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Cursor = Cursors.Hand;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(115, 9);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 32;
            label2.Text = "Balcão";
            // 
            // TelaBalcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(784, 461);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(listBox2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "TelaBalcao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += TelaBalcao_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private ListBox listBox2;
        private Button button2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label14;
        private Label label2;
    }
}