﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DeviceRequest3.  ISO2002 ID# _gvdHYQ0rEeqUVL7sB4m7NA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component define the environment, the context and the services to be used with this message.
/// </summary>
public partial record DeviceRequest3
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public CardPaymentEnvironment75? Environment { get; init; } 
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    public CardPaymentContext28? Context { get; init; } 
    /// <summary>
    /// Define the type of service requested.
    /// </summary>
    public required RetailerService8Code ServiceContent { get; init; } 
    /// <summary>
    /// Content of the Display Request message.
    /// </summary>
    public DeviceDisplayRequest2? DisplayRequest { get; init; } 
    /// <summary>
    /// Content of the Input Request message.
    /// </summary>
    public DeviceInputRequest2? InputRequest { get; init; } 
    /// <summary>
    /// Content of the Print Request message.
    /// </summary>
    public DevicePrintRequest2? PrintRequest { get; init; } 
    /// <summary>
    /// Content of the Sound Request message.
    /// </summary>
    public DevicePlaySoundRequest1? PlaySoundRequest { get; init; } 
    /// <summary>
    /// Request a secure input for a PIN.
    /// </summary>
    public DeviceSecureInputRequest2? SecureInputRequest { get; init; } 
    /// <summary>
    /// A service to send parameters to Card Reader to initialize a new communication with a card.
    /// </summary>
    public DeviceInitialisationCardReaderRequest2? InitialisationCardReaderRequest { get; init; } 
    /// <summary>
    /// Content of the APDU (Application Protocol Data Unit) to send to the Card.
    /// </summary>
    public DeviceSendApplicationProtocolDataUnitCardReaderRequest1? CardReaderAPDURequest { get; init; } 
    /// <summary>
    /// Content of the Power Off Card Reader Request message.
    /// </summary>
    public DevicePoweroffCardReaderRequest2? PowerOffCardReaderRequest { get; init; } 
    /// <summary>
    /// Content of the Request message to transmit.
    /// </summary>
    public DeviceTransmitMessageRequest2? TransmissionRequest { get; init; } 
    /// <summary>
    /// Content of the Input notification message.
    /// </summary>
    public DeviceInputNotification2? InputNotification { get; init; } 
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    public SupplementaryData1[] SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
