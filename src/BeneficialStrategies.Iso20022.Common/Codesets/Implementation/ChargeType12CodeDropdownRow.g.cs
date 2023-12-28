﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ChargeType12Code.  ISO2002 ID# _a8ruBtp-Ed-ak6NoX_4Aeg_-1448425004.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of service for which a charge is asked or paid.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ChargeType12CodeDropdownSource"/>.
/// Implements <seealso cref="IChargeType12CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a8ruBtp-Ed-ak6NoX_4Aeg_-1448425004")]
public partial class ChargeType12CodeDropdownRow : EnumMetadataItem<ChargeType12Code>, IChargeType12CodeDropdownRow
{
    /// <summary>
    /// Type of service for which a charge is asked or paid.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ChargeType12CodeDropdownRow(ChargeType12Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}