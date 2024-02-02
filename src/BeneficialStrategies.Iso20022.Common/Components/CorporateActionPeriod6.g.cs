﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionPeriod6.  ISO2002 ID# _w9BmYd24Ed-KAqAOGQOnnw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies periods of a corporate action.
/// </summary>
[DataContract]
[XmlType]
public partial record CorporateActionPeriod6
{
    #nullable enable
    
    /// <summary>
    /// Period during which the price of a security is determined.
    /// </summary>
    [DataMember]
    public Period3Choice_? PriceCalculationPeriod { get; init; } 
    /// <summary>
    /// Period during which the interest rate has been applied.
    /// </summary>
    [DataMember]
    public Period3Choice_? InterestPeriod { get; init; } 
    /// <summary>
    /// Period during a take-over where any outstanding equity must be purchased by the take-over company.
    /// </summary>
    [DataMember]
    public Period3Choice_? CompulsoryPurchasePeriod { get; init; } 
    /// <summary>
    /// Period during which the security is blocked.
    /// </summary>
    [DataMember]
    public Period3Choice_? BlockingPeriod { get; init; } 
    /// <summary>
    /// Period assigned by the court in a class action. It determines the client's eligible transactions that will be included in the class action and used to determine the resulting entitlement.
    /// </summary>
    [DataMember]
    public Period3Choice_? ClaimPeriod { get; init; } 
    /// <summary>
    /// Period defining the last date for which book entry transfers will be accepted and the date on which the suspension will be released and book entry transfer processing will resume.
    /// </summary>
    [DataMember]
    public Period3Choice_? DepositorySuspensionPeriodForBookEntryTransfer { get; init; } 
    /// <summary>
    /// Period defining the last date for which deposits, into nominee name, at the agent will be accepted and the date on which the suspension will be released and deposits at agent will resume.
    /// </summary>
    [DataMember]
    public Period3Choice_? DepositorySuspensionPeriodForDepositAtAgent { get; init; } 
    /// <summary>
    /// Period defining the last date for which deposits will be accepted and the date on which the suspension will be released and deposits will resume.
    /// </summary>
    [DataMember]
    public Period3Choice_? DepositorySuspensionPeriodForDeposit { get; init; } 
    /// <summary>
    /// Period defining the last date for which pledges will be accepted and the date on which the suspension will be released and pledge processing will resume.
    /// </summary>
    [DataMember]
    public Period3Choice_? DepositorySuspensionPeriodForPledge { get; init; } 
    /// <summary>
    /// Period defining the last date for which intra-position balances can be segregated and the date on which the suspension will be released and the ability to segregate intra-position balances will resume.
    /// </summary>
    [DataMember]
    public Period3Choice_? DepositorySuspensionPeriodForSegregation { get; init; } 
    /// <summary>
    /// Period defining the last date for which withdrawals, from nominee name at the agent will be accepted and the date on which the suspension will be released and withdrawals at agent processing will resume.
    /// </summary>
    [DataMember]
    public Period3Choice_? DepositorySuspensionPeriodForWithdrawalAtAgent { get; init; } 
    /// <summary>
    /// Period defining the last date for which physical withdrawals in the nominee's name will be accepted and the date on which the suspension will be released and physical withdrawals in the nominee's name will resume.
    /// </summary>
    [DataMember]
    public Period3Choice_? DepositorySuspensionPeriodForWithdrawalInNomineeName { get; init; } 
    /// <summary>
    /// Period defining the last date on which withdrawal requests in street name's will be accepted on the event security and the date on which the suspension will be released and withdrawal in street name's processing on the event security will resume.
    /// </summary>
    [DataMember]
    public Period3Choice_? DepositorySuspensionPeriodForWithdrawalInStreetName { get; init; } 
    /// <summary>
    /// Period defining the last date on which shareholder registration will be accepted by the issuer and the date on which shareholder registration will resume.
    /// </summary>
    [DataMember]
    public Period3Choice_? BookClosurePeriod { get; init; } 
    
    #nullable disable
}
