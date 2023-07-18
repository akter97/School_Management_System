using SchoolManagementSystem.Models;
using System.Security.Policy;

namespace SchoolManagementSystem.ViewModel
{
    public class ViewCampusInsert
    {
        public Guid CampusId { get; set; }
        public string CampusName { get; set; }
        public long BranchId { get; set; }
        public string Location { get; set; }
        public string BranchName { get; set; }
        public string BranchLocation { get; set; }
        public Branch Branches { get; set; }
        public class ViewBranch
        {
            public long BranchId { get; set; }
            public string BranchName { get; set; }
            public string BranchLocation { get; set; }
        }

        public long[] ShiftId { get; set; }
        public List<ViewShift> Shifts { get; set; } = new List<ViewShift>();
        public class ViewShift
        {
            public long ShiftId { get; set; }
        }

        public long[] CurriculumId { get; set; }
        public List<ViewCurriculum> Curriculums { get; set; } = new List<ViewCurriculum>();
        public class ViewCurriculum
        {
            public long CurriculumId { get; set; }
        }
    }
}
