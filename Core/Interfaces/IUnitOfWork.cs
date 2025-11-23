namespace Carbon.Core.Interfaces;


public interface IUnitOfWork : IDisposable
{
IActivityRepository Activities { get; }
Task<int> SaveChangesAsync();
}