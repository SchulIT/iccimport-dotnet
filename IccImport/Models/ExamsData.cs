namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    internal class ExamsData
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exams")]
        public IList<ExamData> Exams { get; set; }

    }
}
