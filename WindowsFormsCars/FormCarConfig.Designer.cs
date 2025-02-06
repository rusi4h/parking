namespace WindowsFormsCars
{
    partial class FormCarConfig
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
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSportCar = new System.Windows.Forms.Label();
            this.labelCar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelBeige = new System.Windows.Forms.Panel();
            this.panelPink = new System.Windows.Forms.Panel();
            this.panelBoloto = new System.Windows.Forms.Panel();
            this.panelAqua = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.Location = new System.Drawing.Point(29, 18);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(142, 84);
            this.pictureBoxCar.TabIndex = 0;
            this.pictureBoxCar.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelSportCar);
            this.groupBox1.Controls.Add(this.labelCar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип кузова";
            // 
            // labelSportCar
            // 
            this.labelSportCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSportCar.Location = new System.Drawing.Point(22, 78);
            this.labelSportCar.Name = "labelSportCar";
            this.labelSportCar.Size = new System.Drawing.Size(111, 44);
            this.labelSportCar.TabIndex = 3;
            this.labelSportCar.Text = "Гоночный автомобиль";
            this.labelSportCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSportCar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelSportCar_MouseDown);
            // 
            // labelCar
            // 
            this.labelCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCar.Location = new System.Drawing.Point(22, 25);
            this.labelCar.Name = "labelCar";
            this.labelCar.Size = new System.Drawing.Size(111, 44);
            this.labelCar.TabIndex = 2;
            this.labelCar.Text = "Обычный автомобиль";
            this.labelCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelСar_MouseDown);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.labelDopColor);
            this.panel1.Controls.Add(this.labelBaseColor);
            this.panel1.Controls.Add(this.pictureBoxCar);
            this.panel1.Location = new System.Drawing.Point(186, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 231);
            this.panel1.TabIndex = 2;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(44, 173);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(111, 44);
            this.labelDopColor.TabIndex = 5;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(44, 118);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(111, 44);
            this.labelBaseColor.TabIndex = 4;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.label1_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.label1_DragEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelBeige);
            this.groupBox2.Controls.Add(this.panelPink);
            this.groupBox2.Controls.Add(this.panelBoloto);
            this.groupBox2.Controls.Add(this.panelAqua);
            this.groupBox2.Controls.Add(this.panelRed);
            this.groupBox2.Controls.Add(this.panelGreen);
            this.groupBox2.Controls.Add(this.panelGray);
            this.groupBox2.Controls.Add(this.panelBlack);
            this.groupBox2.Location = new System.Drawing.Point(411, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 231);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цвета";
            // 
            // panelBeige
            // 
            this.panelBeige.BackColor = System.Drawing.Color.Wheat;
            this.panelBeige.Location = new System.Drawing.Point(78, 173);
            this.panelBeige.Name = "panelBeige";
            this.panelBeige.Size = new System.Drawing.Size(38, 36);
            this.panelBeige.TabIndex = 5;
            // 
            // panelPink
            // 
            this.panelPink.BackColor = System.Drawing.Color.Magenta;
            this.panelPink.Location = new System.Drawing.Point(18, 173);
            this.panelPink.Name = "panelPink";
            this.panelPink.Size = new System.Drawing.Size(38, 36);
            this.panelPink.TabIndex = 5;
            // 
            // panelBoloto
            // 
            this.panelBoloto.BackColor = System.Drawing.Color.OliveDrab;
            this.panelBoloto.Location = new System.Drawing.Point(78, 126);
            this.panelBoloto.Name = "panelBoloto";
            this.panelBoloto.Size = new System.Drawing.Size(38, 36);
            this.panelBoloto.TabIndex = 5;
            // 
            // panelAqua
            // 
            this.panelAqua.BackColor = System.Drawing.Color.Aqua;
            this.panelAqua.Location = new System.Drawing.Point(18, 126);
            this.panelAqua.Name = "panelAqua";
            this.panelAqua.Size = new System.Drawing.Size(38, 36);
            this.panelAqua.TabIndex = 5;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(78, 79);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(38, 36);
            this.panelRed.TabIndex = 5;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(18, 79);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(38, 36);
            this.panelGreen.TabIndex = 5;
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.Location = new System.Drawing.Point(78, 26);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(38, 36);
            this.panelGray.TabIndex = 5;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(18, 26);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(38, 36);
            this.panelBlack.TabIndex = 4;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(12, 227);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click_1);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(97, 227);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormCarConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 262);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCarConfig";
            this.Text = "FormCarConfig";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelSportCar;
        private System.Windows.Forms.Label labelCar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelPink;
        private System.Windows.Forms.Panel panelBoloto;
        private System.Windows.Forms.Panel panelAqua;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelBeige;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}