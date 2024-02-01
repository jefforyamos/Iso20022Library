﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UndertakingAdvice1.  ISO2002 ID# _-AMvZnltEeG7BsjMvd1mEw_-927366247.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the advice for the issuance of an undertaking.
/// </summary>
public partial record UndertakingAdvice1
{
    #nullable enable
    
    /// <summary>
    /// Contents of the related UndertakingIssuance message.
    /// </summary>
    public required UndertakingIssuanceMessage UndertakingIssuanceMessage { get; init; } 
    /// <summary>
    /// Additional information related to the first advising party.
    /// </summary>
    public AdvisingPartyAdditionalInformation1? FirstAdvisingPartyAdditionalInformation { get; init; } 
    /// <summary>
    /// Additional information related to the second advising party.
    /// </summary>
    public AdvisingPartyAdditionalInformation1? SecondAdvisingPartyAdditionalInformation { get; init; } 
    /// <summary>
    /// Details related to the confirmation of the undertaking.
    /// </summary>
    public UndertakingConfirmation1? ConfirmationDetails { get; init; } 
    /// <summary>
    /// Digital signature of the party providing additional undertaking advice details.
    /// </summary>
    public PartyAndSignature2[] DigitalSignature { get; init; } = [];
    
    #nullable disable
}
