using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Presenter
{
    public partial class Intelectix : MaterialForm
    {

        public Intelectix()
        {
            InitializeComponent();
            DoubleBuffered = true;

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue900, Primary.Blue900, Primary.Blue900, Accent.Pink400, TextShade.WHITE
            );
        }

        private void Search_tenant_KeyUp(object sender, KeyEventArgs e)
        {
            this.label2.Text = this.search_tenant.Text;
        }

        private void Intelectix_Load(object sender, EventArgs e)
        {
            string user = "Fernando";
            this.label4.Text = $"Bienvenido, {user}.";
        }
    }
}
