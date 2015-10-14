using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Questionnaire.Entities
{
    public class Form
    {
        public int Id;
        public string Name;
        public List <Question> Questions;
    }
}
