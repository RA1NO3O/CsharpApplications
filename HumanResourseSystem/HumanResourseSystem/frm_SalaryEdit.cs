using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResourseSystem
{
    public partial class frm_SalaryEdit : Form
    {
        public frm_SalaryEdit()
        {
            InitializeComponent();
        }

        private void btn_Execute_Click(object sender, EventArgs e)
        {

        }

        private void frm_SalaryEdit_Load(object sender, EventArgs e)
        {
            txt_ID.Text = frm_SalaryMgmt.Id;
            txt_BS.Text = frm_SalaryMgmt.Bs;
            txt_tax.Text = frm_SalaryMgmt.Tax;
            txt_ES.Text = frm_SalaryMgmt.Es;

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            frm_SalaryEdit_Load(sender, e);
        }
    }
}
