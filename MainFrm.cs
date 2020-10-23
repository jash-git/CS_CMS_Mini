using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Lib;

namespace SYRIS_Mini
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            Language.initVar();
            CreateMenu();
        }

        private void minitrv0001_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)//工作選單事件
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                minitrv0001.SelectedNode = e.Node;
                //判斷點選在第幾層 
                //第二層 
                if (e.Node.Level == 1)
                {
                    MessageBox.Show(minitrv0001.SelectedNode.Text + "->(" + e.Node.Parent.Index + "," + e.Node.Index + ")");
                }
            }
        }
    }
}
