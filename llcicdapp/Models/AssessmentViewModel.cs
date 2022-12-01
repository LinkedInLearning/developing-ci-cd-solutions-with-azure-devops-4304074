using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace llcicdapp.Models
{
    public partial class AssessmentViewModel
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public string Course { get; set; }
        public int Score { get; set; }
    }
}
