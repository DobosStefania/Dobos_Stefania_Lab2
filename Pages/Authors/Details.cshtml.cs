using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dobos_Stefania_Lab2.Data;
using Dobos_Stefania_Lab2.Models;

namespace Dobos_Stefania_Lab2.Pages.Authors
{
    public class DetailsModel : PageModel
    {
        private readonly Dobos_Stefania_Lab2.Data.Dobos_Stefania_Lab2Context _context;

        public DetailsModel(Dobos_Stefania_Lab2.Data.Dobos_Stefania_Lab2Context context)
        {
            _context = context;
        }

      public Authors Authors { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.Authors == null)
            {
                return NotFound();
            }

            var authors = await _context.Authors.FirstOrDefaultAsync(m => m.ID == id);
            if (authors == null)
            {
                return NotFound();
            }
            else 
            {
                Authors = authors;
            }
            return Page();
        }
    }
}
