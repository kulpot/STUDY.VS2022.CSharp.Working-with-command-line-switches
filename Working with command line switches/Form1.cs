using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//ref link:https://www.youtube.com/watch?v=DeR8kjNOfKY&list=PLAIBPfq19p2EJ6JY0f5DyQfybwBGVglcR&index=63


namespace Working_with_command_line_switches
{
    public partial class Form1 : Form
    {
        public Form1(string[] args)
        {
            InitializeComponent();
            ProcessArguments(args);
        }

        private void ProcessArguments(string[] args)
        {
            foreach(string argument in args)
            {
                if(argument.ToLower() == "-minimize")//else if(argument.ToLower() == "-time:00")
                {
                    this.WindowState = FormWindowState.Minimized;
                }
                else if(argument.ToLower() == "-safemode") // common switch
                {
                    button1.Hide();
                }
                else if(argument.ToLower() == "") // -noaddons   -similar to safemode , for startup internet explorer with no addons
                {
                    MessageBox.Show("Empty cmd line arg!");
                }
            }
        }
    }
}
