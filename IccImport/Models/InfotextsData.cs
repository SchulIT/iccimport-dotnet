namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    internal class InfotextsData
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "infotexts")]
        public IList<InfotextData> Infotexts { get; set; }
    }
}
