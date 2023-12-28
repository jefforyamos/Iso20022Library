﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InvestmentFundFee1Code.  ISO2002 ID# _YL5_oDiCEeaH-93K5JKmzw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of service for which a fee e is asked or paid.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInvestmentFundFee1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YL5_oDiCEeaH-93K5JKmzw")]
public partial class InvestmentFundFee1CodeDropdownSource : EnumMetadataManager<InvestmentFundFee1Code,IInvestmentFundFee1CodeDropdownRow,InvestmentFundFee1CodeDropdownRow>
{
    public InvestmentFundFee1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new InvestmentFundFee1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
