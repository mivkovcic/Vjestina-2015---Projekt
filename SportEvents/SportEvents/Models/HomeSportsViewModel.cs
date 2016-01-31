using SportEvents.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportEvents.Models
{
    public class HomeSportsViewModel
    {
        public List<Sport> Sportovi { get; set; }

        public List<Događaj> SportDogađaji { get; set; }


    }
}