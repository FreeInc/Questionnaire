using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Questionnaire.DataAccess.Interfaces;
using Questionnaire.Entities;


namespace Questionnaire.DataAccess.FakeImplementation
{
    public class FormsRepositoryFake: IFormsRepository
    {
        private List<Form> ListForm = new List<Form>();

        public FormsRepositoryFake()
        {
            ListForm.Add(new Form() { Id = 1, Name = "Test1" });
            ListForm.Add(new Form() { Id = 2, Name = "Test2" });
            ListForm.Add(new Form() { Id = 3, Name = "Test3" });
            ListForm.Add(new Form() { Id = 4, Name = "Test4" });
            ListForm.Add(new Form() { Id = 5, Name = "Test5" });
        }

        public Form GetById(int FormId)
        {
            return ListForm.SingleOrDefault(x => x.Id == FormId);
        }

        public IEnumerable<Form> Get()
        {
            return ListForm.ToArray<Form>();
        }
        public void Add(Form AddForm)
        {
            throw new NotImplementedException();
        }

        public void Update(Form UpdForm)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id, Form DelForm)
        {
            throw new NotImplementedException();
        }

    }
}
