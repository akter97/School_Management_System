using SchoolManagementSystem.Models;
using System.Security.Policy;

namespace SchoolManagementSystem.ViewModel
{
    public class ViewTeacher
    {
        public long TeacherId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Photo { get; set; } 

        public string? Gender { get; set; }
        public string? MaritalStatus { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Nid { get; set; }
        public string? Religion { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Nationality { get; set; }
        public string? Qualification { get; set; }
        public string? Salary { get; set; }


        //public long[]? designationid { get; set; }
        //public string[]? designationname { get; set; }

        //public list<viewdesignation> viewdesignations { get; set; } = new list<viewdesignation>;
        //public class viewdesignation
        //{
        //    public long designationid { get; set; }
        //    public string? designationname { get; set; }
        //}


        //public long[]? teacherdesignationid { get; set; } 

        //public list<viewdesignation> viewdesignations { get; set; } = new list<viewdesignation>;
        //public class viewdesignation
        //{
        //    public long designationid { get; set; }
        //    public string? designationname { get; set; }
        //}

    }
}
