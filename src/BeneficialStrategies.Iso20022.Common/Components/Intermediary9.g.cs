﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Intermediary9.  ISO2002 ID# _QN5QFtp-Ed-ak6NoX_4Aeg_-1242436209.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party that provides services to investors relating to financial products.
/// </summary>
public partial record Intermediary9
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of the intermediary.
    /// </summary>
    public required IPartyIdentification2Choice Identification { get; init; } 
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    public Account7? Account { get; init; } 
    /// <summary>
    /// Counterparties eligibility as defined by article 24 of the EU MiFID Directive applicable to transactions executed by investment firms for eligible counterparties.
    /// </summary>
    public OrderOriginatorEligibility1Code? OrderOriginatorEligibility { get; init; } 
    /// <summary>
    /// Capacity of the party executing an order.
    /// </summary>
    public TradingCapacity2Code? TradingPartyCapacity { get; init; } 
    /// <summary>
    /// Function performed by the intermediary.
    /// </summary>
    public InvestmentFundRole2Code? Role { get; init; } 
    /// <summary>
    /// Function performed by the intermediary.
    /// </summary>
    public IsoExtended350Code? ExtendedRole { get; init; } 
    
    #nullable disable
}
