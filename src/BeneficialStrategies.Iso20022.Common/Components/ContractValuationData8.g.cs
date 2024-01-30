﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ContractValuationData8.  ISO2002 ID# _UiQtgTOgEe2AEsHTM-bt1w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to contract valuation.
/// </summary>
public partial record ContractValuationData8
{
    #nullable enable
    
    /// <summary>
    /// Specifies the current value of the outstanding contract.
    /// </summary>
    public AmountAndDirection109? ContractValue { get; init; } 
    /// <summary>
    /// Indicates the date and time of the last valuation marked to market provided by the central counterparty (CCP) or calculated using the current or last available market price of the inputs.
    /// </summary>
    public IsoISODateTime? TimeStamp { get; init; } 
    /// <summary>
    /// Indicates the source and method used for the valuation of the transaction by the reporting counterparty.
    /// Usage:
    /// If at least one valuation input is used that is classified as mark-to-model, the whole valuation is classified as mark-to-model.
    /// If only inputs are used that are classified as mark-to-market; the whole valuation is classified as mark-to-market.|
    /// </summary>
    public ValuationType1Code? Type { get; init; } 
    /// <summary>
    /// Specifies the ratio of the absolute change in price of a derivative transaction to the change in price of the underlier, at the time a new transaction is reported or when a change in the notional amount is reported.
    /// </summary>
    public IsoLongFraction19DecimalNumber? Delta { get; init; } 
    
    #nullable disable
}
