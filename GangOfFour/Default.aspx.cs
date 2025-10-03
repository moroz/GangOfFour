using System;
using System.Linq;
using GangOfFour.Models;

namespace GangOfFour
{
    public partial class _Default : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public IQueryable<Event> GetFeaturedEvents()
        {
            return EventRepository.GetFeaturedEvents();
        }
    }
}