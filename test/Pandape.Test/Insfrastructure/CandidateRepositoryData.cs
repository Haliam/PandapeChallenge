using Pandape.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pandape.Test.Insfrastructure
{
    public class CandidateRepositoryData
    {
        public static IEnumerable<object[]> GetAll =>
        new List<object[]>
        {
            new object[]
            {   
                //Entities to add
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
                },
                //Number of entities to add
                3
            },
        };

        public static IEnumerable<object[]> GetById =>
        new List<object[]>
        {
            new object[]
            {
                new Candidate
                {
                    Name = "Malandro",
                    SurName = "Mor",
                    Email = "malandro@gmail.com",
                    BirthDate = new DateTime(1982, 2, 16),
                    InsertDate = DateTime.Now.Date,
                    ModifyDate = null,
                    CandidateExperiences =  new List<CandidateExperience>
                    {
                        new CandidateExperience
                        {
                            Company = "Plastac",
                            Job = "Hunter",
                            Description= "Description",
                            Salary = 80000,
                            BeginDate= DateTime.Now.Date,
                            EndDate = null,
                            InsertDate = DateTime.Now.Date,
                        }
                    }
                },
            },
            new object[]
            {
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
        };

        public static IEnumerable<object[]> Insert =>
        new List<object[]>
        {
            new object[]
            {
                new Candidate
                {
                    Name = "Alejandro",
                    SurName = "Montu",
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
                            Description= "Description",
                            Salary = 40000,
                            BeginDate= DateTime.Now.Date,
                            EndDate = null,
                            InsertDate = DateTime.Now.Date,
                        }
                    }
                },
            },
        };

        public static IEnumerable<object[]> InsertRange =>
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
                        Name = "Alejandro",
                        SurName = "Montu",
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

                        Name = "Alejandro",
                        SurName = "Montu",
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
                                Description= "Description",
                                Salary = 40000,
                                BeginDate= DateTime.Now.Date,
                                EndDate = null,
                                InsertDate = DateTime.Now.Date,
                            }
                        }
                    }
                },

                3
            }
        };

        public static IEnumerable<object[]> DeleteByEntity =>
        new List<object[]>
        {
            new object[]
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
            }
        };

        public static IEnumerable<object[]> DeleteById =>
        new List<object[]>
        {
            new object[]
            {
                 new Candidate
                 {
                    Name = "Alejandro",
                    SurName = "Montu",
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
                            Description= "Description",
                            Salary = 40000,
                            BeginDate= DateTime.Now.Date,
                            EndDate = null,
                            InsertDate = DateTime.Now.Date,
                        }
                    }
                 },
            }
        };

        public static IEnumerable<object[]> DeleteRange =>
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
                        Name = "Alejandro",
                        SurName = "Montu",
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
                        Name = "Alejandro",
                        SurName = "Montu",
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
                                Description= "Description",
                                Salary = 40000,
                                BeginDate= DateTime.Now.Date,
                                EndDate = null,
                                InsertDate = DateTime.Now.Date,
                            }
                        }
                    }
                },
                3
            }
        };

        public static IEnumerable<object[]> Update =>
        new List<object[]>
        {
            new object[]
            {
                new Candidate
                {
                    Name = "Alain",
                    SurName = "Rodriguez",
                    Email = "alain@gmail.com",
                    BirthDate = new DateTime(1974, 2, 14),
                    InsertDate = DateTime.Now.Date,
                    ModifyDate = null,
                    CandidateExperiences =  new List<CandidateExperience>
                    {
                        new CandidateExperience
                        {
                            Company = "LindkedIn",
                            Job = "Human Resources",
                            Description= "Recluter",
                            Salary = 30000,
                            BeginDate= new DateTime(2020, 1, 15),
                            EndDate = null,
                            InsertDate = DateTime.Now.Date,
                        }
                    }
                },

                new Candidate
                {
                    Name = "Alain",
                    SurName = "Rodriguez",
                    Email = "alainfacebook@gmail.com",
                    BirthDate = new DateTime(1974, 2, 14),
                    InsertDate = new DateTime(2023, 1, 15),
                    ModifyDate = null,
                    CandidateExperiences =  new List<CandidateExperience>
                    {
                        new CandidateExperience
                        {
                            Company = "Facebook",
                            Job = "Human Resources",
                            Description= "Recluter",
                            Salary = 40000,
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
