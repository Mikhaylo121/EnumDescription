using System.ComponentModel;

namespace EnumDescription
{
    public enum EmployeeType
    {
        [Description("Full-time")]
        FullTime,
        [Description("Part-time")]
        PartTime,
        [Description("Casual")]
        Casual,
        [Description("Fixed term")]
        FixedTerm,
        [Description("Shift workers")]
        ShiftWorkers,
        [Description("Probation")]
        Probation,
        [Description("Outworkers")]
        Outworkers
    }
}