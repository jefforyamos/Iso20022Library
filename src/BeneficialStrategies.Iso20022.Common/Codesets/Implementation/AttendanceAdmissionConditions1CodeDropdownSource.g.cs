﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AttendanceAdmissionConditions1Code.  ISO2002 ID# _I0hQEK4nEemG7MmivSuE5g.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies conditions for physical admittance to general meetings.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAttendanceAdmissionConditions1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_I0hQEK4nEemG7MmivSuE5g")]
public partial class AttendanceAdmissionConditions1CodeDropdownSource : EnumMetadataManager<AttendanceAdmissionConditions1Code,IAttendanceAdmissionConditions1CodeDropdownRow,AttendanceAdmissionConditions1CodeDropdownRow>
{
    public AttendanceAdmissionConditions1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AttendanceAdmissionConditions1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
