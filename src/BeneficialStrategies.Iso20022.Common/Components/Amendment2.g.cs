﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Amendment2.  ISO2002 ID# _9-Q1snltEeG7BsjMvd1mEw_-687774575.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the amendment.
/// </summary>
public partial record Amendment2
{
    #nullable enable
    
    /// <summary>
    /// Contents of the related Undertaking Amendment message.
    /// </summary>
    public required UndertakingAmendmentMessage1 UndertakingAmendmentMessage { get; init; } 
    /// <summary>
    /// Additional information related to the first advising party.
    /// </summary>
    public AdvisingPartyAdditionalInformation1? FirstAdvisingPartyAdditionalInformation { get; init; } 
    /// <summary>
    /// Additional information related to the second advising party.
    /// </summary>
    public AdvisingPartyAdditionalInformation1? SecondAdvisingPartyAdditionalInformation { get; init; } 
    /// <summary>
    /// Details concerning the confirmation of the proposed amendment.
    /// </summary>
    public UndertakingConfirmation1? ConfirmationDetails { get; init; } 
    /// <summary>
    /// Digital signature of the party providing additional undertaking amendment advice details.
    /// </summary>
    public IReadOnlyCollection<PartyAndSignature2> DigitalSignature { get; init; } = [];
    
    #nullable disable
}
