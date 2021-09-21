using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE_POE_task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    abstract class Tile
    {
        protected int X;
        protected int Y;

        enum TileType
        {
            Hero,
            Enemy,
            Gold,
            Weapon,
        }

        public Tile(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
