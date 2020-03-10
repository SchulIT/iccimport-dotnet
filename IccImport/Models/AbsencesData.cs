namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    internal class AbsencesData
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "absences")]
        public IList<AbsenceData> Absences { get; set; }

    }
}
