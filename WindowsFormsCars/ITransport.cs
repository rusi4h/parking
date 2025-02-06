using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static WindowsFormsCars.SportCar;

namespace WindowsFormsCars
{
    internal interface ITransport
    {
        void SetPosition(int x, int y, int width, int height);
        void MoveTransport(Direction direction);
        void DrawCar(Graphics g);
        void SetMainColor(Color color);
    }
}
