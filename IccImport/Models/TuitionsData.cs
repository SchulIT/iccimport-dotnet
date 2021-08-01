namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    internal class TuitionsData
    {
        [JsonProperty(PropertyName = "section")]
        public int Section { get; set; }

        [JsonProperty(PropertyName = "year")]
        public int Year { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tuitions")]
        public IList<TuitionData> Tuitions { get; set; }

    }
}
