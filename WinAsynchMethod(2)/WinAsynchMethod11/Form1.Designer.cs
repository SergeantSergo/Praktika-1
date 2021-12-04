
namespace WinAsynchMethod11
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
            this.IdIA = new System.Windows.Forms.Label();
            this.IdIB = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txbB = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdIA
            // 
            this.IdIA.AutoSize = true;
            this.IdIA.Location = new System.Drawing.Point(8, 24);
            this.IdIA.Name = "IdIA";
            this.IdIA.Size = new System.Drawing.Size(65, 13);
            this.IdIA.TabIndex = 0;
            this.IdIA.Text = "Значение A";
            // 
            // IdIB
            // 
            this.IdIB.AutoSize = true;
            this.IdIB.Location = new System.Drawing.Point(216, 24);
            this.IdIB.Name = "IdIB";
            this.IdIB.Size = new System.Drawing.Size(65, 13);
            this.IdIB.TabIndex = 1;
            this.IdIB.Text = "Значение B";
            // 
            // txtA
            // 
            this.helpProvider1.SetHelpString(this.txtA, "A");
            this.txtA.Location = new System.Drawing.Point(88, 24);
            this.txtA.Name = "txtA";
            this.helpProvider1.SetShowHelp(this.txtA, true);
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 2;
            // 
            // txbB
            // 
            this.helpProvider1.SetHelpString(this.txbB, "B");
            this.txbB.Location = new System.Drawing.Point(296, 24);
            this.txbB.Name = "txbB";
            this.helpProvider1.SetShowHelp(this.txbB, true);
            this.txbB.Size = new System.Drawing.Size(100, 20);
            this.txbB.TabIndex = 3;
            // 
            // btnRun
            // 
            this.helpProvider1.SetHelpString(this.btnRun, "Summ");
            this.btnRun.Location = new System.Drawing.Point(16, 64);
            this.btnRun.Name = "btnRun";
            this.helpProvider1.SetShowHelp(this.btnRun, true);
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Сумма";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnWork
            // 
            this.btnWork.Location = new System.Drawing.Point(120, 128);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(75, 23);
            this.btnWork.TabIndex = 5;
            this.btnWork.Text = "Работа";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Студент\\Desktop\\Репозиторий Матвеев\\WinAsynchMethod11\\WinAsynchMethod11\\" +
    "text.txt";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 161);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txbB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.IdIB);
            this.Controls.Add(this.IdIA);
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdIA;
        private System.Windows.Forms.Label IdIB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txbB;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button button1;
    }
}

