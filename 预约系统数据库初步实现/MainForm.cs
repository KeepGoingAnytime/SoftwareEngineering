using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 系统初步实现2_数据库.rooms;

namespace 系统初步实现2_数据库
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //rooms.Login login = new Login();
            //login.Show();
            rooms.Toolist toolist = new Toolist();
            toolist.Show();
        }
    }
}
