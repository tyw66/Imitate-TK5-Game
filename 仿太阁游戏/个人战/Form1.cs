using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KOgame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Person
        {
            public int Hp;
            public double Att, Dff;
            public Person() { }

            public Person(int hp, double att, double dff)
            {
                Hp = hp;
                Att = att;
                Dff = dff;
            }
        }

        Person player = new Person(100, 10.0, 5.0);
        Person master = new Person(100, 8.0, 6.0);
        Random ran = new Random();

        public void gameInit()
        {
            player = new Person(100, 10.0, 5.0);
            master = new Person(100, 8.0, 6.0);
            gameFresh();
        }




        private void btn_start_Click(object sender, EventArgs e)
        {
            gameInit();
        }

        private void gameFresh()
        {
            lab_myhp.Text = player.Hp.ToString();
            lab_hp.Text = master.Hp.ToString();            
            if (player.Hp <= 0)
            {
                player.Hp = 0;
                lab_myhp.Text = player.Hp.ToString();
                gameOver(1);
            }

            if (master.Hp <= 0)
            {
                master.Hp = 0;
                lab_hp.Text = master.Hp.ToString(); 
                gameOver(0);
            }



        }

        private void btn_attack_Click(object sender, EventArgs e)
        {

            int hit = 0;

            hit = attack(master.Hp, player.Att, master.Dff);
            master.Hp -= hit;

            hit = attack(player.Hp, master.Att, player.Dff);
            player.Hp -= hit;
            gameFresh();
 

            

        }

        public void timething(object source, System.Timers.ElapsedEventArgs e)
        {
            int hit = 0;

            hit = attack(player.Hp, master.Att, player.Dff);
            player.Hp -= hit;
            gameFresh();
        }

        public int attack(int hp, double att, double dff)
        {
            int hit=0;
            double t = ran.Next(1, 3);
            hit =Convert.ToInt32((att - dff) *t);
            return hit;
        }
       public void gameOver(int flag)
       {
           if (flag == 0) lab_stat.Text = "游戏结束,你胜利了";
           if (flag == 1) lab_stat.Text = "游戏结束,你败北了";
           

           return;
       }
    }
}
