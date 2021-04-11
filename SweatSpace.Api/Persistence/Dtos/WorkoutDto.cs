﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SweatSpace.Api.Persistence.Entities;

namespace SweatSpace.Api.Persistence.Dtos
{
    public class WorkoutDto
    {
        public int Id { get; set; }

        [Required, MaxLength(255)]
        public string Name { get; set; }
        public bool IsCompleted { get; set; }
        public int Rating { get; set; }
        public DateTime Date { get; set; }

        public ICollection<ExerciseDto> Exercises { get; set; } = new List<ExerciseDto>();
        public ICollection<MemberDto> UsersThatLiked { get; set; } = new List<MemberDto>();
    }
}