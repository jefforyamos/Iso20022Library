﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CollateralSubstitutionRequestIdentification.  ISO2002 ID# _TYW3lKerEeCq2KR6DaC1kQ_1953851275.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reference2Choice;

/// <summary>
/// Choice between the identification of the MarginCallRequest message, the MarginCallResponse message, the CollateralProposal message, the CollateralProposalResponse message, the CollateralSubstitutionRequest message, the CollateralSubstitutionResponse message, the CollateralSubstitutionConfirmation message, the InterestPaymentRequest message, the InterestPaymentResponse message, the InterestPaymentStatement message or the MarginCallDisputeNotification message.
/// </summary>
public partial record CollateralSubstitutionRequestIdentification : Reference2Choice_
{
    public required IsoMax35Text Value { get; init; }
}
