using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoComponents
{
    [ViewComponent(Name = "jQDatatable")]
    public class jQDatatableViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke(string model)
        {
            return View(model);
        }

    }
}
