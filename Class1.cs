using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace ATMDemo
{
    internal class Class1
    {
        static void ReadSQL()
        {
            string connectStr = "server=localhost;database=user;user=root;password=root;";
            //并没有建立数据库连接
            MySqlConnection conn = new MySqlConnection(connectStr);
            try
            {
                conn.Open();    //建立连接，打开数据库
                Console.WriteLine("打开数据库成功");

                string sqlstr = "select * from test";   //SQL语句
                MySqlCommand cmd = new MySqlCommand(sqlstr, conn);
                /* cmd.ExecuteReader();     //执行一些查询
                   cmd.ExecuteScalar();     //执行一些查询，返回一个单个的值
                   cmd.ExecuteNonQuery();   //插入删除   */

                //相当于数据读出流  理解为一本书
                MySqlDataReader reader = cmd.ExecuteReader();
                //reader.Read();  //读取下一页数据 ，读取成功，返回true，下一页没有数据则返回false表示到了最后一页

                while (reader.Read())   //遍历表中数据
                {
                    //读取并打印数据
                    reader.Read();
                    //索引是一行有几个数据
                    Console.WriteLine(reader[0].ToString() + reader[1].ToString() + reader[2].ToString() + reader[3].ToString());
                    //还可以使用Getxxx方式去写 参数（索引）
                    Console.WriteLine(reader.GetInt32(0) + reader.GetString(1) + reader.GetString(2));
                    //Getxxx方法的重载  参数(列名)
                    Console.WriteLine(reader.GetInt32("id") + reader.GetString("name") + reader.GetString("age"));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();   //关闭连接
            }
        }

        static void InsertSQL()
        {
            string connectStr = "server=localhost;database=user;user=root;password=12345678;";
            //并没有建立数据库连接
            MySqlConnection conn = new MySqlConnection(connectStr);
            try
            {   //建立连接，打开数据库
                conn.Open();
                //注意一条SQL语句不要一条语句执行两次，会因为已存在而报错
                string sqlstr = "insert into test(username,F1) values('22','ChenChen')";   //SQL语句
                MySqlCommand cmd = new MySqlCommand(sqlstr, conn);

                int result = cmd.ExecuteNonQuery();   //返回值为执行后数据库中受影响的数据行数
                Console.WriteLine("执行成功，影响了{0}行数据", result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();   //关闭连接
            }
        }
        static void UpdateSQL()
        {
            string connectStr = "server=localhost;port=3306;database=czhenya01;user=root;password=123456;";
            //并没有建立数据库连接
            MySqlConnection conn = new MySqlConnection(connectStr);
            try
            {   //建立连接，打开数据库
                conn.Open();
                //注意一条SQL语句不要一条语句执行两次，会因为已存在而报错
                string sqlstr = "update czhenya001 set Id ='2001',Name = 'FaFa' where Id = '1001' ";   //SQL语句
                MySqlCommand cmd = new MySqlCommand(sqlstr, conn);

                int result = cmd.ExecuteNonQuery();   //返回值为执行后数据库中受影响的数据行数
                Console.WriteLine("执行成功，影响了{0}行数据", result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();   //关闭连接
            }
        }

        static void DeleteSQL()
        {
            string connectStr = "server=localhost;database=user;user=root;password=root;";
            //并没有建立数据库连接
            MySqlConnection conn = new MySqlConnection(connectStr);
            try
            {   //建立连接，打开数据库
                conn.Open();
                //注意一条SQL语句不要一条语句执行两次，会因为已存在而报错
                string sqlstr = "Delete from czhenya001 where Id = '1002' ";   //SQL语句
                MySqlCommand cmd = new MySqlCommand(sqlstr, conn);

                int result = cmd.ExecuteNonQuery();   //返回值为执行后数据库中受影响的数据行数
                Console.WriteLine("执行成功，影响了{0}行数据", result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();   //关闭连接
            }
        }

    }
}
