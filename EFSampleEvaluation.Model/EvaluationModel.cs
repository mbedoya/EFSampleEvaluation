using EFSampleEvaluation.Common;
using EFSampleEvaluation.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFSampleEvaluation.Model
{
    public class EvaluationModel
    {
        EvaluationDB db = new EvaluationDB();

        public IEnumerable<EvaluationTO> GetAll()
        {
            var evaluations =
                from e in db.Evaluations
                orderby e.ID ascending
                select e;

            return evaluations;
        }

        public EvaluationTO Get(int id)
        {
            var evaluation =
                (from e in db.Evaluations
                where e.ID == id
                select e).FirstOrDefault();

            return evaluation;
        }

        public bool Exists(int id)
        {
            return Get(id) != null;
        }

        public void Delete(EvaluationTO evaluation)
        {
            db.Evaluations.Remove(evaluation);
        }

        public void Update(EvaluationTO evaluation)
        {
            db.Entry(evaluation).CurrentValues.SetValues(evaluation);
        }

        public EvaluationTO Add(EvaluationTO evaluation)
        {
            evaluation = db.Evaluations.Add(evaluation);

            return evaluation;
        }
    }
}
