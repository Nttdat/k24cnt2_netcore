using System.ComponentModel;

namespace NttdLesson08Models.Models
{
    public class NttdMember
    {
        public string NttdMemberId { get; set; }
        public string NttdUserName { get; set; }
        public string NttdPassword { get; set; }

        [DisplayName("Họ và tên")]
        public string NttdFullName { get; set; }
        public string NttdEmail { get; set; }
    }
}
