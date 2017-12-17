using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace musync_web.Pages
{
    public class IntegrationsModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "You can display or edit your integrations from here.";
        }
    }
}
