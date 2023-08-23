using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace melodiy.server.Dtos.Song
{
    public class GetSongResponse
    {
        public int Id { get; set; }
		public string UID { get; set; } = string.Empty;
		public string Title { get; set; } = string.Empty;
		public string Artist { get; set; } = string.Empty;
		public string? Album { get; set; }
		public string? AlbumArtist { get; set; }
		public string CoverPath { get; set; } = string.Empty;
		public string SongPath { get; set; } = string.Empty;
        public int Duration {get; set; }
        public DateTime CreatedAt { get; set; }
		public GetUserResponse User { get; set; } = null!;
    }
}