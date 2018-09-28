using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Email
    {
        public string RecAddress { get; set; }
        public string Subject { get; set; }
        public string Prefix { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }

        public object ToList()
        {
            throw new NotImplementedException();
        }
    }

    public class Provider
    {
        public int Port { get; set; }
        public string Host { get; set; }
        public string PWD { get; set; }
        public string User { get; set; }
    }
}
