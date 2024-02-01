﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalMessage5.  ISO2002 ID# _TC94j249EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous identification of the original message references.
/// </summary>
public partial record OriginalMessage5
{
    #nullable enable
    
    /// <summary>
    /// Original message sender used to identify the message.
    /// </summary>
    public Party40Choice_? OriginalSender { get; init; } 
    /// <summary>
    /// Point to point reference assigned by the original instructing party to unambiguously identify the original group of individual transactions.
    /// </summary>
    public required IsoMax35Text OriginalMessageIdentification { get; init; } 
    /// <summary>
    /// Specifies the original message name identifier to which the message refers, such as pacs.003.001.01 or MT103.
    /// </summary>
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; } 
    /// <summary>
    /// Original date and time at which the message was created.
    /// </summary>
    public IsoISODateTime? OriginalCreationDateTime { get; init; } 
    
    #nullable disable
}
