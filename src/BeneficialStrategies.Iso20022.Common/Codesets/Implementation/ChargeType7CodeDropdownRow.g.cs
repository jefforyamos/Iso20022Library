﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ChargeType7Code.  ISO2002 ID# _Vlzv-Np-Ed-ak6NoX_4Aeg_-1682515584.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of service for which a charge is asked or paid.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ChargeType7CodeDropdownSource"/>.
/// Implements <seealso cref="IChargeType7CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Vlzv-Np-Ed-ak6NoX_4Aeg_-1682515584")]
public partial class ChargeType7CodeDropdownRow : EnumMetadataItem<ChargeType7Code>, IChargeType7CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of service for which a charge is asked or paid.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ChargeType7CodeDropdownRow(ChargeType7Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
