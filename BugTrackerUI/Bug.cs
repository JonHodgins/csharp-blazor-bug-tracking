using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerUI
{
    public class Bug
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required, MinLength(10, ErrorMessage ="Description must contain at least 10 characters.")]
        public string Description { get; set; }

        [Required, Range(1, 5, ErrorMessage ="Priority must be between 1 and 5")]
        public int Priority { get; set; }
    }
}