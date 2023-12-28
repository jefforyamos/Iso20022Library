﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RejectionReason77Code.  ISO2002 ID# _HzvsaCtYEeyhipY4f42fZQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the request has a rejected or repair status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RejectionReason77CodeDropdownSource"/>.
/// Implements <seealso cref="IRejectionReason77CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_HzvsaCtYEeyhipY4f42fZQ")]
public partial class RejectionReason77CodeDropdownRow : EnumMetadataItem<RejectionReason77Code>, IRejectionReason77CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason why the request has a rejected or repair status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RejectionReason77CodeDropdownRow(RejectionReason77Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
