using MyMusic.Api.Resources.ArtistResources;

namespace MyMusic.Api.Resources.MusicResources
{
    public class MusicResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ArtistResource Artist { get; set; }
    }
}
