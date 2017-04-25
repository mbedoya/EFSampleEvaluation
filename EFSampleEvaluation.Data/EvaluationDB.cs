using EFSampleEvaluation.Common;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace EFSampleEvaluation.Data
{
    public class EvaluationDB : DbContext
    {
        public DbSet<EvaluationTO> Evaluations { get; set; }
    }

}
