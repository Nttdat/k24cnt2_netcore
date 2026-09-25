namespace NttdLesson09Annotation.Models.DataModels
{
    public class NttdMember
    {
        public int NttdMemberId { get; set; }
        public string? NttdMemberUserName { get; set; } 
        public string? NttdMemberPassWord { get; set; } 
        public string? NttdMemberEmail { get; set; } 
        public string? NttdMemberPhoneNumber { get; set; } 
        public DateTime? NttdMemberBirthday { get; set; }
    }
}
