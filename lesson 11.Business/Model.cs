﻿
namespace lesson_11.Business
{
    public class Model
    {
        public string Number { get; }
        public string Description { get; }

        public Model(string number, string description)
        {
            Number = number;
            Description = description;
        }
    }
}
