﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TMSAction2.  ISO2002 ID# _Y2MKQR3ZEeKKrOIoqWglDw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Single terminal management action to be performed by the point of interaction.
/// </summary>
public partial record TMSAction2
{
    #nullable enable
    
    /// <summary>
    /// Types of action to be performed by a point of interaction (POI).
    /// </summary>
    public required TerminalManagementAction1Code Type { get; init; } 
    /// <summary>
    /// Communication parameters of the terminal management system to contact.
    /// </summary>
    public NetworkParameters1? Address { get; init; } 
    /// <summary>
    /// Data set on which the action has to be performed.
    /// </summary>
    public DataSetIdentification3? DataSetIdentification { get; init; } 
    /// <summary>
    /// Event on which the action has to be activated by the point of interaction (POI).
    /// </summary>
    public required TerminalManagementActionTrigger1Code Trigger { get; init; } 
    /// <summary>
    /// Additional process to perform before starting or after completing the action by the point of interaction (POI).
    /// </summary>
    public TerminalManagementAdditionalProcess1Code? AdditionalProcess { get; init; } 
    /// <summary>
    /// Date and time the action has to be performed.
    /// </summary>
    public ProcessTiming2? TimeCondition { get; init; } 
    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    public IsoMax140Binary? TMChallenge { get; init; } 
    /// <summary>
    /// Certificate chain for the encryption of temporary transport key of the key to inject.
    /// </summary>
    public IsoMax5000Binary[] KeyEnciphermentCertificate { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Action to perform in case of error on the related action in progress.
    /// </summary>
    public ErrorAction2[] ErrorAction { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
