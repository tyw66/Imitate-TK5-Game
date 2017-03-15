using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace 抛体弓术
{
    public partial class game : Form
    {
        public game()
        {
            InitializeComponent();
        }
        const double PI = 3.141;    //π
        const int GRAVITY = 2;      //重力加速度
        const int NUM_GOAL = 5;     //靶的初始数目
        const int GOAL_WIDTH = 15;  //靶的宽
        const int GOAL_HIGHT = 45;  //靶的高
        const int ARROWNUMBER = 10; //初始拥有的箭数目
        const int WINDOW_HEIGHT = 380;
        const int WINDOW_WIDTH = 820;

        int v, vx, vy;                              //箭速度与速度分量
        double  angle;                              //入射角
        int hp, grade;                              //箭数目,分数
        //int window_height, window_width;             //靶区画面区域高宽
        int[] height=new int[NUM_GOAL];             //靶的位置Y坐标
        bool[] IsHit = new bool[NUM_GOAL];          //是否碰撞

        Graphics G;                                     //画图设备
        Random rd=new Random();                         //随机数
        Point pt_0 = new Point(90, 280);               //箭的初始位置点
        Point pt;                                      //箭的实时位置点
        Pen pen = new Pen(Color.Chocolate, 2f);         //棕色笔
        Color color = Color.Black;                      //黑色
        myArrow arrow = new myArrow();                  //弓箭类
        Rectangle[] rect_goal = new Rectangle[NUM_GOAL];//靶
        Rectangle arw;                                  //弓箭碰撞体

        //Bitmap bgpic = new Bitmap(@"D:\桌面文件\C#游戏\仿太阁游戏\弓术\Properties\pic\1.bmp");
        Bitmap map_bg, map_goal0, map_goal1;
        Bitmap[] map_arrow = new Bitmap[9];
        Image img,arrimg;
        
        public class myArrow
        {
            public Point Pt;            
            public int Vx, Vy,V;
            public Color _color;
            public myArrow() { }
            public myArrow(Point pt, int vx, int vy, Color color)
            {
                Pt = pt;
                Vx = vx;
                Vy = vy;
                _color = color;
            }
        }
        private void trk_angle_Scroll(object sender, EventArgs e)
        {
            lab_angle.Text = trk_angle.Value.ToString();
        }

        private void trk_bar_Scroll(object sender, EventArgs e)
        {
            lab_force.Text = trk_bar.Value.ToString();
        }
        //按钮_初始化
        private void btn_init_Click(object sender, EventArgs e)
        {
            GameInit();
            
        }
        //按钮_发射
        private void btn_Click(object sender, EventArgs e)
        {
            pt = pt_0;

            v = -trk_bar.Value;
            angle = trk_angle.Value * PI / 180;

            vx = (int)(v * Math.Cos(angle));
            vy = -(int)(v * Math.Sin(angle));
            arrow = new myArrow(pt, vx, vy, color);

            hp -= 1;
            if (hp < 0)
            {
                lab_stat.Text = "游戏结束";
                return;
            }
            lab_HP.Text = hp.ToString();

            btn.Enabled = false;
            timer1.Enabled = true;            
        }





        private void GameInit()
        {
            //ShootOff();
            G = game_window.CreateGraphics();
            img = Image.FromFile(@"D:\桌面文件\C#游戏\仿太阁游戏\弓术\Resources\1.bmp");
            map_bg = new Bitmap(img);
            img = Image.FromFile(@"D:\桌面文件\C#游戏\仿太阁游戏\弓术\Resources\2.bmp");
            map_goal0 = new Bitmap(img);
            map_goal0.MakeTransparent(Color.FromArgb(0, 255, 0));
            img = Image.FromFile(@"D:\桌面文件\C#游戏\仿太阁游戏\弓术\Resources\3.bmp");
            map_goal1 = new Bitmap(img);
            map_goal1.MakeTransparent(Color.FromArgb(0, 255, 0));
            
            
            for (int ii = 0; ii < 9; ii++)
            {
                string path = @"D:\桌面文件\C#游戏\仿太阁游戏\弓术\Resources\5-"+ii.ToString()+".bmp";
                arrimg = Image.FromFile(path);
                map_arrow[ii] = new Bitmap(arrimg);
                map_arrow[ii].MakeTransparent(Color.FromArgb(0, 255, 0));
            }
            
           

            //初始化箭数、分数
            hp = ARROWNUMBER;
            grade = 0;
            lab_HP.Text = hp.ToString();
            lab_HPMAX.Text = hp.ToString();            
            lab_grade.Text = grade.ToString();

            //画图
            G.DrawImageUnscaled(map_bg, new Point(0, 0));
            Init_goals();
            draw_goals();
            lab_stat.Text = "游戏开始";

            
        }

        private void Init_goals()
        {
            //初始化靶
            for (int i = 0; i < NUM_GOAL; i++)
            {
                height[i] = rd.Next(100, 300);
                rect_goal[i] = new Rectangle(380 + i * 100, height[i], GOAL_WIDTH, GOAL_HIGHT);
                IsHit[i] = false;
            }
        }

        //时间循环事件
        private void timer1_Tick(object sender, EventArgs e)
        {
            GameUpdate(G, arrow);
            GameDraw(G, arrow);
        }

        

        private void GameUpdate(Graphics G, myArrow arrow)
        {
            arrow.Pt.X += arrow.Vx;
            arrow.Vy += GRAVITY;
            arrow.Pt.Y += arrow.Vy;
            //生成箭头
            arw = new Rectangle(arrow.Pt.X, arrow.Pt.Y, 32, 32);
            //边缘检测
            if (arrow.Pt.X > WINDOW_WIDTH || arrow.Pt.Y > WINDOW_HEIGHT) ShootOff();
            //碰撞检测
            for (int i = 0; i < NUM_GOAL; i++)
            {
                if (!IsHit[i])
                {
                    if (CheckHit(rect_goal[i], arw))
                    {
                        grade += 1;
                        lab_grade.Text = grade.ToString();                        
                        IsHit[i] = true;
                    }
                }
            }
        }

        private void GameDraw(Graphics G, myArrow arrow)
        {
            G.DrawImage(map_bg, 0, 0);
            
            draw_goals();
            draw_arrow();
            
        }

        private void draw_arrow()
        {
            //G.DrawEllipse(pen,arw);
            int arr_index;            
            arr_index=(int)((arrow.Vy+50)/12);
            

            G.DrawImage(map_arrow[arr_index], arw);

        }
        private void draw_goals()
        {
            for (int i = 0; i < NUM_GOAL; i++)
            {
                if (IsHit[i]) G.DrawImage(map_goal1, rect_goal[i]);
                else G.DrawImage(map_goal0, rect_goal[i].Left, rect_goal[i].Top);
            }
        }

       

        private void ShootOff()
        {
            timer1.Enabled = false;
            btn.Enabled = true;

            //全射中检测
            foreach (bool tmp in IsHit)if (tmp == false) return;
            Init_goals();
            draw_goals();
            hp += 2;
            lab_HP.Text = hp.ToString();
        }

        private bool CheckHit(Rectangle rect1, Rectangle rect2)
        {
            bool result = false;
            if ((rect1.Right > rect2.Left) && (rect1.Left < rect2.Right))
            {
                if ((rect1.Bottom > rect2.Top) && (rect1.Top < rect2.Bottom))result = true;
            }
            return result;
        }



    }
}
