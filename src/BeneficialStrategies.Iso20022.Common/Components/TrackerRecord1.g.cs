﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TrackerRecord1.  ISO2002 ID# _2db_MIW5EeiDBOVr6AJAFA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the agent specific tracking system information of a payment transaction.
/// </summary>
public partial record TrackerRecord1
{
    #nullable enable
    
    /// <summary>
    /// Identification of an agent in the tracker.
    /// </summary>
    public required BranchAndFinancialInstitutionIdentification6 Agent { get; init; } 
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    public ChargeBearerType1Code? ChargeBearer { get; init; } 
    /// <summary>
    /// Transaction charges to be paid by the charge bearer.
    /// </summary>
    public IsoActiveCurrencyAndAmount? ChargesAmount { get; init; } 
    /// <summary>
    /// Provides details of the rate and the currencies used in the foreign exchange.
    /// </summary>
    public CurrencyExchange13? ExchangeRateData { get; init; } 
    
    #nullable disable
}
