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
    public partial class Toolist : Form
    {
        public Toolist()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            toolStripComboBox2.SelectedIndexChanged += ToolStripComboBox1_SelectedIndexChanged;
            toolStripMenuItem1.Click += ToolStripMenuItem1_Click;


        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.;database=zbb_try;user=sa;pwd=123");//创建数据库连接类的对象
            con.Open();//将连接打开
            SqlCommand cmd = con.CreateCommand();//执行con对象的函数，返回一个SqlCommand类型的对象
            cmd.CommandText = "select 房间号,座位号 from bookseat where 队伍号=2";//把输入的数据拼接成sql语句，并交给cmd对象
            StringBuilder sb = new StringBuilder();
            SqlDataReader dr = cmd.ExecuteReader();//用cmd的函数执行语句，返回SqlDataReader对象dr,dr就是返回的结果集（也就是数据库中查询到的表数据）
            sb.Append("房间号：");
            if (dr.Read())
                sb.Append(dr[1].ToString() + "\n座位号：\n");
            while (dr.Read())
            {
                sb.AppendLine(dr[1].ToString());
            }
            MessageBox.Show(sb.ToString());
            con.Close();
        }

        private void ToolStripMenuItem2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ToolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (toolStripComboBox2.SelectedIndex)
            {
                case 0://comboBox的标号是从0开始的
                    
                    break;
                case 1:
                    break;
                case 2:
                    rooms.Room1 r1 = new rooms.Room1();
                    r1.Show();  //显示Room1的座位分布图
                    break;

            }

        }
    }
}
