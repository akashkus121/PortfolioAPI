﻿namespace PortfolioAPI.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string TechStack { get; set; }
        public string GitHubLink { get; set; }
        public string LiveDemoLink { get; set; }
    }
}
