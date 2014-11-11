﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPM.Models
{
    public class Client
    {
        private ICollection<Project> projects;

        public Client()
        {
            this.projects = new HashSet<Project>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        public string Name { get; set; }

        public DateTime CreatedOn { get; set; }

        public virtual ICollection<Project> Projects 
        { 
            get { return this.projects; }
            set { this.projects = value; }
        }
    }
}