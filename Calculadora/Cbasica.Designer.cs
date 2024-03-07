namespace Calculadora
{
    partial class Cbasica
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            n1 = new TextBox();
            n2 = new TextBox();
            label4 = new Label();
            total = new TextBox();
            btn_sum = new Button();
            btn_div = new Button();
            btn_res = new Button();
            btn_mul = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.images;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(743, 16);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(158, 172);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(326, 37);
            label1.Name = "label1";
            label1.Size = new Size(189, 28);
            label1.TabIndex = 1;
            label1.Text = "Calculadora Basica";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 152);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 2;
            label2.Text = "Numero 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 196);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 3;
            label3.Text = "Numero 2:";
            // 
            // n1
            // 
            n1.Location = new Point(272, 148);
            n1.Margin = new Padding(3, 4, 3, 4);
            n1.Name = "n1";
            n1.Size = new Size(114, 27);
            n1.TabIndex = 4;
            // 
            // n2
            // 
            n2.Location = new Point(272, 196);
            n2.Margin = new Padding(3, 4, 3, 4);
            n2.Name = "n2";
            n2.Size = new Size(114, 27);
            n2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(149, 260);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 6;
            label4.Text = "Total :";
            // 
            // total
            // 
            total.Location = new Point(272, 256);
            total.Margin = new Padding(3, 4, 3, 4);
            total.Name = "total";
            total.Size = new Size(228, 27);
            total.TabIndex = 7;
            // 
            // btn_sum
            // 
            btn_sum.Location = new Point(138, 353);
            btn_sum.Margin = new Padding(3, 4, 3, 4);
            btn_sum.Name = "btn_sum";
            btn_sum.Size = new Size(86, 31);
            btn_sum.TabIndex = 8;
            btn_sum.Text = "+";
            btn_sum.UseVisualStyleBackColor = true;
            btn_sum.Click += btn_sum_Click;
            // 
            // btn_div
            // 
            btn_div.Location = new Point(272, 404);
            btn_div.Margin = new Padding(3, 4, 3, 4);
            btn_div.Name = "btn_div";
            btn_div.Size = new Size(86, 31);
            btn_div.TabIndex = 9;
            btn_div.Text = "/";
            btn_div.UseVisualStyleBackColor = true;
            btn_div.Click += btn_div_Click;
            // 
            // btn_res
            // 
            btn_res.Location = new Point(135, 404);
            btn_res.Margin = new Padding(3, 4, 3, 4);
            btn_res.Name = "btn_res";
            btn_res.Size = new Size(86, 31);
            btn_res.TabIndex = 10;
            btn_res.Text = "-";
            btn_res.UseVisualStyleBackColor = true;
            btn_res.Click += btn_res_Click;
            // 
            // btn_mul
            // 
            btn_mul.Location = new Point(272, 353);
            btn_mul.Margin = new Padding(3, 4, 3, 4);
            btn_mul.Name = "btn_mul";
            btn_mul.Size = new Size(86, 31);
            btn_mul.TabIndex = 11;
            btn_mul.Text = "*";
            btn_mul.UseVisualStyleBackColor = true;
            btn_mul.Click += btn_mul_Click;
            // 
            // Cbasica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btn_mul);
            Controls.Add(btn_res);
            Controls.Add(btn_div);
            Controls.Add(btn_sum);
            Controls.Add(total);
            Controls.Add(label4);
            Controls.Add(n2);
            Controls.Add(n1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Cbasica";
            Text = "Cbasica";
            Load += Cbasica_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox n1;
        private TextBox n2;
        private Label label4;
        private TextBox total;
        private Button btn_sum;
        private Button btn_div;
        private Button btn_res;
        private Button btn_mul;
    }
}