﻿namespace To_Do_app.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public bool isCompleted { get; set; }

        public Task()
        {

        }
    }
}
