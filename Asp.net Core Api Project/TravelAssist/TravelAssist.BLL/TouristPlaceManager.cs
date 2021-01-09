using System;
using System.Collections.Generic;
using System.Text;
using TravelAssist.BLL.Base;
using TravelAssist.BLL.Contracts;
using TravelAssist.Model.Models;
using TravelAssist.Repository.Contracts;

namespace TravelAssist.BLL
{
    public class TouristPlaceManager : Manager<TouristPlace>, ITouristPlaceManager
    {
        private readonly ITouristPlaceRepository repository;

        public TouristPlaceManager(ITouristPlaceRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
