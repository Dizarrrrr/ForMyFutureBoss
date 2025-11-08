
namespace kkurs
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButtonKlient = new System.Windows.Forms.RadioButton();
            this.radioButtonSotrudnik = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(196, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.textBox1.Location = new System.Drawing.Point(153, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 34);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Логин";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(153, 90);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(255, 33);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Пароль";
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // radioButtonKlient
            // 
            this.radioButtonKlient.AutoSize = true;
            this.radioButtonKlient.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonKlient.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonKlient.Location = new System.Drawing.Point(196, 130);
            this.radioButtonKlient.Name = "radioButtonKlient";
            this.radioButtonKlient.Size = new System.Drawing.Size(92, 27);
            this.radioButtonKlient.TabIndex = 3;
            this.radioButtonKlient.TabStop = true;
            this.radioButtonKlient.Text = "Клиент";
            this.radioButtonKlient.UseVisualStyleBackColor = false;
            // 
            // radioButtonSotrudnik
            // 
            this.radioButtonSotrudnik.AutoSize = true;
            this.radioButtonSotrudnik.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonSotrudnik.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonSotrudnik.Location = new System.Drawing.Point(196, 163);
            this.radioButtonSotrudnik.Name = "radioButtonSotrudnik";
            this.radioButtonSotrudnik.Size = new System.Drawing.Size(123, 27);
            this.radioButtonSotrudnik.TabIndex = 4;
            this.radioButtonSotrudnik.TabStop = true;
            this.radioButtonSotrudnik.Text = "Сотрудник";
            this.radioButtonSotrudnik.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.BackgroundImage = global::kkurs.Properties.Resources._244129fd878d241a05f705d56aaa99a9;
            this.ClientSize = new System.Drawing.Size(541, 286);
            this.Controls.Add(this.radioButtonSotrudnik);
            this.Controls.Add(this.radioButtonKlient);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(557, 325);
            this.MinimumSize = new System.Drawing.Size(557, 325);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButtonKlient;
        private System.Windows.Forms.RadioButton radioButtonSotrudnik;
    }
}

