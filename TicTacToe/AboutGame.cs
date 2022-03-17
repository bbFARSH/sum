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
    public partial class AboutGame : Form
    {
        public AboutGame()
        {
            InitializeComponent();
        }

        private void AboutGame_Load(object sender, EventArgs e)
        {
            label1.Text = "Данная игра создана\n" +
                " в ходе обучения С#.\n" +
                  "Для отзывов и\n " +
                  "предложений писать\n" +
                  " нам не нужно";
        }
    }
}
