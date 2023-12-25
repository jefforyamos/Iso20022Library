﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ChequePartyRoleCode.  ISO2002 ID# _eJokECmxEeutWNGMV2XKIQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the roles of the parties linked to a cheque.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IChequePartyRoleCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_eJokECmxEeutWNGMV2XKIQ")]
public partial class ChequePartyRoleCodeDropdownSource : EnumMetadataManager<ChequePartyRoleCode,IChequePartyRoleCodeDropdownRow,ChequePartyRoleCodeDropdownRow>
{
    public ChequePartyRoleCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ChequePartyRoleCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
