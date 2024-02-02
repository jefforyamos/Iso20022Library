﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Header23.  ISO2002 ID# _d7nnwAJXEeS2H9l84F_isg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics related to the transfer of transactions.
/// </summary>
[DataContract]
[XmlType]
public partial record Header23
{
    #nullable enable
    
    /// <summary>
    /// Version of file format.
    /// </summary>
    [DataMember]
    public required IsoMax6Text FormatVersion { get; init; } 
    /// <summary>
    /// Unique identification of an exchange occurrence.
    /// </summary>
    [DataMember]
    public required IsoMax3NumericText ExchangeIdentification { get; init; } 
    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    [DataMember]
    public required GenericIdentification32 InitiatingParty { get; init; } 
    /// <summary>
    /// Unique identification of the partner that is the recipient of the exchange.
    /// </summary>
    [DataMember]
    public GenericIdentification32? RecipientParty { get; init; } 
    /// <summary>
    /// Sequence of this message in a conversation in integer.
    /// </summary>
    [DataMember]
    public required IsoNumber MessageSequenceNumber { get; init; } 
    /// <summary>
    /// Date and time at which the file or message was created.
    /// </summary>
    [DataMember]
    public required IsoISODateTime CreationDateTime { get; init; } 
    
    #nullable disable
}
