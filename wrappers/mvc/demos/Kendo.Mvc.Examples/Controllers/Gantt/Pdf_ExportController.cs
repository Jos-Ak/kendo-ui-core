﻿using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web.Mvc;
using Kendo.Mvc.Examples.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using Kendo.Mvc.Examples.Models.Gantt;

namespace Kendo.Mvc.Examples.Controllers
{﻿
    public partial class GanttController : Controller
    {
        public ActionResult Pdf_Export()
        {
            return View();
        }
    }
}