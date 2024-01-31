﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ProposalTypeCode.  ISO2002 ID# _YdGGJtp-Ed-ak6NoX_4Aeg_1195947295.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the proposal is an initial or a counter proposal.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IProposalTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YdGGJtp-Ed-ak6NoX_4Aeg_1195947295")]
public partial class ProposalTypeCodeDropdownSource : EnumMetadataManager<ProposalTypeCode,IProposalTypeCodeDropdownRow,ProposalTypeCodeDropdownRow>
{
    public ProposalTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ProposalTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
