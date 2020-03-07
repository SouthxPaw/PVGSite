using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PVGSite.Models
{
    public class AboutViewModel
    {
        public IEnumerable<PVGPerson> PVGPeople { get; set; }
        public PVGFounder Founder { get; set; }

        public IEnumerable<PVGMod> Mods { get; set; }
        public IEnumerable<PVGVoice> Voices { get; set; }
    }
}
