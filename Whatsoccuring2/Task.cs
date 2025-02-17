using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whatsoccuring2
{
    internal class Task
    {
        public DateTime MaxDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public DateTime DueDate { get; set; }



        public Task(string title, string description, DateTime dueDate)
        {
            this.Title = title;
            this.Description = description;
            this.DueDate = dueDate;


        }

        public override string ToString()
        {
            return $"{Title} (Due : {DueDate: dd MMM yyyy} \a \a {Description})";
        }


    }
}

