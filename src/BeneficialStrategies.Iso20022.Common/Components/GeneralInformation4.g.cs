﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GeneralInformation4.  ISO2002 ID# _y1bu0R9rEeKR8ap75esygQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information concerning the negotiation process leading to a treasury trade.
/// </summary>
public partial record GeneralInformation4
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the trade is a block or single trade.
    /// </summary>
    public IsoYesNoIndicator? BlockIndicator { get; init; } 
    /// <summary>
    /// Reference to a preceding transaction, for example, an option or swap.
    /// </summary>
    public IsoMax35Text? RelatedTradeReference { get; init; } 
    /// <summary>
    /// Method used by the trading parties to negotiate and/or execute a deal.
    /// </summary>
    public Trading1MethodCode? DealingMethod { get; init; } 
    /// <summary>
    /// Specifies the broker which arranged the deal between the trading side and the counterparty side or, when two money brokers are involved, between the trading side and the other money broker.
    /// </summary>
    public IPartyIdentification73Choice? BrokerIdentification { get; init; } 
    /// <summary>
    /// Counterparty's reference for the trade.
    /// </summary>
    public IsoMax35Text? CounterpartyReference { get; init; } 
    /// <summary>
    /// Brokerage fee for a broker confirmation.
    /// </summary>
    public IsoActiveCurrencyAndAmount? BrokersCommission { get; init; } 
    /// <summary>
    /// Specifies additional information for the receiver and applies to the whole message.
    /// </summary>
    public IsoMax210Text? SenderToReceiverInformation { get; init; } 
    /// <summary>
    /// Specifies the branch at the trading side with which the deal was done.
    /// </summary>
    public IPartyIdentification73Choice? DealingBranchTradingSide { get; init; } 
    /// <summary>
    /// Specifies the branch at the counterparty side with which the deal was done.
    /// </summary>
    public IPartyIdentification73Choice? DealingBranchCounterpartySide { get; init; } 
    /// <summary>
    /// Specifies the name and/or electronic address of the receiver of the message who may be contacted for any queries concerning this trade.
    /// </summary>
    public ContactInformation1? ContactInformation { get; init; } 
    
    #nullable disable
}
