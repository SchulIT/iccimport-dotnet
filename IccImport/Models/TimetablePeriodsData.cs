namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    internal class TimetablePeriodsData
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "periods")]
        public IList<TimetablePeriodData> Periods { get; set; }

    }
}
