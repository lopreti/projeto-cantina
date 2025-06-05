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
            // TelaChamadaStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(784, 461);
            Controls.Add(listBoxPreparando);
            Controls.Add(listBoxProntos);
            Name = "TelaChamadaStatus";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaChamadaStatus";
            Load += TelaChamadaStatus_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxProntos;
        private ListBox listBoxPreparando;
        private System.Windows.Forms.Timer timer1;
    }
}