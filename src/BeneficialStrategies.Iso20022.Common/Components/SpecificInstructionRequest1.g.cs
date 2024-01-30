﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SpecificInstructionRequest1.  ISO2002 ID# _RVH95Np-Ed-ak6NoX_4Aeg_-1758177157.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Request to execute specific instructions, such as participation registration, securities registration or blocking of securities.
/// </summary>
public partial record SpecificInstructionRequest1
{
    #nullable enable
    
    /// <summary>
    /// Request to register for participation to the meeting.
    /// </summary>
    public IsoYesNoIndicator? ParticipationRegistration { get; init; } 
    /// <summary>
    /// Request to block the securities.
    /// </summary>
    public IsoYesNoIndicator? BlockingSecurities { get; init; } 
    /// <summary>
    /// Request to register the securities for the meeting.
    /// </summary>
    public IsoYesNoIndicator? SecuritiesRegistration { get; init; } 
    
    #nullable disable
}
