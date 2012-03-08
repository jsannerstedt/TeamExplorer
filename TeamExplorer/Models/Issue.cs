using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace TeamExplorer.Models
{
    public class Issue
    {
        public Issue()
        {
            Images = new Collection<string>();
        }

        public string Id { get; set; }
        public string CharterId { get; set; }

        [Required]
        public IssueType IssueType { get; set; }
        [Required]
        public string Description { get; set; }
        public string Stacktrace { get; set; }

        /// <summary>
        /// This contains the image src, the actual image should be stored somewhere else later on:
        /// TODO: file or raven attachements
        /// </summary>
        public ICollection<string> Images { get; set; }
    }

    public enum IssueType
    {
        Bug, Issue, Note
    }
}