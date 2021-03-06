﻿using MediatR;
using System;

namespace TodoApp.Application.Commads
{
    public class CreateTodoCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public string City { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
