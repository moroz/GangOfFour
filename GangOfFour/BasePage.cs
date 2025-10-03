using System;
using GangOfFour.Models;
using GangOfFour.Repositories;

namespace GangOfFour
{
    public class BasePage : System.Web.UI.Page
    {
        private readonly AppDbContext _db = new AppDbContext();
        protected EventRepository EventRepository;

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            EventRepository = new EventRepository(_db);
        }
    }
}