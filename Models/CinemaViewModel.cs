using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MVCPrimerEjemplo.Models
{
    public class CinemaViewModel
    {
        public List<Cinema>? Cinemas { get; set; }
        public SelectList? Name { get; set; }
    }
}