﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionDate68.  ISO2002 ID# _skqhy83wEee5nJBZsW8MFQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action date.
/// </summary>
public partial record CorporateActionDate68
{
    #nullable enable
    
    /// <summary>
    /// Date/time at which the account servicer has set as the deadline to respond, with instructions, to an outstanding event. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).
    /// </summary>
    public DateFormat49Choice_? ResponseDeadline { get; init; } 
    /// <summary>
    /// Date/time by which cash must be in place in order to take part in the event.
    /// </summary>
    public DateFormat49Choice_? SubscriptionCostDebitDate { get; init; } 
    /// <summary>
    /// Issuer or issuer's agent deadline to respond, with an instruction, to an outstanding offer or privilege.
    /// </summary>
    public DateFormat49Choice_? MarketDeadline { get; init; } 
    /// <summary>
    /// Date/time at which an order expires or on which a privilege or offer terminates.
    /// </summary>
    public DateFormat49Choice_? ExpiryDate { get; init; } 
    /// <summary>
    /// Last day a holder can deliver the securities that it had elected on and/or previously protected.
    /// </summary>
    public DateFormat49Choice_? CoverExpirationDate { get; init; } 
    /// <summary>
    /// Last date/time a holder can request to defer delivery of securities pursuant to a notice of guaranteed delivery or other required documentation.
    /// </summary>
    public DateFormat49Choice_? ProtectDate { get; init; } 
    /// <summary>
    /// Date/time at which the deal (rights) was agreed.
    /// </summary>
    public DateFormat49Choice_? TradingDate { get; init; } 
    
    #nullable disable
}
