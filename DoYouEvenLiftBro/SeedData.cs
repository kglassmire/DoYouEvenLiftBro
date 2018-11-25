using DoYouEvenLiftBro.DAL;
using DoYouEvenLiftBro.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoYouEvenLiftBro
{
    public static class SeedData
    {

        private const string _adminUsername = "admin";
        private const string _adminRolename = "admin";
        private static User _adminUser;
        public static void Initialize(DoYouEvenLiftBroContext context, UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            //Console.WriteLine("Initialized DB.");
            context.Database.EnsureCreated();
            SeedRoles(roleManager);
            SeedUsers(userManager, roleManager);
            GetAdminUser(userManager);
            SeedMuscleGroups(context);
            SeedExercises(context);
            SeedWorkouts(context);
            SeedWorkoutExercises(context);

        }

        private static void SeedWorkoutExercises(DoYouEvenLiftBroContext context)
        {
            Workout workout = null;
            WorkoutExercise workoutExercise = null;

            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 01, 12))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Flat Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Flat Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 8, Weight = 185M },
                new Set { Reps = 7, Weight = 225M },
                new Set { Reps = 6, Weight = 255M },
                new Set { Reps = 7, Weight = 225M },
                new Set { Reps = 7, Weight = 225M },
                new Set { Reps = 8, Weight = 185M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 25M },
                new Set { Reps = 12, Weight = 30M },
                new Set { Reps = 12, Weight = 30M },
                new Set { Reps = 13, Weight = 25M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Decline Hammer Strength Chest Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Decline Hammer Strength Chest Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 186M },
                new Set { Reps = 10, Weight = 206M },
                new Set { Reps = 10, Weight = 226M },
                new Set { Reps = 10, Weight = 186M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Single Arm Cable Triceps Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Single Arm Cable Triceps Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 20M },
                new Set { Reps = 12, Weight = 20M },
                new Set { Reps = 12, Weight = 20M },
                new Set { Reps = 12, Weight = 15M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 01, 13))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 9, Weight = 60M },
                new Set { Reps = 8, Weight = 70M },
                new Set { Reps = 8, Weight = 80M },
                new Set { Reps = 8, Weight = 70M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 60M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 10, Weight = 80M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Dumbbell Lat Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Dumbbell Lat Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 8, Weight = 70M },
                new Set { Reps = 8, Weight = 80M },
                new Set { Reps = 7, Weight = 90M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 01, 14))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Hammer Strength Shoulder Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Hammer Strength Shoulder Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 100M },
                new Set { Reps = 10, Weight = 190M },
                new Set { Reps = 8, Weight = 230M },
                new Set { Reps = 5, Weight = 250M },
                new Set { Reps = 6, Weight = 230M },
                new Set { Reps = 9, Weight = 190M },
                new Set { Reps = 8, Weight = 190M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 8, Weight = 85M },
                new Set { Reps = 6, Weight = 100M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 12, Weight = 40M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Dumbbell Lateral Delt Raise", Exercise = context.Exercises.Single(x => x.Name.Equals("Dumbbell Lateral Delt Raise")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 15M },
                new Set { Reps = 15, Weight = 20M },
                new Set { Reps = 12, Weight = 20M },
                new Set { Reps = 10, Weight = 15M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 01, 20))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 50M },
                new Set { Reps = 12, Weight = 60M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 8, Weight = 80M },
                new Set { Reps = 8, Weight = 70M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 12, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Dumbbell Lat Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Dumbbell Lat Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 8, Weight = 70M },
                new Set { Reps = 8, Weight = 80M },
                new Set { Reps = 7, Weight = 90M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 13, Weight = 60M },
                new Set { Reps = 9, Weight = 70M },
                new Set { Reps = 9, Weight = 80M },
                new Set { Reps = 10, Weight = 60M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 01, 21))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Hammer Strength Shoulder Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Hammer Strength Shoulder Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 100M },
                new Set { Reps = 10, Weight = 190M },
                new Set { Reps = 8, Weight = 230M },
                new Set { Reps = 6, Weight = 250M },
                new Set { Reps = 5, Weight = 230M },
                new Set { Reps = 8, Weight = 190M },
                new Set { Reps = 6, Weight = 190M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 65M },
                new Set { Reps = 11, Weight = 72.5M },
                new Set { Reps = 9, Weight = 80M },
                new Set { Reps = 8, Weight = 87.5M },
                new Set { Reps = 15, Weight = 42.5M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Dumbbell Lateral Delt Raise", Exercise = context.Exercises.Single(x => x.Name.Equals("Dumbbell Lateral Delt Raise")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 15M },
                new Set { Reps = 15, Weight = 20M },
                new Set { Reps = 11, Weight = 20M },
                new Set { Reps = 14, Weight = 15M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Plate Raises", Exercise = context.Exercises.Single(x => x.Name.Equals("Plate Raises")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 25M },
                new Set { Reps = 12, Weight = 35M },
                new Set { Reps = 12, Weight = 45M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 01, 25))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Flat Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Flat Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 8, Weight = 185M },
                new Set { Reps = 7, Weight = 225M },
                new Set { Reps = 6, Weight = 255M },
                new Set { Reps = 8, Weight = 225M },
                new Set { Reps = 4, Weight = 225M },
                new Set { Reps = 9, Weight = 185M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 25M },
                new Set { Reps = 15, Weight = 30M },
                new Set { Reps = 12, Weight = 30M },
                new Set { Reps = 14, Weight = 25M },
                new Set { Reps = 20, Weight = 15M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Decline Hammer Strength Chest Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Decline Hammer Strength Chest Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 186M },
                new Set { Reps = 11, Weight = 206M },
                new Set { Reps = 10, Weight = 226M },
                new Set { Reps = 13, Weight = 186M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 8, Weight = 85M },
                new Set { Reps = 15, Weight = 50M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 01, 30))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Flat Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Flat Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 8, Weight = 185M },
                new Set { Reps = 7, Weight = 225M },
                new Set { Reps = 6, Weight = 255M },
                new Set { Reps = 8, Weight = 225M },
                new Set { Reps = 7, Weight = 225M },
                new Set { Reps = 9, Weight = 185M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 25M },
                new Set { Reps = 15, Weight = 30M },
                new Set { Reps = 12, Weight = 30M },
                new Set { Reps = 14, Weight = 25M },
                new Set { Reps = 20, Weight = 15M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Decline Hammer Strength Chest Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Decline Hammer Strength Chest Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 186M },
                new Set { Reps = 11, Weight = 206M },
                new Set { Reps = 10, Weight = 226M },
                new Set { Reps = 13, Weight = 186M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 8, Weight = 85M },
                new Set { Reps = 15, Weight = 50M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 01, 31))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 50M },
                new Set { Reps = 12, Weight = 60M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 6, Weight = 80M },
                new Set { Reps = 8, Weight = 70M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 12, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 8, Weight = 120M },
                new Set { Reps = 8, Weight = 140M },
                new Set { Reps = 8, Weight = 160M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Upright Barbell Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Upright Barbell Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 16, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 10, Weight = 80M },
                new Set { Reps = 12, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Curl", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Curl")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 50M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 02, 03))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Flat Dumbbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Flat Dumbbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 8, Weight = 185M },
                new Set { Reps = 7, Weight = 225M },
                new Set { Reps = 6, Weight = 255M },
                new Set { Reps = 8, Weight = 225M },
                new Set { Reps = 7, Weight = 225M },
                new Set { Reps = 9, Weight = 185M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 25M },
                new Set { Reps = 11, Weight = 30M },
                new Set { Reps = 11, Weight = 30M },
                new Set { Reps = 13, Weight = 25M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Decline Hammer Strength Chest Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Decline Hammer Strength Chest Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 186M },
                new Set { Reps = 11, Weight = 206M },
                new Set { Reps = 8, Weight = 226M },
                new Set { Reps = 12, Weight = 186M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Single Arm Cable Triceps Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Single Arm Cable Triceps Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 18, Weight = 20M },
                new Set { Reps = 15, Weight = 20M },
                new Set { Reps = 13, Weight = 20M },
                new Set { Reps = 12, Weight = 15M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 02, 04))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 50M },
                new Set { Reps = 12, Weight = 60M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 7, Weight = 80M },
                new Set { Reps = 8, Weight = 70M },
                new Set { Reps = 9, Weight = 60M },
                new Set { Reps = 12, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Dumbbell Lat Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Dumbbell Lat Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 8, Weight = 70M },
                new Set { Reps = 8, Weight = 80M },
                new Set { Reps = 8, Weight = 90M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 8M },
                new Set { Reps = 15, Weight = 8M },
                new Set { Reps = 15, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Upright Barbell Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Upright Barbell Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 12, Weight = 60M },
                new Set { Reps = 12, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 11, Weight = 70M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 12, Weight = 60M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 02, 17))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Flat Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Flat Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 8, Weight = 185M },
                new Set { Reps = 7, Weight = 225M },
                new Set { Reps = 6, Weight = 255M },
                new Set { Reps = 8, Weight = 225M },
                new Set { Reps = 4, Weight = 225M },
                new Set { Reps = 11, Weight = 185M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Decline Hammer Strength Chest Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Decline Hammer Strength Chest Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 186M },
                new Set { Reps = 10, Weight = 206M },
                new Set { Reps = 10, Weight = 226M },
                new Set { Reps = 10, Weight = 186M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 15M },
                new Set { Reps = 12, Weight = 25M },
                new Set { Reps = 12, Weight = 30M },
                new Set { Reps = 12, Weight = 25M },
                new Set { Reps = 15, Weight = 20M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Single Arm Cable Triceps Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Single Arm Cable Triceps Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 20M },
                new Set { Reps = 15, Weight = 20M },
                new Set { Reps = 12, Weight = 20M },
                new Set { Reps = 12, Weight = 15M },
            };

            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 02, 18))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 50M },
                new Set { Reps = 12, Weight = 60M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 8, Weight = 80M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 11, Weight = 60M },
                new Set { Reps = 13, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Dumbbell Lat Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Dumbbell Lat Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 9, Weight = 80M },
                new Set { Reps = 7, Weight = 90M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 10, Weight = 80M },
                new Set { Reps = 10, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Curl", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Curl")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 9, Weight = 57.5M },
                new Set { Reps = 8, Weight = 65M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 02, 25))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Flat Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Flat Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 8, Weight = 185M },
                new Set { Reps = 7, Weight = 225M },
                new Set { Reps = 5, Weight = 255M },
                new Set { Reps = 8, Weight = 225M },
                new Set { Reps = 5, Weight = 225M },
                new Set { Reps = 9, Weight = 185M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Decline Hammer Strength Chest Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Decline Hammer Strength Chest Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 186M },
                new Set { Reps = 10, Weight = 206M },
                new Set { Reps = 10, Weight = 226M },
                new Set { Reps = 11, Weight = 186M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 15M },
                new Set { Reps = 15, Weight = 25M },
                new Set { Reps = 15, Weight = 30M },
                new Set { Reps = 14, Weight = 25M },
                new Set { Reps = 15, Weight = 20M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Single Arm Cable Triceps Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Single Arm Cable Triceps Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 20M },
                new Set { Reps = 12, Weight = 25M },
                new Set { Reps = 14, Weight = 20M },
                new Set { Reps = 12, Weight = 15M },
            };

            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 02, 26))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 42.5M },
                new Set { Reps = 15, Weight = 50M },
                new Set { Reps = 12, Weight = 60M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 6, Weight = 80M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 11, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Dumbbell Lat Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Dumbbell Lat Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 9, Weight = 80M },
                new Set { Reps = 7, Weight = 90M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 9, Weight = 80M },
                new Set { Reps = 10, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 13, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Upright Barbell Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Upright Barbell Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 50M },
                new Set { Reps = 18, Weight = 50M },
                new Set { Reps = 14, Weight = 50M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 02, 28))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Hammer Strength Shoulder Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Hammer Strength Shoulder Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 100M },
                new Set { Reps = 10, Weight = 190M },
                new Set { Reps = 8, Weight = 230M },
                new Set { Reps = 4, Weight = 250M },
                new Set { Reps = 5, Weight = 230M },
                new Set { Reps = 7, Weight = 190M },
                new Set { Reps = 6, Weight = 190M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Dumbbell Lateral Delt Raise", Exercise = context.Exercises.Single(x => x.Name.Equals("Dumbbell Lateral Delt Raise")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 15M },
                new Set { Reps = 10, Weight = 25M },
                new Set { Reps = 15, Weight = 20M },
                new Set { Reps = 12, Weight = 20M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 15, Weight = 70M },
                new Set { Reps = 10, Weight = 85M },
                new Set { Reps = 5, Weight = 100M },
                new Set { Reps = 12, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Plate Raises", Exercise = context.Exercises.Single(x => x.Name.Equals("Plate Raises")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 25M },
                new Set { Reps = 12, Weight = 35M },
                new Set { Reps = 11, Weight = 45M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 03, 03))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Flat Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Flat Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 8, Weight = 185M },
                new Set { Reps = 7, Weight = 225M },
                new Set { Reps = 6, Weight = 255M },
                new Set { Reps = 8, Weight = 225M },
                new Set { Reps = 6, Weight = 225M },
                new Set { Reps = 9, Weight = 185M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Decline Hammer Strength Chest Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Decline Hammer Strength Chest Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 186M },
                new Set { Reps = 10, Weight = 206M },
                new Set { Reps = 10, Weight = 226M },
                new Set { Reps = 13, Weight = 186M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 22.5M },
                new Set { Reps = 20, Weight = 27.5M },
                new Set { Reps = 15, Weight = 32.5M },
                new Set { Reps = 11, Weight = 37.5M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 14, Weight = 70M },
                new Set { Reps = 8, Weight = 85M },
                new Set { Reps = 5, Weight = 100M },
                new Set { Reps = 11, Weight = 60M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 03, 04))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 50M },
                new Set { Reps = 14, Weight = 60M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 8, Weight = 80M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 13, Weight = 60M },
                new Set { Reps = 13, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 8M },
                new Set { Reps = 15, Weight = 8M },
                new Set { Reps = 15, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Dumbbell Lat Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Dumbbell Lat Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 10, Weight = 80M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 9, Weight = 80M },
                new Set { Reps = 10, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Upright Barbell Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Upright Barbell Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 50M },
                new Set { Reps = 18, Weight = 50M },
                new Set { Reps = 14, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 50M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 03, 10))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Hammer Strength Shoulder Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Hammer Strength Shoulder Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 100M },
                new Set { Reps = 10, Weight = 190M },
                new Set { Reps = 8, Weight = 230M },
                new Set { Reps = 6, Weight = 250M },
                new Set { Reps = 7, Weight = 230M },
                new Set { Reps = 8, Weight = 190M },
                new Set { Reps = 6, Weight = 190M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Dumbbell Lateral Delt Raise", Exercise = context.Exercises.Single(x => x.Name.Equals("Dumbbell Lateral Delt Raise")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 15M },
                new Set { Reps = 15, Weight = 20M },
                new Set { Reps = 13, Weight = 20M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 15, Weight = 70M },
                new Set { Reps = 10, Weight = 85M },
                new Set { Reps = 8, Weight = 100M },
                new Set { Reps = 12, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Plate Raises", Exercise = context.Exercises.Single(x => x.Name.Equals("Plate Raises")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 25M },
                new Set { Reps = 12, Weight = 35M },
                new Set { Reps = 12, Weight = 45M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Dumbbell Lateral Delt Raise", Exercise = context.Exercises.Single(x => x.Name.Equals("Dumbbell Lateral Delt Raise")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 14, Weight = 15M },
                new Set { Reps = 15, Weight = 10M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 03, 11))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 18, Weight = 50M },
                new Set { Reps = 14, Weight = 60M },
                new Set { Reps = 8, Weight = 70M },
                new Set { Reps = 8, Weight = 80M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 11, Weight = 60M },
                new Set { Reps = 13, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Dumbbell Lat Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Dumbbell Lat Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 10, Weight = 80M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 9, Weight = 80M },
                new Set { Reps = 12, Weight = 60M },
                new Set { Reps = 15, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Upright Barbell Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Upright Barbell Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 50M },
                new Set { Reps = 18, Weight = 50M },
                new Set { Reps = 14, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Dumbbell Lat Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Dumbbell Lat Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 9, Weight = 90M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 03, 17))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 50M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 9, Weight = 80M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 11, Weight = 60M },
                new Set { Reps = 13, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Dumbbell Lat Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Dumbbell Lat Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 10, Weight = 80M },
                new Set { Reps = 10, Weight = 90M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 9, Weight = 80M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 12, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Upright Barbell Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Upright Barbell Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 50M },
                new Set { Reps = 18, Weight = 50M },
                new Set { Reps = 14, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 16, Weight = 8M },
                new Set { Reps = 16, Weight = 8M },
                new Set { Reps = 16, Weight = 8M },
                new Set { Reps = 16, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 50M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 03, 18))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Flat Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Flat Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 8, Weight = 185M },
                new Set { Reps = 7, Weight = 225M },
                new Set { Reps = 6, Weight = 255M },
                new Set { Reps = 8, Weight = 225M },
                new Set { Reps = 6, Weight = 225M },
                new Set { Reps = 10, Weight = 185M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Decline Hammer Strength Chest Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Decline Hammer Strength Chest Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 186M },
                new Set { Reps = 10, Weight = 206M },
                new Set { Reps = 10, Weight = 226M },
                new Set { Reps = 13, Weight = 186M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 22.5M },
                new Set { Reps = 20, Weight = 27.5M },
                new Set { Reps = 15, Weight = 32.5M },
                new Set { Reps = 11, Weight = 37.5M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 8, Weight = 85M },
                new Set { Reps = 6, Weight = 100M },
                new Set { Reps = 11, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 27.5M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 03, 23))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Hammer Strength Shoulder Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Hammer Strength Shoulder Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 100M },
                new Set { Reps = 10, Weight = 190M },
                new Set { Reps = 8, Weight = 230M },
                new Set { Reps = 6, Weight = 250M },
                new Set { Reps = 7, Weight = 230M },
                new Set { Reps = 8, Weight = 190M },
                new Set { Reps = 6, Weight = 190M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Dumbbell Lateral Delt Raise", Exercise = context.Exercises.Single(x => x.Name.Equals("Dumbbell Lateral Delt Raise")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 15M },
                new Set { Reps = 15, Weight = 20M },
                new Set { Reps = 13, Weight = 20M },
                new Set { Reps = 15, Weight = 15M },
                new Set { Reps = 13, Weight = 10M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Plate Raises", Exercise = context.Exercises.Single(x => x.Name.Equals("Plate Raises")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 25M },
                new Set { Reps = 12, Weight = 35M },
                new Set { Reps = 12, Weight = 45M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Single Arm Cable Triceps Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Single Arm Cable Triceps Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 20M },
                new Set { Reps = 15, Weight = 25M },
                new Set { Reps = 14, Weight = 20M },
                new Set { Reps = 15, Weight = 15M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 03, 24))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 16, Weight = 50M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 9, Weight = 80M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 11, Weight = 60M },
                new Set { Reps = 13, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Dumbbell Lat Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Dumbbell Lat Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 60M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 10, Weight = 80M },
                new Set { Reps = 9, Weight = 90M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 9, Weight = 80M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 12, Weight = 60M },
                new Set { Reps = 15, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Upright Barbell Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Upright Barbell Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 50M },
                new Set { Reps = 18, Weight = 50M },
                new Set { Reps = 14, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 18, Weight = 8M },
                new Set { Reps = 16, Weight = 8M },
                new Set { Reps = 16, Weight = 8M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 03, 25))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 290M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 470M },
                new Set { Reps = 10, Weight = 560M },
                new Set { Reps = 10, Weight = 470M },
                new Set { Reps = 10, Weight = 360M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Sled Calf Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Sled Calf Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 380M },
                new Set { Reps = 18, Weight = 290M },
                new Set { Reps = 18, Weight = 290M },
                new Set { Reps = 15, Weight = 290M },
                new Set { Reps = 15, Weight = 290M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Prone Leg Curl", Exercise = context.Exercises.Single(x => x.Name.Equals("Prone Leg Curl")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 65M },
                new Set { Reps = 12, Weight = 65M },
                new Set { Reps = 12, Weight = 65M },
                new Set { Reps = 10, Weight = 65M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Glute Sled", Exercise = context.Exercises.Single(x => x.Name.Equals("Glute Sled")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 90M },
                new Set { Reps = 90, Weight = 90M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Walking Lunges", Exercise = context.Exercises.Single(x => x.Name.Equals("Walking Lunges")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 03, 27))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 9, Weight = 50M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 03, 29))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Flat Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Flat Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 8, Weight = 185M },
                new Set { Reps = 7, Weight = 225M },
                new Set { Reps = 5, Weight = 255M },
                new Set { Reps = 6, Weight = 225M },
                new Set { Reps = 4, Weight = 225M },
                new Set { Reps = 10, Weight = 185M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Decline Hammer Strength Chest Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Decline Hammer Strength Chest Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 186M },
                new Set { Reps = 10, Weight = 206M },
                new Set { Reps = 10, Weight = 226M },
                new Set { Reps = 15, Weight = 186M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 22.5M },
                new Set { Reps = 20, Weight = 27.5M },
                new Set { Reps = 14, Weight = 32.5M },
                new Set { Reps = 10, Weight = 37.5M },
                new Set { Reps = 18, Weight = 27.5M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 8, Weight = 85M },
                new Set { Reps = 5, Weight = 100M },
                new Set { Reps = 11, Weight = 60M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 04, 14))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 42.5M },
                new Set { Reps = 16, Weight = 50M },
                new Set { Reps = 12, Weight = 60M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 7, Weight = 80M },
                new Set { Reps = 9, Weight = 70M },
                new Set { Reps = 10, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 8, Weight = 80M },
                new Set { Reps = 12, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Upright Barbell Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Upright Barbell Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 13, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Wide Grip Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Wide Grip Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 120M },
                new Set { Reps = 10, Weight = 140M },
                new Set { Reps = 8, Weight = 160M },
                new Set { Reps = 8, Weight = 180M },
                new Set { Reps = 12, Weight = 120M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Upright Barbell Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Upright Barbell Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 60M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 04, 15))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Flat Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Flat Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 8, Weight = 185M },
                new Set { Reps = 7, Weight = 225M },
                new Set { Reps = 5, Weight = 255M },
                new Set { Reps = 6, Weight = 225M },
                new Set { Reps = 4, Weight = 225M },
                new Set { Reps = 10, Weight = 185M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Decline Hammer Strength Chest Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Decline Hammer Strength Chest Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 186M },
                new Set { Reps = 10, Weight = 206M },
                new Set { Reps = 10, Weight = 226M },
                new Set { Reps = 15, Weight = 186M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 22.5M },
                new Set { Reps = 20, Weight = 27.5M },
                new Set { Reps = 14, Weight = 32.5M },
                new Set { Reps = 10, Weight = 37.5M },
                new Set { Reps = 18, Weight = 27.5M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 8, Weight = 85M },
                new Set { Reps = 5, Weight = 100M },
                new Set { Reps = 11, Weight = 60M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 04, 19))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 42.5M },
                new Set { Reps = 16, Weight = 50M },
                new Set { Reps = 12, Weight = 60M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 7, Weight = 80M },
                new Set { Reps = 9, Weight = 70M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 13, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 10, Weight = 80M },
                new Set { Reps = 12, Weight = 70M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Upright Barbell Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Upright Barbell Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 12, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Wide Grip Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Wide Grip Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 120M },
                new Set { Reps = 10, Weight = 140M },
                new Set { Reps = 8, Weight = 160M },
                new Set { Reps = 8, Weight = 180M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 04, 26))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Flat Dumbbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Flat Dumbbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 130M },
                new Set { Reps = 8, Weight = 160M },
                new Set { Reps = 8, Weight = 180M },
                new Set { Reps = 8, Weight = 200M },
                new Set { Reps = 4, Weight = 220M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Decline Hammer Strength Chest Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Decline Hammer Strength Chest Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 186M },
                new Set { Reps = 10, Weight = 206M },
                new Set { Reps = 10, Weight = 226M },
                new Set { Reps = 15, Weight = 186M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 22.5M },
                new Set { Reps = 20, Weight = 27.5M },
                new Set { Reps = 14, Weight = 32.5M },
                new Set { Reps = 12, Weight = 32.5M },
                new Set { Reps = 10, Weight = 32.5M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 8, Weight = 85M },
                new Set { Reps = 5, Weight = 100M },
                new Set { Reps = 15, Weight = 60M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 04, 28))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Hammer Strength Shoulder Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Hammer Strength Shoulder Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 100M },
                new Set { Reps = 10, Weight = 190M },
                new Set { Reps = 7, Weight = 230M },
                new Set { Reps = 2, Weight = 250M },
                new Set { Reps = 8, Weight = 190M },
                new Set { Reps = 6, Weight = 190M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Plate Raises", Exercise = context.Exercises.Single(x => x.Name.Equals("Plate Raises")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 25M },
                new Set { Reps = 12, Weight = 35M },
                new Set { Reps = 12, Weight = 45M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Single Arm Cable Triceps Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Single Arm Cable Triceps Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 20M },
                new Set { Reps = 15, Weight = 25M },
                new Set { Reps = 10, Weight = 30M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Lateral Raise", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Lateral Raise")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 15M },
                new Set { Reps = 12, Weight = 20M },
                new Set { Reps = 5, Weight = 25M },
                new Set { Reps = 10, Weight = 20M },
                new Set { Reps = 12, Weight = 15M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Single Arm Cable Triceps Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Single Arm Cable Triceps Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 20M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 04, 29))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 42.5M },
                new Set { Reps = 16, Weight = 50M },
                new Set { Reps = 12, Weight = 60M },
                new Set { Reps = 9, Weight = 70M },
                new Set { Reps = 7, Weight = 80M },
                new Set { Reps = 9, Weight = 70M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 14, Weight = 42.5M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 18, Weight = 8M },
                new Set { Reps = 18, Weight = 8M },
                new Set { Reps = 18, Weight = 8M },
                new Set { Reps = 18, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Wide Grip Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Wide Grip Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 120M },
                new Set { Reps = 12, Weight = 140M },
                new Set { Reps = 10, Weight = 160M },
                new Set { Reps = 6, Weight = 180M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 10, Weight = 80M },
                new Set { Reps = 15, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Upright Barbell Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Upright Barbell Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 12, Weight = 60M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 05, 02))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Flat Dumbbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Flat Dumbbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 130M },
                new Set { Reps = 8, Weight = 160M },
                new Set { Reps = 8, Weight = 180M },
                new Set { Reps = 8, Weight = 200M },
                new Set { Reps = 4, Weight = 220M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Decline Hammer Strength Chest Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Decline Hammer Strength Chest Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 186M },
                new Set { Reps = 10, Weight = 206M },
                new Set { Reps = 10, Weight = 226M },
                new Set { Reps = 15, Weight = 186M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 22.5M },
                new Set { Reps = 20, Weight = 27.5M },
                new Set { Reps = 14, Weight = 32.5M },
                new Set { Reps = 12, Weight = 32.5M },
                new Set { Reps = 10, Weight = 32.5M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 8, Weight = 85M },
                new Set { Reps = 6, Weight = 100M },
                new Set { Reps = 12, Weight = 50M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 05, 13))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Flat Dumbbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Flat Dumbbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 130M },
                new Set { Reps = 8, Weight = 160M },
                new Set { Reps = 8, Weight = 180M },
                new Set { Reps = 8, Weight = 200M },
                new Set { Reps = 4, Weight = 220M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Decline Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Decline Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 8, Weight = 185M },
                new Set { Reps = 6, Weight = 205M },
                new Set { Reps = 4, Weight = 225M },
                new Set { Reps = 7, Weight = 185M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 22.5M },
                new Set { Reps = 16, Weight = 27.5M },
                new Set { Reps = 16, Weight = 32.5M },
                new Set { Reps = 15, Weight = 32.5M },
                new Set { Reps = 12, Weight = 32.5M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 8, Weight = 85M },
                new Set { Reps = 12, Weight = 50M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 05, 14))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 50M },
                new Set { Reps = 14, Weight = 60M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 7, Weight = 80M },
                new Set { Reps = 9, Weight = 70M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 12, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 18, Weight = 8M },
                new Set { Reps = 18, Weight = 8M },
                new Set { Reps = 18, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Dumbbell Lat Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Dumbbell Lat Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 10, Weight = 80M },
                new Set { Reps = 7, Weight = 90M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 10, Weight = 80M },
                new Set { Reps = 15, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Upright Barbell Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Upright Barbell Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 9, Weight = 70M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 05, 17))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Hammer Strength Shoulder Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Hammer Strength Shoulder Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 100M },
                new Set { Reps = 10, Weight = 190M },
                new Set { Reps = 7, Weight = 230M },
                new Set { Reps = 2, Weight = 250M },
                new Set { Reps = 10, Weight = 190M },
                new Set { Reps = 7, Weight = 190M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Plate Raises", Exercise = context.Exercises.Single(x => x.Name.Equals("Plate Raises")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 25M },
                new Set { Reps = 12, Weight = 35M },
                new Set { Reps = 12, Weight = 45M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Dumbbell Lateral Delt Raise", Exercise = context.Exercises.Single(x => x.Name.Equals("Dumbbell Lateral Delt Raise")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 15M },
                new Set { Reps = 12, Weight = 20M },
                new Set { Reps = 10, Weight = 25M },
                new Set { Reps = 12, Weight = 20M },
                new Set { Reps = 15, Weight = 15M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 14, Weight = 70M },
                new Set { Reps = 10, Weight = 85M },
                new Set { Reps = 7, Weight = 100M },
                new Set { Reps = 20, Weight = 50M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 05, 18))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 290M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 470M },
                new Set { Reps = 10, Weight = 560M },
                new Set { Reps = 10, Weight = 470M },
                new Set { Reps = 10, Weight = 360M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Sled Calf Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Sled Calf Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 380M },
                new Set { Reps = 18, Weight = 290M },
                new Set { Reps = 18, Weight = 290M },
                new Set { Reps = 15, Weight = 290M },
                new Set { Reps = 15, Weight = 290M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Prone Leg Curl", Exercise = context.Exercises.Single(x => x.Name.Equals("Prone Leg Curl")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 12, Weight = 70M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Glute Sled", Exercise = context.Exercises.Single(x => x.Name.Equals("Glute Sled")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 90M },
                new Set { Reps = 12, Weight = 90M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Prone Leg Curl", Exercise = context.Exercises.Single(x => x.Name.Equals("Prone Leg Curl")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 9, Weight = 70M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 05, 19))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Flat Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Flat Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 8, Weight = 185M },
                new Set { Reps = 7, Weight = 225M },
                new Set { Reps = 3, Weight = 255M },
                new Set { Reps = 10, Weight = 185M },
                new Set { Reps = 8, Weight = 185M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Incline Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Incline Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 3, Weight = 185M },
                new Set { Reps = 8, Weight = 155M },
                new Set { Reps = 5, Weight = 155M },
                new Set { Reps = 8, Weight = 135M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 22.5M },
                new Set { Reps = 20, Weight = 27.5M },
                new Set { Reps = 14, Weight = 32.5M },
                new Set { Reps = 12, Weight = 37.5M },
                new Set { Reps = 18, Weight = 27.5M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Single Arm Cable Triceps Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Single Arm Cable Triceps Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 15M },
                new Set { Reps = 20, Weight = 20M },
                new Set { Reps = 12, Weight = 25M },
                new Set { Reps = 14, Weight = 15M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 05, 25))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Flat Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Flat Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 185M },
                new Set { Reps = 7, Weight = 225M },
                new Set { Reps = 4, Weight = 255M },
                new Set { Reps = 7, Weight = 225M },
                new Set { Reps = 8, Weight = 205M },
                new Set { Reps = 10, Weight = 185M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Incline Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Incline Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 4, Weight = 185M },
                new Set { Reps = 6, Weight = 155M },
                new Set { Reps = 5, Weight = 155M },
                new Set { Reps = 8, Weight = 135M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Parallel Bar Triceps Dip", Exercise = context.Exercises.Single(x => x.Name.Equals("Parallel Bar Triceps Dip")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 16, Weight = 209M },
                new Set { Reps = 14, Weight = 209M },
                new Set { Reps = 12, Weight = 209M },
                new Set { Reps = 10, Weight = 209M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 22.5M },
                new Set { Reps = 20, Weight = 27.5M },
                new Set { Reps = 14, Weight = 32.5M },
                new Set { Reps = 12, Weight = 37.5M },
                new Set { Reps = 15, Weight = 27.5M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 05, 27))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 50M },
                new Set { Reps = 14, Weight = 60M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 7, Weight = 80M },
                new Set { Reps = 12, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 18, Weight = 8M },
                new Set { Reps = 18, Weight = 8M },
                new Set { Reps = 18, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Dumbbell Lat Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Dumbbell Lat Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 10, Weight = 80M },
                new Set { Reps = 7, Weight = 90M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 10, Weight = 80M },
                new Set { Reps = 15, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Upright Barbell Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Upright Barbell Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 12, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Curl", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Curl")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 9, Weight = 50M },
                new Set { Reps = 8, Weight = 50M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 05, 30))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Hammer Strength Shoulder Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Hammer Strength Shoulder Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 16, Weight = 100M },
                new Set { Reps = 10, Weight = 190M },
                new Set { Reps = 7, Weight = 230M },
                new Set { Reps = 5, Weight = 250M },
                new Set { Reps = 10, Weight = 190M },
                new Set { Reps = 5, Weight = 190M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Dumbbell Lateral Delt Raise", Exercise = context.Exercises.Single(x => x.Name.Equals("Dumbbell Lateral Delt Raise")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 15M },
                new Set { Reps = 15, Weight = 20M },
                new Set { Reps = 10, Weight = 25M },
                new Set { Reps = 12, Weight = 20M },
                new Set { Reps = 18, Weight = 15M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Plate Raises", Exercise = context.Exercises.Single(x => x.Name.Equals("Plate Raises")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 25M },
                new Set { Reps = 12, Weight = 35M },
                new Set { Reps = 12, Weight = 45M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 16, Weight = 70M },
                new Set { Reps = 12, Weight = 85M },
                new Set { Reps = 7, Weight = 100M },
                new Set { Reps = 20, Weight = 50M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 06, 01))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Flat Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Flat Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 185M },
                new Set { Reps = 7, Weight = 225M },
                new Set { Reps = 3, Weight = 255M },
                new Set { Reps = 7, Weight = 225M },
                new Set { Reps = 8, Weight = 205M },
                new Set { Reps = 8, Weight = 185M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Incline Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Incline Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 4, Weight = 185M },
                new Set { Reps = 6, Weight = 155M },
                new Set { Reps = 5, Weight = 155M },
                new Set { Reps = 5, Weight = 135M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 22.5M },
                new Set { Reps = 20, Weight = 27.5M },
                new Set { Reps = 14, Weight = 32.5M },
                new Set { Reps = 11, Weight = 37.5M },
                new Set { Reps = 15, Weight = 27.5M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 15, Weight = 70M },
                new Set { Reps = 11, Weight = 85M },
                new Set { Reps = 6, Weight = 100M },
                new Set { Reps = 20, Weight = 50M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 06, 03))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 42.5M },
                new Set { Reps = 20, Weight = 50M },
                new Set { Reps = 14, Weight = 60M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 8, Weight = 80M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 18, Weight = 8M },
                new Set { Reps = 18, Weight = 8M },
                new Set { Reps = 18, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Dumbbell Lat Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Dumbbell Lat Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 10, Weight = 80M },
                new Set { Reps = 7, Weight = 90M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 10, Weight = 80M },
                new Set { Reps = 15, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Upright Barbell Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Upright Barbell Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 16, Weight = 60M },
                new Set { Reps = 14, Weight = 60M },
                new Set { Reps = 12, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 18, Weight = 8M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 06, 04))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 290M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 470M },
                new Set { Reps = 10, Weight = 560M },
                new Set { Reps = 10, Weight = 470M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Sled Calf Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Sled Calf Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 380M },
                new Set { Reps = 18, Weight = 290M },
                new Set { Reps = 18, Weight = 290M },
                new Set { Reps = 16, Weight = 290M },
                new Set { Reps = 15, Weight = 290M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Prone Leg Curl", Exercise = context.Exercises.Single(x => x.Name.Equals("Prone Leg Curl")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 65M },
                new Set { Reps = 10, Weight = 65M },
                new Set { Reps = 10, Weight = 65M },
                new Set { Reps = 10, Weight = 65M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Glute Sled", Exercise = context.Exercises.Single(x => x.Name.Equals("Glute Sled")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 90M },
                new Set { Reps = 12, Weight = 90M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 380M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Sled Calf Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Sled Calf Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 200M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 06, 08))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 42.5M },
                new Set { Reps = 18, Weight = 50M },
                new Set { Reps = 14, Weight = 60M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 8, Weight = 80M },
                new Set { Reps = 18, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 18, Weight = 8M },
                new Set { Reps = 18, Weight = 8M },
                new Set { Reps = 18, Weight = 8M },
                new Set { Reps = 18, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Dumbbell Lat Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Dumbbell Lat Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 65M },
                new Set { Reps = 10, Weight = 75M },
                new Set { Reps = 10, Weight = 85M },
                new Set { Reps = 7, Weight = 95M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 10, Weight = 80M },
                new Set { Reps = 15, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Upright Barbell Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Upright Barbell Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 16, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 14, Weight = 60M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 06, 09))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Flat Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Flat Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 185M },
                new Set { Reps = 7, Weight = 225M },
                new Set { Reps = 3, Weight = 255M },
                new Set { Reps = 7, Weight = 225M },
                new Set { Reps = 8, Weight = 205M },
                new Set { Reps = 8, Weight = 185M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Incline Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Incline Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 4, Weight = 185M },
                new Set { Reps = 7, Weight = 155M },
                new Set { Reps = 5, Weight = 155M },
                new Set { Reps = 7, Weight = 135M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 18, Weight = 25M },
                new Set { Reps = 15, Weight = 30M },
                new Set { Reps = 10, Weight = 35M },
                new Set { Reps = 17, Weight = 25M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 15, Weight = 70M },
                new Set { Reps = 11, Weight = 85M },
                new Set { Reps = 6, Weight = 100M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 06, 17))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Flat Dumbbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Flat Dumbbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 130M },
                new Set { Reps = 8, Weight = 160M },
                new Set { Reps = 8, Weight = 180M },
                new Set { Reps = 8, Weight = 200M },
                new Set { Reps = 4, Weight = 220M },
                new Set { Reps = 10, Weight = 140M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Incline Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Incline Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 4, Weight = 185M },
                new Set { Reps = 7, Weight = 155M },
                new Set { Reps = 5, Weight = 155M },
                new Set { Reps = 8, Weight = 135M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 14, Weight = 70M },
                new Set { Reps = 10, Weight = 85M },
                new Set { Reps = 7, Weight = 100M },
                new Set { Reps = 12, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 22.5M },
                new Set { Reps = 20, Weight = 27.5M },
                new Set { Reps = 14, Weight = 32.5M },
                new Set { Reps = 10, Weight = 37.5M },
                new Set { Reps = 10, Weight = 32.5M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 06, 21))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Flat Dumbbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Flat Dumbbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 140M },
                new Set { Reps = 8, Weight = 170M },
                new Set { Reps = 8, Weight = 190M },
                new Set { Reps = 8, Weight = 200M },
                new Set { Reps = 4, Weight = 220M },
                new Set { Reps = 10, Weight = 140M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 22.5M },
                new Set { Reps = 20, Weight = 27.5M },
                new Set { Reps = 14, Weight = 32.5M },
                new Set { Reps = 13, Weight = 37.5M },
                new Set { Reps = 12, Weight = 32.5M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Incline Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Incline Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 5, Weight = 185M },
                new Set { Reps = 7, Weight = 155M },
                new Set { Reps = 5, Weight = 155M },
                new Set { Reps = 6, Weight = 135M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 14, Weight = 70M },
                new Set { Reps = 10, Weight = 85M },
                new Set { Reps = 7, Weight = 100M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Incline Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Incline Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 5, Weight = 135M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 19, Weight = 50M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 06, 22))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 42.5M },
                new Set { Reps = 18, Weight = 50M },
                new Set { Reps = 14, Weight = 60M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 8, Weight = 80M },
                new Set { Reps = 18, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 18, Weight = 8M },
                new Set { Reps = 18, Weight = 8M },
                new Set { Reps = 18, Weight = 8M },
                new Set { Reps = 18, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Wide Grip Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Wide Grip Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 120M },
                new Set { Reps = 12, Weight = 140M },
                new Set { Reps = 10, Weight = 160M },
                new Set { Reps = 8, Weight = 180M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Upright Barbell Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Upright Barbell Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 16, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 14, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 10, Weight = 80M },
                new Set { Reps = 15, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Curl", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Curl")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 50M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 06, 29))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 42.5M },
                new Set { Reps = 18, Weight = 50M },
                new Set { Reps = 14, Weight = 60M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 8, Weight = 80M },
                new Set { Reps = 16, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 18, Weight = 8M },
                new Set { Reps = 18, Weight = 8M },
                new Set { Reps = 18, Weight = 8M },
                new Set { Reps = 18, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Upright Barbell Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Upright Barbell Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 18, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Wide Grip Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Wide Grip Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 120M },
                new Set { Reps = 12, Weight = 140M },
                new Set { Reps = 10, Weight = 160M },
                new Set { Reps = 8, Weight = 180M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 10, Weight = 80M },
                new Set { Reps = 15, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Curl", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Curl")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 50M },
                new Set { Reps = 12, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 18, Weight = 8M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 06, 30))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Flat Dumbbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Flat Dumbbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 140M },
                new Set { Reps = 8, Weight = 160M },
                new Set { Reps = 8, Weight = 180M },
                new Set { Reps = 8, Weight = 200M },
                new Set { Reps = 4, Weight = 220M },
                new Set { Reps = 10, Weight = 150M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 22.5M },
                new Set { Reps = 20, Weight = 27.5M },
                new Set { Reps = 14, Weight = 32.5M },
                new Set { Reps = 13, Weight = 37.5M },
                new Set { Reps = 12, Weight = 32.5M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Incline Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Incline Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 5, Weight = 185M },
                new Set { Reps = 8, Weight = 155M },
                new Set { Reps = 5, Weight = 155M },
                new Set { Reps = 6, Weight = 135M },
                new Set { Reps = 6, Weight = 135M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 15, Weight = 70M },
                new Set { Reps = 12, Weight = 85M },
                new Set { Reps = 7, Weight = 100M },
                new Set { Reps = 19, Weight = 50M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 07, 01))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Hammer Strength Shoulder Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Hammer Strength Shoulder Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 16, Weight = 100M },
                new Set { Reps = 10, Weight = 190M },
                new Set { Reps = 6, Weight = 230M },
                new Set { Reps = 2, Weight = 250M },
                new Set { Reps = 10, Weight = 190M },
                new Set { Reps = 5, Weight = 190M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Dumbbell Lateral Delt Raise", Exercise = context.Exercises.Single(x => x.Name.Equals("Dumbbell Lateral Delt Raise")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 15M },
                new Set { Reps = 14, Weight = 20M },
                new Set { Reps = 10, Weight = 25M },
                new Set { Reps = 12, Weight = 20M },
                new Set { Reps = 18, Weight = 15M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Plate Raises", Exercise = context.Exercises.Single(x => x.Name.Equals("Plate Raises")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 25M },
                new Set { Reps = 12, Weight = 35M },
                new Set { Reps = 12, Weight = 45M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Single Arm Cable Triceps Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Single Arm Cable Triceps Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 20M },
                new Set { Reps = 15, Weight = 25M },
                new Set { Reps = 10, Weight = 30M },
                new Set { Reps = 20, Weight = 20M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 07, 03))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Flat Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Flat Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 175M },
                new Set { Reps = 10, Weight = 175M },
                new Set { Reps = 10, Weight = 175M },
                new Set { Reps = 9, Weight = 175M },
                new Set { Reps = 10, Weight = 165M },
                new Set { Reps = 10, Weight = 165M },
                new Set { Reps = 9, Weight = 165M },
                new Set { Reps = 9, Weight = 155M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 42.5M },
                new Set { Reps = 10, Weight = 42.5M },
                new Set { Reps = 10, Weight = 42.5M },
                new Set { Reps = 10, Weight = 42.5M },
                new Set { Reps = 10, Weight = 42.5M },
                new Set { Reps = 10, Weight = 42.5M },
                new Set { Reps = 10, Weight = 42.5M },
                new Set { Reps = 10, Weight = 42.5M },
                new Set { Reps = 10, Weight = 42.5M },
                new Set { Reps = 10, Weight = 42.5M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 18, Weight = 8M },
                new Set { Reps = 18, Weight = 8M },
                new Set { Reps = 18, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Incline Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Incline Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 8, Weight = 135M },
                new Set { Reps = 8, Weight = 135M },
                new Set { Reps = 5, Weight = 135M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Sled Calf Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Sled Calf Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 18, Weight = 270M },
                new Set { Reps = 16, Weight = 270M },
                new Set { Reps = 16, Weight = 270M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 07, 06))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 120M },
                new Set { Reps = 12, Weight = 140M },
                new Set { Reps = 10, Weight = 160M },
                new Set { Reps = 8, Weight = 180M },
                new Set { Reps = 18, Weight = 100M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Close Grip Pulldowns", Exercise = context.Exercises.Single(x => x.Name.Equals("Close Grip Pulldowns")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 8, Weight = 130M },
                new Set { Reps = 8, Weight = 130M },
                new Set { Reps = 8, Weight = 130M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Dumbbell Lat Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Dumbbell Lat Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 8, Weight = 70M },
                new Set { Reps = 8, Weight = 80M },
                new Set { Reps = 8, Weight = 90M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 18, Weight = 8M },
                new Set { Reps = 18, Weight = 8M },
                new Set { Reps = 18, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 18, Weight = 50M },
                new Set { Reps = 14, Weight = 60M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 8, Weight = 80M },
                new Set { Reps = 16, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Upright Barbell Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Upright Barbell Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 18, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 07, 14))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 42.5M },
                new Set { Reps = 18, Weight = 50M },
                new Set { Reps = 14, Weight = 60M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 8, Weight = 80M },
                new Set { Reps = 16, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 18, Weight = 8M },
                new Set { Reps = 18, Weight = 8M },
                new Set { Reps = 18, Weight = 8M },
                new Set { Reps = 18, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Upright Barbell Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Upright Barbell Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 18, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 120M },
                new Set { Reps = 12, Weight = 140M },
                new Set { Reps = 10, Weight = 160M },
                new Set { Reps = 8, Weight = 180M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 10, Weight = 80M },
                new Set { Reps = 15, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Curl", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Curl")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 50M },
                new Set { Reps = 12, Weight = 50M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 07, 15))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Flat Dumbbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Flat Dumbbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 140M },
                new Set { Reps = 8, Weight = 160M },
                new Set { Reps = 8, Weight = 180M },
                new Set { Reps = 8, Weight = 200M },
                new Set { Reps = 6, Weight = 220M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Incline Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Incline Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 6, Weight = 185M },
                new Set { Reps = 5, Weight = 185M },
                new Set { Reps = 8, Weight = 155M },
                new Set { Reps = 6, Weight = 155M },
                new Set { Reps = 7, Weight = 135M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 22.5M },
                new Set { Reps = 20, Weight = 27.5M },
                new Set { Reps = 15, Weight = 32.5M },
                new Set { Reps = 14, Weight = 37.5M },
                new Set { Reps = 13, Weight = 32.5M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 13, Weight = 70M },
                new Set { Reps = 11, Weight = 85M },
                new Set { Reps = 6, Weight = 100M },
                new Set { Reps = 19, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Incline Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Incline Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 6, Weight = 135M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 07, 28))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 42.5M },
                new Set { Reps = 10, Weight = 42.5M },
                new Set { Reps = 10, Weight = 42.5M },
                new Set { Reps = 10, Weight = 42.5M },
                new Set { Reps = 10, Weight = 42.5M },
                new Set { Reps = 10, Weight = 42.5M },
                new Set { Reps = 10, Weight = 42.5M },
                new Set { Reps = 10, Weight = 42.5M },
                new Set { Reps = 10, Weight = 42.5M },
                new Set { Reps = 10, Weight = 42.5M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Incline Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Incline Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 8, Weight = 135M },
                new Set { Reps = 10, Weight = 115M },
                new Set { Reps = 10, Weight = 115M },
                new Set { Reps = 10, Weight = 115M },
                new Set { Reps = 10, Weight = 115M },
                new Set { Reps = 10, Weight = 115M },
                new Set { Reps = 10, Weight = 115M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Parallel Bar Triceps Dip", Exercise = context.Exercises.Single(x => x.Name.Equals("Parallel Bar Triceps Dip")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 209M },
                new Set { Reps = 15, Weight = 209M },
                new Set { Reps = 15, Weight = 209M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 07, 29))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Sled Calf Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Sled Calf Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 270M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Prone Leg Curl", Exercise = context.Exercises.Single(x => x.Name.Equals("Prone Leg Curl")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 65M },
                new Set { Reps = 14, Weight = 65M },
                new Set { Reps = 15, Weight = 65M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Glute Sled", Exercise = context.Exercises.Single(x => x.Name.Equals("Glute Sled")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 110M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 08, 04))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 10, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Incline Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Incline Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Parallel Bar Triceps Dip", Exercise = context.Exercises.Single(x => x.Name.Equals("Parallel Bar Triceps Dip")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 209M },
                new Set { Reps = 15, Weight = 209M },
                new Set { Reps = 15, Weight = 209M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Incline Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Incline Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 9, Weight = 125M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 08, 11))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 10, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Incline Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Incline Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 9, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 8, Weight = 125M },
                new Set { Reps = 9, Weight = 125M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 15, Weight = 70M },
                new Set { Reps = 9, Weight = 85M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 08, 14))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 10, Weight = 50M },
                new Set { Reps = 10, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Incline Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Incline Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 8, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 9, Weight = 125M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 15, Weight = 70M },
                new Set { Reps = 9, Weight = 85M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 08, 15))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Sled Calf Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Sled Calf Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Prone Leg Curl", Exercise = context.Exercises.Single(x => x.Name.Equals("Prone Leg Curl")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 65M },
                new Set { Reps = 14, Weight = 65M },
                new Set { Reps = 15, Weight = 65M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Glute Sled", Exercise = context.Exercises.Single(x => x.Name.Equals("Glute Sled")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 110M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 08, 19))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 55M },
                new Set { Reps = 10, Weight = 55M },
                new Set { Reps = 10, Weight = 55M },
                new Set { Reps = 10, Weight = 55M },
                new Set { Reps = 10, Weight = 55M },
                new Set { Reps = 10, Weight = 55M },
                new Set { Reps = 10, Weight = 55M },
                new Set { Reps = 10, Weight = 55M },
                new Set { Reps = 10, Weight = 55M },
                new Set { Reps = 10, Weight = 55M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Incline Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Incline Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 15, Weight = 70M },
                new Set { Reps = 9, Weight = 85M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 8M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 08, 20))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Sled Calf Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Sled Calf Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Prone Leg Curl", Exercise = context.Exercises.Single(x => x.Name.Equals("Prone Leg Curl")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 65M },
                new Set { Reps = 15, Weight = 65M },
                new Set { Reps = 15, Weight = 65M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Glute Sled", Exercise = context.Exercises.Single(x => x.Name.Equals("Glute Sled")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 110M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 08, 24))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Incline Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Incline Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Parallel Bar Triceps Dip", Exercise = context.Exercises.Single(x => x.Name.Equals("Parallel Bar Triceps Dip")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 17, Weight = 207M },
                new Set { Reps = 15, Weight = 207M },
                new Set { Reps = 13, Weight = 207M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 08, 25))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Arnold Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Arnold Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Sled Calf Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Sled Calf Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Upright Barbell Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Upright Barbell Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 18, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 12, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 15, Weight = 70M },
                new Set { Reps = 9, Weight = 85M },
                new Set { Reps = 20, Weight = 50M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 08, 31))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
            };  
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Incline Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Incline Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 9, Weight = 125M },
                new Set { Reps = 7, Weight = 125M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 27.5M },
                new Set { Reps = 20, Weight = 27.5M },
                new Set { Reps = 18, Weight = 27.5M },
                new Set { Reps = 18, Weight = 27.5M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 09, 01))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 410M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Sled Calf Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Sled Calf Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Prone Leg Curl", Exercise = context.Exercises.Single(x => x.Name.Equals("Prone Leg Curl")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 65M },
                new Set { Reps = 15, Weight = 65M },
                new Set { Reps = 15, Weight = 65M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Glute Sled", Exercise = context.Exercises.Single(x => x.Name.Equals("Glute Sled")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 110M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 09, 02))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Arnold Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Arnold Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Sled Calf Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Sled Calf Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Upright Barbell Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Upright Barbell Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 18, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 15, Weight = 70M },
                new Set { Reps = 10, Weight = 85M },
                new Set { Reps = 20, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Arnold Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Arnold Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 40M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 09, 08))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Incline Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Incline Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 27.5M },
                new Set { Reps = 20, Weight = 27.5M },
                new Set { Reps = 20, Weight = 27.5M },
                new Set { Reps = 20, Weight = 27.5M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 09, 09))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Arnold Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Arnold Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Sled Calf Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Sled Calf Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Upright Barbell Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Upright Barbell Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 18, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 18, Weight = 70M },
                new Set { Reps = 10, Weight = 85M },
                new Set { Reps = 20, Weight = 50M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 09, 10))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Sled Calf Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Sled Calf Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Glute Sled", Exercise = context.Exercises.Single(x => x.Name.Equals("Glute Sled")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 110M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 09, 13))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Incline Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Incline Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 27.5M },
                new Set { Reps = 18, Weight = 32.5M },
                new Set { Reps = 18, Weight = 32.5M },
                new Set { Reps = 15, Weight = 32.5M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 09, 14))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Sled Calf Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Sled Calf Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 320M },
                new Set { Reps = 12, Weight = 320M },
                new Set { Reps = 12, Weight = 320M },
                new Set { Reps = 12, Weight = 320M },
                new Set { Reps = 12, Weight = 320M },
                new Set { Reps = 12, Weight = 320M },
                new Set { Reps = 12, Weight = 320M },
                new Set { Reps = 12, Weight = 320M },
                new Set { Reps = 12, Weight = 320M },
                new Set { Reps = 12, Weight = 320M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Prone Leg Curl", Exercise = context.Exercises.Single(x => x.Name.Equals("Prone Leg Curl")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 65M },
                new Set { Reps = 15, Weight = 65M },
                new Set { Reps = 15, Weight = 65M },
                new Set { Reps = 10, Weight = 65M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Glute Sled", Exercise = context.Exercises.Single(x => x.Name.Equals("Glute Sled")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 110M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 09, 15))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Arnold Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Arnold Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 18, Weight = 70M },
                new Set { Reps = 12, Weight = 85M },
                new Set { Reps = 20, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Sled Calf Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Sled Calf Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 10, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Upright Barbell Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Upright Barbell Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 70M },
                new Set { Reps = 15, Weight = 70M },
                new Set { Reps = 15, Weight = 70M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 09, 23))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Incline Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Incline Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 27.5M },
                new Set { Reps = 18, Weight = 32.5M },
                new Set { Reps = 18, Weight = 32.5M },
                new Set { Reps = 15, Weight = 32.5M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 09, 26))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Arnold Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Arnold Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Upright Barbell Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Upright Barbell Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 70M },
                new Set { Reps = 15, Weight = 70M },
                new Set { Reps = 13, Weight = 70M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 10, Weight = 70M },
                new Set { Reps = 10, Weight = 70M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Plate Raises", Exercise = context.Exercises.Single(x => x.Name.Equals("Plate Raises")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 45M },
                new Set { Reps = 15, Weight = 35M },
                new Set { Reps = 15, Weight = 25M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 09, 28))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Sled Calf Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Sled Calf Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 340M },
                new Set { Reps = 10, Weight = 340M },
                new Set { Reps = 10, Weight = 340M },
                new Set { Reps = 10, Weight = 340M },
                new Set { Reps = 10, Weight = 340M },
                new Set { Reps = 10, Weight = 340M },
                new Set { Reps = 10, Weight = 340M },
                new Set { Reps = 10, Weight = 340M },
                new Set { Reps = 10, Weight = 340M },
                new Set { Reps = 10, Weight = 340M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Prone Leg Curl", Exercise = context.Exercises.Single(x => x.Name.Equals("Prone Leg Curl")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 65M },
                new Set { Reps = 15, Weight = 65M },
                new Set { Reps = 15, Weight = 65M },
                new Set { Reps = 10, Weight = 65M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Glute Sled", Exercise = context.Exercises.Single(x => x.Name.Equals("Glute Sled")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 110M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 09, 29))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Incline Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Incline Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
                new Set { Reps = 10, Weight = 125M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 27.5M },
                new Set { Reps = 18, Weight = 32.5M },
                new Set { Reps = 18, Weight = 32.5M },
                new Set { Reps = 15, Weight = 32.5M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 10, 06))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Incline Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Incline Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 130M },
                new Set { Reps = 10, Weight = 130M },
                new Set { Reps = 10, Weight = 130M },
                new Set { Reps = 10, Weight = 130M },
                new Set { Reps = 10, Weight = 130M },
                new Set { Reps = 10, Weight = 130M },
                new Set { Reps = 10, Weight = 130M },
                new Set { Reps = 10, Weight = 130M },
                new Set { Reps = 10, Weight = 130M },
                new Set { Reps = 10, Weight = 130M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 27.5M },
                new Set { Reps = 18, Weight = 32.5M },
                new Set { Reps = 18, Weight = 32.5M },
                new Set { Reps = 15, Weight = 32.5M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 10, 07))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Arnold Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Arnold Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Sled Calf Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Sled Calf Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 20, Weight = 70M },
                new Set { Reps = 15, Weight = 85M },
                new Set { Reps = 20, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Upright Barbell Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Upright Barbell Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 16, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Dumbbell Lateral Delt Raise", Exercise = context.Exercises.Single(x => x.Name.Equals("Dumbbell Lateral Delt Raise")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 15M },
                new Set { Reps = 12, Weight = 15M },
                new Set { Reps = 12, Weight = 15M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 10, 10))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Incline Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Incline Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 55M },
                new Set { Reps = 10, Weight = 55M },
                new Set { Reps = 10, Weight = 55M },
                new Set { Reps = 10, Weight = 55M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 27.5M },
                new Set { Reps = 18, Weight = 32.5M },
                new Set { Reps = 18, Weight = 32.5M },
                new Set { Reps = 15, Weight = 32.5M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 120M },
                new Set { Reps = 15, Weight = 120M },
                new Set { Reps = 15, Weight = 120M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 10, 11))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Sled Calf Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Sled Calf Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 340M },
                new Set { Reps = 10, Weight = 340M },
                new Set { Reps = 10, Weight = 340M },
                new Set { Reps = 10, Weight = 340M },
                new Set { Reps = 10, Weight = 340M },
                new Set { Reps = 10, Weight = 340M },
                new Set { Reps = 10, Weight = 340M },
                new Set { Reps = 10, Weight = 340M },
                new Set { Reps = 10, Weight = 340M },
                new Set { Reps = 10, Weight = 340M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Prone Leg Curl", Exercise = context.Exercises.Single(x => x.Name.Equals("Prone Leg Curl")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 65M },
                new Set { Reps = 15, Weight = 65M },
                new Set { Reps = 15, Weight = 65M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Glute Sled", Exercise = context.Exercises.Single(x => x.Name.Equals("Glute Sled")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 110M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 10, 12))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Arnold Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Arnold Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Sled Calf Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Sled Calf Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 20, Weight = 70M },
                new Set { Reps = 15, Weight = 85M },
                new Set { Reps = 20, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Upright Barbell Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Upright Barbell Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 18, Weight = 60M },
                new Set { Reps = 16, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Dumbbell Lateral Delt Raise", Exercise = context.Exercises.Single(x => x.Name.Equals("Dumbbell Lateral Delt Raise")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 15M },
                new Set { Reps = 12, Weight = 15M },
                new Set { Reps = 12, Weight = 15M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 10, 19))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Sled Calf Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Sled Calf Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 340M },
                new Set { Reps = 10, Weight = 340M },
                new Set { Reps = 10, Weight = 340M },
                new Set { Reps = 10, Weight = 340M },
                new Set { Reps = 10, Weight = 340M },
                new Set { Reps = 10, Weight = 340M },
                new Set { Reps = 10, Weight = 340M },
                new Set { Reps = 10, Weight = 340M },
                new Set { Reps = 10, Weight = 340M },
                new Set { Reps = 10, Weight = 340M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Prone Leg Curl", Exercise = context.Exercises.Single(x => x.Name.Equals("Prone Leg Curl")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 65M },
                new Set { Reps = 15, Weight = 65M },
                new Set { Reps = 15, Weight = 65M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Glute Sled", Exercise = context.Exercises.Single(x => x.Name.Equals("Glute Sled")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 110M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 10, 20))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Incline Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Incline Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 8, Weight = 135M },
                new Set { Reps = 9, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Parallel Bar Triceps Dip", Exercise = context.Exercises.Single(x => x.Name.Equals("Parallel Bar Triceps Dip")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 207M },
                new Set { Reps = 10, Weight = 207M },
                new Set { Reps = 10, Weight = 207M },
                new Set { Reps = 10, Weight = 207M },
                new Set { Reps = 10, Weight = 207M },
                new Set { Reps = 10, Weight = 207M },
                new Set { Reps = 10, Weight = 207M },
                new Set { Reps = 10, Weight = 207M },
                new Set { Reps = 10, Weight = 207M },
                new Set { Reps = 10, Weight = 207M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 27.5M },
                new Set { Reps = 18, Weight = 32.5M },
                new Set { Reps = 18, Weight = 32.5M },
                new Set { Reps = 15, Weight = 32.5M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 125M },
                new Set { Reps = 15, Weight = 125M },
                new Set { Reps = 15, Weight = 125M },
                new Set { Reps = 15, Weight = 125M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 10, 23))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Arnold Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Arnold Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Sled Calf Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Sled Calf Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 20, Weight = 70M },
                new Set { Reps = 15, Weight = 85M },
                new Set { Reps = 20, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Upright Barbell Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Upright Barbell Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 18, Weight = 60M },
                new Set { Reps = 16, Weight = 60M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 10, 25))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Upright Barbell Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Upright Barbell Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 50M },
                new Set { Reps = 20, Weight = 50M },
                new Set { Reps = 20, Weight = 50M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 10, 27))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Incline Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Incline Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 125M },
                new Set { Reps = 15, Weight = 125M },
                new Set { Reps = 15, Weight = 125M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Parallel Bar Triceps Dip", Exercise = context.Exercises.Single(x => x.Name.Equals("Parallel Bar Triceps Dip")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 207M },
                new Set { Reps = 10, Weight = 207M },
                new Set { Reps = 10, Weight = 207M },
                new Set { Reps = 10, Weight = 207M },
                new Set { Reps = 10, Weight = 207M },
                new Set { Reps = 10, Weight = 207M },
                new Set { Reps = 10, Weight = 207M },
                new Set { Reps = 10, Weight = 207M },
                new Set { Reps = 10, Weight = 207M },
                new Set { Reps = 10, Weight = 207M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 27.5M },
                new Set { Reps = 18, Weight = 32.5M },
                new Set { Reps = 18, Weight = 32.5M },
                new Set { Reps = 13, Weight = 32.5M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Single Arm Cable Triceps Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Single Arm Cable Triceps Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 20M },
                new Set { Reps = 18, Weight = 20M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 11, 04))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Incline Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Incline Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 9, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Iso Lateral Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Iso Lateral Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
                new Set { Reps = 15, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 27.5M },
                new Set { Reps = 18, Weight = 32.5M },
                new Set { Reps = 18, Weight = 32.5M },
                new Set { Reps = 13, Weight = 32.5M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 11, 05))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
                new Set { Reps = 10, Weight = 360M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Sled Calf Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Sled Calf Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Glute Sled", Exercise = context.Exercises.Single(x => x.Name.Equals("Glute Sled")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 110M },
                new Set { Reps = 12, Weight = 110M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Prone Leg Curl", Exercise = context.Exercises.Single(x => x.Name.Equals("Prone Leg Curl")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 40M },
                new Set { Reps = 15, Weight = 40M },
                new Set { Reps = 15, Weight = 40M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 11, 07))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Arnold Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Arnold Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Sled Calf Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Sled Calf Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Upright Barbell Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Upright Barbell Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 18, Weight = 60M },
                new Set { Reps = 16, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Lateral Raise", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Lateral Raise")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 10M },
                new Set { Reps = 12, Weight = 10M },
                new Set { Reps = 12, Weight = 10M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Dumbbell Lateral Delt Raise", Exercise = context.Exercises.Single(x => x.Name.Equals("Dumbbell Lateral Delt Raise")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 10M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Plate Raises", Exercise = context.Exercises.Single(x => x.Name.Equals("Plate Raises")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 25M },
                new Set { Reps = 12, Weight = 35M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 11, 09))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Incline Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Incline Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 32.5M },
                new Set { Reps = 12, Weight = 32.5M },
                new Set { Reps = 12, Weight = 32.5M },
                new Set { Reps = 12, Weight = 32.5M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 65M },
                new Set { Reps = 12, Weight = 65M },
                new Set { Reps = 12, Weight = 65M },
                new Set { Reps = 12, Weight = 65M },
                new Set { Reps = 12, Weight = 65M },
                new Set { Reps = 12, Weight = 65M },
                new Set { Reps = 12, Weight = 65M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
                new Set { Reps = 20, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 32.5M },
                new Set { Reps = 12, Weight = 32.5M },
                new Set { Reps = 12, Weight = 32.5M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 12, Weight = 70M },
                new Set { Reps = 12, Weight = 70M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 11, 13))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Sled Calf Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Sled Calf Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Glute Sled", Exercise = context.Exercises.Single(x => x.Name.Equals("Glute Sled")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 115M },
                new Set { Reps = 12, Weight = 115M },
                new Set { Reps = 12, Weight = 115M },
                new Set { Reps = 12, Weight = 115M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Prone Leg Curl", Exercise = context.Exercises.Single(x => x.Name.Equals("Prone Leg Curl")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 50M },
                new Set { Reps = 12, Weight = 50M },
                new Set { Reps = 12, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Prone Leg Curl", Exercise = context.Exercises.Single(x => x.Name.Equals("Prone Leg Curl")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 50M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 11, 14))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Incline Barbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Incline Barbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
                new Set { Reps = 10, Weight = 135M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 18, Weight = 8M },
                new Set { Reps = 18, Weight = 8M },
                new Set { Reps = 18, Weight = 8M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Lat Pulldown", Exercise = context.Exercises.Single(x => x.Name.Equals("Lat Pulldown")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
                new Set { Reps = 10, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 32.5M },
                new Set { Reps = 15, Weight = 37.5M },
                new Set { Reps = 15, Weight = 37.5M },
                new Set { Reps = 15, Weight = 37.5M },
                new Set { Reps = 15, Weight = 37.5M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "V-Bar Push Down", Exercise = context.Exercises.Single(x => x.Name.Equals("V-Bar Push Down")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 70M },
                new Set { Reps = 15, Weight = 70M },
                new Set { Reps = 15, Weight = 70M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Wrist Dumbbell Supination", Exercise = context.Exercises.Single(x => x.Name.Equals("Wrist Dumbbell Supination")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 18, Weight = 8M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 11, 16))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Arnold Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Arnold Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Sled Calf Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Sled Calf Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Upright Barbell Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Upright Barbell Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 18, Weight = 60M },
                new Set { Reps = 16, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Dumbbell Lateral Delt Raise", Exercise = context.Exercises.Single(x => x.Name.Equals("Dumbbell Lateral Delt Raise")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 15M },
                new Set { Reps = 12, Weight = 15M },
                new Set { Reps = 12, Weight = 15M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Plate Raises", Exercise = context.Exercises.Single(x => x.Name.Equals("Plate Raises")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 25M },
                new Set { Reps = 12, Weight = 35M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 11, 18))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Flat Dumbbell Bench Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Flat Dumbbell Bench Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 80M },
                new Set { Reps = 10, Weight = 80M },
                new Set { Reps = 10, Weight = 80M },
                new Set { Reps = 10, Weight = 80M },
                new Set { Reps = 10, Weight = 80M },
                new Set { Reps = 10, Weight = 80M },
                new Set { Reps = 10, Weight = 80M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Parallel Bar Triceps Dip", Exercise = context.Exercises.Single(x => x.Name.Equals("Parallel Bar Triceps Dip")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 207M },
                new Set { Reps = 10, Weight = 207M },
                new Set { Reps = 10, Weight = 207M },
                new Set { Reps = 10, Weight = 207M },
                new Set { Reps = 10, Weight = 207M },
                new Set { Reps = 10, Weight = 207M },
                new Set { Reps = 10, Weight = 207M },
                new Set { Reps = 10, Weight = 207M },
                new Set { Reps = 10, Weight = 207M },
                new Set { Reps = 10, Weight = 207M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Single Arm Cable Triceps Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Single Arm Cable Triceps Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 20M },
                new Set { Reps = 20, Weight = 20M },
                new Set { Reps = 15, Weight = 20M },
                new Set { Reps = 20, Weight = 15M },
                new Set { Reps = 15, Weight = 15M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Cable Crossover", Exercise = context.Exercises.Single(x => x.Name.Equals("Cable Crossover")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 32.5M },
                new Set { Reps = 12, Weight = 32.5M },
                new Set { Reps = 12, Weight = 32.5M },
                new Set { Reps = 12, Weight = 32.5M },
                new Set { Reps = 12, Weight = 32.5M },
                new Set { Reps = 12, Weight = 32.5M },
                new Set { Reps = 12, Weight = 32.5M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 11, 20))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
                new Set { Reps = 10, Weight = 380M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Sled Calf Extension", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Sled Calf Extension")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
                new Set { Reps = 15, Weight = 320M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Glute Sled", Exercise = context.Exercises.Single(x => x.Name.Equals("Glute Sled")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 115M },
                new Set { Reps = 12, Weight = 115M },
                new Set { Reps = 12, Weight = 115M },
                new Set { Reps = 12, Weight = 115M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Prone Leg Curl", Exercise = context.Exercises.Single(x => x.Name.Equals("Prone Leg Curl")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 50M },
                new Set { Reps = 12, Weight = 50M },
                new Set { Reps = 12, Weight = 50M },
                new Set { Reps = 12, Weight = 50M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Leg Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Leg Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 380M },
            };
            workout = context.Workouts.Single(x => x.Date.Equals(new DateTimeOffset(new DateTime(2018, 11, 21))));
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Arnold Press", Exercise = context.Exercises.Single(x => x.Name.Equals("Arnold Press")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
                new Set { Reps = 10, Weight = 40M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Seated Cable Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Seated Cable Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 10, Weight = 120M },
                new Set { Reps = 10, Weight = 120M },
                new Set { Reps = 10, Weight = 120M },
                new Set { Reps = 10, Weight = 120M },
                new Set { Reps = 10, Weight = 120M },
                new Set { Reps = 10, Weight = 120M },
                new Set { Reps = 10, Weight = 120M },
                new Set { Reps = 10, Weight = 120M },
                new Set { Reps = 10, Weight = 120M },
                new Set { Reps = 10, Weight = 120M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Upright Barbell Row", Exercise = context.Exercises.Single(x => x.Name.Equals("Upright Barbell Row")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 20, Weight = 60M },
                new Set { Reps = 18, Weight = 60M },
                new Set { Reps = 16, Weight = 60M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Dumbbell Lateral Delt Raise", Exercise = context.Exercises.Single(x => x.Name.Equals("Dumbbell Lateral Delt Raise")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 15M },
                new Set { Reps = 12, Weight = 15M },
                new Set { Reps = 12, Weight = 15M },
            };
            workoutExercise = new WorkoutExercise { Workout = workout, Name = "Plate Raises", Exercise = context.Exercises.Single(x => x.Name.Equals("Plate Raises")) };
            context.WorkoutExercises.Add(workoutExercise);
            workoutExercise.Sets = new List<Set>
            {
                new Set { Reps = 12, Weight = 25M },
                new Set { Reps = 12, Weight = 35M },
            };

            context.SaveChanges();
        }

        private static void SeedWorkouts(DoYouEvenLiftBroContext context)
        {
            User testUser = context.Users.Single(x => x.UserName.Equals("admin"));
            Workout[] workouts = new Workout[]
            {
                new Workout { Name = "Friday, January 12, 2018", Date = new DateTimeOffset(new DateTime(2018, 1, 12, 0, 0, 0)), User = testUser },
                new Workout { Name = "Saturday, January 13, 2018", Date = new DateTimeOffset(new DateTime(2018, 1, 13, 0, 0, 0)), User = testUser },
                new Workout { Name = "Sunday, January 14, 2018", Date = new DateTimeOffset(new DateTime(2018, 1, 14, 0, 0, 0)), User = testUser },
                new Workout { Name = "Saturday, January 20, 2018", Date = new DateTimeOffset(new DateTime(2018, 1, 20, 0, 0, 0)), User = testUser },
                new Workout { Name = "Sunday, January 21, 2018", Date = new DateTimeOffset(new DateTime(2018, 1, 21, 0, 0, 0)), User = testUser },
                new Workout { Name = "Thursday, January 25, 2018", Date = new DateTimeOffset(new DateTime(2018, 1, 25, 0, 0, 0)), User = testUser },
                new Workout { Name = "Tuesday, January 30, 2018", Date = new DateTimeOffset(new DateTime(2018, 1, 30, 0, 0, 0)), User = testUser },
                new Workout { Name = "Wednesday, January 31, 2018", Date = new DateTimeOffset(new DateTime(2018, 1, 31, 0, 0, 0)), User = testUser },
                new Workout { Name = "Saturday, February 03, 2018", Date = new DateTimeOffset(new DateTime(2018, 2, 3, 0, 0, 0)), User = testUser },
                new Workout { Name = "Sunday, February 04, 2018", Date = new DateTimeOffset(new DateTime(2018, 2, 4, 0, 0, 0)), User = testUser },
                new Workout { Name = "Saturday, February 17, 2018", Date = new DateTimeOffset(new DateTime(2018, 2, 17, 0, 0, 0)), User = testUser },
                new Workout { Name = "Sunday, February 18, 2018", Date = new DateTimeOffset(new DateTime(2018, 2, 18, 0, 0, 0)), User = testUser },
                new Workout { Name = "Sunday, February 25, 2018", Date = new DateTimeOffset(new DateTime(2018, 2, 25, 0, 0, 0)), User = testUser },
                new Workout { Name = "Monday, February 26, 2018", Date = new DateTimeOffset(new DateTime(2018, 2, 26, 0, 0, 0)), User = testUser },
                new Workout { Name = "Wednesday, February 28, 2018", Date = new DateTimeOffset(new DateTime(2018, 2, 28, 0, 0, 0)), User = testUser },
                new Workout { Name = "Saturday, March 03, 2018", Date = new DateTimeOffset(new DateTime(2018, 3, 3, 0, 0, 0)), User = testUser },
                new Workout { Name = "Sunday, March 04, 2018", Date = new DateTimeOffset(new DateTime(2018, 3, 4, 0, 0, 0)), User = testUser },
                new Workout { Name = "Saturday, March 10, 2018", Date = new DateTimeOffset(new DateTime(2018, 3, 10, 0, 0, 0)), User = testUser },
                new Workout { Name = "Sunday, March 11, 2018", Date = new DateTimeOffset(new DateTime(2018, 3, 11, 0, 0, 0)), User = testUser },
                new Workout { Name = "Saturday, March 17, 2018", Date = new DateTimeOffset(new DateTime(2018, 3, 17, 0, 0, 0)), User = testUser },
                new Workout { Name = "Sunday, March 18, 2018", Date = new DateTimeOffset(new DateTime(2018, 3, 18, 0, 0, 0)), User = testUser },
                new Workout { Name = "Friday, March 23, 2018", Date = new DateTimeOffset(new DateTime(2018, 3, 23, 0, 0, 0)), User = testUser },
                new Workout { Name = "Saturday, March 24, 2018", Date = new DateTimeOffset(new DateTime(2018, 3, 24, 0, 0, 0)), User = testUser },
                new Workout { Name = "Sunday, March 25, 2018", Date = new DateTimeOffset(new DateTime(2018, 3, 25, 0, 0, 0)), User = testUser },
                new Workout { Name = "Tuesday, March 27, 2018", Date = new DateTimeOffset(new DateTime(2018, 3, 27, 0, 0, 0)), User = testUser },
                new Workout { Name = "Thursday, March 29, 2018", Date = new DateTimeOffset(new DateTime(2018, 3, 29, 0, 0, 0)), User = testUser },
                new Workout { Name = "Saturday, April 14, 2018", Date = new DateTimeOffset(new DateTime(2018, 4, 14, 0, 0, 0)), User = testUser },
                new Workout { Name = "Sunday, April 15, 2018", Date = new DateTimeOffset(new DateTime(2018, 4, 15, 0, 0, 0)), User = testUser },
                new Workout { Name = "Thursday, April 19, 2018", Date = new DateTimeOffset(new DateTime(2018, 4, 19, 0, 0, 0)), User = testUser },
                new Workout { Name = "Thursday, April 26, 2018", Date = new DateTimeOffset(new DateTime(2018, 4, 26, 0, 0, 0)), User = testUser },
                new Workout { Name = "Saturday, April 28, 2018", Date = new DateTimeOffset(new DateTime(2018, 4, 28, 0, 0, 0)), User = testUser },
                new Workout { Name = "Sunday, April 29, 2018", Date = new DateTimeOffset(new DateTime(2018, 4, 29, 0, 0, 0)), User = testUser },
                new Workout { Name = "Wednesday, May 02, 2018", Date = new DateTimeOffset(new DateTime(2018, 5, 2, 0, 0, 0)), User = testUser },
                new Workout { Name = "Sunday, May 13, 2018", Date = new DateTimeOffset(new DateTime(2018, 5, 13, 0, 0, 0)), User = testUser },
                new Workout { Name = "Monday, May 14, 2018", Date = new DateTimeOffset(new DateTime(2018, 5, 14, 0, 0, 0)), User = testUser },
                new Workout { Name = "Thursday, May 17, 2018", Date = new DateTimeOffset(new DateTime(2018, 5, 17, 0, 0, 0)), User = testUser },
                new Workout { Name = "Friday, May 18, 2018", Date = new DateTimeOffset(new DateTime(2018, 5, 18, 0, 0, 0)), User = testUser },
                new Workout { Name = "Saturday, May 19, 2018", Date = new DateTimeOffset(new DateTime(2018, 5, 19, 0, 0, 0)), User = testUser },
                new Workout { Name = "Friday, May 25, 2018", Date = new DateTimeOffset(new DateTime(2018, 5, 25, 0, 0, 0)), User = testUser },
                new Workout { Name = "Sunday, May 27, 2018", Date = new DateTimeOffset(new DateTime(2018, 5, 27, 0, 0, 0)), User = testUser },
                new Workout { Name = "Wednesday, May 30, 2018", Date = new DateTimeOffset(new DateTime(2018, 5, 30, 0, 0, 0)), User = testUser },
                new Workout { Name = "Friday, June 01, 2018", Date = new DateTimeOffset(new DateTime(2018, 6, 1, 0, 0, 0)), User = testUser },
                new Workout { Name = "Sunday, June 03, 2018", Date = new DateTimeOffset(new DateTime(2018, 6, 3, 0, 0, 0)), User = testUser },
                new Workout { Name = "Monday, June 04, 2018", Date = new DateTimeOffset(new DateTime(2018, 6, 4, 0, 0, 0)), User = testUser },
                new Workout { Name = "Friday, June 08, 2018", Date = new DateTimeOffset(new DateTime(2018, 6, 8, 0, 0, 0)), User = testUser },
                new Workout { Name = "Saturday, June 09, 2018", Date = new DateTimeOffset(new DateTime(2018, 6, 9, 0, 0, 0)), User = testUser },
                new Workout { Name = "Sunday, June 17, 2018", Date = new DateTimeOffset(new DateTime(2018, 6, 17, 0, 0, 0)), User = testUser },
                new Workout { Name = "Thursday, June 21, 2018", Date = new DateTimeOffset(new DateTime(2018, 6, 21, 0, 0, 0)), User = testUser },
                new Workout { Name = "Friday, June 22, 2018", Date = new DateTimeOffset(new DateTime(2018, 6, 22, 0, 0, 0)), User = testUser },
                new Workout { Name = "Friday, June 29, 2018", Date = new DateTimeOffset(new DateTime(2018, 6, 29, 0, 0, 0)), User = testUser },
                new Workout { Name = "Saturday, June 30, 2018", Date = new DateTimeOffset(new DateTime(2018, 6, 30, 0, 0, 0)), User = testUser },
                new Workout { Name = "Sunday, July 01, 2018", Date = new DateTimeOffset(new DateTime(2018, 7, 1, 0, 0, 0)), User = testUser },
                new Workout { Name = "Tuesday, July 03, 2018", Date = new DateTimeOffset(new DateTime(2018, 7, 3, 0, 0, 0)), User = testUser },
                new Workout { Name = "Friday, July 06, 2018", Date = new DateTimeOffset(new DateTime(2018, 7, 6, 0, 0, 0)), User = testUser },
                new Workout { Name = "Saturday, July 14, 2018", Date = new DateTimeOffset(new DateTime(2018, 7, 14, 0, 0, 0)), User = testUser },
                new Workout { Name = "Sunday, July 15, 2018", Date = new DateTimeOffset(new DateTime(2018, 7, 15, 0, 0, 0)), User = testUser },
                new Workout { Name = "Saturday, July 28, 2018", Date = new DateTimeOffset(new DateTime(2018, 7, 28, 0, 0, 0)), User = testUser },
                new Workout { Name = "Sunday, July 29, 2018", Date = new DateTimeOffset(new DateTime(2018, 7, 29, 0, 0, 0)), User = testUser },
                new Workout { Name = "Saturday, August 04, 2018", Date = new DateTimeOffset(new DateTime(2018, 8, 4, 0, 0, 0)), User = testUser },
                new Workout { Name = "Saturday, August 11, 2018", Date = new DateTimeOffset(new DateTime(2018, 8, 11, 0, 0, 0)), User = testUser },
                new Workout { Name = "Tuesday, August 14, 2018", Date = new DateTimeOffset(new DateTime(2018, 8, 14, 0, 0, 0)), User = testUser },
                new Workout { Name = "Wednesday, August 15, 2018", Date = new DateTimeOffset(new DateTime(2018, 8, 15, 0, 0, 0)), User = testUser },
                new Workout { Name = "Sunday, August 19, 2018", Date = new DateTimeOffset(new DateTime(2018, 8, 19, 0, 0, 0)), User = testUser },
                new Workout { Name = "Monday, August 20, 2018", Date = new DateTimeOffset(new DateTime(2018, 8, 20, 0, 0, 0)), User = testUser },
                new Workout { Name = "Friday, August 24, 2018", Date = new DateTimeOffset(new DateTime(2018, 8, 24, 0, 0, 0)), User = testUser },
                new Workout { Name = "Saturday, August 25, 2018", Date = new DateTimeOffset(new DateTime(2018, 8, 25, 0, 0, 0)), User = testUser },
                new Workout { Name = "Friday, August 31, 2018", Date = new DateTimeOffset(new DateTime(2018, 8, 31, 0, 0, 0)), User = testUser },
                new Workout { Name = "Saturday, September 01, 2018", Date = new DateTimeOffset(new DateTime(2018, 9, 1, 0, 0, 0)), User = testUser },
                new Workout { Name = "Sunday, September 02, 2018", Date = new DateTimeOffset(new DateTime(2018, 9, 2, 0, 0, 0)), User = testUser },
                new Workout { Name = "Saturday, September 08, 2018", Date = new DateTimeOffset(new DateTime(2018, 9, 8, 0, 0, 0)), User = testUser },
                new Workout { Name = "Sunday, September 09, 2018", Date = new DateTimeOffset(new DateTime(2018, 9, 9, 0, 0, 0)), User = testUser },
                new Workout { Name = "Monday, September 10, 2018", Date = new DateTimeOffset(new DateTime(2018, 9, 10, 0, 0, 0)), User = testUser },
                new Workout { Name = "Thursday, September 13, 2018", Date = new DateTimeOffset(new DateTime(2018, 9, 13, 0, 0, 0)), User = testUser },
                new Workout { Name = "Friday, September 14, 2018", Date = new DateTimeOffset(new DateTime(2018, 9, 14, 0, 0, 0)), User = testUser },
                new Workout { Name = "Saturday, September 15, 2018", Date = new DateTimeOffset(new DateTime(2018, 9, 15, 0, 0, 0)), User = testUser },
                new Workout { Name = "Sunday, September 23, 2018", Date = new DateTimeOffset(new DateTime(2018, 9, 23, 0, 0, 0)), User = testUser },
                new Workout { Name = "Wednesday, September 26, 2018", Date = new DateTimeOffset(new DateTime(2018, 9, 26, 0, 0, 0)), User = testUser },
                new Workout { Name = "Friday, September 28, 2018", Date = new DateTimeOffset(new DateTime(2018, 9, 28, 0, 0, 0)), User = testUser },
                new Workout { Name = "Saturday, September 29, 2018", Date = new DateTimeOffset(new DateTime(2018, 9, 29, 0, 0, 0)), User = testUser },
                new Workout { Name = "Saturday, October 06, 2018", Date = new DateTimeOffset(new DateTime(2018, 10, 6, 0, 0, 0)), User = testUser },
                new Workout { Name = "Sunday, October 07, 2018", Date = new DateTimeOffset(new DateTime(2018, 10, 7, 0, 0, 0)), User = testUser },
                new Workout { Name = "Wednesday, October 10, 2018", Date = new DateTimeOffset(new DateTime(2018, 10, 10, 0, 0, 0)), User = testUser },
                new Workout { Name = "Thursday, October 11, 2018", Date = new DateTimeOffset(new DateTime(2018, 10, 11, 0, 0, 0)), User = testUser },
                new Workout { Name = "Friday, October 12, 2018", Date = new DateTimeOffset(new DateTime(2018, 10, 12, 0, 0, 0)), User = testUser },
                new Workout { Name = "Friday, October 19, 2018", Date = new DateTimeOffset(new DateTime(2018, 10, 19, 0, 0, 0)), User = testUser },
                new Workout { Name = "Saturday, October 20, 2018", Date = new DateTimeOffset(new DateTime(2018, 10, 20, 0, 0, 0)), User = testUser },
                new Workout { Name = "Tuesday, October 23, 2018", Date = new DateTimeOffset(new DateTime(2018, 10, 23, 0, 0, 0)), User = testUser },
                new Workout { Name = "Thursday, October 25, 2018", Date = new DateTimeOffset(new DateTime(2018, 10, 25, 0, 0, 0)), User = testUser },
                new Workout { Name = "Saturday, October 27, 2018", Date = new DateTimeOffset(new DateTime(2018, 10, 27, 0, 0, 0)), User = testUser },
                new Workout { Name = "Sunday, November 04, 2018", Date = new DateTimeOffset(new DateTime(2018, 11, 4, 0, 0, 0)), User = testUser },
                new Workout { Name = "Monday, November 05, 2018", Date = new DateTimeOffset(new DateTime(2018, 11, 5, 0, 0, 0)), User = testUser },
                new Workout { Name = "Wednesday, November 07, 2018", Date = new DateTimeOffset(new DateTime(2018, 11, 7, 0, 0, 0)), User = testUser },
                new Workout { Name = "Friday, November 09, 2018", Date = new DateTimeOffset(new DateTime(2018, 11, 9, 0, 0, 0)), User = testUser },
                new Workout { Name = "Tuesday, November 13, 2018", Date = new DateTimeOffset(new DateTime(2018, 11, 13, 0, 0, 0)), User = testUser },
                new Workout { Name = "Wednesday, November 14, 2018", Date = new DateTimeOffset(new DateTime(2018, 11, 14, 0, 0, 0)), User = testUser },
                new Workout { Name = "Friday, November 16, 2018", Date = new DateTimeOffset(new DateTime(2018, 11, 16, 0, 0, 0)), User = testUser },
                new Workout { Name = "Sunday, November 18, 2018", Date = new DateTimeOffset(new DateTime(2018, 11, 18, 0, 0, 0)), User = testUser },
                new Workout { Name = "Tuesday, November 20, 2018", Date = new DateTimeOffset(new DateTime(2018, 11, 20, 0, 0, 0)), User = testUser },
                new Workout { Name = "Wednesday, November 21, 2018", Date = new DateTimeOffset(new DateTime(2018, 11, 21, 0, 0, 0)), User = testUser },
            };

            foreach (var workout in workouts)
            {
                if (context.Workouts.SingleOrDefault(x => x.Name.Equals(workout.Name) && x.User.UserName.Equals(testUser.UserName)) == null)
                    context.Workouts.Add(workout);
            }

            context.SaveChanges();
        }

        private static void SeedExercises(DoYouEvenLiftBroContext context)
        {
            var muscleGroups = context.MuscleGroups;
            var shoulders = muscleGroups.Single(x => x.Name.Equals("Shoulders"));
            var chest = muscleGroups.Single(x => x.Name.Equals("Chest"));
            var quads = muscleGroups.Single(x => x.Name.Equals("Quadriceps"));
            var hams = muscleGroups.Single(x => x.Name.Equals("Hamstrings"));
            var calves = muscleGroups.Single(x => x.Name.Equals("Calves"));
            var biceps = muscleGroups.Single(x => x.Name.Equals("Biceps"));
            var triceps = muscleGroups.Single(x => x.Name.Equals("Triceps"));
            var lowerBack = muscleGroups.Single(x => x.Name.Equals("Lower Back"));
            var lats = muscleGroups.Single(x => x.Name.Equals("Lats"));
            var glutes = muscleGroups.Single(x => x.Name.Equals("Glutes"));
            var traps = muscleGroups.Single(x => x.Name.Equals("Trapezius"));

            var exercises = new Exercise[]
            {
                new Exercise { Name = "Barbell Shoulder Press", User = _adminUser, PrimaryMuscleGroup = shoulders },
                new Exercise { Name = "Dumbbell Lateral Delt Raise", User = _adminUser, PrimaryMuscleGroup = shoulders },
                new Exercise { Name = "Dumbbell Anterior Delt Raise", User = _adminUser, PrimaryMuscleGroup = shoulders },
                new Exercise { Name = "Upright Barbell Row", User = _adminUser, PrimaryMuscleGroup = shoulders },
                new Exercise { Name = "Arnold Press", User = _adminUser, PrimaryMuscleGroup = shoulders },
                new Exercise { Name = "Plate Raises", User = _adminUser, PrimaryMuscleGroup = shoulders },
                new Exercise { Name = "Hammer Strength Shoulder Press", User = _adminUser, PrimaryMuscleGroup = shoulders },
                new Exercise { Name = "Cable Lateral Raise", User = _adminUser, PrimaryMuscleGroup = shoulders },


                new Exercise { Name = "Flat Barbell Bench Press", User = _adminUser, PrimaryMuscleGroup = chest },
                new Exercise { Name = "Decline Barbell Bench Press", User = _adminUser, PrimaryMuscleGroup = chest },
                new Exercise { Name = "Incline Barbell Bench Press", User = _adminUser, PrimaryMuscleGroup = chest },
                new Exercise { Name = "Dumbbell Flyes", User = _adminUser, PrimaryMuscleGroup = chest },
                new Exercise { Name = "Push Ups", User = _adminUser, PrimaryMuscleGroup = chest },
                new Exercise { Name = "Decline Hammer Strength Chest Press", User = _adminUser, PrimaryMuscleGroup = chest },
                new Exercise { Name = "Incline Hammer Strength Chest Press", User = _adminUser, PrimaryMuscleGroup = chest },
                new Exercise { Name = "Cable Crossover", User = _adminUser, PrimaryMuscleGroup = chest },                new Exercise { Name = "Chest Dips", User = _adminUser, PrimaryMuscleGroup = chest },
                new Exercise { Name = "Flat Dumbbell Bench Press", User = _adminUser, PrimaryMuscleGroup = chest },
                new Exercise { Name = "Incline Dumbbell Bench Press", User = _adminUser, PrimaryMuscleGroup = chest },
                new Exercise { Name = "Decline Dumbbell Bench Press", User = _adminUser, PrimaryMuscleGroup = chest },

                new Exercise { Name = "Leg Press", User = _adminUser, PrimaryMuscleGroup = quads },
                new Exercise { Name = "Leg Extensions", User = _adminUser, PrimaryMuscleGroup = quads },

                new Exercise { Name = "Seated Calf Raise", User = _adminUser, PrimaryMuscleGroup = calves },
                new Exercise { Name = "Standing Calf Raise", User = _adminUser, PrimaryMuscleGroup = calves },
                new Exercise { Name = "Leg Sled Calf Extension", User = _adminUser, PrimaryMuscleGroup = calves },

                new Exercise { Name = "Prone Leg Curl", User = _adminUser, PrimaryMuscleGroup = hams },
                new Exercise { Name = "Sitting Leg Curl", User = _adminUser, PrimaryMuscleGroup = hams },
                new Exercise { Name = "Romanian Dead Lift", User = _adminUser, PrimaryMuscleGroup = hams },


                new Exercise { Name = "Squat", User = _adminUser, PrimaryMuscleGroup = glutes },
                new Exercise { Name = "Box Squat", User = _adminUser, PrimaryMuscleGroup = glutes },
                new Exercise { Name = "Hack Squat", User = _adminUser, PrimaryMuscleGroup = glutes },
                new Exercise { Name = "Front Squat", User = _adminUser, PrimaryMuscleGroup = glutes },
                new Exercise { Name = "Deadlift", User = _adminUser, PrimaryMuscleGroup = glutes },
                new Exercise { Name = "Glute Sled", User = _adminUser, PrimaryMuscleGroup = glutes },
                new Exercise { Name = "Walking Lunges", User = _adminUser, PrimaryMuscleGroup = glutes },

                new Exercise { Name = "Shoulder Shrugs", User = _adminUser, PrimaryMuscleGroup = traps },

                new Exercise { Name = "Lat Pulldown", User = _adminUser, PrimaryMuscleGroup = lats },
                new Exercise { Name = "Pull Ups", User = _adminUser, PrimaryMuscleGroup = lats },
                new Exercise { Name = "Chin Ups", User = _adminUser, PrimaryMuscleGroup = lats },
                new Exercise { Name = "Seated Cable Row", User = _adminUser, PrimaryMuscleGroup = lats },
                new Exercise { Name = "Dumbbell Lat Row", User = _adminUser, PrimaryMuscleGroup = lats },
                new Exercise { Name = "Barbell Lat Row", User = _adminUser, PrimaryMuscleGroup = lats },
                new Exercise { Name = "Seated Iso Lateral Cable Row", User = _adminUser, PrimaryMuscleGroup = lats },
                new Exercise { Name = "Seated Wide Grip Cable Row", User = _adminUser, PrimaryMuscleGroup = lats },
                new Exercise { Name = "Close Grip Pulldowns", User = _adminUser, PrimaryMuscleGroup = lats },


                new Exercise { Name = "Preacher Curl", User = _adminUser, PrimaryMuscleGroup = biceps },
                new Exercise { Name = "Cable Curl", User = _adminUser, PrimaryMuscleGroup = biceps },
                new Exercise { Name = "Hammer Curl", User = _adminUser, PrimaryMuscleGroup = biceps },
                new Exercise { Name = "Incline Dumbbell Curl", User = _adminUser, PrimaryMuscleGroup = biceps },
                new Exercise { Name = "Wrist Dumbbell Supination", User = _adminUser, PrimaryMuscleGroup = biceps },



                new Exercise { Name = "V-Bar Push Down", User = _adminUser, PrimaryMuscleGroup = triceps },
                new Exercise { Name = "V-Bar Triceps Extension", User = _adminUser, PrimaryMuscleGroup = triceps },
                new Exercise { Name = "Dips", User = _adminUser, PrimaryMuscleGroup = triceps },
                new Exercise { Name = "Skullcrushers", User = _adminUser, PrimaryMuscleGroup = triceps },
                new Exercise { Name = "Close Grip Bench Press", User = _adminUser, PrimaryMuscleGroup = triceps },
                new Exercise { Name = "Single Arm Cable Triceps Extension", User = _adminUser, PrimaryMuscleGroup = triceps },
                new Exercise { Name = "Parallel Bar Triceps Dip", User = _adminUser, PrimaryMuscleGroup = triceps },


                new Exercise { Name = "Good Mornings", User = _adminUser, PrimaryMuscleGroup = lowerBack },
                new Exercise { Name = "Hyperextensions", User = _adminUser, PrimaryMuscleGroup = lowerBack },

            };

            foreach (var exercise in exercises)
            {
                if (context.Exercises.SingleOrDefault(x => x.Name.Equals(exercise.Name)) == null)
                    context.Exercises.Add(exercise);
            }

            context.SaveChanges();
        }

        private static void GetAdminUser(UserManager<User> userManager)
        {
            _adminUser = userManager.FindByNameAsync(_adminUsername).Result;
            if (_adminUser != null)
            {
                if (!userManager.IsInRoleAsync(_adminUser, _adminRolename).Result)
                {
                    var identityResult = userManager.AddToRoleAsync(_adminUser, _adminRolename).Result;
                }
            }
        }

        private static void SeedMuscleGroups(DoYouEvenLiftBroContext context)
        {
            var muscleGroups = new MuscleGroup[]
            {
                new MuscleGroup { Name = "Quadriceps", User = _adminUser },
                new MuscleGroup { Name = "Hamstrings", User = _adminUser },
                new MuscleGroup { Name = "Calves", User = _adminUser },
                new MuscleGroup { Name = "Chest", User = _adminUser },
                new MuscleGroup { Name = "Lower Back", User = _adminUser },
                new MuscleGroup { Name = "Lats", User = _adminUser },
                new MuscleGroup { Name = "Shoulders", User = _adminUser },
                new MuscleGroup { Name = "Biceps", User = _adminUser },
                new MuscleGroup { Name = "Triceps", User = _adminUser },
                new MuscleGroup { Name = "Forearms", User = _adminUser },
                new MuscleGroup { Name = "Trapezius", User = _adminUser },
                new MuscleGroup { Name = "Abs", User = _adminUser },
                new MuscleGroup { Name = "Glutes", User = _adminUser }
            };

            foreach (var muscleGroup in muscleGroups)
                if (context.MuscleGroups.SingleOrDefault(x => x.Name.Equals(muscleGroup.Name)) == null)
                    context.MuscleGroups.Add(muscleGroup);

            context.SaveChanges();
        }

        public static void SeedUsers(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            User[] users = new User[]
            {
                new User { UserName = "jasonstatham", Email = "jasonstatham@fakeemail.com" },
                new User { UserName = "slystallone", Email = "slystallone@fakeemail.com" },
                new User { UserName = "jetli", Email = "jetli@fakeemail.com" },
                new User { UserName = "dolphlundgren", Email = "dolphlundgren@fakeemail.com" },
                new User { UserName = "randycouture", Email = "randycouture@fakeemail.com" },
                new User { UserName = "steveaustin", Email = "steveaustin@fakeemail.com" },
                new User { UserName = "arnie", Email = "arnie@fakeemail.com" },
                new User { UserName = "terrycrews", Email = "terrycrews@fakeemail.com" },
                new User { UserName = "mickeyrourke", Email = "mickeyrourke@fakeemail.com" },
                new User { UserName = "jcvd", Email = "jcvd@fakeemail.com" },
                new User { UserName = "melgibson", Email = "melgibson@fakeemail.com" },
                new User { UserName = "chucknorris", Email = "chucknorris@fakeemail.com" },
                new User { UserName = "brucewillis", Email = "brucewillis@fakeemail.com" },
                new User { UserName = "wesleysnipes", Email = "wesleysnipes@fakeemail.com" },
                new User { UserName = "kelseygrammer", Email = "kelseygrammer@fakeemail.com" },
                new User { UserName = "admin", Email = "kglassmire@gmail.com" },
                new User { UserName = "kglassmire", Email = "kglassmire@gmail.com"}
            };

            foreach (var user in users)
            {
                if (userManager.FindByNameAsync(user.UserName).Result == null)
                    userManager.CreateAsync(user, "@3fvu3nRPVs6P4V0KWlO9");
            }
        }

        public static void SeedRoles(RoleManager<Role> roleManager)
        {
            Role[] roles = new Role[]
            {
                new Role { Name = "admin" }
            };

            foreach (var role in roles)
            {
                if (!roleManager.RoleExistsAsync(role.Name).Result)
                    roleManager.CreateAsync(role);
            }
        }
    }
}
