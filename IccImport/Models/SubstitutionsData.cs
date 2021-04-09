namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    internal class SubstitutionsData
    {
        [JsonProperty(PropertyName = "suppress_notifications")]
        public bool SuppressNotifications { get; set; } = false;

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "substitutions")]
        public IList<SubstitutionData> Substitutions { get; set; }

    }
}
