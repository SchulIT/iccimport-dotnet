namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    internal class AppointmentsData
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appointments")]
        public IList<AppointmentData> Appointments { get; set; }

    }
}
