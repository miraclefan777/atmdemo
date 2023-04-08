namespace ATMDemo
{

    class UserDeposit : User
    {

        //查询余额
        public float Query(string account)
        {
            CheckInfo(account);
            return deposit;
        }


        //存款
        public bool Save(string account, float amount)
        {
            if (CheckInfo(account))
            {
                deposit += amount;
                sqlStr = "update Account set DP ='" + deposit + "' where AC = " + account;
                todata.DataIUD(sqlStr);
                issuccess = true;
            }
            return issuccess;
        }

        //取款
        public bool Withdraw(string account, float amount)
        {

            if (CheckInfo(account))
            {
                deposit -= amount;
                if (deposit >= 0)
                {
                    issuccess = true;
                    sqlStr = "update Account set DP ='" + deposit + "' where AC = " + account;
                    todata.DataIUD(sqlStr);
                }
            }
            return issuccess;
        }


        //转账
        public int Transfer(string account, string to_account, float amount)
        {
            if (CheckInfo(to_account))
            {
                CheckInfo(account);//判断account信息是否正确，又因为结合方向从左向右，可以省略再次 CheckInfo(account)

                deposit -= amount;
                if (deposit >= 0)
                {
                    sqlStr = "update Account set DP='" + deposit + "'where AC =" + account;
                    todata.DataIUD(sqlStr);

                    //对收钱方进行操作
                    CheckInfo(to_account);
                    deposit -= amount;
                    sqlStr = "update Account set DP='" + deposit + "'where AC =" + to_account;
                    todata.DataIUD(sqlStr);
                    return 0;
                }
                else
                    return 1;

            }
            else
                return 2;

        }
    }
}

