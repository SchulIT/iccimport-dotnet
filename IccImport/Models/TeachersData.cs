namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    internal class TeachersData
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "teachers")]
        public IList<TeacherData> Teachers { get; set; }

    }
}
