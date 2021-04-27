
namespace Фигуры_КРАСНОВ
{
    partial class Menu1
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
            this.btnSD = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbcolor1 = new System.Windows.Forms.ComboBox();
            this.cmbboxf = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSD
            // 
            this.btnSD.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSD.Location = new System.Drawing.Point(432, 48);
            this.btnSD.Name = "btnSD";
            this.btnSD.Size = new System.Drawing.Size(128, 35);
            this.btnSD.TabIndex = 0;
            this.btnSD.Text = "StartDraw";
            this.btnSD.UseVisualStyleBackColor = false;
            this.btnSD.Click += new System.EventHandler(this.btnSD_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Location = new System.Drawing.Point(0, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 395);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(946, 7);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbboxf);
            this.panel2.Controls.Add(this.cmbcolor1);
            this.panel2.Controls.Add(this.btnSD);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1033, 131);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cmbcolor1
            // 
            this.cmbcolor1.FormattingEnabled = true;
            this.cmbcolor1.Items.AddRange(new object[] {
            "Green",
            "Red",
            "Orange",
            "Blue",
            "Purple",
            "Yellow"});
            this.cmbcolor1.Location = new System.Drawing.Point(622, 56);
            this.cmbcolor1.Name = "cmbcolor1";
            this.cmbcolor1.Size = new System.Drawing.Size(121, 21);
            this.cmbcolor1.TabIndex = 1;
            this.cmbcolor1.SelectedIndexChanged += new System.EventHandler(this.cmbcolor1_SelectedIndexChanged);
            // 
            // cmbboxf
            // 
            this.cmbboxf.FormattingEnabled = true;
            this.cmbboxf.Items.AddRange(new object[] {
            "Треугольник",
            "Круг",
            "Прямоугольник",
            "Линия"});
            this.cmbboxf.Location = new System.Drawing.Point(749, 56);
            this.cmbboxf.Name = "cmbboxf";
            this.cmbboxf.Size = new System.Drawing.Size(121, 21);
            this.cmbboxf.TabIndex = 2;
            this.cmbboxf.SelectedIndexChanged += new System.EventHandler(this.cmbboxf_SelectedIndexChanged);
            // 
            // Menu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 525);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Menu1";
            this.Text = "Рисование";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSD;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbboxf;
        private System.Windows.Forms.ComboBox cmbcolor1;
    }
}

