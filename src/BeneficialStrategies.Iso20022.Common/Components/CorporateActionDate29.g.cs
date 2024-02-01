﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionDate29.  ISO2002 ID# _JU-fsSX0EeO4bIO_HtGo9Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action dates.
/// </summary>
public partial record CorporateActionDate29
{
    #nullable enable
    
    /// <summary>
    /// Date/time that the account servicer has set as the deadline to respond, with instructions, to an outstanding event, giving the holder eligibility to incentives. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).
    /// </summary>
    public DateFormat19Choice_? EarlyResponseDeadline { get; init; } 
    /// <summary>
    /// Last day a holder can deliver the securities that it had elected on and/or previously protected.
    /// </summary>
    public DateFormat19Choice_? CoverExpirationDate { get; init; } 
    /// <summary>
    /// Last date/time a holder can request to defer delivery of securities pursuant to a notice of guaranteed delivery or other required documentation.
    /// </summary>
    public DateFormat19Choice_? ProtectDate { get; init; } 
    /// <summary>
    /// Issuer or issuer's agent deadline to respond, with an instruction, to an outstanding offer or privilege.
    /// </summary>
    public DateFormat19Choice_? MarketDeadline { get; init; } 
    /// <summary>
    /// Date/time at which the account servicer has set as the deadline to respond, with instructions, to an outstanding event. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).
    /// </summary>
    public DateFormat20Choice_? ResponseDeadline { get; init; } 
    /// <summary>
    /// Date/time at which an order expires or on which a privilege or offer terminates.
    /// </summary>
    public DateFormat19Choice_? ExpiryDate { get; init; } 
    /// <summary>
    /// Date/time by which cash must be in place in order to take part in the event.
    /// </summary>
    public DateFormat19Choice_? SubscriptionCostDebitDate { get; init; } 
    /// <summary>
    /// Last day that a participant of the depository can deliver securities that it had elected on and/or previously protected.
    /// </summary>
    public DateFormat19Choice_? DepositoryCoverExpirationDate { get; init; } 
    /// <summary>
    /// Date/time that the account servicer has set as the deadline to respond, with instructions, to an outstanding event, for which the underlying security is out on loan. This time is dependent on the reference time zone of the account servicer as specified in an SLA.
    /// </summary>
    public DateFormat19Choice_? StockLendingDeadline { get; init; } 
    
    #nullable disable
}
