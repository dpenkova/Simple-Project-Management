using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPM.Models
{
    public class Task
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ProjectId { get; set; }

        public virtual Project Project { get; set; }

        public Priority Priority { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime EndedOn { get; set; }

        public DateTime CreatedOn { get; set; }

        public int TaskStatusId { get; set; }

        public virtual TaskStatus Status { get; set; }


    }
}
