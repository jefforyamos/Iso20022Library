﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for MoveType1Code.  ISO2002 ID# _aMtCltp-Ed-ak6NoX_4Aeg_-1643565851.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Describes whether peg or discretion price is static/fixed or floats.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="MoveType1CodeDropdownSource"/>.
/// Implements <seealso cref="IMoveType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aMtCltp-Ed-ak6NoX_4Aeg_-1643565851")]
public partial class MoveType1CodeDropdownRow : EnumMetadataItem<MoveType1Code>, IMoveType1CodeDropdownRow
{
    /// <summary>
    /// Describes whether peg or discretion price is static/fixed or floats.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public MoveType1CodeDropdownRow(MoveType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
