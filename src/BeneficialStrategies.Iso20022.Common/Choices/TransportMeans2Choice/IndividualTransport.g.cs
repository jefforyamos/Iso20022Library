﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IndividualTransport.  ISO2002 ID# _U7oxktp-Ed-ak6NoX_4Aeg_-1980199405.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransportMeans2Choice;

/// <summary>
/// Moving of goods or people from one place to another by vehicle.
/// </summary>
public partial record IndividualTransport : TransportMeans2Choice_
{
    #nullable enable
    /// <summary>
    /// Information related to the transportation of goods by air.
    /// </summary>
    public TransportByAir2? TransportByAir { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Information related for the transportation of goods by sea.
    /// </summary>
    public TransportBySea2? TransportBySea { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Moving of goods or people from one place to another by vehicle.
    /// </summary>
    public TransportByRoad2? TransportByRoad { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Information related to the transportation of goods by rail.
    /// </summary>
    public TransportByRail2? TransportByRail { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
