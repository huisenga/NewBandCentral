using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SWAT.Models
{
    public class tblSTDNT_LOCALController : Controller
    {
        private UWSocWorkMainEntities db = new UWSocWorkMainEntities();

        // GET: tblSTDNT_LOCAL
        public ActionResult Index()
        {
            var tblSTDNT_LOCAL = db.tblSTDNT_LOCAL.Include(t => t.tblAdvisor_Note);
            return View(tblSTDNT_LOCAL.ToList());
        }

        // GET: tblSTDNT_LOCAL/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblSTDNT_LOCAL tblSTDNT_LOCAL = db.tblSTDNT_LOCAL.Find(id);
            if (tblSTDNT_LOCAL == null)
            {
                return HttpNotFound();
            }
            return View(tblSTDNT_LOCAL);
        }

        // GET: tblSTDNT_LOCAL/Create
        public ActionResult Create()
        {
            ViewBag.ID = new SelectList(db.tblAdvisor_Note, "ID", "Note_Text");
            return View();
        }

        // POST: tblSTDNT_LOCAL/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PID,StudentID,ID,FName,LName,PrevLName,MName,SpecialNeeds,SpecialNeedsNotes,SWMailbox,CurrentStreet,CurrentCity,CurrentState,CurrentZip,SummerContactYear,SummerStreet,SummerCity,SummerState,SummerZip,PermanentStreet,PermanentCity,PermanentState,PermanentZip,CellPhone,WorkPhone,WorkPhoneExtension,HomePhone,HomePhoneExtension,PermanentPhone,PermanentPhoneExtension,SummerPhone,SummerPhoneExtension,WIBackgroundComp,WIBackgroundCheckYear,WIDiscrepancy,OOSBackgroundComp,OOSBackgroundCheckYear,OOSDiscrepancy,OOSBackgroundCheckState,BackgroundCheckComment,AlumniTitle,AlumniCompany,CurrentEmployment_1,CurrentEmployment_2,CurrentEmploymentAddress,IVE_Student,IVE_EMail,IVE_Phone1,IVE_Phone2,PreviousEmployer,NumberOfyears,Comments,TypeofEmployment,StudentAdded,StudentUpdated,VetranStatus,Exemptions,GridInfo,PT_StudentGroup,AdvSt,FocusArea,studentPhotoLoc,currentProgram,isSchoolSocialWork,resCounty,ID_String,MSW_Ant_GradTerm,isProspective,FocusAreaUpdated,upsized_ts")] tblSTDNT_LOCAL tblSTDNT_LOCAL)
        {
            if (ModelState.IsValid)
            {
                db.tblSTDNT_LOCAL.Add(tblSTDNT_LOCAL);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID = new SelectList(db.tblAdvisor_Note, "ID", "Note_Text", tblSTDNT_LOCAL.ID);
            return View(tblSTDNT_LOCAL);
        }

        // GET: tblSTDNT_LOCAL/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblSTDNT_LOCAL tblSTDNT_LOCAL = db.tblSTDNT_LOCAL.Find(id);
            if (tblSTDNT_LOCAL == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID = new SelectList(db.tblAdvisor_Note, "ID", "Note_Text", tblSTDNT_LOCAL.ID);
            return View(tblSTDNT_LOCAL);
        }

        // POST: tblSTDNT_LOCAL/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PID,StudentID,ID,FName,LName,PrevLName,MName,SpecialNeeds,SpecialNeedsNotes,SWMailbox,CurrentStreet,CurrentCity,CurrentState,CurrentZip,SummerContactYear,SummerStreet,SummerCity,SummerState,SummerZip,PermanentStreet,PermanentCity,PermanentState,PermanentZip,CellPhone,WorkPhone,WorkPhoneExtension,HomePhone,HomePhoneExtension,PermanentPhone,PermanentPhoneExtension,SummerPhone,SummerPhoneExtension,WIBackgroundComp,WIBackgroundCheckYear,WIDiscrepancy,OOSBackgroundComp,OOSBackgroundCheckYear,OOSDiscrepancy,OOSBackgroundCheckState,BackgroundCheckComment,AlumniTitle,AlumniCompany,CurrentEmployment_1,CurrentEmployment_2,CurrentEmploymentAddress,IVE_Student,IVE_EMail,IVE_Phone1,IVE_Phone2,PreviousEmployer,NumberOfyears,Comments,TypeofEmployment,StudentAdded,StudentUpdated,VetranStatus,Exemptions,GridInfo,PT_StudentGroup,AdvSt,FocusArea,studentPhotoLoc,currentProgram,isSchoolSocialWork,resCounty,ID_String,MSW_Ant_GradTerm,isProspective,FocusAreaUpdated,upsized_ts")] tblSTDNT_LOCAL tblSTDNT_LOCAL)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblSTDNT_LOCAL).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID = new SelectList(db.tblAdvisor_Note, "ID", "Note_Text", tblSTDNT_LOCAL.ID);
            return View(tblSTDNT_LOCAL);
        }

        // GET: tblSTDNT_LOCAL/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblSTDNT_LOCAL tblSTDNT_LOCAL = db.tblSTDNT_LOCAL.Find(id);
            if (tblSTDNT_LOCAL == null)
            {
                return HttpNotFound();
            }
            return View(tblSTDNT_LOCAL);
        }

        // POST: tblSTDNT_LOCAL/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblSTDNT_LOCAL tblSTDNT_LOCAL = db.tblSTDNT_LOCAL.Find(id);
            db.tblSTDNT_LOCAL.Remove(tblSTDNT_LOCAL);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
