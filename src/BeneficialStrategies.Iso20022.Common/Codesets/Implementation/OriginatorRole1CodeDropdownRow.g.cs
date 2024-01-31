﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for OriginatorRole1Code.  ISO2002 ID# _Zw1l89p-Ed-ak6NoX_4Aeg_144300492.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies in what capacity (role) the originator of a quote is acting.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="OriginatorRole1CodeDropdownSource"/>.
/// Implements <seealso cref="IOriginatorRole1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Zw1l89p-Ed-ak6NoX_4Aeg_144300492")]
public partial class OriginatorRole1CodeDropdownRow : EnumMetadataItem<OriginatorRole1Code>, IOriginatorRole1CodeDropdownRow
{
    /// <summary>
    /// Specifies in what capacity (role) the originator of a quote is acting.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public OriginatorRole1CodeDropdownRow(OriginatorRole1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
