using System.Data;
using MySql.Data.MySqlClient;

namespace ATMDemo
{
    class ToData
    {
        private static string tosql = "server=localhost;database=atmdemo;user=root;password=12345678;";
        private static MySqlConnection cnn;
        private MySqlCommand cmd;
        public  MySqlDataReader dr;
        private static MySqlDataAdapter da;
     


        //连接数据库
        public void OpenConnection()
        {
            cnn = new MySqlConnection(tosql);
            cnn.Open();
        }

        //关闭数据库连接
        public void CloseConnection()
        {
            cnn.Close();
        }

        //数据读取
        public void DataRead(string sqlStr)
        {
            OpenConnection();
            cmd = new MySqlCommand(sqlStr, cnn);
            dr = cmd.ExecuteReader();
        }

        //数据查询
        public int DataSelect(string sqlStr, string dt)
        {
            OpenConnection();
            cmd = new MySqlCommand(sqlStr, cnn);
            da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            int n = da.Fill(ds, dt);
            CloseConnection();
            return n;

        }
        //数据插入、更新、删除
        public void DataIUD(string sqlStr)
        {
            OpenConnection();
            cmd = new MySqlCommand(sqlStr, cnn);
            cmd.ExecuteNonQuery();
        }

    }
}
