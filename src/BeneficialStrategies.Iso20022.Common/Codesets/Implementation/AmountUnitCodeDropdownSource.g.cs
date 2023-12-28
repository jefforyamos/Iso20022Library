﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AmountUnitCode.  ISO2002 ID# _YOwqMNtlEeipuvJHTHIw9A.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Unit of a amount (for loyalty or account).
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAmountUnitCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YOwqMNtlEeipuvJHTHIw9A")]
public partial class AmountUnitCodeDropdownSource : EnumMetadataManager<AmountUnitCode,IAmountUnitCodeDropdownRow,AmountUnitCodeDropdownRow>
{
    public AmountUnitCodeDropdownSource()
        : base( (enumValue, memberInfo) => new AmountUnitCodeDropdownRow(enumValue, memberInfo))
    {
    }
}