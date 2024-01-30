﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Amendment6.  ISO2002 ID# _9_TXgXltEeG7BsjMvd1mEw_678552493.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the amendment.
/// </summary>
public partial record Amendment6
{
    #nullable enable
    
    /// <summary>
    /// Contents of the related proposed Undertaking Amendment message.
    /// </summary>
    public required UndertakingAmendmentMessage1 UndertakingAmendmentMessage { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier assigned by the applicant to the undertaking.
    /// </summary>
    public IsoMax35Text? ApplicantReferenceNumber { get; init; } 
    /// <summary>
    /// Additional information related to the notification.
    /// </summary>
    // public IReadOnlyCollection<IsoMax2000Text> AdditionalInformation { get; init; }
    
    #nullable disable
}
