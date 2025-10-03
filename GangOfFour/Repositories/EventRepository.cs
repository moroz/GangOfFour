using System.Collections.Generic;
using System.Linq;
using GangOfFour.Models;

namespace GangOfFour.Repositories
{
    public class EventRepository
    {
        private readonly AppDbContext _db;

        public EventRepository(AppDbContext db)
        {
            _db = db;
        }

        public IQueryable<Event> GetFeaturedEvents()
        {
            return _db.Events;
        }
    }
}