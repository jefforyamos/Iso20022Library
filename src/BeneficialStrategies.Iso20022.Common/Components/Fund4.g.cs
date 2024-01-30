﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Fund4.  ISO2002 ID# _h_KfYWASEeSkSfzdpzkxXg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about an investment fund.
/// </summary>
public partial record Fund4
{
    #nullable enable
    
    /// <summary>
    /// Name of the fund/sub fund.
    /// </summary>
    public IsoMax350Text? Name { get; init; } 
    /// <summary>
    /// Identification of the fund/sub fund with a Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 "Financial Services - Legal Entity Identifier (LEI)".
    /// </summary>
    public IsoLEIIdentifier? LegalEntityIdentifier { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for the fund/sub fund, assigned under a formal or proprietary identification scheme.
    /// </summary>
    public OtherIdentification4? Identification { get; init; } 
    /// <summary>
    /// Currency of the fund/sub fund.
    /// </summary>
    public ActiveOrHistoricCurrencyCode? Currency { get; init; } 
    /// <summary>
    /// Total value of all the holdings, less the fund's liabilities, of the fund/sub fund.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? TotalNAV { get; init; } 
    /// <summary>
    /// Previous total value of all the holdings, less the fund's liabilities, of the fund/sub fund.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? PreviousTotalNAV { get; init; } 
    /// <summary>
    /// Total number of units of the fund/sub fund.
    /// </summary>
    public FinancialInstrumentQuantity1? TotalUnitsNumber { get; init; } 
    /// <summary>
    /// Previous total number of units of the fund/sub fund.
    /// </summary>
    public FinancialInstrumentQuantity1? PreviousTotalUnitsNumber { get; init; } 
    /// <summary>
    /// Consolidated net cash flow expressed as a percentage of the total NAV for the fund/sub fund.
    /// </summary>
    public IsoPercentageRate? PercentageOfFundTotalNAV { get; init; } 
    
    #nullable disable
}
