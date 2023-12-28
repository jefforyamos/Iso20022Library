﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InvestmentFundRole3Code.  ISO2002 ID# _acM3INp-Ed-ak6NoX_4Aeg_1517704034.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the role played by the actors in the investment funds industry.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInvestmentFundRole3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_acM3INp-Ed-ak6NoX_4Aeg_1517704034")]
public partial class InvestmentFundRole3CodeDropdownSource : EnumMetadataManager<InvestmentFundRole3Code,IInvestmentFundRole3CodeDropdownRow,InvestmentFundRole3CodeDropdownRow>
{
    public InvestmentFundRole3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new InvestmentFundRole3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
