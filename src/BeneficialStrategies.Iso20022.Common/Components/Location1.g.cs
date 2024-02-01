﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Location1.  ISO2002 ID# _-Gm5aHltEeG7BsjMvd1mEw_1246431564.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Location information.
/// </summary>
public partial record Location1
{
    #nullable enable
    
    /// <summary>
    /// Country of jurisdiction.
    /// </summary>
    public CountryCode? Country { get; init; } 
    /// <summary>
    /// Codified representation of the jurisdiction as published in ISO 3166-2.
    /// </summary>
    public CountrySubdivision1Choice_? CountrySubDivision { get; init; } 
    /// <summary>
    /// Name of jurisdiction, for example, Frankfurt.
    /// </summary>
    public IsoMax2000Text[] Text { get; init; } = [];
    
    #nullable disable
}
