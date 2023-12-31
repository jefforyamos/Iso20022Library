﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ISAType2Code.  ISO2002 ID# _adi689p-Ed-ak6NoX_4Aeg_1019974978.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of the current year ISA.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ISAType2CodeDropdownSource"/>.
/// Implements <seealso cref="IISAType2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_adi689p-Ed-ak6NoX_4Aeg_1019974978")]
public partial class ISAType2CodeDropdownRow : EnumMetadataItem<ISAType2Code>, IISAType2CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of the current year ISA.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ISAType2CodeDropdownRow(ISAType2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
