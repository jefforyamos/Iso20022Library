﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionRateSD4.  ISO2002 ID# _1XiiZTL3EeKU9IrkkToqcw_-291091942.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action option securities movement rate details.
/// </summary>
public partial record CorporateActionRateSD4
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    public required IsoMax350Text PlaceAndName { get; init; } 
    /// <summary>
    /// Corresponding rate of the security disbursed by CSD (for an example in US, DTC The Depository Trust Corporation).
    /// </summary>
    public IRatioFormat13Choice? CSDSecurityRate { get; init; } 
    
    #nullable disable
}
