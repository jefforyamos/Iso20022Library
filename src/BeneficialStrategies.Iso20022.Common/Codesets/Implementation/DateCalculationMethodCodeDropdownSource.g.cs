﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DateCalculationMethodCode.  ISO2002 ID# _oGUJ5lSUEempisJfoIfvvQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the calculation method to be used to caculate on which dates the shares have been acquired.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDateCalculationMethodCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_oGUJ5lSUEempisJfoIfvvQ")]
public partial class DateCalculationMethodCodeDropdownSource : EnumMetadataManager<DateCalculationMethodCode,IDateCalculationMethodCodeDropdownRow,DateCalculationMethodCodeDropdownRow>
{
    public DateCalculationMethodCodeDropdownSource()
        : base( (enumValue, memberInfo) => new DateCalculationMethodCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
