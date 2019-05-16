using ppedv.FlyingPluto.Logic;
using ppedv.FlyingPluto.Model;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ppedv.FlyingPluto.UI.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = new Core().Repository.Query<Auto>().ToList();

        }
    }
}
