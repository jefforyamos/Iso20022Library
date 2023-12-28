﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ChequePartyRoleCode.  ISO2002 ID# _eJokECmxEeutWNGMV2XKIQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the roles of the parties linked to a cheque.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ChequePartyRoleCodeDropdownSource"/>.
/// Implements <seealso cref="IChequePartyRoleCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_eJokECmxEeutWNGMV2XKIQ")]
public partial class ChequePartyRoleCodeDropdownRow : EnumMetadataItem<ChequePartyRoleCode>, IChequePartyRoleCodeDropdownRow
{
    /// <summary>
    /// Specifies the roles of the parties linked to a cheque.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ChequePartyRoleCodeDropdownRow(ChequePartyRoleCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}