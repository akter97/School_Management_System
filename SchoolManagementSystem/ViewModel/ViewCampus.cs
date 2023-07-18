using SchoolManagementSystem.Models;
using System.Security.Policy;

namespace SchoolManagementSystem.ViewModel
{
    public class ViewCampus
    {
        public Guid CampusId { get; set; }
        public string CampusName { get; set; }
        public long BranchId { get; set; }
        public string Location { get; set; }
        public string BranchName { get; set; }
        public string BranchLocation { get; set; }

        public long[] ShiftId { get; set; }
        public string[] ShiftName { get; set; }
        public string[] ShiftTyp { get; set; }
        public string[] StarTime { get; set; }
        public string[] EndTime { get; set; }
        public List<ViewShift> Shifts { get; set; } = new List<ViewShift>();
        public class ViewShift
        {
            public long ShiftId { get; set; }
            public string ShiftName { get; set; }
            public string ShiftType { get; set; }
            public string StarTime { get; set; }
            public string EndTime { get; set; }
        }

        public long[] CurriculumId { get; set; }
        public string[] CurriculumName { get; set; }
        public List<ViewCurriculum> Curriculums { get; set; } = new List<ViewCurriculum>();
        public class ViewCurriculum
        {
            public long CurriculumId { get; set; }
            public string CurriculumName { get; set; }
        }
    }
}
