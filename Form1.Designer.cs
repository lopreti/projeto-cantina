namespace Cantinaa
{
    partial class Form1
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
            listBoxProduto = new ListBox();
            listBoxCarrinho = new ListBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button3 = new Button();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // listBoxProduto
            // 
            listBoxProduto.FormattingEnabled = true;
            listBoxProduto.Location = new Point(17, 89);
            listBoxProduto.Margin = new Padding(3, 4, 3, 4);
            listBoxProduto.Name = "listBoxProduto";
            listBoxProduto.Size = new Size(264, 204);
            listBoxProduto.TabIndex = 0;
            // 
            // listBoxCarrinho
            // 
            listBoxCarrinho.FormattingEnabled = true;
            listBoxCarrinho.Location = new Point(515, 89);
            listBoxCarrinho.Margin = new Padding(3, 4, 3, 4);
            listBoxCarrinho.Name = "listBoxCarrinho";
            listBoxCarrinho.Size = new Size(264, 204);
            listBoxCarrinho.TabIndex = 1;
            listBoxCarrinho.SelectedIndexChanged += listBoxCarrinho_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(355, 102);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 2;
            button1.Text = "Adicionar ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(355, 222);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 3;
            button2.Text = "Remover";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 65);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 4;
            label1.Text = "Produtos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(518, 65);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Carrinho";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(192, 0, 0);
            label3.Location = new Point(302, 136);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 6;
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(192, 0, 0);
            label4.Location = new Point(301, 262);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 7;
            label4.Visible = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.WhiteSmoke;
            button3.Location = new Point(218, 370);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(344, 31);
            button3.TabIndex = 8;
            button3.Text = "Fechar pedido";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(355, 310);
            label5.Name = "label5";
            label5.Size = new Size(0, 23);
            label5.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(355, 333);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(355, 12);
            label8.Name = "label8";
            label8.Size = new Size(107, 32);
            label8.TabIndex = 12;
            label8.Text = "Cantina ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBoxCarrinho);
            Controls.Add(listBoxProduto);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pede Ifood pede";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxProduto;
        private ListBox listBoxCarrinho;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button3;
        private Label label5;
        private Label label6;
        private Label label8;
    }
}
