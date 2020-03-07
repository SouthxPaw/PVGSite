namespace PVGSite.Models
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    public class PVGFounder : PVGPerson
    {
        public PVGFounder() { }
       
    }


    public class PVGMod : PVGPerson {
        public PVGMod(){ }
       
    }

    public class PVGVoice
    {
        public PVGVoice() { }
        public string Tag { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string Twitch { get; set; }
        public string Youtube { get; set; }
        public string Mixer { get; set; }

        public string Avi { get; set; }

        public string AboutMe { get; set; }
        public string Main { get; set; }

    }

    public abstract class PVGPerson 
    {
        public PVGPerson() { }
        public string Tag { get; set; }
        public string Discord { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string Twitch { get; set; }
        public string Youtube { get; set; }
        public string Mixer { get; set; }

        public string Avi { get; set; }

        public string AboutMe { get; set; }
        public string Main { get; set; }

    }

}

