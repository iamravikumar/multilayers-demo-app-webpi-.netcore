using Microsoft.EntityFrameworkCore;
using MyMusic.Core.Interfaces.Repositories;
using MyMusic.Core.Models;
using MyMusic.Data.Repositories.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyMusic.Data.Repositories
{
    public class ArtistRepository : Repository<Artist>, IArtistRepository
    {
        public ArtistRepository(MyMusicDbContext context) : base(context)
        { }


        private MyMusicDbContext MyMusicDbContext
        {
            get { return Context as MyMusicDbContext; }
        }

        public async Task<IEnumerable<Artist>> GetAllWithMusicsAsync()
        {
            return await MyMusicDbContext.Artists
                .Include(a => a.Musics)
                .ToListAsync();
        }

        public Task<Artist> GetWithMusicsByIdAsync(int id)
        {
            return MyMusicDbContext.Artists
                .Include(a => a.Musics)
                .SingleOrDefaultAsync(a => a.Id == id);
        }
    }
}