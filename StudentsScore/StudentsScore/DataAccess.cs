using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;


namespace StudentsScore
{
    class DataAccess
    {
        private string strDSN;
        OleDbConnection oledbCon;
        public void dataCon()
        {
            strDSN = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath.ToString() + "\\Student.accdb";     oledbCon = new OleDbConnection(strDSN);
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
                MessageBox.Show("数据库未连接");
            }

            try
            {
                OleDbCommand oledbCom = new OleDbCommand(sql, oledbCon);
                oledbCom.ExecuteNonQuery();
                return true;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "提示");
                return false;
            }
            finally
            {
                oledbCon.Close();
            }
        }
    }
}
