namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    internal class StudentsData
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "students")]
        public IList<StudentData> Students { get; set; }

    }
}
