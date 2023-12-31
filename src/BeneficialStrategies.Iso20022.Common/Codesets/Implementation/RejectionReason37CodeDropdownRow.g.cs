﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RejectionReason37Code.  ISO2002 ID# _okzg0SwrEeOEV5XHD-BKpw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the settlement instruction has a rejected status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RejectionReason37CodeDropdownSource"/>.
/// Implements <seealso cref="IRejectionReason37CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_okzg0SwrEeOEV5XHD-BKpw")]
public partial class RejectionReason37CodeDropdownRow : EnumMetadataItem<RejectionReason37Code>, IRejectionReason37CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason why the settlement instruction has a rejected status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RejectionReason37CodeDropdownRow(RejectionReason37Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
