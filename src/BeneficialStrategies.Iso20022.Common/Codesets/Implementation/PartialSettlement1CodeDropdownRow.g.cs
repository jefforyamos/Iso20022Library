﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PartialSettlement1Code.  ISO2002 ID# _ZxlM0Np-Ed-ak6NoX_4Aeg_1725602440.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Information about partial settlement.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PartialSettlement1CodeDropdownSource"/>.
/// Implements <seealso cref="IPartialSettlement1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZxlM0Np-Ed-ak6NoX_4Aeg_1725602440")]
public partial class PartialSettlement1CodeDropdownRow : EnumMetadataItem<PartialSettlement1Code>, IPartialSettlement1CodeDropdownRow
{
    /// <summary>
    /// Information about partial settlement.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PartialSettlement1CodeDropdownRow(PartialSettlement1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}