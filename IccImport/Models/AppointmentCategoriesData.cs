namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    internal class AppointmentCategoriesData
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "categories")]
        public IList<AppointmentCategoryData> Categories { get; set; }

    }
}
