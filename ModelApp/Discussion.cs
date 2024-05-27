using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelApp
{
    public class Discussion
    {
        public int Id { get; set; }
        public required string user { get; set; }
        public required string message { get; set; }
        public required DateTime createdOn { get; set; }

    }
}
