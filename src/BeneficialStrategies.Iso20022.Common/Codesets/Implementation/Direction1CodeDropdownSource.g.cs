﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Direction1Code.  ISO2002 ID# _awK8Adp-Ed-ak6NoX_4Aeg_1477351773.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the direction of a payment.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDirection1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_awK8Adp-Ed-ak6NoX_4Aeg_1477351773")]
public partial class Direction1CodeDropdownSource : EnumMetadataManager<Direction1Code,IDirection1CodeDropdownRow,Direction1CodeDropdownRow>
{
    public Direction1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Direction1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
