﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FXAmountTypeCode.  ISO2002 ID# _7XcKNQNyEe2-vqzwMUAewg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of amount for foreign exchange commissions or fees.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFXAmountTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_7XcKNQNyEe2-vqzwMUAewg")]
public partial class FXAmountTypeCodeDropdownSource : EnumMetadataManager<FXAmountTypeCode,IFXAmountTypeCodeDropdownRow,FXAmountTypeCodeDropdownRow>
{
    public FXAmountTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new FXAmountTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
