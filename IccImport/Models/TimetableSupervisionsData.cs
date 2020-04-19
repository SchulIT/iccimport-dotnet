namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    internal class TimetableSupervisionsData
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period")]
        public string Period { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "supervisions")]
        public IList<TimetableSupervisionData> Supervisions { get; set; }

    }
}
