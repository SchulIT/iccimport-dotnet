namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    internal class StudyGroupMembershipsData
    {
        [JsonProperty(PropertyName = "section")]
        public int Section { get; set; }

        [JsonProperty(PropertyName = "year")]
        public int Year { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "memberships")]
        public IList<StudyGroupMembershipData> Memberships { get; set; }

    }
}
