﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ProxyNotAllowedCode.  ISO2002 ID# _ZWd-Jdp-Ed-ak6NoX_4Aeg_-1352917034.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates that the assignment of a proxy is not allowed for the meeting.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ProxyNotAllowedCodeDropdownSource"/>.
/// Implements <seealso cref="IProxyNotAllowedCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZWd-Jdp-Ed-ak6NoX_4Aeg_-1352917034")]
public partial class ProxyNotAllowedCodeDropdownRow : EnumMetadataItem<ProxyNotAllowedCode>, IProxyNotAllowedCodeDropdownRow
{
    /// <summary>
    /// Indicates that the assignment of a proxy is not allowed for the meeting.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ProxyNotAllowedCodeDropdownRow(ProxyNotAllowedCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
