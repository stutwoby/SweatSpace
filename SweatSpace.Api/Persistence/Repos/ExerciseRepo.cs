﻿using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SweatSpace.Api.Persistence.Entities;
using SweatSpace.Api.Persistence.Helpers;
using SweatSpace.Api.Persistence.Interfaces;
using SweatSpace.Api.Persistence.Params;
using SweatSpace.Persistence.Business;

namespace SweatSpace.Api.Persistence.Repos
{
    internal class ExerciseRepo : IExerciseRepo
    {
        private readonly DataContext _context;

        public ExerciseRepo(DataContext context)
        {
            _context = context;
        }

        public Task<Exercise> GetExerciseByNameAsync(string name)
        {
            return _context.Exercises.SingleOrDefaultAsync(e => e.Name == name.ToLower());
        }

        public Task AddExerciseAsync(Exercise exercise)
        {
            return _context.Exercises.AddAsync(exercise).AsTask();
        }

        public Task<PagedList<Exercise>> GetExercisesAsync(ExerciseParams exerciseParams)
        {
            var query = _context.Exercises.AsNoTracking();
            return PagedList<Exercise>.CreateAsync(query, exerciseParams.PageNumber, exerciseParams.ItemsPerPage);
        }

        public Task<WorkoutExercise> GetWorkoutExerciseByIdAsync(int id)
        {
            return _context.WorkoutExercises.FindAsync(id).AsTask();
        }

        public void RemoveWorkoutExercise(WorkoutExercise workoutExercise) =>
            _context.WorkoutExercises.Remove(workoutExercise);

    }
}