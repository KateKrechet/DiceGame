using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DiceGame
{
    class DiceControl:PictureBox
    {
        Graphics graphics;
        Random random;
        
        int Count;
        public Font NumberFont { get; set; }
        public Color NumberColor { get; set; }
        public DiceControl()
        {
            Width = 100;
            Height = 100;
            graphics = CreateGraphics();
            graphics.Clear(Color.White);
            NumberFont = new Font("Arial", 20);
            NumberColor = Color.Black;
            Count = 6;
            random = new Random();
            DrawNumber(1);
        }
        void DrawNumber(int num)
        {
            int x = (int)Math.Round(NumberFont.Size / 2);
            graphics.Clear(Color.White);
            Bitmap bitmap = new Bitmap(
                Image.FromFile("d:\\КАТЯ -учеба\\xxx.png"), Width, Height);
            graphics.DrawImage(bitmap,0,0);
            graphics.DrawString(num.ToString(),
                NumberFont,
                new SolidBrush(NumberColor),
                Width / 2-x, Height / 2-x);

        }
        public void Generate()
        {
            DrawNumber(random.Next(Count) + 1);
        }
    }
}
