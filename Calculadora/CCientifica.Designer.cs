namespace Calculadora
{
    partial class CCientifica
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
            btn_mul = new Button();
            btn_res = new Button();
            btn_div = new Button();
            btn_sum = new Button();
            total = new TextBox();
            label4 = new Label();
            n2 = new TextBox();
            n1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btn_rai = new Button();
            btn_pot = new Button();
            btn_pi = new Button();
            btn_log = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.images;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(478, 3);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(158, 172);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(175, 29);
            label1.Name = "label1";
            label1.Size = new Size(209, 28);
            label1.TabIndex = 2;
            label1.Text = "Caluladora Cientifica";
            // 
            // btn_mul
            // 
            btn_mul.Location = new Point(210, 381);
            btn_mul.Margin = new Padding(3, 4, 3, 4);
            btn_mul.Name = "btn_mul";
            btn_mul.Size = new Size(86, 31);
            btn_mul.TabIndex = 21;
            btn_mul.Text = "*";
            btn_mul.UseVisualStyleBackColor = true;
            btn_mul.Click += btn_mul_Click;
            // 
            // btn_res
            // 
            btn_res.Location = new Point(73, 432);
            btn_res.Margin = new Padding(3, 4, 3, 4);
            btn_res.Name = "btn_res";
            btn_res.Size = new Size(86, 31);
            btn_res.TabIndex = 20;
            btn_res.Text = "-";
            btn_res.UseVisualStyleBackColor = true;
            btn_res.Click += btn_res_Click;
            // 
            // btn_div
            // 
            btn_div.Location = new Point(210, 432);
            btn_div.Margin = new Padding(3, 4, 3, 4);
            btn_div.Name = "btn_div";
            btn_div.Size = new Size(86, 31);
            btn_div.TabIndex = 19;
            btn_div.Text = "/";
            btn_div.UseVisualStyleBackColor = true;
            btn_div.Click += btn_div_Click;
            // 
            // btn_sum
            // 
            btn_sum.Location = new Point(77, 381);
            btn_sum.Margin = new Padding(3, 4, 3, 4);
            btn_sum.Name = "btn_sum";
            btn_sum.Size = new Size(86, 31);
            btn_sum.TabIndex = 18;
            btn_sum.Text = "+";
            btn_sum.UseVisualStyleBackColor = true;
            btn_sum.Click += btn_sum_Click;
            // 
            // total
            // 
            total.Location = new Point(283, 273);
            total.Margin = new Padding(3, 4, 3, 4);
            total.Name = "total";
            total.Size = new Size(228, 27);
            total.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(160, 277);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 16;
            label4.Text = "Total :";
            // 
            // n2
            // 
            n2.Location = new Point(283, 213);
            n2.Margin = new Padding(3, 4, 3, 4);
            n2.Name = "n2";
            n2.Size = new Size(114, 27);
            n2.TabIndex = 15;
            // 
            // n1
            // 
            n1.Location = new Point(283, 165);
            n1.Margin = new Padding(3, 4, 3, 4);
            n1.Name = "n1";
            n1.Size = new Size(114, 27);
            n1.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 213);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 13;
            label3.Text = "Numero 2:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 169);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 12;
            label2.Text = "Numero 1:";
            // 
            // btn_rai
            // 
            btn_rai.Location = new Point(342, 381);
            btn_rai.Margin = new Padding(3, 4, 3, 4);
            btn_rai.Name = "btn_rai";
            btn_rai.Size = new Size(86, 31);
            btn_rai.TabIndex = 22;
            btn_rai.Text = "Raiz";
            btn_rai.UseVisualStyleBackColor = true;
            btn_rai.Click += btn_rai_Click;
            // 
            // btn_pot
            // 
            btn_pot.Location = new Point(342, 432);
            btn_pot.Margin = new Padding(3, 4, 3, 4);
            btn_pot.Name = "btn_pot";
            btn_pot.Size = new Size(86, 31);
            btn_pot.TabIndex = 23;
            btn_pot.Text = "Potencia";
            btn_pot.UseVisualStyleBackColor = true;
            btn_pot.Click += btn_pot_Click;
            // 
            // btn_pi
            // 
            btn_pi.Location = new Point(449, 432);
            btn_pi.Margin = new Padding(3, 4, 3, 4);
            btn_pi.Name = "btn_pi";
            btn_pi.Size = new Size(86, 31);
            btn_pi.TabIndex = 24;
            btn_pi.Text = "Valor Pi";
            btn_pi.UseVisualStyleBackColor = true;
            btn_pi.Click += btn_pi_Click;
            // 
            // btn_log
            // 
            btn_log.Location = new Point(449, 381);
            btn_log.Margin = new Padding(3, 4, 3, 4);
            btn_log.Name = "btn_log";
            btn_log.Size = new Size(86, 31);
            btn_log.TabIndex = 25;
            btn_log.Text = "Logaritmo";
            btn_log.UseVisualStyleBackColor = true;
            btn_log.Click += btn_log_Click;
            // 
            // CCientifica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 616);
            Controls.Add(btn_log);
            Controls.Add(btn_pi);
            Controls.Add(btn_pot);
            Controls.Add(btn_rai);
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
            Name = "CCientifica";
            Text = "CCientifica";
            Load += CCientifica_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button btn_mul;
        private Button btn_res;
        private Button btn_div;
        private Button btn_sum;
        private TextBox total;
        private Label label4;
        private TextBox n2;
        private TextBox n1;
        private Label label3;
        private Label label2;
        private Button btn_rai;
        private Button btn_pot;
        private Button btn_pi;
        private Button btn_log;
    }
}