﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InvestmentFundRole1Code.  ISO2002 ID# _Vi-eZtp-Ed-ak6NoX_4Aeg_1660914600.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the role played by the actors in the investment funds industry.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInvestmentFundRole1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Vi-eZtp-Ed-ak6NoX_4Aeg_1660914600")]
public partial class InvestmentFundRole1CodeDropdownSource : EnumMetadataManager<InvestmentFundRole1Code,IInvestmentFundRole1CodeDropdownRow,InvestmentFundRole1CodeDropdownRow>
{
    public InvestmentFundRole1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new InvestmentFundRole1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}