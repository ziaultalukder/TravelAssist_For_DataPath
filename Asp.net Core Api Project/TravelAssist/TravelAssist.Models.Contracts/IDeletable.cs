using System;
using System.Collections.Generic;
using System.Text;

namespace TravelAssist.Model.Contracts
{
    public interface IDeletable
    {
        bool IsDeleted { get; set; }
        bool withDeleted();
    }
}
