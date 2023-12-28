﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ChequePartyRole1Code.  ISO2002 ID# _Q-jNYCmyEeutWNGMV2XKIQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the roles of the parties linked to a cheque.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IChequePartyRole1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Q-jNYCmyEeutWNGMV2XKIQ")]
public partial class ChequePartyRole1CodeDropdownSource : EnumMetadataManager<ChequePartyRole1Code,IChequePartyRole1CodeDropdownRow,ChequePartyRole1CodeDropdownRow>
{
    public ChequePartyRole1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ChequePartyRole1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
