﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ApplicationParameters9.  ISO2002 ID# _12koAQufEeqw5uEXxQ9H4g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor parameters dedicated to a payment application of the point of interaction.
/// </summary>
[DataContract]
[XmlType]
public partial record ApplicationParameters9
{
    #nullable enable
    
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [DataMember]
    public required TerminalManagementAction3Code ActionType { get; init; } 
    /// <summary>
    /// Identification of the payment application.
    /// </summary>
    [DataMember]
    public required IsoMax35Text ApplicationIdentification { get; init; } 
    /// <summary>
    /// Version of the payment application configuration parameters.
    /// </summary>
    [DataMember]
    public IsoMax256Text? Version { get; init; } 
    /// <summary>
    /// Version of the parameters' format.
    /// </summary>
    [DataMember]
    public IsoMax8Text? ParameterFormatIdentifier { get; init; } 
    /// <summary>
    /// Configuration parameters used by the related payment application.
    /// </summary>
    [DataMember]
    public ValueList<IsoMax100KBinary> Parameters { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Sensitive parameters (sequence of parameters including the envelope) encrypted with a cryptographic key.
    /// </summary>
    [DataMember]
    public ContentInformationType22? EncryptedParameters { get; init; } 
    
    #nullable disable
}
