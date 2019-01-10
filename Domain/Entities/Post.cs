using CommonShared.Common;
using NodaTime;
using NodaTime.Extensions;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Post : BaseEntity
    {       
        public string Content { get; set; }
        private string _Topic { get; set; }

        [NotMapped]
        public Instant Published { get; set; }
        public string Slug { get; set; }
        public string AuthorName { get; set; }

        [Column("Published")]
        [DataType(DataType.DateTime)]
        public DateTime PublishedDateTime
        {
            get => Published.ToDateTimeUtc();
            set => Published = DateTime.SpecifyKind(value, DateTimeKind.Utc).ToInstant();
        }

        public string Topic
        {
            get
            {
                return _Topic;
            }
            set
            {
                Slug = UrlHelpers.URLFriendly(value);
                _Topic = value;
            }
        } 
    }
}
