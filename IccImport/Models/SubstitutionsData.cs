namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    internal class SubstitutionsData
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "substitutions")]
        public IList<SubstitutionData> Substitutions { get; set; }

    }
}
