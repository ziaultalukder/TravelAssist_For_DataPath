using System;
using System.Collections.Generic;
using System.Text;
using TravelAssist.Model.Models;
using TravelAssist.Models;
using TravelAssist.Repository.Base;
using TravelAssist.Repository.Contracts;

namespace TravelAssist.Repository
{
    public class TouristPlaceRepository : Repository<TouristPlace>, ITouristPlaceRepository
    {
        public TouristPlaceRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
