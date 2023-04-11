using Pandape.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pandape.Host.Mvc.ViewModels
{
    public class GetDetailsCandidateViewModel
    {
        public string Company { get; set; }

        public string Job { get; set; }

        public string Description { get; set; }

        public decimal Salary { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BeginDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime InsertDate { get; set; }

        public Candidate Candidate { get; set; }

        public List<CandidateExperience> CandidateExperiences { get; set; }
    }
}
