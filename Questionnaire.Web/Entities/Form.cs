﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Questionnaire.Entities
{
    public class Form
    {
        public int Id { get; set;}
        public string Name { get; set; }

        public List <Question> Questions;
    }
}
