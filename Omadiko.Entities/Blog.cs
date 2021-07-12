using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities
{
   public class Blog
    {
        public int BlogId { get; set; }
        public string Article { get; set; }
        public int Comments { get; set; }

        //Navigation Properties

        public virtual Customer Customer { get; set; }
    }



}
