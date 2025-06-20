namespace Cantinaa
{
    partial class TelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(228, 253);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(335, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(228, 340);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(335, 23);
            textBox2.TabIndex = 1;
            textBox2.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Location = new Point(602, 364);
            button1.Name = "button1";
            button1.Size = new Size(82, 38);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.ForeColor = SystemColors.ButtonHighlight;
            checkBox1.Location = new Point(228, 375);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(109, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Visualizar senha";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(784, 461);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "TelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private CheckBox checkBox1;
    }
}