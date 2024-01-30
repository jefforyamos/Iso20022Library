﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RejectionReason2.  ISO2002 ID# _UsSuA9p-Ed-ak6NoX_4Aeg_-521235445.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General information about the reason of the rejection.
/// </summary>
public partial record RejectionReason2
{
    #nullable enable
    
    /// <summary>
    /// Reason of the rejection provided by the rejecting party.
    /// </summary>
    public required IsoMax35Text RejectingPartyReason { get; init; } 
    /// <summary>
    /// Date and time at which the rejection was generated.
    /// </summary>
    public IsoISODateTime? RejectionDateTime { get; init; } 
    /// <summary>
    /// Description of the precise location of the potential error in a message.
    /// </summary>
    public IsoMax350Text? ErrorLocation { get; init; } 
    /// <summary>
    /// Detailed description of the rejection reason.
    /// </summary>
    public IsoMax350Text? ReasonDescription { get; init; } 
    /// <summary>
    /// Additional information related to the rejection and meant to allow for the precise identification of the rejection reason. This could include a copy of the rejected message in part or in full.
    /// </summary>
    public IsoMax20000Text? AdditionalData { get; init; } 
    
    #nullable disable
}
