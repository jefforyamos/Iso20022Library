﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SpecialCollateral1Code.  ISO2002 ID# _crADcJf_EeSfnc-VXAEapg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the collateral type against which all repurchase agreements are conducted.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SpecialCollateral1CodeDropdownSource"/>.
/// Implements <seealso cref="ISpecialCollateral1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_crADcJf_EeSfnc-VXAEapg")]
public partial class SpecialCollateral1CodeDropdownRow : EnumMetadataItem<SpecialCollateral1Code>, ISpecialCollateral1CodeDropdownRow
{
    /// <summary>
    /// Specifies the collateral type against which all repurchase agreements are conducted.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SpecialCollateral1CodeDropdownRow(SpecialCollateral1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
