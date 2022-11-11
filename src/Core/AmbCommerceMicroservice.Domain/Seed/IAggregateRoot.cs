using System.Collections;
namespace AmbCommerceMicroservice.Domain.Seed
{
    public interface IAggregateRoot
    {
        ICollection<IDomainEvent> DomainEvents { get; }

    }
}
