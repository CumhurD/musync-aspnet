namespace musync_web.Models {
    public class IntegrationSettings{
        public SpotifySettings Spotify { get; set; }
    }

    public class SpotifySettings {
        public string LoginUrl { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string RedirectUrl { get; set; }
    }
}