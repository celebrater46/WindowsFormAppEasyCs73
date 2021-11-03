using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEasyCs73
{
    public partial class Form1 : Form
    {
        private Label label;
        private Button button;

        public void Display()
        {
            Application.Run(new Form1());
        }
        
        public Form1()
        {
            InitializeComponent();
            this.Text = "Button Test Sample";
            this.Width = 250;
            this.Height = 100;

            label = new Label();
            label.Text("Welcome.");
            label.Dock = DockStyle.Top;

            button = new Button();
            button.Text = "Buy";
            button.Dock = DockStyle.Bottom;

            button.Click += new EventHandler(ClickButton);

            label.Parent = this;
            button.Parent = this;
        }

        public void ClickButton(Object sender, EventArgs e)
        {
            label.Text("Thank you for shopping.");
            button.Enabled = false;
        }
    }
}