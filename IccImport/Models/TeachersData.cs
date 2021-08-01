namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    internal class TeachersData
    {
        [JsonProperty(PropertyName = "section")]
        public int Section { get; set; }

        [JsonProperty(PropertyName = "year")]
        public int Year { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "teachers")]
        public IList<TeacherData> Teachers { get; set; }

    }
}
