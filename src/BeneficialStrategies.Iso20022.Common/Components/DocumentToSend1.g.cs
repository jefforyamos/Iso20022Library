﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DocumentToSend1.  ISO2002 ID# _RTCTPtp-Ed-ak6NoX_4Aeg_436078909.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Determine the type of document and the type of communication method to be used to notify a Party.
/// </summary>
public partial record DocumentToSend1
{
    #nullable enable
    
    /// <summary>
    /// Type of document.
    /// </summary>
    public required IsoMax140Text Type { get; init; } 
    /// <summary>
    /// Party that should receive the document.
    /// </summary>
    public required IPartyIdentification2Choice Recipient { get; init; } 
    /// <summary>
    /// Communication method to be used.
    /// </summary>
    public required CommunicationMethod1Code MethodOfTransmission { get; init; } 
    /// <summary>
    /// Communication means used to send information.
    /// </summary>
    public required IsoExtended350Code ExtendedMethodOfTransmission { get; init; } 
    
    #nullable disable
}
