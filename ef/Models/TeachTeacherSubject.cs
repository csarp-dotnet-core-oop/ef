﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Models
{
    public class TeachTeacherSubject
    {
        private long teacherId;
        private long subjectId;

        public long TeacherId { get => teacherId; set => teacherId = value; }
        //navigation property
        public virtual Teacher Techher{ get; set; }

        public long SubjectId { get => subjectId; set => subjectId = value; }
        // navigatin property
        public virtual Subject Subject { get; set; } 

        public TeachTeacherSubject(long teacherId, long subjectId)
        {
            this.teacherId = teacherId;
            this.subjectId = subjectId;
        }

    }
}
