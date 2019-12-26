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
        private void button1_Click(object sender, EventArgs e)
        {
            string strSql = "INSERT INTO Preferences ('P_Key' , 'P_Value' ,'P_Username') VALUES ( 'Opacity' , '"+txt_Opacity.Text+"' , '"+frm_Login.username+"') ON DUPLICATE KEY UPDATE Preferences SET P_Value = '"+txt_Opacity.Text+"' WHERE P_Key = 'Opacity' AND P_Username = '"+frm_Login.username+"'";
            DataConnector data = new DataConnector();
            DataSet ds;
            ds = data.getDataset(strSql);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_Preferences_Load(object sender, EventArgs e)
        {
            string strSql = "SELECT * FROM Preferences WHERE P_Username="+frm_Login.username+"' ";
            DataConnector data = new DataConnector();
            DataSet ds;
            ds = data.getDataset(strSql);
            txt_Opacity.Text = ds.Tables[0].Rows[0][1].ToString();
        }
    }
}
