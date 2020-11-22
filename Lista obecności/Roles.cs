using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista_obecności
{
    public class Roles
    {
        string _Admin = "admin";
        string _User = "user";
        string _Guest = "guest";

        public string Admin { get { return _Admin; } }
        public string User { get { return _User; } }
        public string Guest { get { return _Guest; } }
    }
}
