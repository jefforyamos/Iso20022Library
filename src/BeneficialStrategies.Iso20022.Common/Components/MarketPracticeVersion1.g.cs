﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MarketPracticeVersion1.  ISO2002 ID# _FaNY0RUVEeOIaq8KyCdIDQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the implementation and version.
/// </summary>
public partial record MarketPracticeVersion1
{
    #nullable enable
    
    /// <summary>
    /// Market practice, for example, “UKTRANSFERS”, “FINDELSLT”.
    /// </summary>
    public required IsoMax35Text Name { get; init; } 
    /// <summary>
    /// Year and month, for example, 2013-06.
    /// </summary>
    public IsoISOYearMonth? Date { get; init; } 
    /// <summary>
    /// Version of the market practice.
    /// </summary>
    public IsoMax35Text? Number { get; init; } 
    
    #nullable disable
}
