using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.ViewCategory;
using SchoolManagementSystem.ViewModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace SchoolManagementSystem.Controllers
{
    public class SchoolController : Controller
    {
        public SchoolDbContext db = new SchoolDbContext();

        #region Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string UserName, string Password) 
        {
            if (UserName == "Akter" && Password == "Akter")
                return RedirectToAction("Teacher", "School");
            return View();
        }
        #endregion

        #region Teacher Section
        //[HttpGet]
        //public IActionResult Teacher()
        //{
        //    return View();
        //}

        //[HttpGet]
        //public IActionResult TeacherList()
        //{
        //    return View();
        //}


        //[HttpGet]
        //public IActionResult Teacher(int? id)
        //{

        //    ViewTeacher OVT = null;
        //    var ovt = db.Teachers.Where(x => x.TeacherId == id).FirstOrDefault();
        //    if (ovt != null)
        //    {
        //        OVT = new ViewTeacher();
        //        OVT.TeacherId = ovt.TeacherId;
        //        OVT.FirstName = ovt.FirstName;
        //        OVT.LastName = ovt.LastName;
        //        OVT.Email = ovt.Email;
        //        OVT.Phone = ovt.Phone;
        //        OVT.Gender = ovt.Gender;
        //        OVT.MaritalStatus = ovt.MaritalStatus;
        //        OVT.DateOfBirth = ovt.DateOfBirth;
        //        OVT.Nid = ovt.Nid;
        //        OVT.Religion = ovt.Religion;
        //        OVT.Nationality = ovt.Nationality;
        //        OVT.Qualification = ovt.Qualification;
        //        OVT.Salary = ovt.Salary;
        //    }
        //    ViewData["List"] = db.Teachers.ToList(); 
        //    return View(OVT);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Teacher(ViewTeacher viewTeacher)
        //{
        //    var OTeacher = db.Teachers.Find(viewTeacher.TeacherId);
        //    if (OTeacher == null)
        //    {
        //        OTeacher = new Teacher(); 
        //        OTeacher.FirstName = viewTeacher.FirstName;
        //        OTeacher.LastName = viewTeacher.LastName;
        //        OTeacher.Email = viewTeacher.Email;
        //        OTeacher.Phone = viewTeacher.Phone;
        //        OTeacher.Photo = viewTeacher.Photo;
        //        OTeacher.Gender = viewTeacher.Gender;
        //        OTeacher.MaritalStatus = viewTeacher.MaritalStatus;
        //        OTeacher.DateOfBirth = viewTeacher.DateOfBirth;
        //        OTeacher.Nid = viewTeacher.Nid;
        //        OTeacher.Religion = viewTeacher.Religion;
        //        OTeacher.Nationality = viewTeacher.Nationality;
        //        OTeacher.Qualification = viewTeacher.Qualification;
        //        OTeacher.Salary = viewTeacher.Salary; 
        //        db.Teachers.Add(OTeacher);
        //        ViewBag.Message = "Teacher Inserted Successfully";
        //    }
        //    else
        //    {
        //        OTeacher.FirstName = viewTeacher.FirstName;
        //        OTeacher.LastName = viewTeacher.LastName;
        //        OTeacher.Email = viewTeacher.Email;
        //        OTeacher.Phone = viewTeacher.Phone;
        //        OTeacher.Photo = viewTeacher.Photo;
        //        OTeacher.Gender = viewTeacher.Gender;
        //        OTeacher.MaritalStatus = viewTeacher.MaritalStatus;
        //        OTeacher.DateOfBirth = viewTeacher.DateOfBirth;
        //        OTeacher.Nid = viewTeacher.Nid;
        //        OTeacher.Religion = viewTeacher.Religion;
        //        OTeacher.Nationality = viewTeacher.Nationality;
        //        OTeacher.Qualification = viewTeacher.Qualification;
        //        OTeacher.Salary = viewTeacher.Salary;
        //        ViewBag.Message = "Teacher Update Successfully"; 
        //    }
        //    db.SaveChanges();
        //    return View("TeacherList");

        //}


        #endregion

        #region Teacher
        [HttpGet]
        public IActionResult Teacher() // Teacher View
        {
            ViewData["List"] = db.Teachers.ToList();
            return View(db.Teachers.ToList());
        }

        [HttpGet]
        public IActionResult TeacherDetails(ViewTeacher TDS) //  Details View or Edit View
        {
            var OTeacher = db.Teachers.Find(TDS.TeacherId);
           var viewTeacher = new ViewTeacher();
            if (OTeacher != null)
            {
                viewTeacher.TeacherId = OTeacher.TeacherId;
                viewTeacher.FirstName = OTeacher.FirstName;
                viewTeacher.LastName = OTeacher.LastName;
                viewTeacher.Email = OTeacher.Email;
                viewTeacher.Phone = OTeacher.Phone;
                viewTeacher.Photo = OTeacher.Photo;
                viewTeacher.Gender = OTeacher.Gender;
                viewTeacher.MaritalStatus = OTeacher.MaritalStatus;
                viewTeacher.DateOfBirth = OTeacher.DateOfBirth;
                viewTeacher.Nid = OTeacher.Nid;
                viewTeacher.Religion = OTeacher.Religion;
                viewTeacher.Nationality = OTeacher.Nationality;
                viewTeacher.Qualification = OTeacher.Qualification;
                viewTeacher.Salary = OTeacher.Salary;
                ViewData["List"] = db.Teachers.ToList();
                db.Teachers.Add(OTeacher);


            }
                else if (OTeacher == null)
                {
                     
                    return View("TeacherDetails");
                }
            db.SaveChanges();
                return View("Teacher");
            }
        [HttpGet]
        public IActionResult TeacherInsert() // submission Form View
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult TeacherEdit(ViewTeacher viewTeacher) //  Update Action
        {
          var  OTeacher = new Teacher();
            OTeacher.TeacherId = viewTeacher.TeacherId;
            OTeacher.FirstName = viewTeacher.FirstName;
            OTeacher.LastName = viewTeacher.LastName;
            OTeacher.Email = viewTeacher.Email;
            OTeacher.Phone = viewTeacher.Phone;
            OTeacher.Photo = viewTeacher.Photo; 
            OTeacher.Gender = viewTeacher.Gender;
            OTeacher.MaritalStatus = viewTeacher.MaritalStatus;
            OTeacher.DateOfBirth = viewTeacher.DateOfBirth;
            OTeacher.Nid = viewTeacher.Nid;
            OTeacher.Religion = viewTeacher.Religion;
            OTeacher.Nationality = viewTeacher.Nationality;
            OTeacher.Qualification = viewTeacher.Qualification;
            OTeacher.Salary = viewTeacher.Salary;
            db.Teachers.Add(OTeacher);
             
            
            db.SaveChanges();
            return RedirectToAction("Teacher");
        }
       


        [HttpGet]
        public IActionResult DeleteTeacher(long id) // Delete Teacher Remove Action
        { 
            var T = db.Teachers.Where(m => m.TeacherId == id).ToList();
            if (T.Any())
            {
                db.Teachers.RemoveRange(T);
                db.SaveChanges();
            }
             
            return RedirectToAction("Teacher");
        }
 

        [HttpPost]
        public IActionResult TeacherInsert(ViewTeacher OTeacher) //   Submission Action
        {
            var viewTeacher = new Teacher();  
            viewTeacher.TeacherId = OTeacher.TeacherId;
            viewTeacher.FirstName = OTeacher.FirstName;
            viewTeacher.LastName = OTeacher.LastName;
            viewTeacher.Email = OTeacher.Email;
            viewTeacher.Phone = OTeacher.Phone;
            viewTeacher.Photo = OTeacher.Photo;
            viewTeacher.Gender = OTeacher.Gender;
            viewTeacher.MaritalStatus = OTeacher.MaritalStatus;
            viewTeacher.DateOfBirth = OTeacher.DateOfBirth;
            viewTeacher.Nid = OTeacher.Nid;
            viewTeacher.Religion = OTeacher.Religion;
            viewTeacher.Nationality = OTeacher.Nationality;
            viewTeacher.Qualification = OTeacher.Qualification;
            viewTeacher.Salary = OTeacher.Salary;
            db.Teachers.Add(viewTeacher); 
            db.SaveChanges();
             
            db.SaveChanges();
            return RedirectToAction("Teacher");
        }




        //teacher class routine
        public SchoolDbContext _context = new SchoolDbContext();
        // GET: TeacherClassRoutine
        [HttpGet]
        public async Task<IActionResult> TeacherClassRoutinesIndex()
        {
            var schoolDbContext = _context.TeacherClassRoutines.Include(t => t.ClassRoutine).Include(t => t.Teacher);
            return View(await  schoolDbContext.ToListAsync());
        }

        // GET: TeacherClassRoutine/Details/5
        [HttpGet]
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.TeacherClassRoutines == null)
            {
                return NotFound();
            }

            var teacherClassRoutine = await _context.TeacherClassRoutines
                .Include(t => t.ClassRoutine)
                .Include(t => t.Teacher)
                .FirstOrDefaultAsync(m => m.TeacherClassRoutineId == id);
            if (teacherClassRoutine == null)
            {
                return NotFound();
            }

            return View("/TeacherClassRoutines/Details");
        }

        // GET: TeacherClassRoutine/Create
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["ClassRoutineId"] = new SelectList(_context.ClassRoutines, "ClassRoutineId", "ClassRoutineId");
            ViewData["TeacherId"] = new SelectList(_context.Teachers, "TeacherId", "TeacherId");
            return View("/TeacherClassRoutines/Create");
        }

        // POST: TeacherClassRoutine/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TeacherClassRoutineId,ClassRoutineId,TeacherId")] TeacherClassRoutine teacherClassRoutine)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teacherClassRoutine);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClassRoutineId"] = new SelectList(_context.ClassRoutines, "ClassRoutineId", "ClassRoutineId", teacherClassRoutine.ClassRoutineId);
            ViewData["TeacherId"] = new SelectList(_context.Teachers, "TeacherId", "TeacherId", teacherClassRoutine.TeacherId);
            return View("/TeacherClassRoutines/Index");
        }

        // GET: TeacherClassRoutine/Edit/5
        [HttpGet]
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.TeacherClassRoutines == null)
            {
                return NotFound();
            }

            var teacherClassRoutine = await _context.TeacherClassRoutines.FindAsync(id);
            if (teacherClassRoutine == null)
            {
                return NotFound();
            }
            ViewData["ClassRoutineId"] = new SelectList(_context.ClassRoutines, "ClassRoutineId", "ClassRoutineId", teacherClassRoutine.ClassRoutineId);
            ViewData["TeacherId"] = new SelectList(_context.Teachers, "TeacherId", "TeacherId", teacherClassRoutine.TeacherId);
            return View("/TeacherClassRoutines/Index");

        }

        // POST: TeacherClassRoutine/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("TeacherClassRoutineId,ClassRoutineId,TeacherId")] TeacherClassRoutine teacherClassRoutine)
        {
            if (id != teacherClassRoutine.TeacherClassRoutineId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teacherClassRoutine);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeacherClassRoutineExists(teacherClassRoutine.TeacherClassRoutineId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClassRoutineId"] = new SelectList(_context.ClassRoutines, "ClassRoutineId", "ClassRoutineId", teacherClassRoutine.ClassRoutineId);
            ViewData["TeacherId"] = new SelectList(_context.Teachers, "TeacherId", "TeacherId", teacherClassRoutine.TeacherId);
            return View(teacherClassRoutine);
        }

        // GET: TeacherClassRoutine/Delete/5
        [HttpGet]
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.TeacherClassRoutines == null)
            {
                return NotFound();
            }

            var teacherClassRoutine = await _context.TeacherClassRoutines
                .Include(t => t.ClassRoutine)
                .Include(t => t.Teacher)
                .FirstOrDefaultAsync(m => m.TeacherClassRoutineId == id);
            if (teacherClassRoutine == null)
            {
                return NotFound();
            }

            return View("/TeacherClassRoutines/Index");
           
        }

        // POST: TeacherClassRoutine/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.TeacherClassRoutines == null)
            {
                return Problem("Entity set 'SchoolDbContext.TeacherClassRoutines'  is null.");
            }
            var teacherClassRoutine = await _context.TeacherClassRoutines.FindAsync(id);
            if (teacherClassRoutine != null)
            {
                _context.TeacherClassRoutines.Remove(teacherClassRoutine);
            }

            await _context.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));
            return RedirectToAction("/TeacherClassRoutines/Index");

        }
        [HttpGet]
        private bool TeacherClassRoutineExists(long id)
        {
            return (_context.TeacherClassRoutines?.Any(e => e.TeacherClassRoutineId == id)).GetValueOrDefault();
        }
    

    #endregion
    #region Staff
    [HttpGet]
        public IActionResult Staff()
        {
            return View();
        }

        [HttpGet]
        public IActionResult StuffList()
        {
            return View();
        }
        [HttpGet]
        public IActionResult StuffSalary ()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SalaryRecord()
        {
            return View();
        }

        #endregion

        #region Student
        [HttpGet]
        public IActionResult Student()
        {
            return View();
        }

        [HttpGet]
        public IActionResult StudentList()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GuardianRecord()
        {
            return View();
        }
        #endregion

        #region StudentPromote
        [HttpGet]
        public IActionResult StudentPromote()
        {
            return View();
        }       

        [HttpGet]
        public IActionResult PromoteList()
        {
            return View();
        }
        #endregion

        #region StudentPayment
        [HttpGet]
        public IActionResult StudentPayment()
        {
            return View();
        }

        [HttpGet]
        public IActionResult PaymentList()
        {
            return View();
        }
        #endregion

        #region StudentAttendance
        [HttpGet]
        public IActionResult StudentAttendance()
        {
            return View();
        }
        public IActionResult AttendanceList()
        {
            return View();
        }
        #endregion

        #region Session
        [HttpGet]
        public IActionResult Session()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SessionProgrameSettings()
        {
            return View();
        }
        #endregion

        #region Subject
        [HttpGet]
        public IActionResult Subject()
        {
            return View();
        }

        #endregion

        #region Class
        [HttpGet]
        public IActionResult Class()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ClassSubject()
        {
            return View();
        }

        #endregion

        #region Branch

        [HttpGet]
        public IActionResult Branch()
        {
            var b = db.Branches.ToList();
            return View(b);
        }
        [HttpGet]
        public IActionResult BranchInsert()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BranchInsert(Branch b)
        {
            db.Branches.Add(b);
            db.SaveChanges();
            return RedirectToAction("Branch");
        }
        #endregion

        #region Building
        [HttpGet]
        public IActionResult Buiding()
        {
            ViewData["Campus"] = db.Campuses.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Buiding(ViewCampus model)
        {    
            return RedirectToAction("Building");
        }
        #endregion

        #region Shift
        [HttpGet]
        public IActionResult Shift()
        {
            return View(db.Shifts.ToList());
        }
        [HttpGet]
        public IActionResult ShiftInsert()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ShiftInsert(Shift s)
        {
            db.Shifts.Add(s);
            db.SaveChanges();
            return RedirectToAction("Shift");
        }
        #endregion

        #region Campus
        [HttpGet]
        public IActionResult Campus() // Campus View
        {
            return View(db.Campuses.ToList());
        }
        [HttpGet]
        public IActionResult CampusDetails(ActionCategory ac) // Campus Details View or Edit View
        {
            var c = db.Campuses.Find(ac.Id);
            var campus = new ViewCampus();
            if (c != null)
            {
                campus.CampusId = c.CampusId;
                campus.BranchId = (long)c.BranchId;
                campus.CampusName = c.CampusName;
                campus.Location = c.Location;


                var b = db.Branches.Find(campus.BranchId);
                campus.BranchId = b.BranchId;
                campus.BranchName = b.BranchName;
                campus.BranchLocation = b.BranchLocation;


                var s = db.CampusShifts.Where(x => x.CampusId == campus.CampusId).ToList();
                var shlist = new List<ViewCampus.ViewShift>();
                foreach (var list in s)
                {
                    var s2 = db.Shifts.Where(x=>x.ShiftId == list.ShiftId).ToList();
                    foreach(var item in  s2)
                    {
                        var sh = new ViewCampus.ViewShift();
                        sh.ShiftId = item.ShiftId;
                        sh.ShiftType = item.ShiftType;
                        sh.ShiftName = item.ShiftName;
                        sh.StarTime = item.StartTime;
                        sh.EndTime = item.EndTime;
                        shlist.Add(sh);
                    }
                }


                campus.Shifts = shlist;
                var Cr = db.CampusCurricula.Where(x => x.CampusId == campus.CampusId).ToList();
                var crList = new List<ViewCampus.ViewCurriculum>();
                foreach (var list in Cr)
                {
                    var crFind = db.Curricula.Where(x => x.CurriculumId == list.CurriculumId).ToList();
                    foreach (var item in crFind)
                    {
                        var cr1 = new ViewCampus.ViewCurriculum();
                        cr1.CurriculumId = item.CurriculumId;
                        cr1.CurriculumName = item.CurriculumName;
                        crList.Add(cr1);
                    }
                }


                campus.Curriculums = crList;
            }
            if (ac.ActionName == "Update")
            {
                ViewData["Branch"] = db.Branches.ToList();
                ViewData["Shift"] = db.Shifts.ToList();
                ViewData["Curriculum"] = db.Curricula.ToList();
                return View("CampusEdit", campus);
            }
            return View(campus);
        }

        [HttpGet]
        public IActionResult CampusInsert() // Campus submission Form View
        {
            ViewData["Branch"] = db.Branches.ToList();
            ViewData["Shift"] = db.Shifts.ToList();
            ViewData["Curriculum"] = db.Curricula.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult CampusUpdate(ViewCampusInsert model) // Campus Update Action
        {
            var c = new Campus();
            var cslist = new List<CampusShift>();
            c.CampusId = model.CampusId;
            c.BranchId = model.BranchId;
            c.CampusName = model.CampusName;
            c.Location = model.Location;
            db.Entry(c).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var csr = db.CampusShifts.Where(x=>x.CampusId == c.CampusId).ToList();
            db.CampusShifts.RemoveRange(csr);
            db.SaveChanges();
            for (int i = 0; i < model.ShiftId.Length; i++)
            {
                var cs = new CampusShift();
                cs.ShiftId = model.ShiftId[i];
                cs.CampusId = c.CampusId;
                cslist.Add(cs);
            }
            db.CampusShifts.AddRange(cslist);
            db.SaveChanges();
            var ccr = db.CampusCurricula.Where(x => x.CampusId == c.CampusId).ToList();
            db.RemoveRange(ccr);
            db.SaveChanges();
            var ccList = new List<CampusCurriculum>();
            for (int i = 0; i < model.CurriculumId.Length; i++)
            {
                var cc = new CampusCurriculum();
                cc.CurriculumId = model.CurriculumId[i];
                cc.CampusId = c.CampusId;
                ccList.Add(cc);
            }
            db.CampusCurricula.AddRange(ccList);
            db.SaveChanges();
            return RedirectToAction("Campus");
        }

        [HttpGet]
        public IActionResult DeleteCampus(Guid id) // Campus Remove Action
        {
            var cs = db.CampusShifts.Where(m => m.CampusId == id).ToList();
            var cc = db.CampusCurricula.Where(m => m.CampusId == id).ToList();
            var c = db.Campuses.Where(m => m.CampusId == id).ToList();
            if (cc.Any())
            {
                db.CampusCurricula.RemoveRange(cc);
                db.CampusShifts.RemoveRange(cs);
                db.Campuses.RemoveRange(c);
                db.SaveChanges();
            }
            return RedirectToAction("Campus");
        }

        [HttpPost]
        public IActionResult CampusInsert(ViewCampusInsert model) // Campus Submission Action
        {
            var c = new Campus();
            var cslist = new List<CampusShift>();
            c.CampusId = Guid.NewGuid();
            c.BranchId = model.BranchId;
            c.CampusName = model.CampusName;
            c.Location = model.Location;
            db.Campuses.Add(c);
            db.SaveChanges();
            for (int i = 0; i < model.ShiftId.Length; i++)
            {
                var cs = new CampusShift();
                cs.ShiftId = model.ShiftId[i];
                cs.CampusId = c.CampusId;
                cslist.Add(cs);
            }
            db.CampusShifts.AddRange(cslist);
            var ccList = new List<CampusCurriculum>();
            for (int i = 0; i < model.CurriculumId.Length; i++)
            {
                var cc = new CampusCurriculum();
                cc.CurriculumId = model.CurriculumId[i];
                cc.CampusId = c.CampusId;
                ccList.Add(cc);
            }
            db.CampusCurricula.AddRange(ccList);
            db.SaveChanges();
            return RedirectToAction("Campus");
        }
        #endregion

        #region Curriculum
        [HttpGet]
        public IActionResult Curriculum()
        {
            return View(db.Curricula.ToList());
        }
        [HttpGet]
        public IActionResult CurriculumInsert()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CurriculumInsert(Curriculum c)
        {
            db.Curricula.Add(c);
            db.SaveChanges();
            return RedirectToAction("Curriculum");
        }
        #endregion
    }
}
