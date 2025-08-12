using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BestStoreMVC.Views.Account
{
    public class Password : PageModel
    {
        private readonly ILogger<Password> _logger;

        public Password(ILogger<Password> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}