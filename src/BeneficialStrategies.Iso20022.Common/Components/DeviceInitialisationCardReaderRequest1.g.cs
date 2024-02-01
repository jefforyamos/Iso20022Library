﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DeviceInitialisationCardReaderRequest1.  ISO2002 ID# _DHlm0N7AEeiwsev40qZGEQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Device Initialisation Card Reader Request message.
/// </summary>
public partial record DeviceInitialisationCardReaderRequest1
{
    #nullable enable
    
    /// <summary>
    /// Flag to request a warm reset on a chip.
    /// </summary>
    public IsoTrueFalseIndicator? WarmResetFlag { get; init; } 
    /// <summary>
    /// Payment instrument entry mode requested by the Sale System.
    /// </summary>
    public CardDataReading6Code[] ForceEntryMode { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Flag to indicate the POI System to keep the card in the reader for a smart card.
    /// </summary>
    public IsoTrueFalseIndicator? LeaveCardFlag { get; init; } 
    /// <summary>
    /// Maximum time in seconds that the POI has to wait for a card response.
    /// </summary>
    public IsoNumber? MaximumWaitingTime { get; init; } 
    /// <summary>
    /// Information to display.
    /// </summary>
    public ActionMessage6? DisplayOutput { get; init; } 
    
    #nullable disable
}
