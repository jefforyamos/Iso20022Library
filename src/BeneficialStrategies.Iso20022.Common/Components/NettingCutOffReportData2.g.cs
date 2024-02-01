﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NettingCutOffReportData2.  ISO2002 ID# _BuNM0QN1Ee2-vqzwMUAewg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the meta data associated with a netting cut off report.
/// </summary>
public partial record NettingCutOffReportData2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a message, as assigned by the Sender. This unique identifier can be used for cross-referencing purposes in subsequent messages.
    /// </summary>
    public required IsoMax35Text MessageIdentification { get; init; } 
    /// <summary>
    /// Date and time at which the net report was generated.
    /// </summary>
    public required IsoISODateTime CreationDateTime { get; init; } 
    /// <summary>
    /// Describes the type of net report, indicating how the obligations have been calculated.
    /// </summary>
    public required IsoMax4Text ReportType { get; init; } 
    /// <summary>
    /// Date on which the proposed netting cut off will become active.
    /// </summary>
    public required IsoISODate ActivationDate { get; init; } 
    /// <summary>
    /// Describes the participant receiving the net report.
    /// </summary>
    public PartyIdentification242Choice_? NetServiceParticipantIdentification { get; init; } 
    /// <summary>
    /// Describes the central system responsible for generating the net report.
    /// </summary>
    public PartyIdentification242Choice_? ReportServicer { get; init; } 
    /// <summary>
    /// Describes the type of netting service supporting the net report.
    /// </summary>
    public IsoMax35Text? NetServiceType { get; init; } 
    /// <summary>
    /// Page number of the message (within the net cut off report) and continuation indicator to indicate that the report is to continue or that the message is the last page of the report.
    /// </summary>
    public Pagination1? MessagePagination { get; init; } 
    
    #nullable disable
}
