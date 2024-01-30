﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionDate18.  ISO2002 ID# _jMBm3fZFEd-2Jsl2KtUQCw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action date.
/// </summary>
public partial record CorporateActionDate18
{
    #nullable enable
    
    /// <summary>
    /// Date/time at which the account servicer has set as the deadline to respond, with instructions, to an outstanding event. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).
    /// </summary>
    public IDateFormat19Choice? ResponseDeadline { get; init; } 
    /// <summary>
    /// Date/time by which cash must be in place in order to take part in the event.
    /// </summary>
    public IDateFormat19Choice? SubscriptionCostDebitDate { get; init; } 
    /// <summary>
    /// Issuer or issuer's agent deadline to respond, with an instruction, to an outstanding offer or privilege.
    /// </summary>
    public IDateFormat19Choice? MarketDeadline { get; init; } 
    /// <summary>
    /// Date/time at which an order expires or on which a privilege or offer terminates.
    /// </summary>
    public IDateFormat19Choice? ExpiryDate { get; init; } 
    /// <summary>
    /// Last day a holder can deliver the securities that it had elected on and/or previously protected.
    /// </summary>
    public IDateFormat19Choice? CoverExpirationDate { get; init; } 
    /// <summary>
    /// Last date/time a holder can request to defer delivery of securities pursuant to a notice of guaranteed delivery or other required documentation.
    /// </summary>
    public IDateFormat19Choice? ProtectDate { get; init; } 
    /// <summary>
    /// Date/time at which the deal (rights) was agreed.
    /// </summary>
    public IDateFormat19Choice? TradingDate { get; init; } 
    
    #nullable disable
}
