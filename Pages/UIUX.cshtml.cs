using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace JN_Me.Pages
{
    public class UIUXModel : PageModel
    {
        private readonly ILogger<UIUXModel> _logger;

        public UIUXModel(ILogger<UIUXModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
