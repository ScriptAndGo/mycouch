﻿using System;
using EnsureThat;

namespace MyCouch.Commands
{
    [Serializable]
    public class PutEntityCommand<T> : IMyCouchCommand where T : class
    {
        public T Entity { get; set; }

        public PutEntityCommand(T entity)
        {
            Ensure.That(entity, "entity").IsNotNull();

            Entity = entity;
        }
    }
}