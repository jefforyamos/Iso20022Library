﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ApplicationParameters10.  ISO2002 ID# _FjIo0S8qEeu125Ip9zFcsQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor parameters dedicated to a payment application of the point of interaction.
/// </summary>
public partial record ApplicationParameters10
{
    #nullable enable
    
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    public required TerminalManagementAction3Code ActionType { get; init; } 
    /// <summary>
    /// Identification of the payment application.
    /// </summary>
    public required IsoMax35Text ApplicationIdentification { get; init; } 
    /// <summary>
    /// Version of the payment application configuration parameters.
    /// </summary>
    public IsoMax256Text? Version { get; init; } 
    /// <summary>
    /// Version of the parameters' format.
    /// </summary>
    public IsoMax8Text? ParameterFormatIdentifier { get; init; } 
    /// <summary>
    /// Full length of parameters.
    /// </summary>
    public IsoPositiveNumber? ParametersLength { get; init; } 
    /// <summary>
    /// Place of this  Block, beginning with 0, in the full parameters.
    /// </summary>
    public IsoPositiveNumber? OffsetStart { get; init; } 
    /// <summary>
    /// Following place of this Block in the full parameters.
    /// </summary>
    public IsoPositiveNumber? OffsetEnd { get; init; } 
    /// <summary>
    /// Configuration parameters used by the related payment application.
    /// </summary>
    public IsoMax100KBinary[] Parameters { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Sensitive parameters (sequence of parameters including the envelope) encrypted with a cryptographic key.
    /// </summary>
    public ContentInformationType28? EncryptedParameters { get; init; } 
    
    #nullable disable
}
