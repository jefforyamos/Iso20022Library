﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TMSAction10.  ISO2002 ID# _YR3KUU6nEeyGi9JAv6wq7Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Single terminal management action to be performed by the point of interaction.
/// </summary>
public partial record TMSAction10
{
    #nullable enable
    
    /// <summary>
    /// Types of action to be performed by a point of interaction (POI).
    /// </summary>
    public required TerminalManagementAction5Code Type { get; init; } 
    /// <summary>
    /// Host access information.
    /// </summary>
    public NetworkParameters7? RemoteAccess { get; init; } 
    /// <summary>
    /// Cryptographic key used to communicate with the host.
    /// </summary>
    public KEKIdentifier5? Key { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of the master terminal manager or the terminal manager with which the POI has to perform the action.
    /// </summary>
    public GenericIdentification176? TerminalManagerIdentification { get; init; } 
    /// <summary>
    /// TMS protocol to use for performing the maintenance action.
    /// </summary>
    public IsoMax35Text? TMSProtocol { get; init; } 
    /// <summary>
    /// Version of the TMS protocol to use to perform the maintenance action.
    /// </summary>
    public IsoMax35Text? TMSProtocolVersion { get; init; } 
    /// <summary>
    /// Data set on which the action has to be performed.
    /// </summary>
    public DataSetIdentification9? DataSetIdentification { get; init; } 
    /// <summary>
    /// Type of POI components to send in a status report.
    /// </summary>
    public DataSetCategory17Code? ComponentType { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of the delegation scope assigned by the MTM.
    /// </summary>
    public IsoMax35Text? DelegationScopeIdentification { get; init; } 
    /// <summary>
    /// This element contains all information relevant to the DelegationScopeIdentification. The format of this element is out of scope of this definition.
    /// </summary>
    public IsoMax3000Binary? DelegationScopeDefinition { get; init; } 
    /// <summary>
    /// This element contains the necessary information to secure the management of the Delegation. The format of this element is out of scope of this definition.
    /// </summary>
    public IsoMax5000Binary? DelegationProof { get; init; } 
    /// <summary>
    /// Protected proof of delegation.
    /// </summary>
    public ContentInformationType30? ProtectedDelegationProof { get; init; } 
    /// <summary>
    /// Event on which the action has to be activated by the point of interaction (POI).
    /// </summary>
    public required TerminalManagementActionTrigger1Code Trigger { get; init; } 
    /// <summary>
    /// Additional process to perform before starting or after completing the action by the point of interaction (POI).
    /// </summary>
    public TerminalManagementAdditionalProcess1Code? AdditionalProcess { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Definition of retry process if activation of the action fails.
    /// </summary>
    public ProcessRetry3? ReTry { get; init; } 
    /// <summary>
    /// Date and time the action has to be performed.
    /// </summary>
    public ProcessTiming5? TimeCondition { get; init; } 
    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    public IsoMax140Binary? TMChallenge { get; init; } 
    /// <summary>
    /// Certificate chain for the encryption of temporary transport key of the key to inject.
    /// </summary>
    public IsoMax10KBinary? KeyEnciphermentCertificate { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Action to perform in case of error on the related action in progress.
    /// </summary>
    public ErrorAction5? ErrorAction { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information about the maintenance action.
    /// </summary>
    public IsoMax3000Binary? AdditionalInformation { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Configuration of a message item.
    /// </summary>
    public MessageItemCondition1? MessageItem { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Information related to a device request of the POI.
    /// </summary>
    public DeviceRequest5? DeviceRequest { get; init; } 
    
    #nullable disable
}
