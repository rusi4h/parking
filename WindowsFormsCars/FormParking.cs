using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCars
{
    public partial class FormParking : Form
    {
        MultiLevelParking parking;
        FormCarConfig form;
        private const int countLevel = 5;
        public FormParking()
        {
            InitializeComponent();
            parking = new MultiLevelParking(countLevel, pictureBoxParking.Width,
            pictureBoxParking.Height);

            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }
        private void buttonTakeCar_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBox.Text != "")
                {
                    var car = parking[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBox.Text);
                    if (car != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTakeCar.Width, pictureBoxTakeCar.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        car.SetPosition(5, 5, pictureBoxTakeCar.Width, pictureBoxTakeCar.Height);
                        car.DrawCar(gr);
                        pictureBoxTakeCar.Image = bmp;
                    }
                    else
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTakeCar.Width, pictureBoxTakeCar.Height);
                        pictureBoxTakeCar.Image = bmp;
                    }
                    Draw();
                }
            }
        }
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void buttonSetCar_Click(object sender, EventArgs e)
        {
            form = new FormCarConfig();
            form.AddEvent(AddCar);
            form.Show();
        }
        private void AddCar(ITransport car)
        {
            if (car != null && listBoxLevels.SelectedIndex > -1)
            {
                int place = parking[listBoxLevels.SelectedIndex] + car;
                if (place > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Машину не удалось поставить");
                }
            }
        }

    }
}
