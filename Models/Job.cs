using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace JobTracker.Models
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }


        [Required]
        [MinLength(2)]
        [Display(Name = "Company Name :")]
        public string CompanyName { get; set; }


        [Required]
        [MinLength(2)]
        [Display(Name = "Job Title :")]
        public string JobTitle { get; set; }


        [Required]
        [Display(Name = "Status :")]
        public string JobStatus { get; set; }


        [Display(Name = "Applied At :")]
        public string AppliedAt { get; set; }

        [Display(Name = "Date Applied :")]
        public DateTime AppliedDate { get; set; }


        [Display(Name = "Job Type :")]
        public string JobType { get; set; }


        [Display(Name = "Company Website :")]
        public string CompanyWebsite { get; set; }

        [Display(Name = "Application Link :")]
        public string ApplicationLink { get; set; }


        [Display(Name = "Required Skill :")]
        public string RequiredSkill { get; set; }


        [Display(Name = "Note :")]
        public string JobNote { get; set; }

        public List<Application> Applicants { get; set; }

        public List<Contact> JobContact { get; set; }

        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdateAt {get; set;} = DateTime.Now;

    }
}