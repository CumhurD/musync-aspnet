using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using musync_web.Models;

namespace musync_web.Pages
{
    public class IntegrationsModel : PageModel
    {
        private readonly IntegrationSettings _settings;
        public IntegrationsModel(IntegrationSettings settings)
        {
          _settings = settings;  
        }
        
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "You can display or edit your integrations from here.";
        }
    }
}
