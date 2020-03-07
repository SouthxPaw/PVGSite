using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PVGSite.Models;

namespace PVGSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            var PVGListMods = new List<PVGMod> {};
            var PVGListVoices = new List<PVGVoice> {};

            var awaken = new PVGFounder()
            {
                Tag = "awaken.",
                Discord = "awaken.#6752",
                Instagram = "https://www.instagram.com/awaken.ssbu/",
                Twitch = "https://twitch.tv/awakenssbu",
                Twitter = "https://twitter.com/awaken_ssb",
                Youtube = "",
                Mixer = "",
                Avi = "../images/awakentwitch.png",
                AboutMe= "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Main = "../Icons/peach.png"
            };
            var ender = new PVGMod()
            {
                Tag = "Ender1241",
                Discord = "Ender1241#9299",
                Instagram = "",
                Twitch = "",
                Twitter = "https://twitter.com/1241_ssbu",
                Youtube = "",
                Mixer = "",
                Avi = "../images/Ender.png",
                AboutMe = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Main = "../Icons/zelda.png"
            };
            var ez = new PVGMod()
            {
                Tag = "ez",
                Discord = "ez#3274",
                Instagram = "",
                Twitch = "",
                Twitter = "",
                Youtube = "",
                Mixer = "",
                Avi = "../images/discord_salad.jpg",
                AboutMe = "Voted \"Most Likely to Spam Projectiles on Wifi\" in the high school yearbook, and has spent the rest of his life trying to live up to that expectation.",
                Main = "../Icons/mega_man.png"
            };
            var woxdy = new PVGMod()
            {
                Tag = "woxdy",
                Discord = "woxdy#3897",
                Instagram = "",
                Twitch = "",
                Twitter = "https://twitter.com/woxdy",
                Youtube = "https://www.youtube.com/woxdy",
                Mixer = "https://mixer.com/woxdy",
                Avi = "../images/woxdy.png",
                AboutMe = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Main = "../Icons/lucina.png",
            };
            var triaezon = new PVGVoice()
            {
                Tag = "TrieaZon",
                Instagram = "",
                Twitch = "",
                Twitter = "",
                Youtube = "",
                Mixer = "",
                Avi = "../images/Trieazon.png",
                AboutMe = "Known for his deep thoughts in our discord channel and his musings that will inspire any living thing. TrieaZon has been an integral part of the community and spreads positive vibes no matter where he goes.",
                Main = "../Icons/cloud.png"
            };
            var mous = new PVGVoice()
            {
                Tag = "Mous",
                Instagram = "",
                Twitch = "",
                Twitter = "",
                Youtube = "",
                Mixer = "",
                Avi = "../images/Mous.png",
                AboutMe = "While rough around the edges sometimes, Mous is extremely attentive and goes into deep anaylsis with his match critiques. He is known to almost flame the user he is critiquing but he burns the player down, only to build them up and make them greater than they were before.",
                Main = "../Icons/random.png",
            };

            
            PVGListMods.Add(ender);
            PVGListMods.Add(ez);
            PVGListMods.Add(woxdy);
            PVGListVoices.Add(triaezon);
            PVGListVoices.Add(mous);
            
            return View(new AboutViewModel {Founder = awaken, Mods = PVGListMods, Voices = PVGListVoices });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
