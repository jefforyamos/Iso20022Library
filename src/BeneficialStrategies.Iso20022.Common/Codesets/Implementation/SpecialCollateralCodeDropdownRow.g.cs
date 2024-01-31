﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SpecialCollateralCode.  ISO2002 ID# _Q4dpgJf_EeSfnc-VXAEapg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the collateral type against which all repurchase agreements are conducted.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SpecialCollateralCodeDropdownSource"/>.
/// Implements <seealso cref="ISpecialCollateralCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Q4dpgJf_EeSfnc-VXAEapg")]
public partial class SpecialCollateralCodeDropdownRow : EnumMetadataItem<SpecialCollateralCode>, ISpecialCollateralCodeDropdownRow
{
    /// <summary>
    /// Specifies the collateral type against which all repurchase agreements are conducted.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SpecialCollateralCodeDropdownRow(SpecialCollateralCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
