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
    public partial class frm_Preferences : Form
    {
        public frm_Preferences()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btn_Apply.Enabled = true;
        }

        private void frm_Preferences_Load(object sender, EventArgs e)
        {

            //获取当前用户设定的透明度
            string strSql = "SELECT   P_Value FROM(SELECT   P_Key, P_Value, P_Username FROM Preferences WHERE(P_Username = '"+frm_Login.username+"')) derivedtbl_1 WHERE(P_Key = 'form_opacity')";
            DataConnector data = new DataConnector();
            DataSet ds;
            data.dataCon();
            ds = data.getDataset(strSql);
            txt_Opacity.Text = ds.Tables[0].Rows[0][0].ToString();
            tkb_Opacity.Value = Convert.ToInt32(txt_Opacity.Text);

            btn_Apply.Enabled = false;
        }
        public void changed()
        {
            btn_Apply.Enabled = true;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            btn_Apply_Click(sender, e);
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            string strSql = "UPDATE Preferences SET P_Value = '" + txt_Opacity.Text + "' WHERE P_Key = 'form_opacity' AND P_Username = '" + frm_Login.username + "'";
            DataConnector data = new DataConnector();
            DataSet ds;
            data.dataCon();
            ds = data.getDataset(strSql);
            btn_Apply.Enabled = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txt_Opacity.Text = tkb_Opacity.Value.ToString();
        }

        private void chk_statusBar_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
