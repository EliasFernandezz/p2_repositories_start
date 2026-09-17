//------------------------------------------------------------------------------
// <copyright file="Repository.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Ucu.Poo.Repositories
{
    public class Repository<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            if (item != null)
            {
                this.items.Add(item);
            }
        }

        public void Remove(T item)
        {
            this.items.Remove(item);
        }

        public T Find(Predicate<T> criteria)
        {
            foreach (T item in this.items)
            {
                if (criteria(item))
                {
                    return item;
                }
            }

            return default(T);
        }
    }
}