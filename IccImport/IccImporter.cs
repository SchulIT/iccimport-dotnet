using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SchulIT.IccImport.Models;
using SchulIT.IccImport.Response;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SchulIT.IccImport
{
    public class IccImporter : IIccImporter
    {
        public string Token { get; set; }

        public string BaseUrl { get; set; }


        public const string ImportApiEndpoint = "api/import";

        public const string AppointmentsUrl = "appointments";
        public const string AppointmentCategoriesUrl = "appointments/categories";
        public const string ExamsUrl = "exams";
        public const string GradesUrl = "grades";
        public const string GradeTeachersUrl = "grades/teachers";
        public const string StudentsUrl = "students";
        public const string StudyGroupsUrl = "studygroups";
        public const string StudyGroupMembershipsUrl = "studygroups/memberships";
        public const string SubjectsUrl = "subjects";
        public const string SubstitutionsUrl = "substitutions";
        public const string TeachersUrl = "teachers";
        public const string TimetableLessonsUrl = "timetable/lessons";
        public const string TimetablePeriodsUrl = "timetable/periods";
        public const string TimetableSupervisionsUrl = "timetable/supervisions";
        public const string TuitionsUrl = "tuitions";
        public const string InfotextsUrl = "infotexts";
        public const string AbsencesUrl = "absences";
        public const string PrivacyCategoryUrl = "privacy/categories";
        public const string RoomUrl = "rooms";
        public const string FreeLessonTimespanUrl = "free_lessons";

        private readonly ILogger<IccImporter> logger;

        public IccImporter()
        {

        }

        public IccImporter(ILogger<IccImporter> logger)
        {
            this.logger = logger;
        }

        private string BuildUrl(string url)
        {
            var parts = new List<string>
            {
                BaseUrl.TrimEnd('/'),
                ImportApiEndpoint
            };

            return string.Join("/", parts) + "/";
        }

        private async Task<IResponse> ImportAsync(object request, string url)
        {
            using (var client = new HttpClient())
            {
                logger?.LogDebug($"Start request with base url {BaseUrl} and url {url}");

                var urlBuilder = new StringBuilder();
                client.BaseAddress = new Uri(BuildUrl(url));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("X-Token", Token);

                logger?.LogDebug($"Endpoint Base-URL is: {client.BaseAddress.ToString()}");

                var json = JsonConvert.SerializeObject(request);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(url, content);
                var responseContent = await response.Content.ReadAsStringAsync();

                try
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var importResponse = new ImportResponse((int)response.StatusCode, responseContent);
                        JsonConvert.PopulateObject(responseContent, importResponse);
                        logger?.LogInformation($"Request ({url}) successful: {importResponse.AddedCount} entities added, {importResponse.UpdatedCount} entities updated, {importResponse.RemovedCount} entities removed, {importResponse.IgnoredEntities.Count} entities ignored.");
                        return importResponse;
                    }
                    else
                    {
                        var errorResponse = new ErrorResponse((int)response.StatusCode, responseContent);
                        JsonConvert.PopulateObject(responseContent, errorResponse);
                        logger?.LogError($"Request was not succesful: {errorResponse.Message}");
                        return errorResponse;
                    }
                }
                catch (Exception e)
                {
                    logger?.LogError("Failed to parse response.");
                    throw e;
                }
            }
        }

        public Task<IResponse> ImportAbsencesAsync(List<AbsenceData> absences)
        {
            return ImportAsync(new AbsencesData { Absences = absences }, AbsencesUrl);
        }

        public Task<IResponse> ImportAppointmentCategoriesAsync(List<AppointmentCategoryData> categories)
        {
            return ImportAsync(new AppointmentCategoriesData { Categories = categories }, AppointmentCategoriesUrl);
        }


        public Task<IResponse> ImportAppointmentsAsync(List<AppointmentData> appointments)
        {
            return ImportAsync(new AppointmentsData { Appointments = appointments }, AppointmentsUrl);
        }

        public Task<IResponse> ImportExamsAsync(List<ExamData> exams, bool suppressNotifications = false)
        {
            return ImportAsync(new ExamsData { Exams = exams, SuppressNotifications = suppressNotifications }, ExamsUrl);
        }

        public Task<IResponse> ImportGradesAsync(List<GradeData> grades)
        {
            return ImportAsync(new GradesData { Grades = grades }, GradesUrl);
        }

        public Task<IResponse> ImportGradeTeachersAsync(List<GradeTeacherData> gradeTeachers)
        {
            return ImportAsync(new GradeTeachersData { GradeTeachers = gradeTeachers }, GradeTeachersUrl);
        }

        public Task<IResponse> ImportInfotextsAsync(List<InfotextData> infotexts)
        {
            return ImportAsync(new InfotextsData { Infotexts = infotexts }, InfotextsUrl);
        }

        public Task<IResponse> ImportStudentsAsync(List<StudentData> students)
        {
            return ImportAsync(new StudentsData { Students = students }, StudentsUrl);
        }

        public Task<IResponse> ImportStudyGroupMembershipsAsync(List<StudyGroupMembershipData> memberships)
        {
            return ImportAsync(new StudyGroupMembershipsData { Memberships = memberships }, StudyGroupMembershipsUrl);
        }

        public Task<IResponse> ImportStudyGroupsAsync(List<StudyGroupData> studyGroups)
        {
            return ImportAsync(new StudyGroupsData { StudyGroups = studyGroups }, StudyGroupsUrl);
        }

        public Task<IResponse> ImportSubjectsAsync(List<SubjectData> subjects)
        {
            return ImportAsync(new SubjectsData { Subjects = subjects }, SubjectsUrl);
        }

        public Task<IResponse> ImportSubstitutionsAsync(List<SubstitutionData> substitutions, bool suppressNotifications)
        {
            return ImportAsync(new SubstitutionsData { Substitutions = substitutions, SuppressNotifications = suppressNotifications }, SubstitutionsUrl);
        }

        public Task<IResponse> ImportSupervisionsAsync(string period, List<TimetableSupervisionData> supervisions)
        {
            return ImportAsync(new TimetableSupervisionsData { Period = period, Supervisions = supervisions }, TimetableSupervisionsUrl);
        }

        public Task<IResponse> ImportTeachersAsync(List<TeacherData> teachers)
        {
            return ImportAsync(new TeachersData { Teachers = teachers }, TeachersUrl);
        }

        public Task<IResponse> ImportTimetableLessonsAsync(string period, List<TimetableLessonData> lessons)
        {
            return ImportAsync(new TimetableLessonsData { Period = period, Lessons = lessons }, TimetableLessonsUrl);
        }

        public Task<IResponse> ImportTimetablePeriodsAsync(List<TimetablePeriodData> periods)
        {
            return ImportAsync(new TimetablePeriodsData { Periods = periods }, TimetablePeriodsUrl);
        }

        public Task<IResponse> ImportTuitionsAsync(List<TuitionData> tuitions)
        {
            return ImportAsync(new TuitionsData { Tuitions = tuitions }, TuitionsUrl);
        }

        public Task<IResponse> ImportPrivacyCategoriesAsync(List<PrivacyCategoryData> categories)
        {
            return ImportAsync(new PrivacyCategoriesData { Categories = categories }, PrivacyCategoryUrl);
        }

        public Task<IResponse> ImportRoomsAsync(List<RoomData> rooms)
        {
            return ImportAsync(new RoomsData { Rooms = rooms }, RoomUrl);
        }

        public Task<IResponse> ImportFreeLessonTimespansAsync(List<FreeLessonTimespanData> timespans)
        {
            return ImportAsync(new FreeLessonTimespansData { FreeLessons = timespans }, FreeLessonTimespanUrl);
        }
    }
}
