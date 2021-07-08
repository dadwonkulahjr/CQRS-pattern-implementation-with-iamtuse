﻿using System.Collections.Generic;

namespace MyAppCQRSPattern.Domain.Entities
{
    public class MainMenuItem
    {
       
        public int MainMenuId { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public string StudentDescription { get; set; }
        public string GenderDescription { get; set; }
        public string CourseDescripion { get; set; }
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }


    }
}
