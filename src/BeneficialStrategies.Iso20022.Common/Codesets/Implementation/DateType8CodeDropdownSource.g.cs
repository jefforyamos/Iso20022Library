﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DateType8Code.  ISO2002 ID# _m23dkeEMEd-qUMZtd_eZuQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of dates.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDateType8CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_m23dkeEMEd-qUMZtd_eZuQ")]
public partial class DateType8CodeDropdownSource : EnumMetadataManager<DateType8Code,IDateType8CodeDropdownRow,DateType8CodeDropdownRow>
{
    public DateType8CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DateType8CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
