namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    internal class SubjectsData
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subjects")]
        public IList<SubjectData> Subjects { get; set; }

    }
}
