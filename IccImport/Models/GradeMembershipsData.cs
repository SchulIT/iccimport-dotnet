using Newtonsoft.Json;
using System.Collections.Generic;

namespace SchulIT.IccImport.Models
{
    internal class GradeMembershipsData
    {
        [JsonProperty(PropertyName = "section")]
        public int Section { get; set; }

        [JsonProperty(PropertyName = "year")]
        public int Year { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "memberships")]
        public IList<GradeMembershipData> Memberships { get; set; }
    }
}
