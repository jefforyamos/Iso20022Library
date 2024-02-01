﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TMSHeader1.  ISO2002 ID# _ROuPdwuhEeqw5uEXxQ9H4g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics related to the transfer of transactions.
/// </summary>
public partial record TMSHeader1
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
    public required IsoNumber ExchangeIdentification { get; init; } 
    /// <summary>
    /// Date and time at which the file or message was created.
    /// </summary>
    public required IsoISODateTime CreationDateTime { get; init; } 
    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    public required GenericIdentification176 InitiatingParty { get; init; } 
    /// <summary>
    /// Unique identification of the partner that is the recipient of the exchange.
    /// </summary>
    public GenericIdentification177? RecipientParty { get; init; } 
    /// <summary>
    /// Identification of partners involved in exchange from the merchant to the issuer, with the relative timestamp of their exchanges.
    /// </summary>
    public Traceability8[] Traceability { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
