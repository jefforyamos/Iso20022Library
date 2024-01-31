﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ResidualCashCode.  ISO2002 ID# _qoyqE_peEeCLMa5EIHtDrg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether there is cash in the account that is awaiting investment.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IResidualCashCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_qoyqE_peEeCLMa5EIHtDrg")]
public partial class ResidualCashCodeDropdownSource : EnumMetadataManager<ResidualCashCode,IResidualCashCodeDropdownRow,ResidualCashCodeDropdownRow>
{
    public ResidualCashCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ResidualCashCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
