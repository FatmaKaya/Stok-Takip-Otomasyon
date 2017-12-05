using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class FRMGiris : DevExpress.XtraEditors.XtraForm
    {
        public FRMGiris()
        {
            InitializeComponent();
        }

        private void Giriş_Click(object sender, EventArgs e)
        {
            MDI mdi = new MDI();
            this.Hide();
            mdi.Show();
        }
    }
}
