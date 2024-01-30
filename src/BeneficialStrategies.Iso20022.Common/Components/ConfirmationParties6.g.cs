﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ConfirmationParties6.  ISO2002 ID# _hv4QUY-iEeaEa8S_GI1QNA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parties used for acting parties that apply either to the whole message or to individual sides.
/// </summary>
public partial record ConfirmationParties6
{
    #nullable enable
    
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    public ConfirmationPartyDetails7? Buyer { get; init; } 
    /// <summary>
    /// Party that has applied, met specific requirements, and received a monetary or securities loan from a lender. The party initiating the request signs a promissory note agreeing to pay the lien holder back during a specified timeframe for the entire loan amount plus any additional fees. The borrower is legally responsible for repayment of the loan and is subject to any penalties for not repaying the loan back based on the lending terms agreed upon.
    /// </summary>
    public ConfirmationPartyDetails7? Borrower { get; init; } 
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    public ConfirmationPartyDetails7? Seller { get; init; } 
    /// <summary>
    /// A private, public or institutional entity which makes funds available to others to borrow.
    /// </summary>
    public ConfirmationPartyDetails7? Lender { get; init; } 
    /// <summary>
    /// Brokerage firm which is the commissioned broker in a multi-broker trade.
    /// </summary>
    public ConfirmationPartyDetails8? BrokerOfCredit { get; init; } 
    /// <summary>
    /// Broker or other intermediary with the closest association with the investor.
    /// </summary>
    public ConfirmationPartyDetails8? IntroducingFirm { get; init; } 
    /// <summary>
    /// Brokerage firm assigned to take credit on the trade from the step-out brokerage firm.
    /// </summary>
    public ConfirmationPartyDetails8? StepInFirm { get; init; } 
    /// <summary>
    /// Brokerage firm that executes an order, but gives other firms credit and some of the commission for the trade.
    /// </summary>
    public ConfirmationPartyDetails8? StepOutFirm { get; init; } 
    /// <summary>
    /// Party, also know as take up broker, that settles security transactions from another broker for a fee.
    /// </summary>
    public ConfirmationPartyDetails9? ClearingFirm { get; init; } 
    /// <summary>
    /// Party responsible for executing an order (for example, an executing or give-up broker). Usually a commission is charged to the client for executing an order.
    /// </summary>
    public ConfirmationPartyDetails9? ExecutingBroker { get; init; } 
    /// <summary>
    /// Party sending the message to the CMU (Central Matching Utility) to identify the actual business unit as known to the CMU (Central Matching Utility).
    /// </summary>
    public ConfirmationPartyDetails8? CMUParty { get; init; } 
    /// <summary>
    /// Actual business unit of the counterparty to the sender of the message to the CMU (Central Matching Utility) as known to the CMU (Central Matching Utility).
    /// </summary>
    public ConfirmationPartyDetails8? CMUCounterparty { get; init; } 
    /// <summary>
    /// Party (buyer or seller) that positively affirms the details of a previously agreed security trade confirmation.
    /// </summary>
    public ConfirmationPartyDetails8? AffirmingParty { get; init; } 
    /// <summary>
    /// Party involved in a legal proceeding, agreement or other transaction.
    /// </summary>
    public ConfirmationPartyDetails10? TradeBeneficiaryParty { get; init; } 
    
    #nullable disable
}
