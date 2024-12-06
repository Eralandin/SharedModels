using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class Role
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long MenuItemId { get; set; }
        public bool AllowRead { get; set; }
        public bool AllowWrite { get; set; }
        public bool AllowEdit { get; set; }
        public bool AllowDelete { get; set; }
    }
}
