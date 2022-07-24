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

        public Form1()
        {
            InitializeComponent();
        }

        public void Init()
        {
            boardX = mapWidth / 2;
            boardY = mapHeight -1;

            for (int i = 0; i < mapHeight; i++)
            {
                for (int j = 0; j < mapWidth; j++)
                {
                    map[i, j] = 0;
                }
            }
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {

        }
    }
}
