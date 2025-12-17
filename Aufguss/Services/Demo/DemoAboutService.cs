using Aufguss.Models;
using Aufguss.Pages;
using Aufguss.Pages.Bookings;
using Aufguss.Services.Interface;
using System.Xml.Linq;
using About = Aufguss.Models.About;

namespace Aufguss.Services.Demo
{
    public class DemoAboutService : IAboutService
    {
        private SiteSettings _settings;
        private About _about;
        
        private readonly IEventService _eventService;


        public DemoAboutService(IEventService eventService)
        {
            _settings = null;
            _eventService = eventService;

            _about = new()
            {
                EditorHtml = @"
                            <p class=""card-text"">
                                Relax i bastu med härliga dofter och svepande värme. Flera tillfällen under året bjuder vi in till aufguss i vår sköna bastu.
                                <br /><br />
                                <strong>För dig som bastar:</strong><br />
                                - Inga badkläder i bastun<br />
                                - Sitt på egen handduk<br />
                                - Duscha innan du går in i bastun<br />
                                - Tänk på att dricka vatten<br />
                                <br />
                                Aufguss är en tysk bastukultur som letat sig in i Sverige under senare tid. Ordet betyder ungefär ""hälla på"".
                                En bastuvärd häller på underbart väldoftande eteriska oljor och vatten över heta stenar.
                                Värmen viftas sedan omkring så att den mjukt sprider sig i bastun.
                                <br /><br />
                                En vanlig sittning brukar vara mellan 5 och 15 minuter och har ofta olika teman.
                                Flera tillfällen under året bjuder vi in till aufguss i vår sköna bastu.
                                <br /><br />
                                Medtag egen vattenflaska och drick ordentligt både innan, under tiden och efteråt då du svettas ut mycket vätska.
                                Aufguss ingår i priset för bad- och gym-kort.
                            </p>"
            };
        }

        public Task<About> GetHTMLAsync()
        {
            return Task.FromResult(_about);
        }

        public Task EditAboutAsync(string editAbout)
        {
            _about.EditorHtml = editAbout;

            return Task.CompletedTask;
        }
    }
}
