using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace chepai001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();          
        }

        Random rand = new Random();

        double makeArriveTime()    //生成到达时间间隔
        {
            double arriveTime;
            do
            {
                double u = 0d;
                while (u == 0d)
                {
                    u = rand.NextDouble();
                }
                arriveTime = 10 * System.Math.Log(u * 10, System.Math.E);
            }
            while (arriveTime < 0);
            return arriveTime;
        }

        double makeServiceTime()    //生成服务时间间隔
        {
            double serviceTime;
            serviceTime = rand.Next(8, 10);
            return serviceTime;
        }

       
        public void makeArraylist()
        {
            double max = 0;
            ArrayList listArrive1= new ArrayList();
            ArrayList listArrive2 = new ArrayList();
            ArrayList listArrive3 = new ArrayList();
            ArrayList listSrvice1 = new ArrayList();
            ArrayList listSrvice2 = new ArrayList();
            ArrayList listSrvice3 = new ArrayList();
            while (max < 5000)                  //生成到达list
            {
                double add = makeArriveTime();
                max += add;
                listArrive.Add(add);
            }
            max = 0;
            while (max < 5000)                // 生成服务list
            {
                double add = makeServiceTime();
                max += add;
                listSrvice.Add(add);
            }
            //ArrayList b = listArrive;
            //label4.Text = b[10].ToString();
        }

       
        double plan1()
        {
            return 0;
        }
        double plan2()
        {
            return 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text=makeArriveTime().ToString();
            label2.Text = makeServiceTime().ToString();
            makeArraylist();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
