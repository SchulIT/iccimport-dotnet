using SchulIT.IccImport.Models;
using SchulIT.IccImport.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchulIT.IccImport
{
    public interface IIccImporter
    {
        string Token { get; set; }

        string BaseUrl { get; set; }

        Task<IResponse> ImportAppointmentsAsync(List<AppointmentData> appointments);

        Task<IResponse> ImportAppointmentCategoriesAsync(List<AppointmentCategoryData> categories);

        Task<IResponse> ImportExamsAsync(List<ExamData> exams);

        Task<IResponse> ImportGradesAsync(List<GradeData> grades);

        Task<IResponse> ImportGradeTeachersAsync(List<GradeTeacherData> gradeTeachers);

        Task<IResponse> ImportStudentsAsync(List<StudentData> students);

        Task<IResponse> ImportStudyGroupsAsync(List<StudyGroupData> studyGroups);

        Task<IResponse> ImportStudyGroupMembershipsAsync(List<StudyGroupMembershipData> memberships);

        Task<IResponse> ImportSubjectsAsync(List<SubjectData> subjects);

        Task<IResponse> ImportSubstitutionsAsync(List<SubstitutionData> substitutions);

        Task<IResponse> ImportTeachersAsync(List<TeacherData> teachers);

        Task<IResponse> ImportTimetableLessonsAsync(string period, List<TimetableLessonData> lessons);

        Task<IResponse> ImportTimetablePeriodsAsync(List<TimetablePeriodData> periods);

        Task<IResponse> ImportSupervisionsAsync(string period, List<TimetableSupervisionData> supervisions);

        Task<IResponse> ImportTuitionsAsync(List<TuitionData> tuitions);

        Task<IResponse> ImportInfotextsAsync(List<InfotextData> infotexts);

        Task<IResponse> ImportAbsencesAsync(List<AbsenceData> absences);

        Task<IResponse> ImportPrivacyCategoriesAsync(List<PrivacyCategoryData> categories);

        Task<IResponse> ImportRoomsAsync(List<RoomData> rooms);

        Task<IResponse> ImportFreeLessonTimespansAsync(List<FreeLessonTimespanData> timespans);
    }
}
