﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Header13.  ISO2002 ID# _Hl7pwWpCEeS4VPLpYyQgxQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics related to the protocol after a rejection.
/// </summary>
public partial record Header13
{
    #nullable enable
    
    /// <summary>
    /// Identifies the type of process related to the message.
    /// </summary>
    public required MessageFunction4Code MessageFunction { get; init; } 
    /// <summary>
    /// Version of the acquirer protocol specifications.
    /// </summary>
    public required IsoMax6Text ProtocolVersion { get; init; } 
    /// <summary>
    /// Unique identification of an exchange occurrence.
    /// </summary>
    public IsoMax3NumericText? ExchangeIdentification { get; init; } 
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    public required IsoISODateTime CreationDateTime { get; init; } 
    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    public GenericIdentification53? InitiatingParty { get; init; } 
    /// <summary>
    /// Unique identification of the partner that is the recipient of the message exchange.
    /// </summary>
    public GenericIdentification53? RecipientParty { get; init; } 
    /// <summary>
    /// Identification of partners involved in exchange from the merchant to the issuer, with the relative timestamp of their exchanges.
    /// </summary>
    public Traceability2[] Traceability { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
