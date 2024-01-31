﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ClearingMethod1Code.  ISO2002 ID# _zEIoUH6HEeSAlrUr1Vow5g.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the value is net (inclusive of tax) or gross.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ClearingMethod1CodeDropdownSource"/>.
/// Implements <seealso cref="IClearingMethod1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_zEIoUH6HEeSAlrUr1Vow5g")]
public partial class ClearingMethod1CodeDropdownRow : EnumMetadataItem<ClearingMethod1Code>, IClearingMethod1CodeDropdownRow
{
    /// <summary>
    /// Specifies whether the value is net (inclusive of tax) or gross.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ClearingMethod1CodeDropdownRow(ClearingMethod1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
