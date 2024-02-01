﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification255.  ISO2002 ID# _h0OF0YZ_EeuSbct6WWD-Ng.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
public partial record PartyIdentification255
{
    #nullable enable
    
    /// <summary>
    /// Identification of the acceptor.
    /// ISO 8583 bit 42
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Identification of the entity assigning an identification to the acceptor.
    /// </summary>
    public IsoMax35Text? Assigner { get; init; } 
    /// <summary>
    /// Country code of the acceptor.
    /// ISO 8583:87/93 bit 43 & 8583:2003 bit 43-71 (when used for Acceptor Country Code)
    /// </summary>
    public ISO3NumericCountryCode? Country { get; init; } 
    /// <summary>
    /// Short name of the acceptor.
    /// </summary>
    public IsoMax35Text? ShortName { get; init; } 
    /// <summary>
    /// Legal Corporate Name of the party.
    /// </summary>
    public IsoMax99Text? LegalCorporateName { get; init; } 
    /// <summary>
    /// Additional identification assigned by an agent to an acceptor.
    /// </summary>
    public AdditionalData1? AdditionalIdentification { get; init; } 
    /// <summary>
    /// Name and location of acceptor.  May only contain name when the location is specified elsewhere.
    /// </summary>
    public required IsoMax99Text NameAndLocation { get; init; } 
    /// <summary>
    /// Address of the entity.
    /// ISO 8583:93 bit 43 & 8583:2003 bit 43-71 (when used for acceptor address)
    /// </summary>
    public Address2? Address { get; init; } 
    /// <summary>
    /// Additional information used when card acceptor street address is insufficient.
    /// </summary>
    public IsoMax256Text? AdditionalAddressInformation { get; init; } 
    /// <summary>
    /// Location of the acceptor in latitude/longitude decimal degrees.
    /// </summary>
    public IsoGeographicPointInDecimalDegrees? GeographicLocation { get; init; } 
    /// <summary>
    /// Electronic mail address.
    /// ISO 8583:2003 bit 43-71 (when used for Acceptor email address)
    /// </summary>
    public IsoMax256Text? Email { get; init; } 
    /// <summary>
    /// Universal Resource Locator (URL) address.
    /// ISO 8583:2003 bit 43-71 (when used for Acceptor URL)
    /// </summary>
    public IsoMax256Text? URLAddress { get; init; } 
    /// <summary>
    /// Collection of information that identifies  a phone number as defined by telecom services.
    /// ISO 8583:2003 bit 43-71 (when used for Acceptor phone number)
    /// </summary>
    public IsoMax35Text? PhoneNumber { get; init; } 
    /// <summary>
    /// Phone number of the customer service.
    /// ISO 8583:2003 bit 43-71 (when used for Acceptor customer service phone number)
    /// </summary>
    public IsoMax35Text? CustomerService { get; init; } 
    /// <summary>
    /// Additional information used to facilitate contact with the card acceptor, for instance sales agent name, dispute manager name.
    /// ISO 8583:2003 bit 43-71 (when used for Acceptor additional contact information)
    /// </summary>
    public IsoMax256Text? AdditionalContactInformation { get; init; } 
    /// <summary>
    /// Identification of a party by its tax registration number.
    /// </summary>
    public IsoMax35Text? TaxRegistrationIdentification { get; init; } 
    /// <summary>
    /// Contains additional data.
    /// </summary>
    public AdditionalData1[] AdditionalData { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Contains local language equivalent(s) of data in the current component.
    /// </summary>
    public LocalData4? LocalData { get; init; } 
    /// <summary>
    /// Sponsored merchant is a merchant that uses the payment services of another entity that acts as the card acceptor.
    /// </summary>
    public SponsoredMerchant2[] SponsoredMerchant { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
