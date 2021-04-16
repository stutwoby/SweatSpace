﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SweatSpace.Api.Business.Dtos
{
    public class WorkoutUpdateDto
    {
        [Required, MaxLength(255)]
        public string Name { get; set; }

        public int Rating { get; set; }
        public DateTime? Date { get; set; }
    }
}