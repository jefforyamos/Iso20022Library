﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ElectionTypeCode.  ISO2002 ID# _ahHzYdp-Ed-ak6NoX_4Aeg_-1893441845.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of election.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IElectionTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ahHzYdp-Ed-ak6NoX_4Aeg_-1893441845")]
public partial class ElectionTypeCodeDropdownSource : EnumMetadataManager<ElectionTypeCode,IElectionTypeCodeDropdownRow,ElectionTypeCodeDropdownRow>
{
    public ElectionTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ElectionTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
