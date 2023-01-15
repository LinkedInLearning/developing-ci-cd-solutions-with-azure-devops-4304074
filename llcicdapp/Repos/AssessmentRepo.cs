using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using llcicdapp.Models;

namespace llcicdapp.Repos
{
    public class AssessmentRepo : IAssessmentRepo
    {
        public List<AssessmentViewModel> GetAssessments()
        {
            var assessments = new List<AssessmentViewModel>
            {
                new AssessmentViewModel(){ StudentId =20229391, Name = "Rex Timothy", Level =300, Course = "CIS313", Score=89 },
                new AssessmentViewModel(){ StudentId =20227791, Name = "John Doe", Level =300, Course = "CIS313", Score=94 },
                new AssessmentViewModel(){ StudentId =20226891, Name = "Mary Jane", Level =300, Course = "CIS313", Score=94 },
                new AssessmentViewModel(){ StudentId =20229677, Name = "Fred Bill", Level =300, Course = "CIS313", Score=86 },
                new AssessmentViewModel(){ StudentId =20223422, Name = "Cynthia Jack", Level =300, Course = "CIS313", Score=90 },
            };
            return assessments;
        }
    }
}
