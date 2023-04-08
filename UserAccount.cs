namespace ATMDemo
{
    class UserAccount : User
    {


        //注册账号
        public int Reg(string account, string key, string cfm, string id, string isfrozen)
        {
            sqlStr = "select AC from account where AC ='" + account + "'";
            int n = todata.DataSelect(sqlStr, "Account");
            if (n == 0 && key == cfm)
            {
                sqlStr = "insert into account(AC,PW,ID,DP,IsFrozen) values ('"
                    + account + "','" + key + "','" + id + "','" + 0 + "','" + isfrozen + "')";
                todata.DataIUD(sqlStr);
            }
            return n;
        }

        //验证密码
        public int Judge(string account, string key)
        {
            if (CheckInfo(account))
            {
                if (isfroze == "yes")
                    return 0;//账号冻结
                else if (key == Key)
                    return 1;//账号密码匹配
                else
                    return 2;//密码错误
            }
            else
                return 3;//未读取到账号信息

        }

        //修改密码
        public bool Change(string account, string oldkey, string newkey)
        {
            if (CheckInfo(account) && oldkey == Key)
            {
                sqlStr = "update Account set PW ='" + newkey + "' where AC = " + account;
                todata.DataIUD(sqlStr);
                issuccess = true;
            }
            return issuccess;
        }

        //查找密码
        public string Findkey(string account, string id)
        {

            if (CheckInfo(account))
            {
                if (id == ID)
                {
                    return Key;
                }
                if (ID != id)
                {
                    return "IDerror";
                }
            }
            return "";
        }

        //注销账户
        public bool Cancellation(string account, string id)
        {
            if (CheckInfo(account) && id == ID)
            {
                sqlStr = "delete from Account where AC = " + account;
                todata.DataIUD(sqlStr);
                issuccess = true;
            }
            return issuccess;
        }

        //冻结账户
        public bool Frozen(string account)
        {
            if (CheckInfo(account))
            {
                sqlStr = "update Account set IsFrozen='" + "yes" + "'where AC=" + account;
                todata.DataIUD(sqlStr);
                issuccess = true;
            }
            return issuccess;
        }
        
        
        //解冻账户
        public int Unfreeze(string account ,string id)
        {
            if (CheckInfo(account))
            {
                if (id == ID)
                {
                    sqlStr = "update Account set IsFrozen='" + "no" + "'where AC=" + account;
                    todata.DataIUD(sqlStr);
                    return 0;//账号ID都正确
                }
                if (ID != id)
                {
                    return 1;//ID错误
                }
            }
            return 2;//未读取账号信息
        }



    }
}
