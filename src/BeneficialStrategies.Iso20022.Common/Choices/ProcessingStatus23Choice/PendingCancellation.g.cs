﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PendingCancellation.  ISO2002 ID# _tTjyhf7sEeCvPoRGOxRobQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus23Choice;

/// <summary>
/// A cancellation request from yourself for this instruction is pending waiting for further processing (only as an response to an SecuritiesTransactionStatusQuery). The pending status on the processing of a cancellation request must be provided using a SecuritiesTransactionCancellationRequestStatusAdvice.
/// </summary>
public partial record PendingCancellation : IProcessingStatus23Choice
{
    #nullable enable
    #nullable disable
}
