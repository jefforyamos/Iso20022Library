﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DerivativeEventTypeV2Code.  ISO2002 ID# _YLv1ME2VEe2bQ-Ksk8mwQg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Explanation or reason for the action being taken on the transaction reporting.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DerivativeEventTypeV2CodeDropdownSource"/>.
/// Implements <seealso cref="IDerivativeEventTypeV2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YLv1ME2VEe2bQ-Ksk8mwQg")]
public partial class DerivativeEventTypeV2CodeDropdownRow : EnumMetadataItem<DerivativeEventTypeV2Code>, IDerivativeEventTypeV2CodeDropdownRow
{
    /// <summary>
    /// Explanation or reason for the action being taken on the transaction reporting.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DerivativeEventTypeV2CodeDropdownRow(DerivativeEventTypeV2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
