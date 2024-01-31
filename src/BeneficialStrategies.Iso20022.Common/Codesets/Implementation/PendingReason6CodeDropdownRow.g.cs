﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PendingReason6Code.  ISO2002 ID# _aDBiINp-Ed-ak6NoX_4Aeg_649445219.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why a cancellation request sent for the related instruction is pending.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PendingReason6CodeDropdownSource"/>.
/// Implements <seealso cref="IPendingReason6CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aDBiINp-Ed-ak6NoX_4Aeg_649445219")]
public partial class PendingReason6CodeDropdownRow : EnumMetadataItem<PendingReason6Code>, IPendingReason6CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason why a cancellation request sent for the related instruction is pending.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PendingReason6CodeDropdownRow(PendingReason6Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
