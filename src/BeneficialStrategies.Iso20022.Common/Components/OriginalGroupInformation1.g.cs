﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalGroupInformation1.  ISO2002 ID# _Pg5AJ9p-Ed-ak6NoX_4Aeg_312087008.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous identifier of the group of transactions as assigned by the original instructing party.
/// </summary>
public partial record OriginalGroupInformation1
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference assigned by the original instructing party to unambiguously identify the original group of individual transactions.
    /// </summary>
    public required IsoMax35Text OriginalMessageIdentification { get; init; } 
    /// <summary>
    /// Name assigned by the sending party to unambiguously identify the file transmitted on the network.
    /// </summary>
    public required IsoMax35Text NetworkFileName { get; init; } 
    /// <summary>
    /// Specifies the original message name identifier to which the message refers, eg, pacs.003.001.01 or MT103.
    /// </summary>
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; } 
    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    public IsoISODateTime? OriginalCreationDateTime { get; init; } 
    /// <summary>
    /// Party that sent the file for which the status has been generated.||Usage: this field will only be used when the content of the message could not be decoded at the receiving side.
    /// </summary>
    public IsoMax35Text? FileOriginator { get; init; } 
    /// <summary>
    /// Number of individual transactions contained in the original message.
    /// </summary>
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; } 
    /// <summary>
    /// Total of all individual amounts included in the original message, irrespective of currencies.
    /// </summary>
    public IsoDecimalNumber? OriginalControlSum { get; init; } 
    /// <summary>
    /// Specifies the status of a group of transactions.
    /// </summary>
    public TransactionGroupStatus1Code? GroupStatus { get; init; } 
    /// <summary>
    /// Detailed information on the status reason.
    /// </summary>
    public StatusReasonInformation1[] StatusReasonInformation { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Detailed information on the number of transactions for each identical individual transaction status.
    /// </summary>
    public NumberOfTransactionsPerStatus1[] NumberOfTransactionsPerStatus { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
