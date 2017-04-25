using EFSampleEvaluation.Common;
using EFSampleEvaluation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EFSampleEvaluation.Web.Controllers
{
    public class EvaluationController : ApiController
    {
        EvaluationModel model = new EvaluationModel();
        string apiUrl = "/api/evaluation/";

        public IEnumerable<EvaluationTO> Get()
        {
            
            return model.GetAll();
        }

        public EvaluationTO Get(int id)
        {
            EvaluationModel model = new EvaluationModel();
            return model.Get(id);
        }

        public EvaluationTO Delete(int id)
        {
            EvaluationTO evaluation = model.Get(id);
            if(evaluation == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            model.Delete(evaluation);
            return evaluation;
        }

        public HttpResponseMessage Put(EvaluationTO evaluation)
        {
            if (!model.Exists(evaluation.ID))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            model.Update(evaluation);
            HttpResponseMessage response = Request.CreateResponse<EvaluationTO>(HttpStatusCode.OK, evaluation);

            return response;
        }

        public HttpResponseMessage Post(EvaluationTO evaluation)
        {
            evaluation = model.Add(evaluation);
            HttpResponseMessage response = Request.CreateResponse<EvaluationTO>(HttpStatusCode.Created, evaluation);
            response.Headers.Location = new Uri(Request.RequestUri + apiUrl + evaluation.ID.ToString());

            return response;
        }
    }
}
