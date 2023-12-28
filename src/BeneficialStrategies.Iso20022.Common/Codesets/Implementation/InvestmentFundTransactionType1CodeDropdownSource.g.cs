﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InvestmentFundTransactionType1Code.  ISO2002 ID# _nj6G8FsJEea4y99eritluQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInvestmentFundTransactionType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_nj6G8FsJEea4y99eritluQ")]
public partial class InvestmentFundTransactionType1CodeDropdownSource : EnumMetadataManager<InvestmentFundTransactionType1Code,IInvestmentFundTransactionType1CodeDropdownRow,InvestmentFundTransactionType1CodeDropdownRow>
{
    public InvestmentFundTransactionType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new InvestmentFundTransactionType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}