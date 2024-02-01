﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification93.  ISO2002 ID# _n-5xMUGTEeWqy4niLuXETA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the beneficial owner of the securities.
/// </summary>
public partial record PartyIdentification93
{
    #nullable enable
    
    /// <summary>
    /// Party that is the beneficial owner of the specified quantity of securities.
    /// </summary>
    public required PartyIdentification71Choice_ OwnerIdentification { get; init; } 
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    public AlternatePartyIdentification7[] AlternateIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Country in which a person is permanently domiciled (the place of a person's permanent home).
    /// </summary>
    public CountryCode? DomicileCountry { get; init; } 
    /// <summary>
    /// Holder of the security certifies, in line with the terms of the corporate action, that it is not domiciled in the country indicated.
    /// </summary>
    public CountryCode[] NonDomicileCountry { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Quantity of securities belonging to the beneficial owner specified.
    /// </summary>
    public required FinancialInstrumentQuantity1Choice_ OwnedSecuritiesQuantity { get; init; } 
    /// <summary>
    /// Type of certification which is required.
    /// </summary>
    public BeneficiaryCertificationType10Choice_[] CertificationType { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides additional information about the type of certification/breakdown required.
    /// </summary>
    public IsoMax350Text? CertificationBreakdown { get; init; } 
    
    #nullable disable
}
