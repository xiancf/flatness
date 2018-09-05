using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Params
{
  public  class UserParams
    {
        private string adminPwd = "1";
        private string engineerPwd = "1";
        private string productPwd = "1";
        public string 管理员密码
        {
            get { return adminPwd; }
            set { adminPwd = value; }
        }
        public string 工程师密码
        {
            get { return engineerPwd; }
            set { engineerPwd = value; }
        }
        public string 操作员密码
        {
            get { return productPwd; }
            set { productPwd = value; }
        }
    }
}
