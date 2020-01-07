using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResourseSystem
{
    class DataConnector
    {
        private string strDSN;
        OleDbConnection oledbCon;
        public void dataCon()
        {
            strDSN = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath.ToString() + "\\Resources/HR.accdb"; oledbCon = new OleDbConnection(strDSN);
        }
        public DataSet getDataset(string sql)
        {
            DataSet ds = new DataSet();
            oledbCon.Open();
            try
            {
                OleDbCommand oledbCom = new OleDbCommand(sql, oledbCon);
                OleDbDataAdapter oledbDa = new OleDbDataAdapter(oledbCom);
                oledbDa.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                oledbCon.Close();
            }
        }
        public bool sqlExec(string sql)
        {
            try
            {
                oledbCon.Open();
            }
            catch
            {
                MessageBox.Show("数据库未连接","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            try
            {
                OleDbCommand oledbCom = new OleDbCommand(sql, oledbCon);
                oledbCom.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return false;
            }
            finally
            {
                oledbCon.Close();
            }
        }
    }
}
