﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Consignment5.  ISO2002 ID# _XzXXgeWoEeevU7McUP3D1w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the arrangement of the transport of goods and services and the parties involved in this process.
/// </summary>
public partial record Consignment5
{
    #nullable enable
    
    /// <summary>
    /// Party consigning goods as stipulated in the transport contract by the party ordering transport.
    /// </summary>
    public TradeParty4? Consignor { get; init; } 
    /// <summary>
    /// Party to which goods are consigned.
    /// </summary>
    public TradeParty4? Consignee { get; init; } 
    /// <summary>
    /// Particular aircraft, vehicle, vessel or other device used for the transport of a consignment.
    /// </summary>
    public TransportMeans3? TransportMeans { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
