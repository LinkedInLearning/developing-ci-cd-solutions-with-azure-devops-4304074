using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using llcicdapp.Models;

namespace llcicdapp.Repos
{
    public interface IAssessmentRepo
    {
        List<AssessmentViewModel> GetAssessments();
    }
}
