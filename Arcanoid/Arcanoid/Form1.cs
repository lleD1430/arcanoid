using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arcanoid
{
    public partial class Form1 : Form
    {
        const int mapWidth = 16;
        const int mapHeight = 20;
        
        public int[,] map = new int[mapHeight, mapWidth];
        public int dirX = 0;
        public int dirY = 0;
        public int boardX;
        public int boardY;

        public Image arcanoidSet;

        public Form1()
        {
            InitializeComponent();  

            timer1.Tick += new EventHandler(update);

            Init();
        }

        private void update(object sender, EventArgs e)
        {
            Invalidate();
        }

        public void Init()
        {
            arcanoidSet = new Bitmap("D:\\pic\\arcanoid.png");
            timer1.Interval = 50;

            boardX = mapWidth / 2;
            boardY = mapHeight -1;

            for (int i = 0; i < mapHeight; i++)
            {
                for (int j = 0; j < mapWidth; j++)
                {
                    map[i, j] = 0;
                }
            }

            map[boardY, boardX] = 9;
            map[boardY, boardX + 1] = 9;
        }

        public void DrawMap(Graphics g)
        {
            for (int i = 0; i < mapHeight; i++)
            {
                for (int j = 0; j < mapWidth; j++)
                {
                    if (map[i, j] == 9)
                    {
                        g.DrawImage(arcanoidSet, new Rectangle(new Point(0,0), new Size(75,25)), 398, 17, 150, 50, GraphicsUnit.Pixel);
                    }
                    g.DrawImage
                }
            }
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {

        }
    }
}
