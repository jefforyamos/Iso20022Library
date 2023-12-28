﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OtherAmountTypeCode.  ISO2002 ID# _mutCoK53Eee6Q7mFsDuJBA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of other amount.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOtherAmountTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_mutCoK53Eee6Q7mFsDuJBA")]
public partial class OtherAmountTypeCodeDropdownSource : EnumMetadataManager<OtherAmountTypeCode,IOtherAmountTypeCodeDropdownRow,OtherAmountTypeCodeDropdownRow>
{
    public OtherAmountTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new OtherAmountTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}