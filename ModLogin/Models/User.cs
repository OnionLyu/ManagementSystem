using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModLogin.Models
{
    public class User
    {
        private int _id;
        private int _designationId;
        private string _username;
        private string _password;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int DesignationId
        {
            get { return _designationId; }
            set { _designationId = value; }
        }
        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}
