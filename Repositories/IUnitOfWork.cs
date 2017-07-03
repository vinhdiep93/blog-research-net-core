using System;

namespace blogResearchNetCore.Repositories
{
    public interface IUnitOfWork: IDisposable
    {
        int Commit();
    }
}