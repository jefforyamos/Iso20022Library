﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ChargeType13Code.  ISO2002 ID# _a81fBdp-Ed-ak6NoX_4Aeg_724898334.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies charges linked to the type of service.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ChargeType13CodeDropdownSource"/>.
/// Implements <seealso cref="IChargeType13CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a81fBdp-Ed-ak6NoX_4Aeg_724898334")]
public partial class ChargeType13CodeDropdownRow : EnumMetadataItem<ChargeType13Code>, IChargeType13CodeDropdownRow
{
    /// <summary>
    /// Identifies charges linked to the type of service.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ChargeType13CodeDropdownRow(ChargeType13Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
