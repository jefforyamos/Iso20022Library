﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for UnderlyingInterestRateType3Code.  ISO2002 ID# _NdyGMICmEea6KOHFXW8q7A.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of an underlying contract for interest rate derivatives.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IUnderlyingInterestRateType3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_NdyGMICmEea6KOHFXW8q7A")]
public partial class UnderlyingInterestRateType3CodeDropdownSource : EnumMetadataManager<UnderlyingInterestRateType3Code,IUnderlyingInterestRateType3CodeDropdownRow,UnderlyingInterestRateType3CodeDropdownRow>
{
    public UnderlyingInterestRateType3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new UnderlyingInterestRateType3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}