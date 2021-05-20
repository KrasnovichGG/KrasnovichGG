
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
            this.components = new System.ComponentModel.Container();
            this.paper = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.load_ph = new System.Windows.Forms.Button();
            this.Panelmenu = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.Figuresize = new System.Windows.Forms.TrackBar();
            this.btncolor = new System.Windows.Forms.Button();
            this.cmbboxf = new System.Windows.Forms.ComboBox();
            this.btnSD = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.paper.SuspendLayout();
            this.Panelmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Figuresize)).BeginInit();
            this.SuspendLayout();
            // 
            // paper
            // 
            this.paper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paper.Controls.Add(this.btnClear);
            this.paper.Location = new System.Drawing.Point(0, 130);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(1379, 395);
            this.paper.TabIndex = 1;
            this.paper.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.paper.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Bisque;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Location = new System.Drawing.Point(12, 7);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 27);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // load_ph
            // 
            this.load_ph.BackColor = System.Drawing.Color.Bisque;
            this.load_ph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.load_ph.Location = new System.Drawing.Point(1244, 23);
            this.load_ph.Name = "load_ph";
            this.load_ph.Size = new System.Drawing.Size(99, 70);
            this.load_ph.TabIndex = 2;
            this.load_ph.Text = "Загрузить фото";
            this.load_ph.UseVisualStyleBackColor = false;
            this.load_ph.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // Panelmenu
            // 
            this.Panelmenu.BackColor = System.Drawing.Color.Coral;
            this.Panelmenu.Controls.Add(this.load_ph);
            this.Panelmenu.Controls.Add(this.label4);
            this.Panelmenu.Controls.Add(this.label3);
            this.Panelmenu.Controls.Add(this.label2);
            this.Panelmenu.Controls.Add(this.label1);
            this.Panelmenu.Controls.Add(this.btnsave);
            this.Panelmenu.Controls.Add(this.Figuresize);
            this.Panelmenu.Controls.Add(this.btncolor);
            this.Panelmenu.Controls.Add(this.cmbboxf);
            this.Panelmenu.Controls.Add(this.btnSD);
            this.Panelmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panelmenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Panelmenu.Location = new System.Drawing.Point(0, 0);
            this.Panelmenu.Name = "Panelmenu";
            this.Panelmenu.Size = new System.Drawing.Size(1379, 131);
            this.Panelmenu.TabIndex = 2;
            this.Panelmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1030, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Выбрать размер фигуры";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(825, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Выбрать фигуру";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(684, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Выбрать цвет фигуры";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 32);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(237, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Сохранение происходит без предупреждения";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Bisque;
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.Location = new System.Drawing.Point(85, 48);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(191, 56);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Сохранить";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.button2_Click);
            // 
            // Figuresize
            // 
            this.Figuresize.Location = new System.Drawing.Point(1033, 48);
            this.Figuresize.Name = "Figuresize";
            this.Figuresize.Size = new System.Drawing.Size(188, 45);
            this.Figuresize.TabIndex = 4;
            this.Figuresize.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btncolor
            // 
            this.btncolor.BackColor = System.Drawing.Color.White;
            this.btncolor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncolor.Location = new System.Drawing.Point(709, 48);
            this.btncolor.Name = "btncolor";
            this.btncolor.Size = new System.Drawing.Size(56, 45);
            this.btncolor.TabIndex = 3;
            this.btncolor.UseVisualStyleBackColor = false;
            this.btncolor.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbboxf
            // 
            this.cmbboxf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbboxf.FormattingEnabled = true;
            this.cmbboxf.Items.AddRange(new object[] {
            "Треугольник",
            "Круг",
            "Прямоугольник",
            "Линия"});
            this.cmbboxf.Location = new System.Drawing.Point(825, 60);
            this.cmbboxf.Name = "cmbboxf";
            this.cmbboxf.Size = new System.Drawing.Size(121, 21);
            this.cmbboxf.TabIndex = 2;
            // 
            // btnSD
            // 
            this.btnSD.BackColor = System.Drawing.Color.Bisque;
            this.btnSD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSD.Location = new System.Drawing.Point(393, 12);
            this.btnSD.Name = "btnSD";
            this.btnSD.Size = new System.Drawing.Size(233, 112);
            this.btnSD.TabIndex = 0;
            this.btnSD.Text = "Начать Рисовать";
            this.btnSD.UseVisualStyleBackColor = false;
            this.btnSD.Click += new System.EventHandler(this.btnSD_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Menu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 525);
            this.Controls.Add(this.Panelmenu);
            this.Controls.Add(this.paper);
            this.Name = "Menu1";
            this.Text = "Рисование";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.paper.ResumeLayout(false);
            this.Panelmenu.ResumeLayout(false);
            this.Panelmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Figuresize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSD;
        private System.Windows.Forms.Panel Panelmenu;
        public System.Windows.Forms.Panel paper;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbboxf;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btncolor;
        private System.Windows.Forms.TrackBar Figuresize;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button load_ph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

