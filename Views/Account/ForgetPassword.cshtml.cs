using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BestStoreMVC.Views.Account
{
    public class ForgetPassword : PageModel
    {
        private readonly ILogger<ForgetPassword> _logger;

        public ForgetPassword(ILogger<ForgetPassword> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}