﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SponsoredMerchant2.  ISO2002 ID# _6l8gMMWPEeuhguwJmlgagQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Merchant using the payment services of the card acceptor. The sponsored merchant is not acting as the card acceptor; the latter remaining the only party liable for the transaction vis-à-vis the acquirer.
/// </summary>
public partial record SponsoredMerchant2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the sponsored merchant.
    /// </summary>
    public required PartyIdentification262 Identification { get; init; } 
    /// <summary>
    /// Contains the full name of the sponsored merchant.
    /// </summary>
    public IsoMax140Text? CommonName { get; init; } 
    /// <summary>
    /// Legal Corporate Name of the sponsored merchant.
    /// </summary>
    public IsoMax99Text? LegalCorporateName { get; init; } 
    /// <summary>
    /// Address of the sponsored merchant. 
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
    /// Additional sponsored merchant data.
    /// </summary>
    public AdditionalData1? AdditionalData { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Contains local language equivalent(s) of data in the current component.
    /// </summary>
    public LocalData5? LocalData { get; init; } 
    
    #nullable disable
}
