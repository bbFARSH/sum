using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Donate : Form
    {
        public Donate()
        {
            InitializeComponent();
        }

        private void Donate_Load(object sender, EventArgs e)
        {
            label1.Text = "Данные сберкарты\n" +
                " 4200 **** **** ****.\n" +
                  "Тинкоф Банк\n " +
                  "1234 **** **** ****\n" +
                  "Если ты здесь, то значит\n" +
                  "ты добрый человек.:)";
        }
    }
}
