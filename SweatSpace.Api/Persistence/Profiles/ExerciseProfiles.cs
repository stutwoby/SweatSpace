﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SweatSpace.Api.Business.Dtos;
using SweatSpace.Api.Persistence.Entities;

namespace SweatSpace.Api.Persistence.Profiles
{
    public class ExerciseProfiles : Profile
    {
        public ExerciseProfiles() 
        {
            CreateMap<ExerciseAddDto, WorkoutExercise>();
        }
    }
}