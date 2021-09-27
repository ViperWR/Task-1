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
            MapLabel.Text = " ";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MapLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
    //Question 2.1
    public abstract class Tile
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

        public Tile()
        {
            
        }
        public Tile(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    abstract class Obstacle : Tile
    {
        
    }
    abstract class EmptyTile
    {

    }
    //Question 2.2
    abstract class Character : Tile
    {
        protected int HP;
        protected int Max_HP;
        protected int Damage;
        protected int MapBorder;

        protected int[] Vision = new int[4];

        public enum Movement
        {
            No_movement,
            Up,
            Down,
            Left,
            Right,
        }

        //Question 2.3
        public Character()
        {

        }
        public Character(int x, int y, char border)
        {
            X = x;
            Y = y;
            MapBorder = border;
        }
        public virtual void Attack(Character target)
        {

        }
        public void IsDead()
        {

        }
        public virtual void CheckRange(Character target)
        {
            DistanceTo();
        }
        private void DistanceTo()
        {

        }
        public void Move(Movement move)
        {

        }
        public abstract Movement ReturnMove(Movement move = 0);

        public abstract override string ToString();
    }
    //Question 2.4
    abstract class Enemy : Character
    {
        public Random rndObject = new Random();

        public Enemy()
        {

        }
        public Enemy(int x, int y, int enemy_Damage, int enemy_Starting_HP, char symbol)
        {

        }
        public override string ToString()
        {
            return ("Goblin at " + X + Y + Damage);
        }
        //Question 2.5
        public abstract class Goblin : Enemy
        {
            protected int goblin_HP;
            protected int goblin_Damage;
            public Goblin()
            {

            }
            public Goblin(int x, int y)
            {
                
            }
            public static void ReturnMove()
            {
                Random rnd = new Random();
                int direction = rnd.Next(0, 3);
            }
        }
    }
    abstract class Hero : Character
    {
        protected int Hero_Damage = 2;
        public Hero()
        {

        }
        public Hero(int x, int y, int hp)
        {
            X = x;
            Y = y;
            HP = hp;
            Max_HP = hp;
        }
        public void ReturnMove()
        {

        }
        public override string ToString()
        {
            return ("Player Stats:" + "\n HP: " + HP + "\n Damage: 2" + "\n [" + X + "," + Y + "]");
        }
    }
    //question 3.1
    abstract class map
    {
        public string[,] map_Arr;

        public object Hero_Symbol;

        public int[] enemies_Arr;

        public int map_Width;
        public int map_Height;

        //Question 3.2

        public map()
        {

        }
        public map(int min_Width, int max_Width, int min_Height, int max_Height , int enemies)
        {
            Random ran = new Random();

            map_Width = ran.Next(min_Width, max_Width);
            map_Height = ran.Next(min_Height, max_Height);

            map_Arr = new string[map_Width, map_Height];

            enemies_Arr = new int[enemies];

            Create();

            UpdateVision();

            Create_Objects();
        }
        public void Create()
        {
            for (int i = 0; i < map_Width; i++)
            {
                for (int n = 0; n < map_Height; n++)
                {
                    map_Arr[i, n] = " ";
                }
            }
            for (int i = 0; i < map_Width; i++)
            {
                map_Arr[i, 0] = "X";
                map_Arr[i, map_Height - 1] = "X";
            }
            for (int i = 0; i < map_Height; i++)
            {
                map_Arr[i, 0] = "X";
                map_Arr[i, map_Width - 1] = "X";
            }
        }

        public void UpdateVision()
        {
            
        }
        public void Create_Objects()
        {
            bool done = false;
            bool done_2 = false;

            while (done == false)
            {
                int i = 0;
                int x, y;

                Random ran = new Random();
                x = ran.Next(1, map_Width - 1);
                y = ran.Next(1, map_Height - 1);

                while (map_Arr[x, y] != " ")
                {
                    x = ran.Next(1, map_Width - 1);
                    y = ran.Next(1, map_Height - 1);
                }

                if (map_Arr[x, y] == " ")
                {
                    map_Arr[x, y] = "G";
                    i++;
                }

                if (i >= enemies_Arr.Length - 1)
                {
                    done = true;
                }
            }

            while (done_2 == false)
            {
                int i = 0;
                int x, y;

                Random ran = new Random();
                x = ran.Next(1, map_Width - 1);
                y = ran.Next(1, map_Height - 1);

                while (map_Arr[x, y] != " ")
                {
                    x = ran.Next(1, map_Width - 1);
                    y = ran.Next(1, map_Height - 1);
                }
                if (map_Arr[x, y] == " ")
                {
                    map_Arr[x, y] = "H";

                    done_2 = true;
                }
            }
            char display_Map = Convert.ToChar(map_Arr);
            //question 4.1
            MessageBox.Show(Convert.ToString(display_Map));
        }
    }
    //question 3.3
    abstract class GameEngine
    {
        private int Map;
        public bool goRight, goLeft, goUp, goDown;

        public GameEngine()
        {
            
        }
        public static void MovePlayer()
        {

        }
        public void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.S)
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.W)
            {
                goUp = true;
            }
        }
        public void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.S)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.W)
            {
                goUp = false;
            }
        }
    }
}
