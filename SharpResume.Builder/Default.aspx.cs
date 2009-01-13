using System;
using System.Web.UI;
using Just3Ws.SharpResume;

namespace SharpResume.Builder
{
  public class _Default : Page
  {
    /// <summary>
    /// Handles the Load event of the Page control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    protected void Page_Load(object sender, EventArgs e)
    {
      var resume = new MySharpResume();
      resume.Objective = "To find a job.";
      resume.Name = "Michael D. Hall";
    }
  }
}