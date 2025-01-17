﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SweatSpace.Api.Persistence.Entities
{
    public class Workout
    {
        public int Id { get; set; }

        [Required, MaxLength(255)]
        public string Name { get; set; }

        public bool IsCompleted { get; set; }

        [Range(0, 5)]
        public int Rating { get; set; }
        public DateTime? Date { get; set; }

        public int AppUserId { get; set; }
        public ICollection<WorkoutExercise> Exercises { get; set; } = new List<WorkoutExercise>();
        public ICollection<AppUser> UsersThatLiked { get; set; } = new List<AppUser>();
    }
}