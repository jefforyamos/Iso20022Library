﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMCommand5.  ISO2002 ID# _WHlpIYtvEeSLQutgI1Ulfw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Command result for reinitialization of the transaction counters.
/// </summary>
public partial record ATMCommand5
{
    #nullable enable
    
    /// <summary>
    /// Type of command to be performed by the ATM.
    /// </summary>
    public required ATMCommand3Code Type { get; init; } 
    /// <summary>
    /// Date time on which the command has been requested to be performed.
    /// </summary>
    public IsoISODateTime? RequiredDateTime { get; init; } 
    /// <summary>
    /// Date time on which the command has been performed.
    /// </summary>
    public required IsoISODateTime ProcessedDateTime { get; init; } 
    /// <summary>
    /// Identification of the entity issuing the command.
    /// </summary>
    public ATMCommandIdentification1? CommandIdentification { get; init; } 
    /// <summary>
    /// Final result of the processed command at the ATM.
    /// </summary>
    public required TerminalManagementActionResult2Code Result { get; init; } 
    /// <summary>
    /// Additional information on the failure to be logged for further examination.
    /// </summary>
    public IsoMax140Text? AdditionalErrorInformation { get; init; } 
    
    #nullable disable
}
