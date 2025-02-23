﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCars
{
    public class SportCar : Car, IComparable<Car>, IEquatable<Car>
    {
        public enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }

        public Color DopColor { private set; get; }
        public bool FrontSpoiler { private set; get; }
        public bool SideSpoiler { private set; get; }
        public bool BackSpoiler { private set; get; }
        private int _countLines;
        public int CountLines
        {
            set
            {
                if (value > 0 && value < 4) _countLines = value;
            }
            get { return _countLines; }
        }
        public SportCar(int maxSpeed, float weight, Color mainColor, Color dopColor,
        bool frontSpoiler, bool sideSpoiler, bool backSpoiler) : base (maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            FrontSpoiler = frontSpoiler;
            SideSpoiler = sideSpoiler;
            BackSpoiler = backSpoiler;

            Random rnd = new Random();
            CountLines = rnd.Next(1, 4);
        }

        public SportCar(string v) : base(v)
        {
        }

        public void DrawCar(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopBrush = new SolidBrush(DopColor);

            if (FrontSpoiler)
            {
                g.DrawEllipse(pen, _startPosX + 80, _startPosY - 6, 20, 20);
                g.DrawEllipse(pen, _startPosX + 80, _startPosY + 35, 20, 20);
                g.DrawEllipse(pen, _startPosX - 5, _startPosY - 6, 20, 20);
                g.DrawEllipse(pen, _startPosX - 5, _startPosY + 35, 20, 20);
                g.DrawRectangle(pen, _startPosX + 80, _startPosY - 6, 15, 15);
                g.DrawRectangle(pen, _startPosX + 80, _startPosY + 40, 15, 15);
                g.DrawRectangle(pen, _startPosX, _startPosY - 6, 14, 15);
                g.DrawRectangle(pen, _startPosX, _startPosY + 40, 14, 15);

                g.FillEllipse(dopBrush, _startPosX + 80, _startPosY - 5, 20, 20);
                g.FillEllipse(dopBrush, _startPosX + 80, _startPosY + 35, 20, 20);
                g.FillRectangle(dopBrush, _startPosX + 75, _startPosY, 25, 40);
                g.FillRectangle(dopBrush, _startPosX + 80, _startPosY - 5, 15, 15);
                g.FillRectangle(dopBrush, _startPosX + 80, _startPosY + 40, 15, 15);


                g.FillEllipse(dopBrush, _startPosX - 5, _startPosY - 5, 20, 20);
                g.FillEllipse(dopBrush, _startPosX - 5, _startPosY + 35, 20, 20);
                g.FillRectangle(dopBrush, _startPosX - 5, _startPosY, 25, 40);
                g.FillRectangle(dopBrush, _startPosX, _startPosY - 5, 15, 15);
                g.FillRectangle(dopBrush, _startPosX, _startPosY + 40, 15, 15);
            }
            if (SideSpoiler)
            {
                g.DrawRectangle(pen, _startPosX + 25, _startPosY - 6, 39, 10);
                g.DrawRectangle(pen, _startPosX + 25, _startPosY + 45, 39, 10);

                g.FillRectangle(dopBrush, _startPosX + 25, _startPosY - 5, 40, 10);
                g.FillRectangle(dopBrush, _startPosX + 25, _startPosY + 45, 40, 10);
            }

            base.DrawCar(g);

            switch (_countLines) 
            {
                case 1:
                    g.FillRectangle(dopBrush, _startPosX + 65, _startPosY + 18, 25, 15);
                    g.FillRectangle(dopBrush, _startPosX + 25, _startPosY + 18, 35, 15);
                    g.FillRectangle(dopBrush, _startPosX, _startPosY + 18, 20, 15);
                break;
                case 2:
                    g.FillRectangle(dopBrush, _startPosX + 65, _startPosY + 15, 25, 8);
                    g.FillRectangle(dopBrush, _startPosX + 65, _startPosY + 28, 25, 8);
                    g.FillRectangle(dopBrush, _startPosX + 25, _startPosY + 15, 35, 8);
                    g.FillRectangle(dopBrush, _startPosX + 25, _startPosY + 28, 35, 8);
                    g.FillRectangle(dopBrush, _startPosX, _startPosY + 15, 20, 8);
                    g.FillRectangle(dopBrush, _startPosX, _startPosY + 28, 20, 8);
                break;
                case 3:
                    g.FillRectangle(dopBrush, _startPosX + 65, _startPosY + 15, 25, 5);
                    g.FillRectangle(dopBrush, _startPosX + 65, _startPosY + 23, 25, 5);
                    g.FillRectangle(dopBrush, _startPosX + 65, _startPosY + 31, 25, 5);
                    g.FillRectangle(dopBrush, _startPosX + 25, _startPosY + 15, 35, 5);
                    g.FillRectangle(dopBrush, _startPosX + 25, _startPosY + 23, 35, 5);
                    g.FillRectangle(dopBrush, _startPosX + 25, _startPosY + 31, 35, 5);
                    g.FillRectangle(dopBrush, _startPosX, _startPosY + 15, 20, 5);
                    g.FillRectangle(dopBrush, _startPosX, _startPosY + 23, 20, 5);
                    g.FillRectangle(dopBrush, _startPosX, _startPosY + 31, 20, 5);
                break;
            }

            if (BackSpoiler)
            {
                g.FillRectangle(dopBrush, _startPosX - 5, _startPosY, 10, 50);
                g.DrawRectangle(pen, _startPosX - 5, _startPosY, 10, 50);
            }
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + FrontSpoiler + ";" + SideSpoiler + ";" + BackSpoiler;
        }
        public int CompareTo(SportCar other)
        {
            var res = (this is Car).CompareTo(other is Car);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (FrontSpoiler != other.FrontSpoiler)
            {
                return FrontSpoiler.CompareTo(other.FrontSpoiler);
            }
            if (SideSpoiler != other.SideSpoiler)
            {
                return SideSpoiler.CompareTo(other.SideSpoiler);
            }
            if (BackSpoiler != other.BackSpoiler)
            {
                return BackSpoiler.CompareTo(other.BackSpoiler);
            }
            return 0;
        }
        public bool Equals(SportCar other)
        {
            var res = (this as Car).Equals(other as Car);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (FrontSpoiler != other.FrontSpoiler)
            {
                return false;
            }
            if (SideSpoiler != other.SideSpoiler)
            {
                return false;
            }
            if (BackSpoiler != other.BackSpoiler)
            {
                return false;
            }
            return true;
        }
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is SportCar carObj))
            {
                return false;
            }
            else
            {
                return Equals(carObj);
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
