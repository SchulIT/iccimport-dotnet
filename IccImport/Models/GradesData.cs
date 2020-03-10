namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    internal class GradesData
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "grades")]
        public IList<GradeData> Grades { get; set; }

    }
}
