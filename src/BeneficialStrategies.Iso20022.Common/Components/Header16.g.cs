﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Header16.  ISO2002 ID# _Ns0VYWp3EeSojYXQbRlLzA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics related to the reject of a transaction.
/// </summary>
[DataContract]
[XmlType]
public partial record Header16
{
    #nullable enable
    
    /// <summary>
    /// Version of the terminal management protocol specifications.
    /// </summary>
    [DataMember]
    public required IsoMax6Text ProtocolVersion { get; init; } 
    /// <summary>
    /// Unique identification of an exchange occurrence.
    /// </summary>
    [DataMember]
    public IsoMax3NumericText? ExchangeIdentification { get; init; } 
    /// <summary>
    /// Date and time at which the file or message was created.
    /// </summary>
    [DataMember]
    public required IsoISODateTime CreationDateTime { get; init; } 
    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    [DataMember]
    public required GenericIdentification72 InitiatingParty { get; init; } 
    /// <summary>
    /// Unique identification of the partner that is the recipient of the exchange.
    /// </summary>
    [DataMember]
    public GenericIdentification72? RecipientParty { get; init; } 
    
    #nullable disable
}
