﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMCommand13.  ISO2002 ID# _YH7bkLV_Eee9tu0oJrSx7A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Maintenance command to perform on an ATM.
/// </summary>
public partial record ATMCommand13
{
    #nullable enable
    
    /// <summary>
    /// Type of command to be performed by the ATM.
    /// </summary>
    public required ATMCommand6Code Type { get; init; } 
    /// <summary>
    /// Urgency of the command.
    /// </summary>
    public required TMSContactLevel2Code Urgency { get; init; } 
    /// <summary>
    /// Date time on which the command must be performed.
    /// </summary>
    public IsoISODateTime? DateTime { get; init; } 
    /// <summary>
    /// Identification of the entity issuing the command.
    /// </summary>
    public ATMCommandIdentification1? CommandIdentification { get; init; } 
    /// <summary>
    /// Specific parameters attached to the command.
    /// </summary>
    public ATMCommandParameters1Choice_? CommandParameters { get; init; } 
    
    #nullable disable
}
