using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void p100_Click(object sender, EventArgs e)
        {
            //charge.Text = Convert.ToString(Convert.ToInt32(charge.Text) + 100);
            status.Clear();
            int temp = Convert.ToInt16(charge.Text);
            temp += 100;
            charge.Text = Convert.ToString(temp);
            if (temp>=600)
            {
                sprite.Enabled = true;
                status.Text += sprite.Text + " 을/를 뽑을 수 있습니다.\n";
            }
            if (temp >= 700)
            {
                pocari.Enabled = true;
                status.Text += pocari.Text + " 을/를 뽑을 수 있습니다.\n";
            }
            if (temp >= 800)
            {
                coca.Enabled = true;
                status.Text += coca.Text + " 을/를 뽑을 수 있습니다.\n";
            }
            if (temp >= 900)
            {
                tropi.Enabled = true;
                status.Text += tropi.Text + " 을/를 뽑을 수 있습니다.\n";
            }
            if (temp >= 1000)
            {
                letsbe.Enabled = true;
                status.Text += letsbe.Text + " 을/를 뽑을 수 있습니다.\n";
            }
        }

        private void p500_Click(object sender, EventArgs e)
        {
            status.Clear();
            int temp = Convert.ToInt16(charge.Text);
            temp += 500;
            charge.Text = Convert.ToString(temp);
            if (temp >= 600)
            {
                sprite.Enabled = true;
                status.Text += sprite.Text + " 을/를 뽑을 수 있습니다.\n";
            }
            if (temp >= 700)
            {
                pocari.Enabled = true;
                status.Text += pocari.Text + " 을/를 뽑을 수 있습니다.\n";
            }
            if (temp >= 800)
            {
                coca.Enabled = true;
                status.Text += coca.Text + " 을/를 뽑을 수 있습니다.\n";
            }
            if (temp >= 900)
            {
                tropi.Enabled = true;
                status.Text += tropi.Text + " 을/를 뽑을 수 있습니다.\n";
            }
            if (temp >= 1000)
            {
                letsbe.Enabled = true;
                status.Text += letsbe.Text + " 을/를 뽑을 수 있습니다.\n";
            }
        }

        private void p1000_Click(object sender, EventArgs e)
        {
            status.Clear();
            int temp = Convert.ToInt16(charge.Text);
            temp += 1000;
            charge.Text = Convert.ToString(temp);
            if (temp >= 600)
            {
                sprite.Enabled = true;
                status.Text += sprite.Text + " 을/를 뽑을 수 있습니다.\n";
            }
            if (temp >= 700)
            {
                pocari.Enabled = true;
                status.Text += pocari.Text + " 을/를 뽑을 수 있습니다.\n";
            }
            if (temp >= 800)
            {
                coca.Enabled = true;
                status.Text += coca.Text + " 을/를 뽑을 수 있습니다.\n";
            }
            if (temp >= 900)
            {
                tropi.Enabled = true;
                status.Text += tropi.Text + " 을/를 뽑을 수 있습니다.\n";
            }
            if (temp >= 1000)
            {
                letsbe.Enabled = true;
                status.Text += letsbe.Text + " 을/를 뽑을 수 있습니다.\n";
            }
        }

        private void status_TextChanged(object sender, EventArgs e)
        {

        }

        private void sprite_Click(object sender, EventArgs e)
        {
            status.Clear();
            int temp = Convert.ToInt16(charge.Text);
            temp -= 600;
            charge.Text = Convert.ToString(temp);
            status.Text += sprite.Text + " 나왔습니다. 받아가세요.\n";
            if (temp < 600)
            {
                sprite.Enabled = false;
            }
            if (temp < 700)
            {
                pocari.Enabled = false;
            }
            if (temp < 800)
            {
                coca.Enabled = false;
            }
            if (temp < 900)
            {
                tropi.Enabled = false;
            }
            if (temp < 1000)
            {
                letsbe.Enabled = false;
            }
        }

        private void pocari_Click(object sender, EventArgs e)
        {
            status.Clear();
            int temp = Convert.ToInt16(charge.Text);
            temp -= 700;
            charge.Text = Convert.ToString(temp);
            status.Text += pocari.Text + " 나왔습니다. 받아가세요.\n";
            if (temp < 600)
            {
                sprite.Enabled = false;
            }
            if (temp < 700)
            {
                pocari.Enabled = false;
            }
            if (temp < 800)
            {
                coca.Enabled = false;
            }
            if (temp < 900)
            {
                tropi.Enabled = false;
            }
            if (temp < 1000)
            {
                letsbe.Enabled = false;
            }
        }

        private void coca_Click(object sender, EventArgs e)
        {
            status.Clear();
            int temp = Convert.ToInt16(charge.Text);
            temp -= 800;
            charge.Text = Convert.ToString(temp);
            status.Text += coca.Text + " 나왔습니다. 받아가세요.\n";
            if (temp < 600)
            {
                sprite.Enabled = false;
            }
            if (temp < 700)
            {
                pocari.Enabled = false;
            }
            if (temp < 800)
            {
                coca.Enabled = false;
            }
            if (temp < 900)
            {
                tropi.Enabled = false;
            }
            if (temp < 1000)
            {
                letsbe.Enabled = false;
            }
        }

        private void tropi_Click(object sender, EventArgs e)
        {
            status.Clear();
            int temp = Convert.ToInt16(charge.Text);
            temp -= 900;
            charge.Text = Convert.ToString(temp);
            status.Text += tropi.Text + " 나왔습니다. 받아가세요.\n";
            if (temp < 600)
            {
                sprite.Enabled = false;
            }
            if (temp < 700)
            {
                pocari.Enabled = false;
            }
            if (temp < 800)
            {
                coca.Enabled = false;
            }
            if (temp < 900)
            {
                tropi.Enabled = false;
            }
            if (temp < 1000)
            {
                letsbe.Enabled = false;
            }
        }

        private void letsbe_Click(object sender, EventArgs e)
        {
            status.Clear();
            int temp = Convert.ToInt16(charge.Text);
            temp -= 1000;
            charge.Text = Convert.ToString(temp);
            status.Text += letsbe.Text + " 나왔습니다. 받아가세요.\n";
            if (temp < 600)
            {
                sprite.Enabled = false;
            }
            if (temp < 700)
            {
                pocari.Enabled = false;
            }
            if (temp < 800)
            {
                coca.Enabled = false;
            }
            if (temp < 900)
            {
                tropi.Enabled = false;
            }
            if (temp < 1000)
            {
                letsbe.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            status.Text += "이용해주셔서 감사합니다. 안녕히 가세요.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            charge.Text = "0";
            status.Text += "잔돈이 모두 반환되었습니다.";
        }
    }
}
