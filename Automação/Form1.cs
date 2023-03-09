using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automação
{

    List<Commands> commands = new List<Commands>();

    private bool start_mapeamento = false;

    public int stepe = 1;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMapear_Click(object sender, EventArgs e)
        {
            start_mapeamento = true;
            btnMapear.Visible = true;
            btnParar.Visible = true;
            new Thread(new ThreadStart(Mapear)).Start();
        }

        private void Mapear()
        {
            while (start_mapeamento)
            {
                int x = MousePosition.X;
                int y = MousePosition.Y;

                this.Invoke(delegate
                {
                    this.label1.Text = "X:" + x.ToString();
                    this.label2.Text = "Y:" + y.ToString();
                });
            }
        }
    }
}
