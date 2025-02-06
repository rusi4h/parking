namespace WindowsFormsCars
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.pictureBoxTakeCar = new System.Windows.Forms.PictureBox();
            this.buttonTakeCar = new System.Windows.Forms.Button();
            this.buttonSetCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeCar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(-1, -2);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(679, 465);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(693, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Забрать машину";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(693, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Место:";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(739, 310);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(45, 20);
            this.maskedTextBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSetCar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.listBoxLevels);
            this.groupBox1.Controls.Add(this.pictureBoxTakeCar);
            this.groupBox1.Controls.Add(this.maskedTextBox);
            this.groupBox1.Controls.Add(this.pictureBoxParking);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 463);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(687, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Уровни:";
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.Location = new System.Drawing.Point(689, 39);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(99, 95);
            this.listBoxLevels.TabIndex = 10;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // pictureBoxTakeCar
            // 
            this.pictureBoxTakeCar.Location = new System.Drawing.Point(684, 371);
            this.pictureBoxTakeCar.Name = "pictureBoxTakeCar";
            this.pictureBoxTakeCar.Size = new System.Drawing.Size(110, 82);
            this.pictureBoxTakeCar.TabIndex = 9;
            this.pictureBoxTakeCar.TabStop = false;
            // 
            // buttonTakeCar
            // 
            this.buttonTakeCar.Location = new System.Drawing.Point(706, 338);
            this.buttonTakeCar.Name = "buttonTakeCar";
            this.buttonTakeCar.Size = new System.Drawing.Size(67, 24);
            this.buttonTakeCar.TabIndex = 8;
            this.buttonTakeCar.Text = "Забрать";
            this.buttonTakeCar.UseVisualStyleBackColor = true;
            this.buttonTakeCar.Click += new System.EventHandler(this.buttonTakeCar_Click);
            // 
            // buttonSetCar
            // 
            this.buttonSetCar.Location = new System.Drawing.Point(689, 140);
            this.buttonSetCar.Name = "buttonSetCar";
            this.buttonSetCar.Size = new System.Drawing.Size(99, 40);
            this.buttonSetCar.TabIndex = 11;
            this.buttonSetCar.Text = "Добавить автомобиль";
            this.buttonSetCar.UseVisualStyleBackColor = true;
            this.buttonSetCar.Click += new System.EventHandler(this.buttonSetCar_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 461);
            this.Controls.Add(this.buttonTakeCar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTakeCar;
        private System.Windows.Forms.PictureBox pictureBoxTakeCar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.Button buttonSetCar;
    }
}