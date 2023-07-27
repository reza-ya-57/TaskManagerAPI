using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerAPI.Core.Common
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTime InsDate { get; set; }
    }
}
