namespace Cantinaa
{
    partial class TelaChamadaStatus
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaChamadaStatus));
            listBoxProntos = new ListBox();
            listBoxPreparando = new ListBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            label14 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBoxProntos
            // 
            listBoxProntos.BackColor = Color.WhiteSmoke;
            listBoxProntos.Enabled = false;
            listBoxProntos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxProntos.FormattingEnabled = true;
            listBoxProntos.ItemHeight = 20;
            listBoxProntos.Location = new Point(440, 111);
            listBoxProntos.Name = "listBoxProntos";
            listBoxProntos.Size = new Size(291, 304);
            listBoxProntos.TabIndex = 0;
            // 
            // listBoxPreparando
            // 
            listBoxPreparando.BackColor = Color.WhiteSmoke;
            listBoxPreparando.Enabled = false;
            listBoxPreparando.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxPreparando.FormattingEnabled = true;
            listBoxPreparando.ItemHeight = 20;
            listBoxPreparando.Location = new Point(67, 111);
            listBoxPreparando.Name = "listBoxPreparando";
            listBoxPreparando.Size = new Size(291, 304);
            listBoxPreparando.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label14);
            panel1.Location = new Point(590, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(143, 34);
            panel1.TabIndex = 37;
            panel1.Visible = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Black;
            label14.Cursor = Cursors.Hand;
            label14.ForeColor = SystemColors.ControlLightLight;
            label14.Location = new Point(12, 10);
            label14.Name = "label14";
            label14.Size = new Size(117, 15);
            label14.TabIndex = 33;
            label14.Text = "Menu Administrador";
            label14.Click += label14_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(735, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // TelaChamadaStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(784, 461);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(listBoxPreparando);
            Controls.Add(listBoxProntos);
            Name = "TelaChamadaStatus";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaChamadaStatus";
            Load += TelaChamadaStatus_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxProntos;
        private ListBox listBoxPreparando;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Label label14;
        private PictureBox pictureBox1;
    }
}