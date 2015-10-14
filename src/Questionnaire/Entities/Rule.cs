using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Questionnaire.Entities
{
    public class Rule
    {
        public int Id;
        public Question Question;
        public string SelectedOption;
        public Form NextForm;
    }
}
