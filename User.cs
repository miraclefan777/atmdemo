namespace ATMDemo
{
    class User
    {
        protected ToData todata = new ToData();
        protected static string sqlStr;
        protected static string Account;
        protected static string Key;
        protected static string ID;
        protected static string isfroze;
        protected static float deposit;
        protected bool issuccess = false;

        //核对账号并读取信息
        public bool CheckInfo(string account)
        {
            bool istrue = false;
            sqlStr = "select * from Account";
            todata.DataRead(sqlStr);
            while (todata.dr.Read())
            {
                Account = todata.dr["AC"].ToString().Trim();
                Key = todata.dr["PW"].ToString().Trim();
                deposit = float.Parse(todata.dr["DP"].ToString().Trim());
                ID = todata.dr["ID"].ToString().Trim();
                isfroze = todata.dr["IsFrozen"].ToString().Trim();
                if (account == Account)
                {
                    istrue = true;
                    break;
                }
            }
            todata.CloseConnection();
            return istrue;
        }

    }
}
