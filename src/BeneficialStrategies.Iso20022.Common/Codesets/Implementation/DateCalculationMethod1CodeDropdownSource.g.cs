﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DateCalculationMethod1Code.  ISO2002 ID# _TNd2QFSVEempisJfoIfvvQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the calculation method to be used to determine on which dates the shares have been acquired.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDateCalculationMethod1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TNd2QFSVEempisJfoIfvvQ")]
public partial class DateCalculationMethod1CodeDropdownSource : EnumMetadataManager<DateCalculationMethod1Code,IDateCalculationMethod1CodeDropdownRow,DateCalculationMethod1CodeDropdownRow>
{
    public DateCalculationMethod1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DateCalculationMethod1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
