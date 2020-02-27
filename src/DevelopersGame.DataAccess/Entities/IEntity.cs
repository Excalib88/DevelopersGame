using System;

namespace DevelopersGame.DataAccess.Entities
{
    public interface IEntity
    {
        Guid Id { get; set; }
        bool IsActive { get; set; }
    }
}