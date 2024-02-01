﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransportBySea6.  ISO2002 ID# _WhO5YRriEeOVR9VN6fAMUg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related for the transportation of goods by sea.
/// </summary>
public partial record TransportBySea6
{
    #nullable enable
    
    /// <summary>
    /// Identifies the port where the goods are loaded on board the ship.
    /// </summary>
    public IsoMax35Text[] PortOfLoading { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identifies the port where the goods are discharged.
    /// </summary>
    public IsoMax35Text[] PortOfDischarge { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Name of a vessel.
    /// </summary>
    public IsoMax70Text? VesselName { get; init; } 
    /// <summary>
    /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
    /// </summary>
    public IsoMax70Text? SeaCarrierName { get; init; } 
    /// <summary>
    /// Country in which the carrier of the goods, for example, shipping company, is located or registered.
    /// </summary>
    public CountryCode? SeaCarrierCountry { get; init; } 
    /// <summary>
    /// Name of the carrier's (for example, shipping company's) agent that acts on behalf of the carrier and may be the issuer of transport documents relating to the underlying shipment.
    /// </summary>
    public IsoMax70Text? CarrierAgentName { get; init; } 
    /// <summary>
    /// Country of registration of the carrier's (for example, shipping company's) agent that acts on behalf of the carrier and may be the issuer of transport documents relating to the underlying shipment.
    /// </summary>
    public CountryCode? CarrierAgentCountry { get; init; } 
    
    #nullable disable
}
