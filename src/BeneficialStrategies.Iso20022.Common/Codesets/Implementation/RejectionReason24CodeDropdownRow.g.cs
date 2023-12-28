﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RejectionReason24Code.  ISO2002 ID# _ZjbcF9p-Ed-ak6NoX_4Aeg_-1383112473.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the request has a rejected or repair status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RejectionReason24CodeDropdownSource"/>.
/// Implements <seealso cref="IRejectionReason24CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZjbcF9p-Ed-ak6NoX_4Aeg_-1383112473")]
public partial class RejectionReason24CodeDropdownRow : EnumMetadataItem<RejectionReason24Code>, IRejectionReason24CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason why the request has a rejected or repair status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RejectionReason24CodeDropdownRow(RejectionReason24Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}