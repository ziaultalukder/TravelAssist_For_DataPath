using System;
using System.Collections.Generic;
using System.Text;
using TravelAssist.Model.Models;

namespace TravelAssist.Models.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string UserId { get; set; }
        public int TouristPlaceId { get; set; }
        public TouristPlace TouristPlace { get; set; }
    }
}
