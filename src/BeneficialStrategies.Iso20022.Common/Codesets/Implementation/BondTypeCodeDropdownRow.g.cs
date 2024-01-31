﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for BondTypeCode.  ISO2002 ID# _5al_gc4lEeSc85GUbgBycw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of bonds.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="BondTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IBondTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_5al_gc4lEeSc85GUbgBycw")]
public partial class BondTypeCodeDropdownRow : EnumMetadataItem<BondTypeCode>, IBondTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of bonds.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public BondTypeCodeDropdownRow(BondTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
