﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InvestmentFundTransactionTypeCode.  ISO2002 ID# _aczUGNp-Ed-ak6NoX_4Aeg_-1474043592.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInvestmentFundTransactionTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aczUGNp-Ed-ak6NoX_4Aeg_-1474043592")]
public partial class InvestmentFundTransactionTypeCodeDropdownSource : EnumMetadataManager<InvestmentFundTransactionTypeCode,IInvestmentFundTransactionTypeCodeDropdownRow,InvestmentFundTransactionTypeCodeDropdownRow>
{
    public InvestmentFundTransactionTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new InvestmentFundTransactionTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
