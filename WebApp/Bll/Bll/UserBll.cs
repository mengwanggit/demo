using Bll.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bll.Bll
{
    public class UserBll : IUser
    {
        public string GetName(int id)
        {
            return "son";
        }
    }
}
