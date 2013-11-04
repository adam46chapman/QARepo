using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace QAProject.Data
{
    class MessageContext : DbContext
    {
        public DbSet<Message> Message {get; set;}       
    }
}
