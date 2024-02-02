﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification236.  ISO2002 ID# _or-3Qe4CEeqc-LCjwLsUVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the beneficial owner of the securities.
/// </summary>
[DataContract]
[XmlType]
public partial record PartyIdentification236
{
    #nullable enable
    
    /// <summary>
    /// Party that is the beneficial owner of the specified quantity of securities.
    /// </summary>
    [DataMember]
    public required PartyIdentification229Choice_ OwnerIdentification { get; init; } 
    /// <summary>
    /// Legal entity identification of the party.
    /// </summary>
    [DataMember]
    public IsoLEIIdentifier? LEIIdentification { get; init; } 
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [DataMember]
    public ValueList<AlternatePartyIdentification7> AlternateIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Country in which a person is permanently domiciled (the place of a person's permanent home).
    /// </summary>
    [DataMember]
    public CountryCode? DomicileCountry { get; init; } 
    /// <summary>
    /// Holder of the security certifies, in line with the terms of the corporate action, that it is not domiciled in the country indicated.
    /// </summary>
    [DataMember]
    public ValueList<CountryCode> NonDomicileCountry { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Quantity of securities belonging to the beneficial owner specified.
    /// </summary>
    [DataMember]
    public required FinancialInstrumentQuantity1Choice_ OwnedSecuritiesQuantity { get; init; } 
    /// <summary>
    /// Type of certification which is required.
    /// </summary>
    [DataMember]
    public ValueList<BeneficiaryCertificationType10Choice_> CertificationType { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Requested percentage of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [DataMember]
    public RateAndAmountFormat37Choice_? WithholdingTaxRate { get; init; } 
    /// <summary>
    /// Provides additional information about the type of certification/breakdown required.
    /// </summary>
    [DataMember]
    public ValueList<IsoMax350Text> CertificationBreakdown { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
