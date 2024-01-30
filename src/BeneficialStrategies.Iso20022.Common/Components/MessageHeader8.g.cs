﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MessageHeader8.  ISO2002 ID# _i375p5IhEeect698_YsnIA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics, such as the identification or the creation date and time, specific to the message.
/// </summary>
public partial record MessageHeader8
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
    /// Pagination of the message.|Usage: the pagination of the message is only allowed when agreed between the parties.
    /// </summary>
    public Pagination1? MessagePagination { get; init; } 
    /// <summary>
    /// Unique identification of the original query message.
    /// </summary>
    public OriginalBusinessQuery1? OriginalBusinessQuery { get; init; } 
    /// <summary>
    /// Specific actions to be executed through the request.
    /// </summary>
    public IRequestType4Choice? RequestType { get; init; } 
    /// <summary>
    /// Recalls the criteria (search and return criteria) defined in a preceding query.
    /// </summary>
    public IsoMax35Text? QueryName { get; init; } 
    
    #nullable disable
}
