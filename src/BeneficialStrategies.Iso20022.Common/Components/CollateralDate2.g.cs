﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralDate2.  ISO2002 ID# _qxz5MRInEeyZaPkaPAzTvQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Dates related to the triparty collateral instruction or transactions.
/// </summary>
public partial record CollateralDate2
{
    #nullable enable
    
    /// <summary>
    /// Date the transaction was agreed between the trading parties.
    /// </summary>
    public IsoISODate? TradeDate { get; init; } 
    /// <summary>
    /// Date/time at which the instructing party requests the instruction to be executed. 
    /// </summary>
    public IDateAndDateTime2Choice? RequestedExecutionDate { get; init; } 
    /// <summary>
    /// Date on which the financial instruments are to be delivered or received.
    /// </summary>
    public IsoISODate? SettlementDate { get; init; } 
    
    #nullable disable
}
