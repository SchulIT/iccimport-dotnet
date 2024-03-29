namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    internal class GradeTeachersData
    {
        [JsonProperty(PropertyName = "section")]
        public int Section { get; set; }

        [JsonProperty(PropertyName = "year")]
        public int Year { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "grade_teachers")]
        public IList<GradeTeacherData> GradeTeachers { get; set; }
    }
}
