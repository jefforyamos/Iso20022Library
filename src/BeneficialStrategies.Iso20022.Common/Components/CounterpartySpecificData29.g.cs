﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CounterpartySpecificData29.  ISO2002 ID# _nQXxmXg-Eeu3kecHd7QKUQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related specifically to counterparties.
/// </summary>
public partial record CounterpartySpecificData29
{
    #nullable enable
    
    /// <summary>
    /// Data specific to counterparties of the reported transaction/position.
    /// </summary>
    public required TradeCounterpartyReport14 Counterparty { get; init; } 
    /// <summary>
    /// Data specific to the valuation of the transaction.
    /// </summary>
    public ContractValuationData6? Valuation { get; init; } 
    /// <summary>
    /// Information related to collateral agreement existing between counterparties.
    /// Usage: This element is not present when there is no collateral agreement or if no collateral is posted or received.
    /// </summary>
    public TradeCollateralReport5? Collateral { get; init; } 
    /// <summary>
    /// Indicates the date and time of the submission of the report to the trade repository.
    /// </summary>
    public required IsoISODateTime ReportingTimeStamp { get; init; } 
    
    #nullable disable
}
