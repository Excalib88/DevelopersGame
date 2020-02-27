using System;

namespace DevelopersGame.DataAccess.Entities
{
    public class BaseEntity: IEntity
    {
        public Guid Id { get; set; }
        public bool IsActive { get; set; } = true;
    }
}