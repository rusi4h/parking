﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WindowsFormsCars.SportCar;

namespace WindowsFormsCars
{
    internal abstract class Vehicle : ITransport
    {
        protected float _startPosX;
        protected float _startPosY;
        protected int _pictureHeight;
        protected int _pictureWidth;
        public int MaxSpeed { protected set; get; }
        public float Weight { protected set; get; }
        public Color MainColor { protected set; get; }
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        public abstract void DrawCar(Graphics g);
        public abstract void MoveTransport(Direction direction);
    }
}
