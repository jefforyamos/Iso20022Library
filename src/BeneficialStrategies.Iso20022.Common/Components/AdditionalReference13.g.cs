﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalReference13.  ISO2002 ID# _H2CF4ZS9EemqYPWMBuVawg.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference to a related message or transaction.
/// </summary>
public partial record AdditionalReference13
{
    #nullable enable
    
    /// <summary>
    /// Message identification of a message. This reference was assigned by the party issuing the message.
    /// </summary>
    public required IsoMax35Text Reference { get; init; } 
    /// <summary>
    /// Issuer of the reference.
    /// </summary>
    public IPartyIdentification125Choice? ReferenceIssuer { get; init; } 
    /// <summary>
    /// Name of the message.
    /// </summary>
    public IsoMax35Text? MessageName { get; init; } 
    
    #nullable disable
}
