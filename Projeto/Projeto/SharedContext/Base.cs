using System;
using Projeto.NotificationContext;

namespace Projeto.SharedContext
{
    public abstract class Base : Notifiable
    {
        public Guid Id { get; set; }

        public Base()
        {
            Id = Guid.NewGuid();
        }
    }
}
