﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesAccountReturnCriteria.  ISO2002 ID# _hjB2Z2liEeGaMcKyqKNRfQ_-1911828030.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Return criteria for information to be returned in the report deriving from a query about securities account reference data.
/// </summary>
[DataContract]
[XmlType]
public partial record SecuritiesAccountReturnCriteria
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the identification of the account is requested.
    /// </summary>
    [DataMember]
    public IsoRequestedIndicator? AccountIdentification { get; init; } 
    /// <summary>
    /// Indicates whether the identification of the party owning the account is requested.
    /// </summary>
    [DataMember]
    public IsoRequestedIndicator? PartyIdentification { get; init; } 
    /// <summary>
    /// Indicates whether the type of the party owning the account is requested.
    /// </summary>
    [DataMember]
    public IsoRequestedIndicator? PartyType { get; init; } 
    /// <summary>
    /// Indicates whether the account servicer is requested.
    /// </summary>
    [DataMember]
    public IsoRequestedIndicator? AccountServicer { get; init; } 
    /// <summary>
    /// Indicates whether the account type is requested.
    /// </summary>
    [DataMember]
    public IsoRequestedIndicator? AccountType { get; init; } 
    /// <summary>
    /// Indicates whether the opening date for the account is requested.
    /// </summary>
    [DataMember]
    public IsoRequestedIndicator? OpeningDate { get; init; } 
    /// <summary>
    /// Indicates whether the closing date for the account is requested.
    /// </summary>
    [DataMember]
    public IsoRequestedIndicator? ClosingDate { get; init; } 
    /// <summary>
    /// Specifies information to identify securities accounts where allocation instructions are posted.
    /// </summary>
    [DataMember]
    public IsoRequestedIndicator? EndInvestorFlag { get; init; } 
    /// <summary>
    /// Defines how the price is applied to the securities account.
    /// </summary>
    [DataMember]
    public IsoRequestedIndicator? PricingScheme { get; init; } 
    
    #nullable disable
}
