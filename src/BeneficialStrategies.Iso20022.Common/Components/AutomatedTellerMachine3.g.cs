﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AutomatedTellerMachine3.  ISO2002 ID# _AXzKsYqlEeS4a4abTJTSSw.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM information.
/// </summary>
public partial record AutomatedTellerMachine3
{
    #nullable enable
    
    /// <summary>
    /// ATM terminal device identification for the acquirer and the issuer.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// ATM terminal device identification for the ATM manager.
    /// </summary>
    public IsoMax35Text? AdditionalIdentification { get; init; } 
    /// <summary>
    /// ATM terminal device identification for the branch.
    /// </summary>
    public IsoMax35Text? SequenceNumber { get; init; } 
    /// <summary>
    /// Location of the ATM.
    /// </summary>
    public PostalAddress17? Location { get; init; } 
    
    #nullable disable
}
