using System;
using System.Collections.Generic;
using System.Text;
using TravelAssist.Model.Contracts;

namespace TravelAssist.Model.Models
{
    public class TouristPlace: IDeletable
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool IsDeleted { get; set; }
        public string UserId { get; set; }
        public bool withDeleted()
        {
            return IsDeleted;
        }
    }
}
