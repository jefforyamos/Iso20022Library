﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InvestmentFundMiFIDFeeCode.  ISO2002 ID# _N_RgADclEeidBoT_PugKiA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of cost or charge.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInvestmentFundMiFIDFeeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_N_RgADclEeidBoT_PugKiA")]
public partial class InvestmentFundMiFIDFeeCodeDropdownSource : EnumMetadataManager<InvestmentFundMiFIDFeeCode,IInvestmentFundMiFIDFeeCodeDropdownRow,InvestmentFundMiFIDFeeCodeDropdownRow>
{
    public InvestmentFundMiFIDFeeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new InvestmentFundMiFIDFeeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
