﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LoyaltyProgramme2.  ISO2002 ID# _R1YN9PJpEeiJn9rM2Znz2w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Loyalty programme information
/// </summary>
public partial record LoyaltyProgramme2
{
    #nullable enable
    
    /// <summary>
    /// Type of loyalty programme (for example, airline, lodging, vehicle and rail etc.).
    /// </summary>
    public IsoMax35Text? ProgrammeType { get; init; } 
    /// <summary>
    /// Loyalty programme identification value.
    /// </summary>
    public IsoMax70Text? ProgramIdentification { get; init; } 
    /// <summary>
    /// Loyalty programme participant identification value.
    /// </summary>
    public IsoMax70Text? ParticipantIdentification { get; init; } 
    
    #nullable disable
}
