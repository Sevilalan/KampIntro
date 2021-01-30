﻿using InterfaceAbstractDemo.Abstract;
using System;

namespace InterfaceAbstractDemo.Entities
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateofBirt { get; set; }
        public string NationalityId { get; set; }

    }
}