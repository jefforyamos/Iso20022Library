﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SingleTransport3.  ISO2002 ID# _StL9Adp-Ed-ak6NoX_4Aeg_-886888907.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies individually each leg of a transport of goods.
/// </summary>
public partial record SingleTransport3
{
    #nullable enable
    
    /// <summary>
    /// Information related to the transportation of goods by air.
    /// </summary>
    public TransportByAir2? TransportByAir { get; init; } 
    /// <summary>
    /// Information related for the transportation of goods by sea.
    /// </summary>
    public TransportBySea4? TransportBySea { get; init; } 
    /// <summary>
    /// Information related to the transportation of goods by road.
    /// </summary>
    public TransportByRoad2? TransportByRoad { get; init; } 
    /// <summary>
    /// Information related to the transportation of goods by rail.
    /// </summary>
    public TransportByRail2? TransportByRail { get; init; } 
    
    #nullable disable
}
