﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ConfirmationParties4.  ISO2002 ID# _AeLmRNokEeC60axPepSq7g_-324873963.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parties used for acting parties that apply either to the whole message or to individual sides.
/// </summary>
public partial record ConfirmationParties4
{
    #nullable enable
    
    /// <summary>
    /// Party that identifies the underlying investor.
    /// </summary>
    public PartyIdentificationAndAccount79[] Investor { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    public ConfirmationPartyDetails2? Buyer { get; init; } 
    /// <summary>
    /// Party that has applied, met specific requirements, and received a monetary or securities loan from a lender. The party initiating the request signs a promissory note agreeing to pay the lien holder back during a specified timeframe for the entire loan amount plus any additional fees. The borrower is legally responsible for repayment of the loan and is subject to any penalties for not repaying the loan back based on the lending terms agreed upon.
    /// </summary>
    public ConfirmationPartyDetails2? Borrower { get; init; } 
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    public ConfirmationPartyDetails2? Seller { get; init; } 
    /// <summary>
    /// A private, public or institutional entity which makes funds available to others to borrow.
    /// </summary>
    public ConfirmationPartyDetails2? Lender { get; init; } 
    /// <summary>
    /// Brokerage firm which is the commissioned broker in a multi-broker trade.
    /// </summary>
    public ConfirmationPartyDetails3? BrokerOfCredit { get; init; } 
    /// <summary>
    /// Broker or other intermediary with the closest association with the investor.
    /// </summary>
    public ConfirmationPartyDetails3? IntroducingFirm { get; init; } 
    /// <summary>
    /// Brokerage firm assigned to take credit on the trade from the step-out brokerage firm.
    /// </summary>
    public ConfirmationPartyDetails1? StepInFirm { get; init; } 
    /// <summary>
    /// Brokerage firm that executes an order, but gives other firms credit and some of the commission for the trade.
    /// </summary>
    public ConfirmationPartyDetails1? StepOutFirm { get; init; } 
    /// <summary>
    /// Party, also know as take up broker, that settles security transactions from another broker for a fee.
    /// </summary>
    public ConfirmationPartyDetails6? ClearingFirm { get; init; } 
    /// <summary>
    /// Party responsible for executing an order (for example, an executing or give-up broker). Usually a commission is charged to the client for executing an order.
    /// </summary>
    public ConfirmationPartyDetails6? ExecutingBroker { get; init; } 
    /// <summary>
    /// Party (buyer or seller) that positively affirms the details of a previously agreed security trade confirmation.
    /// </summary>
    public ConfirmationPartyDetails3? AffirmingParty { get; init; } 
    /// <summary>
    /// Party involved in a legal proceeding, agreement, or other transaction.
    /// </summary>
    public ConfirmationPartyDetails3? TradeBeneficiaryParty { get; init; } 
    
    #nullable disable
}
