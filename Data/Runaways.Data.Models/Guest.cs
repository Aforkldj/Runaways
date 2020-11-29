﻿namespace Runaways.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    using Runaways.Data.Common.Models;

    public class Guest : BaseModel<string>
    {
        public Guest()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string AccommodationId { get; set; }
        public virtual Accommodation Accommodation { get; set; }

        [ForeignKey(nameof(Client))]
        public string ClientId { get; set; }
        public virtual ApplicationUser Client { get; set; }
    }
}