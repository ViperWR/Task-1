﻿using System;
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
        map map11 = new map();
        //GameEngine GEngine = new GameEngine();
        int directions = 0;
        public Form1()
        {
            InitializeComponent();

            map11.map_Height = 12;
            map11.map_Width = 12;
            map11.enemies_Arr = new int[5];
            map11.map_Arr = new string[map11.map_Width, map11.map_Height];

            map11.Create();

            map11.UpdateVision();

            map11.Create_Objects();

            MapLabel.Text = "";
            for (int i = 0; i < map11.map_Width; i++)
            {
                for (int n = 0; n < map11.map_Height; n++)
                {
                    MapLabel.Text = MapLabel.Text + map11.map_Arr[i, n];
                }
                MapLabel.Text = MapLabel.Text + "\n";
            }

            update_P_Stats();
        }      
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void update_Map()
        {
            MapLabel.Text = "";
            for (int i = 0; i < map11.map_Width; i++)
            {
                for (int n = 0; n < map11.map_Height; n++)
                {
                    MapLabel.Text = MapLabel.Text + map11.map_Arr[i, n];
                }
                MapLabel.Text = MapLabel.Text + "\n";
            }
        }
        private void update_P_Stats()
        {
            richTextBox_Player_Stats.Text = "Player Stats:" + "\n HP: " + 100 + "\n Damage: 2" + "\n [" + map11.hero_Coords_X + "," + map11.hero_Coords_Y + "]";
        }
        private void moveHero()
        {
            switch (directions)
            {
                case 1:                //left
                    if (map11.hero_Coords_Y > 0)
                    {
                        if (map11.map_Arr[map11.hero_Coords_X, map11.hero_Coords_Y - 1] == " ")
                        {
                            map11.map_Arr[map11.hero_Coords_X, map11.hero_Coords_Y] = " ";
                            map11.map_Arr[map11.hero_Coords_X, map11.hero_Coords_Y - 1] = "H";
                            map11.hero_Coords_Y -= 1;
                        }
                        //else if (map11.map_Arr[map11.hero_Coords_X, map11.hero_Coords_Y - 1] == "G")
                        //{
                        //   map11.map_Arr[map11.hero_Coords_X, map11.hero_Coords_Y] = " ";          
                        //    map11.map_Arr[map11.hero_Coords_X, map11.hero_Coords_Y - 1] = "H";       
                        //    map11.hero_Coords_Y -= 1;
                        //}
                        update_P_Stats();
                        update_Map();
                    }

                    directions = 0;                //gets set to 0 so the player stops moving
                    return;
                case 2:                //right
                    if (map11.hero_Coords_Y < map11.map_Height - 1)
                    {
                        if (map11.map_Arr[map11.hero_Coords_X, map11.hero_Coords_Y + 1] == " ")
                        {
                            map11.map_Arr[map11.hero_Coords_X, map11.hero_Coords_Y] = " ";
                            map11.map_Arr[map11.hero_Coords_X, map11.hero_Coords_Y + 1] = "H";
                            map11.hero_Coords_Y += 1;
                        }
                        update_P_Stats();
                        update_Map();
                    }
                    directions = 0;
                    return;
                case 3:                //up
                    if (map11.hero_Coords_X > 0)
                    {
                        if (map11.map_Arr[map11.hero_Coords_X - 1, map11.hero_Coords_Y] == " ")
                        {
                            map11.map_Arr[map11.hero_Coords_X, map11.hero_Coords_Y] = " ";
                            map11.map_Arr[map11.hero_Coords_X - 1, map11.hero_Coords_Y] = "H";
                            map11.hero_Coords_X -= 1;
                        }
                        update_P_Stats();
                        update_Map();
                    }
                    directions = 0;
                    return;
                case 4:                //down
                    if (map11.hero_Coords_X < map11.map_Width - 1)
                    {
                        if (map11.map_Arr[map11.hero_Coords_X + 1, map11.hero_Coords_Y] == " ")
                        {
                            map11.map_Arr[map11.hero_Coords_X, map11.hero_Coords_Y] = " ";
                            map11.map_Arr[map11.hero_Coords_X + 1, map11.hero_Coords_Y] = "H";
                            map11.hero_Coords_X += 1;
                        }
                        update_P_Stats();
                        update_Map();
                    }
                    directions = 0;                //gets set to 0 so the player stops moving
                    return;
            }
        }
        private void selected_Enemy()
        {
            select_enemy.Items.Add("Above you");
            select_enemy.Items.Add("Under you");
            select_enemy.Items.Add("On your Right");
            select_enemy.Items.Add("On your Left");
        }
        private void attack_Enemy()
        {
            if (select_enemy.SelectedIndex == 0)
            {
                if (map11.map_Arr[map11.hero_Coords_X - 1, map11.hero_Coords_Y] == "G")
                {

                }
            }
            if (select_enemy.SelectedIndex == 1)
            {
                if (map11.map_Arr[map11.hero_Coords_X + 1, map11.hero_Coords_Y] == "G")
                {

                }
            }
            if (select_enemy.SelectedIndex == 2)
            {
                if (map11.map_Arr[map11.hero_Coords_X, map11.hero_Coords_Y + 1] == "G")
                {

                }
            }
            if (select_enemy.SelectedIndex == 3)
            {
                if (map11.map_Arr[map11.hero_Coords_X, map11.hero_Coords_Y - 1] == "G")
                {

                }
            }
        }
        private void MapLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            update_Map();
        }
        private void buttonUP1_Click(object sender, EventArgs e)
        {
            directions = 3;
            moveHero();
        }

        private void buttonLEFT1_Click(object sender, EventArgs e)
        {
            directions = 1;
            moveHero();
        }

        private void buttonDown1_Click(object sender, EventArgs e)
        {
            directions = 4;
            moveHero();
        }

        private void buttonRIGHT1_Click(object sender, EventArgs e)
        {
            directions = 2;
            moveHero();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_Attack_Click(object sender, EventArgs e)
        {
            attack_Enemy();
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
        protected int HP = 100;
        protected int Max_HP = 100;
        protected int Damage = 2;
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
    public class map
    {
        public string[,] map_Arr;

        public object Hero_Symbol;
        public int hero_Coords_X;
        public int hero_Coords_Y;

        public int prev_hero_Coords_X;
        public int prev_hero_Coords_Y;

        public int[] enemies_Arr;
        public int[] enemies_Coords_X;
        public int[] enemies_Coords_Y;

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
                map_Arr[0, i] = "X";
                map_Arr[map_Width - 1, i] = "X";
            }
        }

        public void UpdateVision()
        {
            
        }
        public void Create_Objects()
        {
            bool done = false;
            bool done_2 = false;

            for (int i = 0; i < enemies_Arr.Length; i++)
            {
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
                    //enemies_Coords_X[i] = x;
                    //enemies_Coords_Y[i] = y;
                }
            }

            while (done_2 == false)
            {
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
                    hero_Coords_X = x;
                    hero_Coords_Y = y;

                    done_2 = true;
                }
            }
        }

    }
    //question 3.3
    public class GameEngine
    {
        map map11 = new map();
        private int Map;
        public bool goRight, goLeft, goUp, goDown;

        public GameEngine()
        {
            
        }
    }
}
