﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PlainCardData21.  ISO2002 ID# _VZbFQSFPEey8XKHwKquEQw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Sensitive data associated with a payment card.
/// </summary>
public partial record PlainCardData21
{
    #nullable enable
    
    /// <summary>
    /// Identification of the driver or vehicle.
    /// </summary>
    public IsoMax20Text? DriverOrVehicleIdentification { get; init; } 
    /// <summary>
    /// Additional card specific data.
    /// </summary>
    public AdditionalData1[] AdditionalCardData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
