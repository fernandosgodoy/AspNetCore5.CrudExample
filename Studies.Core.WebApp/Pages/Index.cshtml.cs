using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studies.Core.WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly AlunosDbContext _context;

        public IndexModel(ILogger<IndexModel> logger,
            AlunosDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            var alunos = _context.Alunos.ToArray();
            ViewData["alunos"] = alunos;
        }
    }
}
