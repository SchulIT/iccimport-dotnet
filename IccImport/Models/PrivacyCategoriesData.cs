using Newtonsoft.Json;
using System.Collections.Generic;

namespace SchulIT.IccImport.Models
{
    class PrivacyCategoriesData
    {
        [JsonProperty("categories")]
        public IList<PrivacyCategoryData> Categories { get; set; }
    }
}
