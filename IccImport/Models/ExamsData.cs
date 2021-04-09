namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    internal class ExamsData
    {
        [JsonProperty(PropertyName = "suppress_notifications")]
        public bool SuppressNotifications { get; set; } = false;

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exams")]
        public IList<ExamData> Exams { get; set; }

    }
}
