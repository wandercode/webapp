﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace myWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private bool isPost=false;
        public bool IsPostBack
        {
            get
            {
                return isPost;
            }
            set
            {
                isPost=value;
            }
        }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public void OnPost()
        {
            isPost=true;
            double amount=double.Parse(Request.Form["billamount"]);
            double tippercent=double.Parse(Request.Form["percentage"]);
            double tip=(amount*tippercent)/100;
            ViewData["Tip"]=tip;
        }
    }
}
