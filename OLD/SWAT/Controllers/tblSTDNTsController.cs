using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SWAT.Models;

namespace SWAT.Controllers
{
    public class tblSTDNTsController : Controller
    {
        private UWSocWorkMainEntities db = new UWSocWorkMainEntities();

        // GET: tblSTDNTs
        public ActionResult Index()
        {
            return View(db.tblSTDNTs.ToList());
        }

        // GET: tblSTDNTs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblSTDNT tblSTDNT = db.tblSTDNTs.Find(id);
            if (tblSTDNT == null)
            {
                return HttpNotFound();
            }
            return View(tblSTDNT);
        }

        // GET: tblSTDNTs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tblSTDNTs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PID,TERM,ID,CAMPUS_ID,NAME,FERPA_FLAG,DECEASED_IND,WITHDREW_IND,WITHDREW_REASON,WITHDREW_DATE,PRIMARY_ACADEMIC_GROUP,ACADEMIC_LEVEL,ACADEMIC_LEVEL_PROJ,ACADEMIC_LEVEL_EOT,CAREER_TYPE,CAREER,GENDER,AGE,CITIZEN_IND,CITIZEN_STATUS,RESIDENCY,TUITION_RESIDENCY,VISA_PERMIT_TYPE,VISA_PERMIT_NUMBER,COUNTRY_OF_CITIZENSHIP,COUNTRY_OF_CITIZENSHIP_DESCR,COUNTRY_OF_BIRTH,COUNTRY_OF_BIRTH_DESCR,PRIMARY_SUPPORT_DESCR,SECONDARY_SUPPORT_DESCR,MARITAL_STATUS_DESCR,VETERAN_STATUS,DIVERSITY,DIVERSITY_DESCR,ETHNIC_GROUP,ETHNIC_GROUP_DESCR,MINORITY,TARGETED_MINORITY,ACADEMIC_LOAD,ADMIT_TYPE,ACADEMIC_ADVANCEMENT_PROG,DISSERTATOR_IND,HIGH_SCHOOL_CODE,HIGH_SCHOOL_PERCENTILE,MATRICULATION_TERM,DEG_EXPECTED,TERM_CREDITS_TOTAL,TERM_TAKEN_CREDITS_TOTAL,TERM_TAKEN_CREDITS_GPA,TERM_TAKEN_CREDITS_NOGPA,TERM_TAKEN_CREDITS_PROGRESS,TERM_TAKEN_CREDITS_PROG_GRAD,TERM_INPROG_CREDITS_TOTAL,TERM_INPROG_CREDITS_GPA,TERM_INPROG_CREDITS_NOGPA,TERM_CREDITS_AUDIT,TERM_GRADE_POINTS,TERM_GPA,CUM_CREDITS_TOTAL,CUM_TAKEN_CREDITS_GPA,CUM_TRANSFER_CREDITS,CUM_TEST_CREDITS,CUM_OTHER_CREDITS,CUM_GRADE_POINTS,CUM_GPA,PREVIOUS_TERM_GPA,PREVIOUS_GPA_TERM,NEGATIVE_SERVICE_IND,SEMESTER_HONORS1,SEMESTER_HONORS2,EXTRACT_DATE_TIME,upsize_ts")] tblSTDNT tblSTDNT)
        {
            if (ModelState.IsValid)
            {
                db.tblSTDNTs.Add(tblSTDNT);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblSTDNT);
        }

        // GET: tblSTDNTs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblSTDNT tblSTDNT = db.tblSTDNTs.Find(id);
            if (tblSTDNT == null)
            {
                return HttpNotFound();
            }
            return View(tblSTDNT);
        }

        // POST: tblSTDNTs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PID,TERM,ID,CAMPUS_ID,NAME,FERPA_FLAG,DECEASED_IND,WITHDREW_IND,WITHDREW_REASON,WITHDREW_DATE,PRIMARY_ACADEMIC_GROUP,ACADEMIC_LEVEL,ACADEMIC_LEVEL_PROJ,ACADEMIC_LEVEL_EOT,CAREER_TYPE,CAREER,GENDER,AGE,CITIZEN_IND,CITIZEN_STATUS,RESIDENCY,TUITION_RESIDENCY,VISA_PERMIT_TYPE,VISA_PERMIT_NUMBER,COUNTRY_OF_CITIZENSHIP,COUNTRY_OF_CITIZENSHIP_DESCR,COUNTRY_OF_BIRTH,COUNTRY_OF_BIRTH_DESCR,PRIMARY_SUPPORT_DESCR,SECONDARY_SUPPORT_DESCR,MARITAL_STATUS_DESCR,VETERAN_STATUS,DIVERSITY,DIVERSITY_DESCR,ETHNIC_GROUP,ETHNIC_GROUP_DESCR,MINORITY,TARGETED_MINORITY,ACADEMIC_LOAD,ADMIT_TYPE,ACADEMIC_ADVANCEMENT_PROG,DISSERTATOR_IND,HIGH_SCHOOL_CODE,HIGH_SCHOOL_PERCENTILE,MATRICULATION_TERM,DEG_EXPECTED,TERM_CREDITS_TOTAL,TERM_TAKEN_CREDITS_TOTAL,TERM_TAKEN_CREDITS_GPA,TERM_TAKEN_CREDITS_NOGPA,TERM_TAKEN_CREDITS_PROGRESS,TERM_TAKEN_CREDITS_PROG_GRAD,TERM_INPROG_CREDITS_TOTAL,TERM_INPROG_CREDITS_GPA,TERM_INPROG_CREDITS_NOGPA,TERM_CREDITS_AUDIT,TERM_GRADE_POINTS,TERM_GPA,CUM_CREDITS_TOTAL,CUM_TAKEN_CREDITS_GPA,CUM_TRANSFER_CREDITS,CUM_TEST_CREDITS,CUM_OTHER_CREDITS,CUM_GRADE_POINTS,CUM_GPA,PREVIOUS_TERM_GPA,PREVIOUS_GPA_TERM,NEGATIVE_SERVICE_IND,SEMESTER_HONORS1,SEMESTER_HONORS2,EXTRACT_DATE_TIME,upsize_ts")] tblSTDNT tblSTDNT)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblSTDNT).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblSTDNT);
        }

        // GET: tblSTDNTs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblSTDNT tblSTDNT = db.tblSTDNTs.Find(id);
            if (tblSTDNT == null)
            {
                return HttpNotFound();
            }
            return View(tblSTDNT);
        }

        // POST: tblSTDNTs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblSTDNT tblSTDNT = db.tblSTDNTs.Find(id);
            db.tblSTDNTs.Remove(tblSTDNT);
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
