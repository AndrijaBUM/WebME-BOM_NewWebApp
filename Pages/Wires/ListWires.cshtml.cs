using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using WebME_BOM_NewWebApp.Core;
using WebME_BOM_NewWebApp.Data;

namespace WebME_BOM_NewWebApp.Pages.Wires
{
    public class ListWiresModel : PageModel
    {
        private readonly IConfiguration configuration;
        private readonly IWireData wireData;

        public string Message { get; set; }
        public string Message1 { get; set; }
        public IEnumerable<Wire> Wires { get; set; }

        public ListWiresModel(IConfiguration configuration, IWireData wireData)
        {
            this.configuration = configuration;
            this.wireData = wireData;
        }
        public void OnGet()
        {
            Message = "Hello from Model!";
            Message1 = configuration["Message"];
            Wires = wireData.GetAllWires();
        }
    }
}
