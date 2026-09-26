using System;
using System.Collections.Generic;

namespace Nttd2410900020_exam.Models;

public partial class NttdStudent
{
    public int Id { get; set; }

    public string NttdName { get; set; } = null!;

    public bool? NttdGender { get; set; }

    public DateOnly? NttdBirthDay { get; set; }

    public string? NttdEmail { get; set; }

    public string? NttdPhone { get; set; }

    public bool? NttdActive { get; set; }
}
