﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ProposalType1Code.  ISO2002 ID# _YdGGI9p-Ed-ak6NoX_4Aeg_1323819587.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the proposal is an initial or a counter proposal.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IProposalType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YdGGI9p-Ed-ak6NoX_4Aeg_1323819587")]
public partial class ProposalType1CodeDropdownSource : EnumMetadataManager<ProposalType1Code,IProposalType1CodeDropdownRow,ProposalType1CodeDropdownRow>
{
    public ProposalType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ProposalType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
