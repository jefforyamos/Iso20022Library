﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountBalanceSD9.  ISO2002 ID# _qOfHUZFCEeanIpS4qvJ1tw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding account balance. Contains transaction details of the stock loans, repurchase agreements (REPOs) and undelivered trades (FAILs).
/// </summary>
public partial record AccountBalanceSD9
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    public required IsoMax350Text PlaceAndName { get; init; } 
    /// <summary>
    /// Position held in a security as of the day prior to publication date. This position is subject to a redemption lottery call when this is the first lottery. This balance will not be adjusted for the supplemental or concurrent lotteries and will remain constant to report the original position.
    /// </summary>
    public SignedQuantityFormat9? OriginalBalance { get; init; } 
    /// <summary>
    /// Portion of the Original Balance position held in DTC General Free account as of day prior to Publication Date. Position held in this account is subject to redemption lottery call.
    /// </summary>
    public SignedQuantityFormat9? UnpledgedBalance { get; init; } 
    /// <summary>
    /// Portion of the Original Balance position held in DTC Segregated account as of day prior to Publication Date. Position held in this account is subject to redemption lottery call and must be released to allow allocation.
    /// </summary>
    public SignedQuantityFormat9? InvestmentUnpledgedBalance { get; init; } 
    /// <summary>
    /// Portion of the Original Balance position held in DTC Investment account as of day prior to Publication Date. Position held in this account is subject to redemption lottery call and must be released to allow allocation.
    /// </summary>
    public SignedQuantityFormat9? InvestmentPledgedBalance { get; init; } 
    /// <summary>
    /// Balance that has been accepted by the issuer / agent for payment.
    /// </summary>
    public SignedQuantityFormat9? AcceptedBalance { get; init; } 
    /// <summary>
    /// Balance that has not been accepted by issuer / agent for payment.
    /// </summary>
    public SignedQuantityFormat9? UnacceptedBalance { get; init; } 
    /// <summary>
    /// For Rights Subscription events, total number of oversubscribed units applicable to the payment or the subscription charge.
    /// </summary>
    public SignedQuantityFormat9? OversubscriptionBalance { get; init; } 
    
    #nullable disable
}
