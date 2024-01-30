﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RejectedCancellation.  ISO2002 ID# _UuYYtdp-Ed-ak6NoX_4Aeg_1934789984.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InvestigationStatusChoice;

/// <summary>
/// Explains the reason for rejecting a payment cancellation request.
/// </summary>
public partial record RejectedCancellation : IInvestigationStatusChoice
{
    #nullable enable
    /// <summary>
    /// Justification for the rejection of the cancellation.
    /// </summary>
    public required PaymentCancellationRejection1Code ReasonCode { get; init; } 
    /// <summary>
    /// Free text justification for rejecting a cancellation.
    /// </summary>
    public IsoMax140Text? Reason { get; init; } 
    #nullable disable
}
