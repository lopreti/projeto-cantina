﻿namespace Cantinaa
{
    partial class TelaVendas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVendas));
            listBoxProduto = new ListBox();
            listBoxCarrinho = new ListBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            label7 = new Label();
            label9 = new Label();
            textBoxNome = new TextBox();
            comboBox1 = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            textBoxValor = new TextBox();
            textBoxTroco = new TextBox();
            label6 = new Label();
            label8 = new Label();
            checkBox1 = new CheckBox();
            pictureBox1 = new PictureBox();
            label14 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // listBoxProduto
            // 
            listBoxProduto.BackColor = SystemColors.Window;
            listBoxProduto.Cursor = Cursors.Hand;
            listBoxProduto.ForeColor = SystemColors.WindowText;
            listBoxProduto.FormattingEnabled = true;
            listBoxProduto.ItemHeight = 15;
            listBoxProduto.Location = new Point(57, 80);
            listBoxProduto.Name = "listBoxProduto";
            listBoxProduto.Size = new Size(267, 184);
            listBoxProduto.TabIndex = 0;
            listBoxProduto.SelectedIndexChanged += listBoxProduto_SelectedIndexChanged;
            // 
            // listBoxCarrinho
            // 
            listBoxCarrinho.FormattingEnabled = true;
            listBoxCarrinho.ItemHeight = 15;
            listBoxCarrinho.Location = new Point(475, 79);
            listBoxCarrinho.Name = "listBoxCarrinho";
            listBoxCarrinho.Size = new Size(267, 184);
            listBoxCarrinho.TabIndex = 1;
            listBoxCarrinho.SelectedIndexChanged += listBoxCarrinho_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(341, 151);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 6;
            label3.Text = "Selecione Produto";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(341, 273);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 7;
            label4.Text = "Selecione Produto";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(566, 273);
            label5.Name = "label5";
            label5.Size = new Size(0, 19);
            label5.TabIndex = 9;
            label5.Click += label5_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Cursor = Cursors.Hand;
            numericUpDown1.Location = new Point(133, 288);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 13;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = Color.Yellow;
            label7.Location = new Point(97, 315);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.LightGray;
            label9.Location = new Point(155, 270);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 15;
            label9.Text = "Quantidade";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(47, 375);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(100, 23);
            textBoxNome.TabIndex = 16;
            textBoxNome.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(463, 375);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 17;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(47, 357);
            label10.Name = "label10";
            label10.Size = new Size(40, 15);
            label10.TabIndex = 18;
            label10.Text = "Nome";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(463, 357);
            label11.Name = "label11";
            label11.Size = new Size(125, 15);
            label11.TabIndex = 19;
            label11.Text = "Forma de Pagamento";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.Location = new Point(601, 354);
            label12.Name = "label12";
            label12.Size = new Size(40, 15);
            label12.TabIndex = 20;
            label12.Text = "Valor:";
            label12.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.Location = new Point(600, 395);
            label13.Name = "label13";
            label13.Size = new Size(41, 15);
            label13.TabIndex = 21;
            label13.Text = "Troco:";
            label13.Visible = false;
            // 
            // textBoxValor
            // 
            textBoxValor.Location = new Point(658, 352);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(99, 23);
            textBoxValor.TabIndex = 22;
            textBoxValor.Visible = false;
            textBoxValor.TextChanged += textBoxValor_TextChanged;
            // 
            // textBoxTroco
            // 
            textBoxTroco.Location = new Point(658, 392);
            textBoxTroco.Name = "textBoxTroco";
            textBoxTroco.ReadOnly = true;
            textBoxTroco.Size = new Size(99, 23);
            textBoxTroco.TabIndex = 23;
            textBoxTroco.Visible = false;
            textBoxTroco.TextChanged += textBox3_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(570, 296);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(180, 357);
            label8.Name = "label8";
            label8.Size = new Size(108, 15);
            label8.TabIndex = 26;
            label8.Text = "Forma de Retirada";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Location = new Point(180, 377);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(92, 19);
            checkBox1.TabIndex = 27;
            checkBox1.Text = "Para Viagem";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(739, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
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
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label14);
            panel1.Location = new Point(594, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(143, 34);
            panel1.TabIndex = 35;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(285, 416);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(224, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 37;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(343, 103);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(110, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 38;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(343, 229);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(110, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 39;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // TelaVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(784, 461);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(checkBox1);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(textBoxTroco);
            Controls.Add(textBoxValor);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(comboBox1);
            Controls.Add(textBoxNome);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBoxCarrinho);
            Controls.Add(listBoxProduto);
            Name = "TelaVendas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Vendas";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxProduto;
        private ListBox listBoxCarrinho;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private Label label7;
        private Label label9;
        private TextBox textBoxNome;
        private ComboBox comboBox1;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox textBoxValor;
        private TextBox textBoxTroco;
        private Label label6;
        private Label label8;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
        private Label label14;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
