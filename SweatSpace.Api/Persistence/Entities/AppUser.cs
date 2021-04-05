﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SweatSpace.Api.Persistence.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        [Required, MaxLength(255)]
        public string UserName { get; set; }
        public ICollection<Workout> Workouts { get; set; } = new List<Workout>();
        public ICollection<Workout> LikedWorkouts { get; set; } = new List<Workout>();
    }
}
