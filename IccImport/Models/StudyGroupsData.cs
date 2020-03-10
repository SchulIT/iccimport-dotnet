namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    internal class StudyGroupsData
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "study_groups")]
        public IList<StudyGroupData> StudyGroups { get; set; }

    }
}
