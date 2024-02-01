﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransportByRail3.  ISO2002 ID# _SuFU6dp-Ed-ak6NoX_4Aeg_-1718114304.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the transportation of goods by rail.
/// </summary>
public partial record TransportByRail3
{
    #nullable enable
    
    /// <summary>
    /// Identifies the location where the goods are received for transportation.
    /// </summary>
    public IsoMax35Text[] PlaceOfReceipt { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identifies the location of delivery of the goods.
    /// </summary>
    public IsoMax35Text[] PlaceOfDelivery { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
    /// </summary>
    public IsoMax35Text? RailCarrierName { get; init; } 
    
    #nullable disable
}
