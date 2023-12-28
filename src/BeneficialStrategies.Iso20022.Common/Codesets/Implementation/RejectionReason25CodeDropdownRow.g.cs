﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RejectionReason25Code.  ISO2002 ID# _ZjlNFtp-Ed-ak6NoX_4Aeg_-1820710282.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the settlement instruction has a rejected status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RejectionReason25CodeDropdownSource"/>.
/// Implements <seealso cref="IRejectionReason25CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZjlNFtp-Ed-ak6NoX_4Aeg_-1820710282")]
public partial class RejectionReason25CodeDropdownRow : EnumMetadataItem<RejectionReason25Code>, IRejectionReason25CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason why the settlement instruction has a rejected status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RejectionReason25CodeDropdownRow(RejectionReason25Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}