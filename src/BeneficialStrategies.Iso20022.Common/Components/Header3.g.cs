﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Header3.  ISO2002 ID# _SwPX0wEcEeCQm6a_G2yO_w_-1399456836.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics related to the transfer of transactions.
/// </summary>
public partial record Header3
{
    #nullable enable
    
    /// <summary>
    /// Indicates if the file transfer is a download or an upload.
    /// </summary>
    public required IsoTrueFalseIndicator DownloadTransfer { get; init; } 
    /// <summary>
    /// Version of file format.
    /// </summary>
    public required IsoMax6Text FormatVersion { get; init; } 
    /// <summary>
    /// Unique identification of an exchange occurrence.
    /// </summary>
    public required IsoMax3NumericText ExchangeIdentification { get; init; } 
    /// <summary>
    /// Date and time at which the file or message was created.
    /// </summary>
    public required IsoISODateTime CreationDateTime { get; init; } 
    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    public required GenericIdentification32 InitiatingParty { get; init; } 
    /// <summary>
    /// Unique identification of the partner that is the recipient of the exchange.
    /// </summary>
    public GenericIdentification32? RecipientParty { get; init; } 
    
    #nullable disable
}
