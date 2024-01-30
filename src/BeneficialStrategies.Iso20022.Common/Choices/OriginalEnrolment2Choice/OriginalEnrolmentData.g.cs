﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OriginalEnrolmentData.  ISO2002 ID# _UZbOI-H7Eeqbls7Gk4-ckA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OriginalEnrolment2Choice;

/// <summary>
/// Provides the original enrolment data.
/// </summary>
public partial record OriginalEnrolmentData : IOriginalEnrolment2Choice
{
    #nullable enable
    /// <summary>
    /// Detailed activation data related to the creditor enrolment.
    /// </summary>
    public required CreditorServiceEnrolment1 Enrolment { get; init; } 
    /// <summary>
    /// Name used by a business for commercial purposes, although its registered legal name, used for contracts and other formal situations, may be another, such as the brand name.
    /// </summary>
    public IsoMax140Text? CreditorTradingName { get; init; } 
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    public required RTPPartyIdentification1 Creditor { get; init; } 
    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    public RTPPartyIdentification1? UltimateCreditor { get; init; } 
    /// <summary>
    /// Classification of a business by the types of goods or services it provides.
    /// </summary>
    public required IsoMerchantCategoryCodeIdentifier MerchantCategoryCode { get; init; } 
    /// <summary>
    /// Commercial logo of the creditor.
    /// </summary>
    public IsoMax10KBinary? CreditorLogo { get; init; } 
    #nullable disable
}
