namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    internal class TuitionsData
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tuitions")]
        public IList<TuitionData> Tuitions { get; set; }

    }
}
