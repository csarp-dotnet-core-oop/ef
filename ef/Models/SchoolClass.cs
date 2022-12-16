﻿using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
    public class SchoolClass : ClassWithId
    {
        public SchoolClass(long id, int schoolYear, char classType, long headTeachId) : base(id)
        {
            SchoolYear = schoolYear;
            ClassType = classType;
            HeadTeacherId = headTeachId;

        }

        public SchoolClass()
             : base(-1)
        {
            SchoolYear = -1;
            ClassType = char.MinValue;
            HeadTeacherId = -1;
        }

        public virtual int SchoolYear { get; set; }

        public virtual char ClassType { get; set; }

        // one-zero
        public long HeadTeacherId { get; set; }
        public virtual Teacher HeadTeacher { get; set; }

        // one - many
        public virtual ICollection<Student> Students { get; set; }
    }
}
