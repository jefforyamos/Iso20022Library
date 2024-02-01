﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MultimodalTransport2.  ISO2002 ID# _U7MstNp-Ed-ak6NoX_4Aeg_511762628.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to multimodal transportation of goods.
/// </summary>
public partial record MultimodalTransport2
{
    #nullable enable
    
    /// <summary>
    /// Place from where the goods must leave.
    /// </summary>
    public AirportName1Choice_[] DepartureAirport { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Place where the goods must arrive.
    /// </summary>
    public AirportName1Choice_[] DestinationAirport { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
    /// </summary>
    public IsoMax35Text[] AirCarrierName { get; init; } = []; // Warning: Don't know multiplicity.
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
    public IsoMax35Text[] VesselName { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identifies the location where the goods are received for transportation.
    /// </summary>
    public IsoMax35Text[] PlaceOfReceipt { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identifies the location of delivery of the goods.
    /// </summary>
    public IsoMax35Text[] PlaceOfDelivery { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identifies the location where the goods are take in charge for transportation.
    /// </summary>
    public IsoMax35Text[] TakingInCharge { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identifies the location of the final destination of the goods.
    /// </summary>
    public IsoMax35Text[] PlaceOfFinalDestination { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies a place in a country.
    /// </summary>
    public IsoMax35Text[] TransitLocation { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
    /// </summary>
    public IsoMax35Text[] RoadCarrierName { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
    /// </summary>
    public IsoMax35Text[] RailCarrierName { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
