﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DocumentToSend4.  ISO2002 ID# _y2mIcZTFEemqYPWMBuVawg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Type of document and the type of communication method to be used to notify a party.
/// </summary>
public partial record DocumentToSend4
{
    #nullable enable
    
    /// <summary>
    /// Type of document.
    /// </summary>
    public required IsoMax140Text Type { get; init; } 
    /// <summary>
    /// Party that should receive the document.
    /// </summary>
    public required IPartyIdentification125Choice Recipient { get; init; } 
    /// <summary>
    /// Communication method to be used.
    /// </summary>
    public required ICommunicationMethod3Choice MethodOfTransmission { get; init; } 
    
    #nullable disable
}
