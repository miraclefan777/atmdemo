using System;
using System.Collections.Generic;
using System.Text;

namespace ATMDemo
{
    class DepositException : Exception
    {
        private string _message;
        public DepositException()
        {
            _message = base.Message;
        }
        public DepositException(string strMessage)
        {
            _message = strMessage;
        }
        public override string Message
        {
            get
            {
                return _message;
            }
        }
    }
}
