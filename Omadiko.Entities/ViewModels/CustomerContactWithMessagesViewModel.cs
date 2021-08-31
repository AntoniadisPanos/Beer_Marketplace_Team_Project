using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities.ViewModels
{
  public  class CustomerContactWithMessagesViewModel
    {
        public Customer Customer { get; set; }

        public Message Message { get; set; }
    }
}
