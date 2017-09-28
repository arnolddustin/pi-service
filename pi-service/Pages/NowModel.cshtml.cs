using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace pi_service.Pages
{
  public class NowModel : PageModel
  {
    public NowModel() {
      LastModified = DateTime.Now.AddHours(-34);
    }
    public DateTime LastModified { get; set; }

    public void OnGet() { }

  }
}