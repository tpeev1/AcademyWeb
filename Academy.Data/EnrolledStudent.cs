﻿namespace Academy.Data
{
    public class EnrolledStudent
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int StudentId { get; set; }
        public User Student { get; set; }
    }
}