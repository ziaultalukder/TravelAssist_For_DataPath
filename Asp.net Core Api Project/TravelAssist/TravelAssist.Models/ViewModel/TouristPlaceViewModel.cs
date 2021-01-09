using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace TravelAssist.Models.ViewModel
{
    public class TouristPlaceViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool IsDeleted { get; set; }
        public string UserId { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
