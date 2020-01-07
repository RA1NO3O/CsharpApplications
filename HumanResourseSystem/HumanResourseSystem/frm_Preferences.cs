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
        public static frm_Preferences frm_P;
        public int qa_state = 1;
        public int wstate = 1;
        public frm_Preferences()
        {
            InitializeComponent();
            frm_P = this;
        }

        private void frm_Preferences_Load(object sender, EventArgs e)
        {
            //获取当前用户设定的透明度
            string strSql = "SELECT   P_Value FROM(SELECT   P_Key, P_Value, P_Username FROM Preferences WHERE(P_Username = '"+frm_Login.username+"')) derivedtbl_1 WHERE(P_Key = 'form_opacity')";
           ;
            try {
                txt_Opacity.Text = doSQL(strSql).Tables[0].Rows[0][0].ToString();
                tkb_Opacity.Value = Convert.ToInt32(txt_Opacity.Text);
            }catch(Exception ex)
            {
                Error_PropertyValue(ex.Message);
            }
            

            //查询当前用户设定的"快速添加按钮"属性.
            strSql = "SELECT P_Value FROM(SELECT P_Key , P_Value , P_Username FROM Preferences WHERE(P_Username = '" + frm_Login.username + "')) WHERE(P_Key='btn_QuickAdd')";
            switch (doSQL(strSql).Tables[0].Rows[0][0].ToString())
            {
                case "include":
                    radioButton1.Checked = true;
                    break;
                case "float":
                    radioButton2.Checked = true;
                    break;
                case "hide":
                    radioButton3.Checked = true;
                    break;
                default:
                    Error_PropertyValue("从数据库中读取的属性异常!");
                    break;
            }
            
            //查询当前用户设定的"窗体初始状态"属性.
            strSql = "SELECT P_Value FROM(SELECT P_Key , P_Value , P_Username FROM Preferences WHERE(P_Username = '" + frm_Login.username + "')) WHERE(P_Key='form_state')";
            switch (doSQL(strSql).Tables[0].Rows[0][0].ToString())
            {
                case "normal":
                    radioButton4.Checked = true;
                    break;
                case "maximized":
                    radioButton5.Checked = true;
                    break;
                case "minimized":
                    radioButton6.Checked = true;
                    break;
                default:
                    Error_PropertyValue("从数据库中读取的属性异常!");
                    break;
            }

            //查询当前用户设定的"窗体状态栏"属性.
            strSql = "SELECT P_Value FROM(SELECT P_Key , P_Value , P_Username FROM Preferences WHERE(P_Username = '" + frm_Login.username + "')) WHERE(P_Key='form_statusbar')";
            if (doSQL(strSql).Tables[0].Rows[0][0].ToString().Equals("show"))
            {
                chk_statusBar.Checked = true;
            }else if (doSQL(strSql).Tables[0].Rows[0][0].ToString().Equals("hide"))
            {
                chk_statusBar.Checked = false;
            }
            else
            {
                Error_PropertyValue("从数据库中读取的属性异常!");
            }


            btn_Apply.Enabled = false;
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
        {   //应用更改
            string strSql = "UPDATE Preferences SET P_Value = '" + txt_Opacity.Text + "' WHERE P_Key = 'form_opacity' AND P_Username = '" + frm_Login.username + "'";
            DataConnector data = new DataConnector();
            DataSet ds;
            data.dataCon();
            ds = data.getDataset(strSql);

            if (chk_statusBar.Checked) { strSql= "UPDATE Preferences SET P_Value = 'show' WHERE P_Key = 'form_statusbar' AND P_Username = '" + frm_Login.username + "'"; } else { strSql= "UPDATE Preferences SET P_Value = 'hide' WHERE P_Key = 'form_statusbar' AND P_Username = '" + frm_Login.username + "'"; }
            ds = data.getDataset(strSql);

            switch (qa_state)   //处理此处的变量
            {
                case 1:
                    strSql = "UPDATE Preferences SET P_Value = 'include' WHERE P_KEY= 'btn_QuickAdd' AND P_Username = '" + frm_Login.username + "'";
                    break;
                case 2:
                    strSql = "UPDATE Preferences SET P_Value = 'float' WHERE P_KEY= 'btn_QuickAdd' AND P_Username = '" + frm_Login.username + "'";
                    break;
                case 3:
                    strSql = "UPDATE Preferences SET P_Value = 'hide' WHERE P_KEY= 'btn_QuickAdd' AND P_Username = '" + frm_Login.username + "'";
                    break;
            }
            ds = data.getDataset(strSql);
            frm_Main.ActiveForm.Refresh();

            switch (wstate)
            {
                case 1:
                    strSql = "UPDATE Preferences SET P_Value = 'normal' WHERE P_KEY='form_state' AND P_Username = '" + frm_Login.username + "'";
                    break;
                case 2:
                    strSql = "UPDATE Preferences SET P_Value = 'maximized' WHERE P_KEY='form_state' AND P_Username = '" + frm_Login.username + "'";
                    break;
                case 3:
                    strSql = "UPDATE Preferences SET P_Value = 'minimized' WHERE P_KEY='form_state' AND P_Username = '" + frm_Login.username + "'";
                    break;
            }
            ds = data.getDataset(strSql);

            btn_Apply.Enabled = false;
            frm_Main.frm_M.form_Refresh();
            //调用方法调整按钮状态
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txt_Opacity.Text = tkb_Opacity.Value.ToString();
        }

        private void Property_Changed(object sender, EventArgs e)
        {
            btn_Apply.Enabled = true;
        }
        public DataSet doSQL(string strSql)
        {
            DataConnector data = new DataConnector();
            DataSet ds;
            data.dataCon();
            return ds = data.getDataset(strSql);
        }
        private void Error_PropertyValue(string context)
        {
            MessageBox.Show(context+"\r\n请单击确定按钮,以重新写入正确的属性!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void rdo_qastate_Changed(object sender, EventArgs e)
        {
            if (sender.Equals(radioButton1)) { qa_state = 1; }
            if (sender.Equals(radioButton2)) { qa_state = 2; }
            if (sender.Equals(radioButton3)) { qa_state = 3; }
            Property_Changed(sender,e);
        }
    }
}
