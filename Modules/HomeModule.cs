using Nancy;
using JobBoard.Objects;
using System.Collections.Generic;

namespace JobBoard
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_new_job.cshtml"];
      Get["/view_all_jobs"] = _ => {
        List<Job> allJobs = Job.GetAll();
        return View["view_all_jobs.cshtml", allJobs];
      };
      Post["/job_added"] = _ => {
        Contact newContact = new Contact(Request.Form["new-contact-name"],
                                         Request.Form["new-telephone"],
                                         Request.Form["new-email"]);
        Job newJob = new Job (Request.Form["new-title"],
                              Request.Form["new-description"],
                              newContact);
        return View["job_added.cshtml", newJob];
      };
      Post["/jobs_cleared"] = _ => {
        Job.ClearAll();
        return View["jobs_cleared.cshtml"];
      };
    }
  }
}
