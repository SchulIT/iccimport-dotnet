using Newtonsoft.Json;
using System.Collections.Generic;

namespace SchulIT.IccImport.Models
{
    internal class PrivacyCategoriesData
    {
        [JsonProperty("categories")]
        public IList<PrivacyCategoryData> Categories { get; set; }
    }
}
