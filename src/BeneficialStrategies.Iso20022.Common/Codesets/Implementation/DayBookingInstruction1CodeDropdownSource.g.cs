﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DayBookingInstruction1Code.  ISO2002 ID# _aytSpNp-Ed-ak6NoX_4Aeg_1419752225.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Describes of the nature of execution booking process.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDayBookingInstruction1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aytSpNp-Ed-ak6NoX_4Aeg_1419752225")]
public partial class DayBookingInstruction1CodeDropdownSource : EnumMetadataManager<DayBookingInstruction1Code,IDayBookingInstruction1CodeDropdownRow,DayBookingInstruction1CodeDropdownRow>
{
    public DayBookingInstruction1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DayBookingInstruction1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
