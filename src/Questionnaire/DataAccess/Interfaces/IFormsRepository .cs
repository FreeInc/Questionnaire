using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Questionnaire.Entities;

namespace Questionnaire.DataAccess.Interfaces
{
    interface IFormsRepository
    {
        void Get();
        Form GetById(int FormId);
        void Add(Form AddForm);
        void Update(Form UpdForm);
        void Delete(int Id, Form DelForm);
    }
}
