﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InputData2.  ISO2002 ID# _svNbwQ0cEeqUVL7sB4m7NA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to an Input request.
/// </summary>
public partial record InputData2
{
    #nullable enable
    
    /// <summary>
    /// Type of logical device located on a Sale Terminal or a POI Terminal.
    /// </summary>
    public required SaleCapabilities2Code DeviceType { get; init; } 
    /// <summary>
    /// Qualification of the information to output to the logical device.
    /// </summary>
    public required InformationQualify1Code InformationQualifier { get; init; } 
    /// <summary>
    /// Type of requested input.
    /// </summary>
    public required InputCommand1Code InputCommand { get; init; } 
    /// <summary>
    /// Flag of notification of card to be entered in the POI card reader.
    /// </summary>
    public required IsoTrueFalseIndicator NotifyCardInputFlag { get; init; } 
    /// <summary>
    /// Maximum input time in seconds.
    /// </summary>
    public IsoNumber? MaximumInputTime { get; init; } 
    /// <summary>
    /// Text value set for an input command.
    /// </summary>
    public ActionMessage7? InputText { get; init; } 
    /// <summary>
    /// Flag to request Immediate response without waiting for the completion of the command.
    /// </summary>
    public IsoTrueFalseIndicator? ImmediateResponseFlag { get; init; } 
    /// <summary>
    /// Flag to confirm by the user the entered characters, when the maximum allowed length is reached.
    /// </summary>
    public IsoTrueFalseIndicator? WaitUserValidationFlag { get; init; } 
    /// <summary>
    /// Flag to indicate that when the user press a key, a beep has to be generated.
    /// </summary>
    public IsoTrueFalseIndicator? BeepKeyFlag { get; init; } 
    /// <summary>
    /// Flag to correct all characters (True) or just the last one (False).
    /// </summary>
    public IsoTrueFalseIndicator? GlobalCorrectionFlag { get; init; } 
    /// <summary>
    /// Flag to deactivate the "Cancel" function key.
    /// </summary>
    public IsoTrueFalseIndicator? DisableCancelFlag { get; init; } 
    /// <summary>
    /// Flag to deactivate the "Correct" function key.
    /// </summary>
    public IsoTrueFalseIndicator? DisableCorrectFlag { get; init; } 
    /// <summary>
    /// Flag to disable the "Valid" function key.
    /// </summary>
    public IsoTrueFalseIndicator? DisableValidFlag { get; init; } 
    /// <summary>
    /// Flag to enable the "Back" function key to go the upper level.
    /// </summary>
    public IsoTrueFalseIndicator? MenuBackFlag { get; init; } 
    
    #nullable disable
}
