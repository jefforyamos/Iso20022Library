﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ConfirmationParties9.  ISO2002 ID# _YMcpnwasEe2phaVG0lYKTw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parties used for acting parties that apply either to the whole message or to individual sides.
/// </summary>
[DataContract]
[XmlType]
public partial record ConfirmationParties9
{
    #nullable enable
    
    /// <summary>
    /// Party that identifies the underlying investor.
    /// </summary>
    [DataMember]
    public ValueList<PartyIdentificationAndAccount220> Investor { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [DataMember]
    public ConfirmationPartyDetails12? Buyer { get; init; } 
    /// <summary>
    /// Party that has applied, met specific requirements, and received a monetary or securities loan from a lender. The party initiating the request signs a promissory note agreeing to pay the lien holder back during a specified timeframe for the entire loan amount plus any additional fees. The borrower is legally responsible for repayment of the loan and is subject to any penalties for not repaying the loan back based on the lending terms agreed upon.
    /// </summary>
    [DataMember]
    public ConfirmationPartyDetails12? Borrower { get; init; } 
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [DataMember]
    public ConfirmationPartyDetails12? Seller { get; init; } 
    /// <summary>
    /// A private, public or institutional entity which makes funds available to others to borrow.
    /// </summary>
    [DataMember]
    public ConfirmationPartyDetails12? Lender { get; init; } 
    /// <summary>
    /// Brokerage firm which is the commissioned broker in a multi-broker trade.
    /// </summary>
    [DataMember]
    public ConfirmationPartyDetails14? BrokerOfCredit { get; init; } 
    /// <summary>
    /// Broker or other intermediary with the closest association with the investor.
    /// </summary>
    [DataMember]
    public ConfirmationPartyDetails14? IntroducingFirm { get; init; } 
    /// <summary>
    /// Brokerage firm assigned to take credit on the trade from the step-out brokerage firm.
    /// </summary>
    [DataMember]
    public ConfirmationPartyDetails11? StepInFirm { get; init; } 
    /// <summary>
    /// Brokerage firm that executes an order, but gives other firms credit and some of the commission for the trade.
    /// </summary>
    [DataMember]
    public ConfirmationPartyDetails11? StepOutFirm { get; init; } 
    /// <summary>
    /// Party, also know as take up broker, that settles security transactions from another broker for a fee.
    /// </summary>
    [DataMember]
    public ConfirmationPartyDetails16? ClearingFirm { get; init; } 
    /// <summary>
    /// Party responsible for executing an order (for example, an executing or give-up broker). Usually a commission is charged to the client for executing an order.
    /// </summary>
    [DataMember]
    public ConfirmationPartyDetails16? ExecutingBroker { get; init; } 
    /// <summary>
    /// Party (buyer or seller) that positively affirms the details of a previously agreed security trade confirmation.
    /// </summary>
    [DataMember]
    public ConfirmationPartyDetails14? AffirmingParty { get; init; } 
    /// <summary>
    /// Party involved in a legal proceeding, agreement, or other transaction.
    /// </summary>
    [DataMember]
    public ConfirmationPartyDetails14? TradeBeneficiaryParty { get; init; } 
    
    #nullable disable
}
