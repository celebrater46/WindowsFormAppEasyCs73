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
        private Label label, label2;
        private Button button;
        private CheckBox cb1, cb2;
        private FlowLayoutPanel flp;

        public void Display()
        {
            Application.Run(new Form1());
        }
        
        public Form1()
        {
            InitializeComponent();
            this.Text = "Button Test Sample";
            this.Width = 250;
            this.Height = 250;

            label = new Label();
            label.Text = "Welcome.";
            label.Dock = DockStyle.Top;
            
            label2 = new Label();
            label2.Text = "Choose your vehicle.";
            label2.Dock = DockStyle.Top;
            label2.Width = 200;

            cb1 = new CheckBox();
            cb2 = new CheckBox();

            cb1.Text = "Car";
            cb2.Text = "Train";

            flp = new FlowLayoutPanel();
            flp.Dock = DockStyle.Bottom;
            flp.Parent = this;

            label2.Parent = flp;
            cb1.Parent = flp;
            cb2.Parent = flp;

            cb1.CheckedChanged += new EventHandler(CbCheckedChanged);
            cb2.CheckedChanged += new EventHandler(CbCheckedChanged);

            button = new Button();
            button.Text = "Buy";
            button.Dock = DockStyle.Top;

            button.Click += new EventHandler(ClickButton);

            button.Parent = this;
            label.Parent = this;
        }

        public void ClickButton(Object sender, EventArgs e)
        {
            label.Text = "Thank you for shopping.";
            button.Enabled = false;
        }

        public void CbCheckedChanged(Object sender, EventArgs e)
        {
            CheckBox temp = (CheckBox) sender;
            if (temp.Checked == true)
            {
                label2.Text = string.Format("Checked {0}.", temp.Text);
            }
            else if (temp.Checked == false)
            {
                label2.Text = string.Format("Canceled {0}.", temp.Text);
            }
        }
    }
}