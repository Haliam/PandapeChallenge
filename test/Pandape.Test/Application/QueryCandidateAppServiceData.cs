using Pandape.Application.CQRS.Queries;
using Pandape.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Pandape.Test.Application
{
    public class QueryCandidateAppServiceData
    {
        public static IEnumerable<object[]> FindCandidateSuccess =>
        new List<object[]>
        {
            new object[]
            {
                new List<Candidate>
                {
                     new Candidate
                     {
                        Name = "Alejandro",
                        SurName = "Montu",
                        Email = "alejandrof@gmail.com",
                        BirthDate = new DateTime(1965, 2, 16),
                        InsertDate = DateTime.Now.Date,
                        ModifyDate = null,
                        CandidateExperiences =  new List<CandidateExperience>
                        {
                            new CandidateExperience
                            {
                                Company = "University of Valencia",
                                Job = "Cinema Teacher",
                                Description= "Description",
                                Salary = 40000,
                                BeginDate= DateTime.Now.Date,
                                EndDate = null,
                                InsertDate = DateTime.Now.Date,
                            }
                        }
                     }
                },

                new FindCandidateQuery
                {
                    Expression = candidate =>
                    candidate.SurName == "Montu" &&
                    candidate.BirthDate == new DateTime(1965, 2, 16)
                }
            }
        };

        public static IEnumerable<object[]> GetAllCandidatesSuccess =>
        new List<object[]>
        {
            new object[]
            {
                new List<Candidate>
                {
                    new Candidate
                    {
                        Name = "Alejandro",
                        SurName = "Montu",
                        Email = "alejandrof@gmail.com",
                        BirthDate = new DateTime(1965, 2, 16),
                        InsertDate = DateTime.Now.Date,
                        ModifyDate = null,
                        CandidateExperiences =  new List<CandidateExperience>
                        {
                            new CandidateExperience
                            {
                                Company = "University of Valencia",
                                Job = "Cinema Teacher",
                                Description= "Description",
                                Salary = 40000,
                                BeginDate= DateTime.Now.Date,
                                EndDate = null,
                                InsertDate = DateTime.Now.Date,
                            }
                        }
                    },

                    new Candidate
                    {
                        Name = "Haliam",
                        SurName = "Perez",
                        Email = "haliampf@gmail.com",
                        BirthDate = new DateTime(1982, 2, 16),
                        InsertDate = DateTime.Now.Date,
                        ModifyDate = null,
                        CandidateExperiences =  new List<CandidateExperience>
                        {
                            new CandidateExperience
                            {
                                Company = "Google",
                                Job = "Developer",
                                Description= "Develop new features",
                                Salary = 45000,
                                BeginDate= DateTime.Now.Date,
                                EndDate = null,
                                InsertDate = DateTime.Now.Date,
                            }
                        }
                    },

                    new Candidate
                    {
                        Name = "Lourdes",
                        SurName = "Fernandez",
                        Email = "lourdes@gmail.com",
                        BirthDate = new DateTime(1957, 12, 14),
                        InsertDate = DateTime.Now.Date,
                        ModifyDate = null,
                        CandidateExperiences =  new List<CandidateExperience>
                        {
                            new CandidateExperience
                            {
                                Company = "Imexin",
                                Job = "Chemistry",
                                Description= "Description",
                                Salary = 50000,
                                BeginDate= DateTime.Now.Date,
                                EndDate = null,
                                InsertDate = DateTime.Now.Date,
                            }
                        }
                    }
                }
            }
        };

        public static IEnumerable<object[]> GetByIdCandidateSuccess =>
        new List<object[]>
        {
            new object[]
            {
                new Candidate
                {
                    Id = 3134,
                    Name = "Alejandro",
                    SurName = "Montu",
                    Email = "alejandrof@gmail.com",
                    BirthDate = new DateTime(1965, 2, 16),
                    InsertDate = DateTime.Now.Date,
                    ModifyDate = null,
                    CandidateExperiences =  new List<CandidateExperience>
                    {
                        new CandidateExperience
                        {
                            Company = "University of Valencia",
                            Job = "Cinema Teacher",
                            Description= "Description",
                            Salary = 40000,
                            BeginDate= DateTime.Now.Date,
                            EndDate = null,
                            InsertDate = DateTime.Now.Date,
                        }
                    }
                }

            },

            new object[]
            {
                new Candidate
                {
                    Id = 3135,
                    Name = "Haliam",
                    SurName = "Perez",
                    Email = "haliampf@gmail.com",
                    BirthDate = new DateTime(1982, 2, 16),
                    InsertDate = DateTime.Now.Date,
                    ModifyDate = null,
                    CandidateExperiences =  new List<CandidateExperience>
                    {
                        new CandidateExperience
                        {
                            Company = "Google",
                            Job = "Developer",
                            Description= "Develop new features",
                            Salary = 45000,
                            BeginDate= DateTime.Now.Date,
                            EndDate = null,
                            InsertDate = DateTime.Now.Date,
                        }
                    }
                } 
            },

            new object[]
            {
                new Candidate
                {
                    Id = 3136,
                    Name = "Lourdes",
                    SurName = "Fernandez",
                    Email = "lourdes@gmail.com",
                    BirthDate = new DateTime(1957, 12, 14),
                    InsertDate = DateTime.Now.Date,
                    ModifyDate = null,
                    CandidateExperiences =  new List<CandidateExperience>
                    {
                        new CandidateExperience
                        {
                            Company = "Imexin",
                            Job = "Chemistry",
                            Description= "Description",
                            Salary = 50000,
                            BeginDate= DateTime.Now.Date,
                            EndDate = null,
                            InsertDate = DateTime.Now.Date,
                        }
                    }
                }
            }
        };
    }
}
