using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;

namespace api.Helper
{
    public class CommentQueryObject
    {
        public string Symbol { get; set; }
        public bool IsDescending { get; set; }
    }
}