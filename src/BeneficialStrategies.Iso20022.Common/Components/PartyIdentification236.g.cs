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
public partial record PartyIdentification236
{
    #nullable enable
    
    /// <summary>
    /// Party that is the beneficial owner of the specified quantity of securities.
    /// </summary>
    public required IPartyIdentification229Choice OwnerIdentification { get; init; } 
    /// <summary>
    /// Legal entity identification of the party.
    /// </summary>
    public IsoLEIIdentifier? LEIIdentification { get; init; } 
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    public AlternatePartyIdentification7? AlternateIdentification { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Country in which a person is permanently domiciled (the place of a person's permanent home).
    /// </summary>
    public CountryCode? DomicileCountry { get; init; } 
    /// <summary>
    /// Holder of the security certifies, in line with the terms of the corporate action, that it is not domiciled in the country indicated.
    /// </summary>
    public CountryCode? NonDomicileCountry { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Quantity of securities belonging to the beneficial owner specified.
    /// </summary>
    public required IFinancialInstrumentQuantity1Choice OwnedSecuritiesQuantity { get; init; } 
    /// <summary>
    /// Type of certification which is required.
    /// </summary>
    public IBeneficiaryCertificationType10Choice? CertificationType { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Requested percentage of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    public IRateAndAmountFormat37Choice? WithholdingTaxRate { get; init; } 
    /// <summary>
    /// Provides additional information about the type of certification/breakdown required.
    /// </summary>
    public IsoMax350Text? CertificationBreakdown { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
