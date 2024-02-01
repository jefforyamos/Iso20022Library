﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Header31.  ISO2002 ID# _eMl4Qa1wEeWMg5rOByfExw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
/// </summary>
public partial record Header31
{
    #nullable enable
    
    /// <summary>
    /// Identifies the type of process related to the message.
    /// </summary>
    public required ATMMessageFunction2 MessageFunction { get; init; } 
    /// <summary>
    /// Version of the ATM protocol specifications.
    /// </summary>
    public required IsoMax6Text ProtocolVersion { get; init; } 
    /// <summary>
    /// Unique identification of an exchange occurrence.
    /// </summary>
    public required IsoMax3NumericText ExchangeIdentification { get; init; } 
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    public required IsoISODateTime CreationDateTime { get; init; } 
    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    public required IsoMax35Text InitiatingParty { get; init; } 
    /// <summary>
    /// Unique identification of the partner that is the recipient of the message exchange.
    /// </summary>
    public IsoMax35Text? RecipientParty { get; init; } 
    /// <summary>
    /// State of the sender of the message inside the process flow.
    /// </summary>
    public IsoMax35Text? ProcessState { get; init; } 
    /// <summary>
    /// Identification of partners involved in exchange from the merchant to the issuer, with the relative timestamp of their exchanges.
    /// </summary>
    public Traceability4[] Traceability { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
