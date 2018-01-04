using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int choose { get; set; }
        Random ra = new Random();

        private void fenye()
        {
            int p;//总页数
            int d;//页内地址

            if(yemiandaxiao.Text=="")
                yemiandaxiao.Text = Math.Pow(2, ra.Next(0,10)).ToString();//生成2的幂次方页面大小
           
            #region 页表为空，随机生成
            if (yebiao1.Text == "")
                yebiao1.Text = ra.Next(0, 999).ToString();
            if (yebiao2.Text == "")
                yebiao2.Text = ra.Next(0, 999).ToString();
            if (yebiao3.Text == "")
                yebiao3.Text = ra.Next(0, 999).ToString();
            if (yebiao4.Text == "")
                yebiao4.Text = ra.Next(0, 999).ToString();
            #endregion

            p = int.Parse(luojidizhi.Text) / int.Parse(yemiandaxiao.Text);//求出总页数  
            d = int.Parse(luojidizhi.Text) % int.Parse(yemiandaxiao.Text);//求出该页大小  

            if (p >= 4)
                Result.Text = "页号大于页表长度,越界中断";
            switch (p)
            {
                case 0: Result.Text = string.Format("页号：{0} 页内地址：{1} 物理地址：{2}",p, d, int.Parse(yebiao1.Text) * 1024 + d);
                    break;
                case 1: Result.Text = string.Format("页号：{0} 页内地址：{1} 物理地址：{2}", p, d, int.Parse(yebiao2.Text) * 1024 + d);
                    break;
                case 2: Result.Text = string.Format("页号：{0} 页内地址：{1} 物理地址：{2}", p, d, int.Parse(yebiao3.Text) * 1024 + d);
                    break;
                case 3: Result.Text = string.Format("页号：{0} 页内地址：{1} 物理地址：{2}", p, d, int.Parse(yebiao4.Text) * 1024 + d);
                    break;
            }
        }

        private void duanshi()
        {
            int dh=int.Parse(duanhao.Text);//段号
            int dz = int.Parse(duanneidizhi.Text);//段内地址

            #region 始址为空，随机生成
            if (shizhi1.Text == "")
                shizhi1.Text = ra.Next(0, 999).ToString();
            if (shizhi2.Text == "")
                shizhi2.Text = ra.Next(0, 999).ToString();
            if (shizhi3.Text == "")
                shizhi3.Text = ra.Next(0, 999).ToString();
            if (shizhi4.Text == "")
                shizhi4.Text = ra.Next(0, 999).ToString();
            #endregion

            #region 长度为空，随机生成
            if (changdu1.Text == "")
                changdu1.Text = ra.Next(0, 999).ToString();
            if (changdu2.Text == "")
                changdu2.Text = ra.Next(0, 999).ToString();
            if (changdu3.Text == "")
                changdu3.Text = ra.Next(0, 999).ToString();
            if (changdu4.Text == "")
                changdu4.Text = ra.Next(0, 999).ToString();
            #endregion

            if (dh > 4)
                Result.Text = "段号大于段表长度4,越界中断";
            switch (dh)
            {
                case 0: if (dz > int.Parse(changdu1.Text))
                        Result.Text = "段内地址大于段长度,越界中断";
                    else
                        Result.Text = (int.Parse(shizhi1.Text) + dz).ToString();
                    break;
                case 1: if (dz > int.Parse(changdu2.Text))
                        Result.Text = "段内地址大于段长度,越界中断";
                    else
                        Result.Text = (int.Parse(shizhi2.Text) + dz).ToString();
                    break;
                case 2: if (dz > int.Parse(changdu3.Text))
                        Result.Text = "段内地址大于段长度,越界中断";
                    else
                        Result.Text = (int.Parse(shizhi3.Text) + dz).ToString();
                    break;
                case 3: if (dz > int.Parse(changdu4.Text))
                        Result.Text = "段内地址大于段长度,越界中断";
                    else
                        Result.Text = (int.Parse(shizhi4.Text) + dz).ToString();
                    break;
            }
            
        }

        private void duanyeshi()
        {
            int dh = int.Parse(duanhao1.Text);//段号
            int lz = int.Parse(luojidizhi1.Text); //逻辑地址

            int ph=lz/1024;//页号
            int pd=lz%1024;//页内地址

            #region 随机生成段始址
            if (diyiduanshizhi.Text == "")
                diyiduanshizhi.Text = ra.Next(0, 999).ToString();
            if (dierduanshizhi.Text == "")
                dierduanshizhi.Text = ra.Next(0, 999).ToString();
            if (disanduanshizhi.Text == "")
                disanduanshizhi.Text = ra.Next(0, 999).ToString();
            #endregion

            #region 随机生成页面地址
            #region 第一段
            if (diyiduan1.Text == "")
                diyiduan1.Text = ra.Next(0, 999).ToString();
            if (diyiduan2.Text == "")
                diyiduan2.Text = ra.Next(0, 999).ToString();
            if (diyiduan3.Text == "")
                diyiduan3.Text = ra.Next(0, 999).ToString();
            if (diyiduan4.Text == "")
                diyiduan4.Text = ra.Next(0, 999).ToString();
            #endregion
            #region 第二段
            if (dierduan1.Text == "")
                dierduan1.Text = ra.Next(0, 999).ToString();
            if (dierduan2.Text == "")
                dierduan2.Text = ra.Next(0, 999).ToString();
            if (dierduan3.Text == "")
                dierduan3.Text = ra.Next(0, 999).ToString();
            if (dierduan4.Text == "")
                dierduan4.Text = ra.Next(0, 999).ToString();
            #endregion
            #region 第三段
            if (disanduan1.Text == "")
                disanduan1.Text = ra.Next(0, 999).ToString();
            if (disanduan2.Text == "")
                disanduan2.Text = ra.Next(0, 999).ToString();
            if (disanduan3.Text == "")
                disanduan3.Text = ra.Next(0, 999).ToString();
            if (disanduan4.Text == "")
                disanduan4.Text = ra.Next(0, 999).ToString();
            #endregion
            #endregion

            if (dh>2) 
                Result.Text ="段号大于段表长度3,越界中断";
	        else if(ph>=4)
		        Result.Text ="页号大于页表长度4,越界中断";
	        else
		    {
                switch (dh)
                {
                    case 0:
                        diyiduan(ph,pd);
                        break;
                    case 1:
                        dierduan(ph, pd);
                        break;
                    case 2:
                        disanduan(ph, pd);
                        break;
                }
		    }
        }

        private void diyiduan(int ph,int pd)
        {
            int shizhi=int.Parse(diyiduanshizhi.Text);
            switch (ph)
            {
                case 1:
                    Result.Text = (shizhi + int.Parse(diyiduan1.Text) + pd).ToString();//计算物理地址的公式=(段号始址+页号始址+页内地址)
                    break;
                case 2:
                    Result.Text = (shizhi + int.Parse(diyiduan2.Text) + pd).ToString();//计算物理地址的公式=(段号始址+页号始址+页内地址)
                    break;
                case 3:
                    Result.Text = (shizhi + int.Parse(diyiduan3.Text) + pd).ToString();//计算物理地址的公式=(段号始址+页号始址+页内地址)
                    break;
                case 4:
                    Result.Text = (shizhi + int.Parse(diyiduan4.Text) + pd).ToString();//计算物理地址的公式=(段号始址+页号始址+页内地址)
                    break;
            }
        }

        private void dierduan(int ph, int pd)
        {
            int shizhi = int.Parse(dierduanshizhi.Text);
            switch (ph)
            {
                case 1:
                    Result.Text = (shizhi + int.Parse(dierduan1.Text) + pd).ToString();//计算物理地址的公式=(段号始址+页号始址+页内地址)
                    break;
                case 2:
                    Result.Text = (shizhi + int.Parse(dierduan2.Text) + pd).ToString();//计算物理地址的公式=(段号始址+页号始址+页内地址)
                    break;
                case 3:
                    Result.Text = (shizhi + int.Parse(dierduan3.Text) + pd).ToString();//计算物理地址的公式=(段号始址+页号始址+页内地址)
                    break;
                case 4:
                    Result.Text = (shizhi + int.Parse(dierduan4.Text) + pd).ToString();//计算物理地址的公式=(段号始址+页号始址+页内地址)
                    break;
            }
        }

        private void disanduan(int ph, int pd)
        {
            int shizhi = int.Parse(disanduanshizhi.Text);
            switch (ph)
            {
                case 1:
                    Result.Text = (shizhi + int.Parse(disanduan1.Text) + pd).ToString();//计算物理地址的公式=(段号始址+页号始址+页内地址)
                    break;
                case 2:
                    Result.Text = (shizhi + int.Parse(disanduan2.Text) + pd).ToString();//计算物理地址的公式=(段号始址+页号始址+页内地址)
                    break;
                case 3:
                    Result.Text = (shizhi + int.Parse(disanduan3.Text) + pd).ToString();//计算物理地址的公式=(段号始址+页号始址+页内地址)
                    break;
                case 4:
                    Result.Text = (shizhi + int.Parse(disanduan4.Text) + pd).ToString();//计算物理地址的公式=(段号始址+页号始址+页内地址)
                    break;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if(choose==1)
                fenye();
            if (choose == 2)
                duanshi();
            if (choose == 3)
                duanyeshi();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            choose = 1;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            choose = 2;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            choose = 3;
        }

        


    }
}
