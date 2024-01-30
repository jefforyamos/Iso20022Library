﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MessageHeader9.  ISO2002 ID# _jAUZkZIhEeect698_YsnIA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics, such as the identification or the creation date and time, specific to the message.
/// </summary>
public partial record MessageHeader9
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the sender, to unambiguously identify the message.|Usage: The sender has to make sure that MessageIdentification is unique for a pre-agreed period.
    /// </summary>
    public required IsoMax35Text MessageIdentification { get; init; } 
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    public IsoISODateTime? CreationDateTime { get; init; } 
    /// <summary>
    /// Specific actions to be executed through the request.
    /// </summary>
    public IRequestType4Choice? RequestType { get; init; } 
    
    #nullable disable
}
