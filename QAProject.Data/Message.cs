using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAProject.Data
{
    public class Message
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public char Title { get; set; }
        public char Body { get; set; }
        public DateTime PostDate { get; set; }
    }
}
