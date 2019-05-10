using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//should be imported

namespace 系统初步实现2_数据库.rooms
{
    public partial class Room1 : Form
    {
        public Room1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            refresh();//更新座位
            book.Click += Button1_Click;
            lookbutton.Click += Lookbutton_Click;//查看教室实景
            foreach(var v in seatsPanel.Controls)//使用seatsPanel限定范围
            {
                CheckBox cb = v as CheckBox;
                if (cb != null)
                {
                    cb.CheckedChanged += Cb_CheckedChanged;
                }
            }
        }

        private void Cb_CheckedChanged(object sender, EventArgs e)
        {

            CheckBox cb = sender as CheckBox;
            string starttime = "" + startDate.Text + " " + startTime.Text, endtime = "" + endDate.Text + " " + endTime.Text;//通过输入获得的预约结束时间
            if (starttime != " " && endtime != " ")
            {
                if (cb.Checked == true)
                {
                    SqlConnection con = new SqlConnection("server=.;database=zbb_try;user=sa;pwd=123");//创建数据库连接类的对象
                    con.Open();//将连接打开
                    SqlCommand cmd = con.CreateCommand();//执行con对象的函数，返回一个SqlCommand类型的对象
                    int seatno = 0;
                    switch (cb.Text)
                    {
                        case "checkBox1":
                            seatno = 1;
                            break;
                        case "checkBox2":
                            seatno = 2;
                            break;
                        case "checkBox3":
                            seatno = 3;
                            break;
                        case "checkBox4":
                            seatno = 4;
                            break;
                        case "checkBox5":
                            seatno = 5;
                            break;
                        case "checkBox6":
                            seatno = 6;
                            break;
                        case "checkBox7":
                            seatno = 7;
                            break;
                    }//switch
                    cmd.CommandText = "update bookseat set 是否正在使用='yes' where " + endtime + "<开始时间 and 房间号=1 and 座位号=" + seatno;//把输入的数据拼接成sql语句，并交给cmd对象
                                                                                                                                //if(cmd.ExecuteNonQuery()==0)//执行SQL语句//不满足条件，执行失败
                                                                                                                                //{
                    StringBuilder sb = new StringBuilder();
                    sb.Append("该座位");
                    cmd.CommandText = "select 开始时间 from bookseat where 房间号=1 and 座位号=" + seatno;
                    SqlDataReader dr = cmd.ExecuteReader();//用cmd的函数执行语句，返回SqlDataReader对象dr,dr就是返回的结果集（也就是数据库中查询到的表数据）
                    if (dr.Read())
                    {
                        sb.Append(dr[0].ToString());
                    }
                    sb.Append("时已被预定，请更换座位或时间！");
                    MessageBox.Show(sb.ToString());
                    con.Close();
                    /*foreach(var v in seatsPanel.Controls)
                    {
                        CheckBox c = v as CheckBox;
                        if(c.Text.Last()==1)
                    }*/

                    /*else//执行成功
                    {

                    }*/


                }//if
                else
                {
                    SqlConnection con = new SqlConnection("server=.;database=zbb_try;user=sa;pwd=123");//创建数据库连接类的对象
                    con.Open();//将连接打开
                    SqlCommand cmd = con.CreateCommand();//执行con对象的函数，返回一个SqlCommand类型的对象
                    int seatno = 0;
                    switch (cb.Text)
                    {
                        case "checkBox1":
                            seatno = 1;
                            break;
                        case "checkBox2":
                            seatno = 2;
                            break;
                        case "checkBox3":
                            seatno = 3;
                            break;
                        case "checkBox4":
                            seatno = 4;
                            break;
                        case "checkBox5":
                            seatno = 5;
                            break;
                        case "checkBox6":
                            seatno = 6;
                            break;
                        case "checkBox7":
                            seatno = 7;
                            break;
                    }//switch
                    cmd.CommandText = "update bookseat set 是否正在使用='no' and 开始时间=NULL and 结束时间=NULL and 队伍号=NULL where 房间号=1 and 座位号=" + seatno;//把输入的数据拼接成sql语句，并交给cmd对象
                    cmd.ExecuteNonQuery();//执行SQL语句
                    con.Close();
                    refresh();
                }//else
            }//if Text is inputed
            else
            {
                MessageBox.Show("请先输入预约时间信息。");
            }//if not input
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("确定后不可更改，确认预约吗？" ,"确认提示",MessageBoxButtons.YesNo);
            if(dg== DialogResult.Yes)//如果对话框的返回值是YES（按"Y"按钮）
            {
                this.Close();
                MessageBox.Show("预约成功！");
            }
            //MessageBox.Show("选中后无法进行更改，确定选择这些座位吗？");
            
            refresh();

        }//Button1_Click
        private void Lookbutton_Click(object sender, EventArgs e)//点击按钮后生成教室场景对话框
        {
            rooms.ShowRoom sr = new ShowRoom();
            sr.Show();
        }

        public void refresh()//连接数据库，将房间号为1的座位状态进行刷新
        {
            //如果已经预约的队伍的预约时间到期，则释放座位??
            SqlConnection con = new SqlConnection("server=.;database=zbb_try;user=sa;pwd=123");//创建数据库连接类的对象
            con.Open();//将连接打开
            SqlCommand cmd = con.CreateCommand();//执行con对象的函数，返回一个SqlCommand类型的对象
            //根据系统时间判断座位是否正在使用
            cmd.CommandText = "update bookseat set 是否正在使用 = 'yes' where SYSDATETIME() > 开始时间 and SYSDATETIME() < 结束时间";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update bookseat set 是否正在使用 = 'no' where SYSDATETIME() > 结束时间 or SYSDATETIME() < 开始时间";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select 座位号,是否正在使用 from bookseat where 房间号=1";//把输入的数据拼接成sql语句，并交给cmd对象
            SqlDataReader dr = cmd.ExecuteReader();//用cmd的函数执行语句，返回SqlDataReader对象dr,dr就是返回的结果集（也就是数据库中查询到的表数据）
            while (dr.Read())//用dr的read函数，每执行一次，返回一个包含下一行数据的集合dr，在执行read函数之前，dr并不是集合
            {
                if (dr[1].ToString() == "yes")
                {
                    switch (Convert.ToInt32(dr[0].ToString()))
                    {
                        case 1:
                            checkBox1.Checked = true;
                            checkBox1.Enabled = false;
                            break;
                        case 2:
                            checkBox2.Checked = true;
                            checkBox2.Enabled = false;
                            break;
                        case 3:
                            checkBox3.Checked = true;
                            checkBox3.Enabled = false;
                            break;
                        case 4:
                            checkBox4.Checked = true;
                            checkBox4.Enabled = false;
                            break;
                        case 5:
                            checkBox5.Checked = true;
                            checkBox5.Enabled = false;
                            break;
                        case 6:
                            checkBox6.Checked = true;
                            checkBox6.Enabled = false;
                            break;
                        case 7:
                            checkBox1.Checked = true;
                            checkBox1.Enabled = false;
                            break;
                    }
                }
            }
            con.Close();//用完后关闭连接，以免影响其他程序访问
        }

    }//Room1
}//namespace