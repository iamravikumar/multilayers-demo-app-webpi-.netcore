using System;
using System.Threading.Tasks;

namespace MyMusic.Core.Interfaces.Repositories.Base
{
    public interface IUnitOfWork : IDisposable
    {
        IMusicRepository Musics { get; }
        IArtistRepository Artists { get; }
        Task<int> CommitAsync();
    }
}
