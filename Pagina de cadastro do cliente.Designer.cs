namespace CALCULADORA_POO
{
    partial class Pagina_de_cadastro_do_cliente
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
            this.textBox_CPF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.TextBox_Telefone = new System.Windows.Forms.TextBox();
            this.Telefone = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_CPF
            // 
            this.textBox_CPF.Location = new System.Drawing.Point(32, 48);
            this.textBox_CPF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_CPF.Name = "textBox_CPF";
            this.textBox_CPF.Size = new System.Drawing.Size(76, 20);
            this.textBox_CPF.TabIndex = 0;
            this.textBox_CPF.TextChanged += new System.EventHandler(this.textBox_CPF_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOME";
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(11, 103);
            this.textBox_Nome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Nome.Multiline = true;
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(279, 19);
            this.textBox_Nome.TabIndex = 3;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(150, 48);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(254, 20);
            this.textBox_Email.TabIndex = 7;
            this.textBox_Email.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "DATA DE NASCIMENTO";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 152);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 217);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 58);
            this.button1.TabIndex = 9;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBox_Telefone
            // 
            this.TextBox_Telefone.Location = new System.Drawing.Point(301, 103);
            this.TextBox_Telefone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBox_Telefone.Name = "TextBox_Telefone";
            this.TextBox_Telefone.Size = new System.Drawing.Size(104, 20);
            this.TextBox_Telefone.TabIndex = 11;
            this.TextBox_Telefone.Text = " ";
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Location = new System.Drawing.Point(333, 88);
            this.Telefone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(49, 13);
            this.Telefone.TabIndex = 10;
            this.Telefone.Text = "Telefone";
            this.Telefone.Click += new System.EventHandler(this.Telefone_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(279, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 60);
            this.button2.TabIndex = 12;
            this.button2.Text = "CONSULTAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(162, 282);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(229, 60);
            this.button3.TabIndex = 13;
            this.button3.Text = "EXCLUIR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Pagina_de_cadastro_do_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TextBox_Telefone);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_CPF);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Pagina_de_cadastro_do_cliente";
            this.Text = "Pagina_de_cadastro_do_cliente";
            this.Load += new System.EventHandler(this.Pagina_de_cadastro_do_cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_CPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextBox_Telefone;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}