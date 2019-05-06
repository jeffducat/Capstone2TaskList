using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone2TaskList
{
    class Task
    {
        public List<string> members;

        
        public string date;
        public bool status;
        public string description;

        public Task()
        {
            members = new List<string>();
            status = false;
        }

      
        }
}
