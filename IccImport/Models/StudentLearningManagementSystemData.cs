using Newtonsoft.Json;

namespace SchulIT.IccImport.Models
{
    public class StudentLearningManagementSystemData
    {
        [JsonProperty(PropertyName = "student")]
        public string Student { get; set; }

        [JsonProperty(PropertyName = "lms")]
        public string Lms { get; set; }

        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        [JsonProperty(PropertyName = "is_consented")]
        public bool IsConsented { get; set; }

        [JsonProperty(PropertyName = "is_consent_obtained")]
        public bool IsConsentObtained { get; set; }

        [JsonProperty(PropertyName = "is_audio_consented")]
        public bool IsAudioConsented { get; set; }

        [JsonProperty(PropertyName = "is_video_consented")]
        public bool IsVideoConsented { get; set; }
    }
}
