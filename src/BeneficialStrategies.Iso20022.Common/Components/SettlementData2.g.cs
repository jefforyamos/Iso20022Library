﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementData2.  ISO2002 ID# _TJMjldp-Ed-ak6NoX_4Aeg_1219011122.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the settlement of a treasury trade.
/// </summary>
public partial record SettlementData2
{
    #nullable enable
    
    /// <summary>
    /// Unique reference supplied by the trade processing system.
    /// </summary>
    public IsoMax35Text? CashFlowUniqueReference { get; init; } 
    /// <summary>
    /// Unique reference assigned by a settlement system.
    /// </summary>
    public IsoMax35Text? SettlementSystemUniqueReference { get; init; } 
    /// <summary>
    /// Original amount which should be settled. This information should be provided when the trade is partially settled or when the settlement is rejected.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount SettlementAmount { get; init; } 
    /// <summary>
    /// Funds which the trading side is expected to receive.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? SettledAmount { get; init; } 
    /// <summary>
    /// Amount that cannot be settled by a settlement system.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? RejectedAmount { get; init; } 
    /// <summary>
    /// Specifies the party that pays the settlement amount.
    /// </summary>
    public required IPartyIdentification8Choice PayingParty { get; init; } 
    /// <summary>
    /// Specifies the party that receives the settlement amount.
    /// </summary>
    public required IPartyIdentification8Choice ReceivingParty { get; init; } 
    /// <summary>
    /// Date on which the settlement is due to settle.
    /// </summary>
    public required IsoISODate SettlementDate { get; init; } 
    /// <summary>
    /// Specifies the status of a settlement eg rejected, settled or awaiting authorisation.
    /// </summary>
    public required SettlementStatus1Code SettlementStatus { get; init; } 
    /// <summary>
    /// Description of the status of the settlement of a trade when no coded form is available.
    /// </summary>
    public required IsoExtended350Code ExtendedSettlementStatus { get; init; } 
    /// <summary>
    /// Additional information about the cause of the rejection of a settlement.
    /// </summary>
    public IsoMax70Text? SettlementStatusSubType { get; init; } 
    /// <summary>
    /// Cash settlement is suspended.
    /// </summary>
    public required IsoYesNoIndicator Suspended { get; init; } 
    /// <summary>
    /// Cash settlement is pending.
    /// </summary>
    public required IsoYesNoIndicator Pending { get; init; } 
    
    #nullable disable
}
