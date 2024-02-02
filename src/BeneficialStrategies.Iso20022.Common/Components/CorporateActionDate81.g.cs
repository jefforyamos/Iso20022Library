﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionDate81.  ISO2002 ID# _ZHfZDx9REeuFz_FaCzCLgQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action dates.
/// </summary>
[DataContract]
[XmlType]
public partial record CorporateActionDate81
{
    #nullable enable
    
    /// <summary>
    /// Date/time that the account servicer has set as the deadline to respond, with instructions, to an outstanding event, giving the holder eligibility to incentives. 
    /// </summary>
    [DataMember]
    public DateFormat49Choice_? EarlyResponseDeadline { get; init; } 
    /// <summary>
    /// Last day a holder can deliver the securities that it had elected on and/or previously protected.
    /// </summary>
    [DataMember]
    public DateFormat43Choice_? CoverExpirationDeadline { get; init; } 
    /// <summary>
    /// Last date/time a holder can request to defer delivery of securities pursuant to a notice of guaranteed delivery or other required documentation.
    /// </summary>
    [DataMember]
    public DateFormat43Choice_? ProtectDeadline { get; init; } 
    /// <summary>
    /// Issuer or issuer's agent deadline to respond with an instruction to an outstanding offer or privilege.
    /// </summary>
    [DataMember]
    public DateFormat49Choice_? MarketDeadline { get; init; } 
    /// <summary>
    /// Date/time at which the account servicer has set as the deadline to respond, with instructions, to an outstanding event.
    /// </summary>
    [DataMember]
    public DateFormat54Choice_? ResponseDeadline { get; init; } 
    /// <summary>
    /// Date/time at which an order expires or on which a privilege or offer terminates.
    /// </summary>
    [DataMember]
    public DateFormat49Choice_? ExpiryDate { get; init; } 
    /// <summary>
    /// Date/time by which cash must be in place in order to take part in the event.
    /// </summary>
    [DataMember]
    public DateFormat49Choice_? SubscriptionCostDebitDate { get; init; } 
    /// <summary>
    /// Last day that a participant of the depository can deliver securities that it had elected on and/or previously protected.
    /// </summary>
    [DataMember]
    public DateFormat49Choice_? DepositoryCoverExpirationDate { get; init; } 
    /// <summary>
    /// Date/time set as the deadline to respond, with instructions, to an outstanding event, for which the underlying security is out on loan.
    /// </summary>
    [DataMember]
    public DateFormat49Choice_? StockLendingDeadline { get; init; } 
    /// <summary>
    /// Specifies the party borrowing stocks and the associated stock lending deadline assigned to the borrower.
    /// </summary>
    [DataMember]
    public ValueList<BorrowerLendingDeadline6> BorrowerStockLendingDeadline { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
