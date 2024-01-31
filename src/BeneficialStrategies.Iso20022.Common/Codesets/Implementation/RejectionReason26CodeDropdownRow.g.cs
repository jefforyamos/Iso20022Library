﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RejectionReason26Code.  ISO2002 ID# _ZkB5Cdp-Ed-ak6NoX_4Aeg_663109859.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the securities financing instruction has a rejected status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RejectionReason26CodeDropdownSource"/>.
/// Implements <seealso cref="IRejectionReason26CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZkB5Cdp-Ed-ak6NoX_4Aeg_663109859")]
public partial class RejectionReason26CodeDropdownRow : EnumMetadataItem<RejectionReason26Code>, IRejectionReason26CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason why the securities financing instruction has a rejected status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RejectionReason26CodeDropdownRow(RejectionReason26Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
