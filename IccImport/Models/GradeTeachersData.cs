namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    internal class GradeTeachersData
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "grade_teachers")]
        public IList<GradeTeacherData> GradeTeachers { get; set; }
    }
}
