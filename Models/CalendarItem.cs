using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KetoCalculator.Models
{
    public class CalendarItem
    {
        public string Title { get; set; }

        public string Url { get; set; }

        public DateTime Date { get; set; }

        public string HighlightClass { get; private set; } = "bg-danger";

        public void SetHighlightClass(string ClassType)
        {
            switch (ClassType)
            {
                case "Bad":
                {
                    HighlightClass = "bg-danger";
                    break;
                }
                case "OK":
                {
                    HighlightClass = "bg-warning";
                    break;
                }
                case "Good":
                {
                    HighlightClass = "bg-info";
                        break;
                }

                default:
                { 
                    HighlightClass = "bg-danger";
                    break;
                }
            }
        } 
    }
}
