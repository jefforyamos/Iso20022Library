﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReportedPartyIdentification1.  ISO2002 ID# _v6TEUYInEeWA9fc11zJf1Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the identification of the reported party through the location and the name or the sector.
/// </summary>
public partial record ReportedPartyIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Name or sector of the counterparty of the reporting agent used by the reporting agent.
    /// </summary>
    public required NameOrSector1Choice_ NameOrSector { get; init; } 
    /// <summary>
    /// Location of the country in which the counterparty is incorporated.
    /// </summary>
    public required CountryCode Location { get; init; } 
    
    #nullable disable
}
