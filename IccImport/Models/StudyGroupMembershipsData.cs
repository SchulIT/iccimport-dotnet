namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    internal class StudyGroupMembershipsData
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "memberships")]
        public IList<StudyGroupMembershipData> Memberships { get; set; }

    }
}
