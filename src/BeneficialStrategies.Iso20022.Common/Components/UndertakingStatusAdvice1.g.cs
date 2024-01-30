﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UndertakingStatusAdvice1.  ISO2002 ID# _-DLK5XltEeG7BsjMvd1mEw_1047822406.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Undertaking status information.
/// </summary>
public partial record UndertakingStatusAdvice1
{
    #nullable enable
    
    /// <summary>
    /// Details related to the party that initiated the report.
    /// </summary>
    public required PartyIdentification43 InitiatingParty { get; init; } 
    /// <summary>
    /// Details related to the identification of the undertaking.
    /// </summary>
    public Undertaking8? UndertakingIdentification { get; init; } 
    /// <summary>
    /// Sequence number assigned by the issuer to each amendment of the undertaking.
    /// </summary>
    public IsoNumber? AmendmentSequenceNumber { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier assigned by the advising party to the undertaking.
    /// </summary>
    public IsoMax35Text? AdvisingPartyReferenceNumber { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier assigned by the confirmer to the undertaking.
    /// </summary>
    public IsoMax35Text? ConfirmerReferenceNumber { get; init; } 
    /// <summary>
    /// Specifies the category of the status.
    /// </summary>
    public required ExternalUndertakingStatusCategory1Code StatusCategory { get; init; } 
    /// <summary>
    /// Specifies the reported status.
    /// </summary>
    public required UndertakingStatus3Code Status { get; init; } 
    /// <summary>
    /// Set of elements used to provide detailed information on the status reason.
    /// </summary>
    public StatusReasonInformation8? StatusReason { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Amount reported.
    /// </summary>
    public ReportedAmount1? ReportedAmount { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Information concerning the original message to which the status report may be sent in response.
    /// </summary>
    public OriginalMessage1? OriginalMessageDetails { get; init; } 
    /// <summary>
    /// Document or template enclosed in the report.
    /// </summary>
    public Document9? EnclosedFile { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information related to the report.
    /// </summary>
    // public IReadOnlyCollection<IsoMax2000Text> AdditionalInformation { get; init; }
    
    #nullable disable
}
