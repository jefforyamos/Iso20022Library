﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TMSAction3.  ISO2002 ID# _8fKyYTV_EeODSIIQsYYKhw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Single terminal management action to be performed by the point of interaction.
/// </summary>
[DataContract]
[XmlType]
public partial record TMSAction3
{
    #nullable enable
    
    /// <summary>
    /// Types of action to be performed by a point of interaction (POI).
    /// </summary>
    [DataMember]
    public required TerminalManagementAction1Code Type { get; init; } 
    /// <summary>
    /// Communication parameters of the terminal management system to contact.
    /// </summary>
    [DataMember]
    public NetworkParameters1? Address { get; init; } 
    /// <summary>
    /// Data set on which the action has to be performed.
    /// </summary>
    [DataMember]
    public DataSetIdentification3? DataSetIdentification { get; init; } 
    /// <summary>
    /// Event on which the action has to be activated by the point of interaction (POI).
    /// </summary>
    [DataMember]
    public required TerminalManagementActionTrigger1Code Trigger { get; init; } 
    /// <summary>
    /// Additional process to perform before starting or after completing the action by the point of interaction (POI).
    /// </summary>
    [DataMember]
    public ValueList<TerminalManagementAdditionalProcess1Code> AdditionalProcess { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Definition of retry process if activation of the action fails.
    /// </summary>
    [DataMember]
    public ProcessRetry2? ReTry { get; init; } 
    /// <summary>
    /// Date and time the action has to be performed.
    /// </summary>
    [DataMember]
    public ProcessTiming3? TimeCondition { get; init; } 
    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    [DataMember]
    public IsoMax140Binary? TMChallenge { get; init; } 
    /// <summary>
    /// Certificate chain for the encryption of temporary transport key of the key to inject.
    /// </summary>
    [DataMember]
    public ValueList<IsoMax10KBinary> KeyEnciphermentCertificate { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Action to perform in case of error on the related action in progress.
    /// </summary>
    [DataMember]
    public ValueList<ErrorAction2> ErrorAction { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
