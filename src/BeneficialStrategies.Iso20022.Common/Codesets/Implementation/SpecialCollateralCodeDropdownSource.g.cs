﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SpecialCollateralCode.  ISO2002 ID# _Q4dpgJf_EeSfnc-VXAEapg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the collateral type against which all repurchase agreements are conducted.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISpecialCollateralCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Q4dpgJf_EeSfnc-VXAEapg")]
public partial class SpecialCollateralCodeDropdownSource : EnumMetadataManager<SpecialCollateralCode,ISpecialCollateralCodeDropdownRow,SpecialCollateralCodeDropdownRow>
{
    public SpecialCollateralCodeDropdownSource()
        : base( (enumValue, memberInfo) => new SpecialCollateralCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
