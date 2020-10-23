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
        void CreateMenu()
        {
            minitrv0001.Nodes.Clear();//清除所有節點
            //---
            //建立選單變數
            TreeNode trnMainMenu01 = new TreeNode(Language.m_StrMainMenu01, 0, 0);
            trnMainMenu01.Nodes.Add("", Language.m_StrSubMenu01_01, 1, 1);
            trnMainMenu01.Nodes.Add("", Language.m_StrSubMenu01_02, 1, 1);
            TreeNode trnMainMenu02 = new TreeNode(Language.m_StrMainMenu02, 0, 0);
            trnMainMenu02.Nodes.Add("", Language.m_StrSubMenu02_01, 1, 1);
            trnMainMenu02.Nodes.Add("", Language.m_StrSubMenu02_02, 1, 1);
            trnMainMenu02.Nodes.Add("", Language.m_StrSubMenu02_03, 1, 1);
            TreeNode trnMainMenu03 = new TreeNode(Language.m_StrMainMenu03, 0, 0);
            trnMainMenu03.Nodes.Add("", Language.m_StrSubMenu03_01, 1, 1);
            trnMainMenu03.Nodes.Add("", Language.m_StrSubMenu03_02, 1, 1);
            trnMainMenu03.Nodes.Add("", Language.m_StrSubMenu03_03, 1, 1);
            trnMainMenu03.Nodes.Add("", Language.m_StrSubMenu03_04, 1, 1);
            TreeNode trnMainMenu04 = new TreeNode(Language.m_StrMainMenu04, 0, 0);
            trnMainMenu04.Nodes.Add("", Language.m_StrSubMenu04_01, 1, 1);
            //---建立選單變數

            //---
            //新增選單
            minitrv0001.Nodes.Add(trnMainMenu01);
            minitrv0001.Nodes.Add(trnMainMenu02);
            minitrv0001.Nodes.Add(trnMainMenu03);
            minitrv0001.Nodes.Add(trnMainMenu04);
            //---新增選單

            minitrv0001.CollapseAll();//關閉所有節點
            //minitrv0001.ExpandAll();//打開所有節點

            minitrv0001.SelectedNode = minitrv0001.Nodes[3];//展開特定節點
            minitrv0001.SelectedNode.Expand();
        }
    }
}
