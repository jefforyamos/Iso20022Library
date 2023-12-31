﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalInvestigationExecutionConfirmation1Code.  ISO2002 ID# _iF0dsImxEeeKR__nUfxjwA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the result of an investigation, as published in an external investigation execution confirmation code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_iF0dsImxEeeKR__nUfxjwA")]
[Description(@"Specifies the result of an investigation, as published in an external investigation execution confirmation code set. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalInvestigationExecutionConfirmationCode))]
public enum ExternalInvestigationExecutionConfirmation1Code
{
    /// <summary>
    /// Used when a creditor accepts the debit authorisation.
    /// Encoded/decoded by serializers as "AcceptedDebitAuthorisation".
    /// </summary>
    [EnumMember(Value = "ACDA")]
    [IsoId("_uZRepfRYEeuLhpyIdtJzwg")]
    [Description(@"Used when a creditor accepts the debit authorisation.")]
    AcceptedDebitAuthorisation,
    
    /// <summary>
    /// The claim for non-receipt of a payment instruction is accepted.
    /// Encoded/decoded by serializers as "AcceptedClaimNonReceipt".
    /// </summary>
    [EnumMember(Value = "ACNR")]
    [IsoId("_uZReqPRYEeuLhpyIdtJzwg")]
    [Description(@"The claim for non-receipt of a payment instruction is accepted.")]
    AcceptedClaimNonReceipt,
    
    /// <summary>
    /// The claim for value date correction is accepted.
    /// Encoded/decoded by serializers as "AcceptedValueDateAdjustment".
    /// </summary>
    [EnumMember(Value = "ACVA")]
    [IsoId("_uZaokvRYEeuLhpyIdtJzwg")]
    [Description(@"The claim for value date correction is accepted.")]
    AcceptedValueDateAdjustment,
    
    /// <summary>
    /// Further charges details are provided to resolve the case.
    /// Encoded/decoded by serializers as "ChargesDetailsProvided".
    /// </summary>
    [EnumMember(Value = "CHRG")]
    [IsoId("_uZaolfRYEeuLhpyIdtJzwg")]
    [Description(@"Further charges details are provided to resolve the case.")]
    ChargesDetailsProvided,
    
    /// <summary>
    /// Used when a requested cancellation is successful.
    /// Encoded/decoded by serializers as "CancelledAsPerRequest".
    /// </summary>
    [EnumMember(Value = "CNCL")]
    [IsoId("_uZaomPRYEeuLhpyIdtJzwg")]
    [Description(@"Used when a requested cancellation is successful.")]
    CancelledAsPerRequest,
    
    /// <summary>
    /// Used when a payment has been checked and was correctly executed without any intervention.
    /// Encoded/decoded by serializers as "ConfirmationOfPayment".
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_uZaom_RYEeuLhpyIdtJzwg")]
    [Description(@"Used when a payment has been checked and was correctly executed without any intervention.")]
    ConfirmationOfPayment,
    
    /// <summary>
    /// The original value date was correct.
    /// Encoded/decoded by serializers as "CorrectValueDateAlreadyApplied".
    /// </summary>
    [EnumMember(Value = "CVAA")]
    [IsoId("_uZkZkvRYEeuLhpyIdtJzwg")]
    [Description(@"The original value date was correct.")]
    CorrectValueDateAlreadyApplied,
    
    /// <summary>
    /// Used when a payment will be cancelled to solve an investigation case.
    /// Encoded/decoded by serializers as "CancellationWillFollow".
    /// </summary>
    [EnumMember(Value = "CWFW")]
    [IsoId("_uZkZlfRYEeuLhpyIdtJzwg")]
    [Description(@"Used when a payment will be cancelled to solve an investigation case.")]
    CancellationWillFollow,
    
    /// <summary>
    /// The cancellation request has been forwarded to the next agent for execution.|Usage: This code should only be utilised where a Case Id is not present.
    /// Encoded/decoded by serializers as "CancellationRequestForwardedToTheNextAgent".
    /// </summary>
    [EnumMember(Value = "FTNA")]
    [IsoId("_uZkZmPRYEeuLhpyIdtJzwg")]
    [Description(@"The cancellation request has been forwarded to the next agent for execution.|Usage: This code should only be utilised where a Case Id is not present.")]
    CancellationRequestForwardedToTheNextAgent,
    
    /// <summary>
    /// Used when a transfer of funds has been initiated (a cover payment) to resolve a case.
    /// Encoded/decoded by serializers as "CoverInitiated".
    /// </summary>
    [EnumMember(Value = "ICOV")]
    [IsoId("_uZkZm_RYEeuLhpyIdtJzwg")]
    [Description(@"Used when a transfer of funds has been initiated (a cover payment) to resolve a case.")]
    CoverInitiated,
    
    /// <summary>
    /// Used when the requested check for a possible duplicate instruction is confirmed.
    /// Encoded/decoded by serializers as "InstructionIsDuplicate".
    /// </summary>
    [EnumMember(Value = "IDUP")]
    [IsoId("_uZuKkvRYEeuLhpyIdtJzwg")]
    [Description(@"Used when the requested check for a possible duplicate instruction is confirmed.")]
    InstructionIsDuplicate,
    
    /// <summary>
    /// Used when the result of an investigation is, or will be, the initiation of a payment instruction.
    /// Encoded/decoded by serializers as "PaymentInitiated".
    /// </summary>
    [EnumMember(Value = "IPAY")]
    [IsoId("_uZuKmPRYEeuLhpyIdtJzwg")]
    [Description(@"Used when the result of an investigation is, or will be, the initiation of a payment instruction.")]
    PaymentInitiated,
    
    /// <summary>
    /// Used when a payment instruction (eg. MT103) has been initiated to resolve a case.
    /// Encoded/decoded by serializers as "PaymentInstructionInitiated".
    /// </summary>
    [EnumMember(Value = "IPYI")]
    [IsoId("_uZuKm_RYEeuLhpyIdtJzwg")]
    [Description(@"Used when a payment instruction (eg. MT103) has been initiated to resolve a case.")]
    PaymentInstructionInitiated,
    
    /// <summary>
    /// Used when a transfer of funds has been modified (a cover payment) to resolve a case.
    /// Encoded/decoded by serializers as "CoverModified".
    /// </summary>
    [EnumMember(Value = "MCOV")]
    [IsoId("_uZuKnvRYEeuLhpyIdtJzwg")]
    [Description(@"Used when a transfer of funds has been modified (a cover payment) to resolve a case.")]
    CoverModified,
    
    /// <summary>
    /// Used when a requested modification is successful.
    /// Encoded/decoded by serializers as "ModifiedAsPerRequest".
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_uZ3UgvRYEeuLhpyIdtJzwg")]
    [Description(@"Used when a requested modification is successful.")]
    ModifiedAsPerRequest,
    
    /// <summary>
    /// Used when the payment will be modified to solve an investigation case.
    /// Encoded/decoded by serializers as "ModificationWillFollow".
    /// </summary>
    [EnumMember(Value = "MWFW")]
    [IsoId("_uZ3UhfRYEeuLhpyIdtJzwg")]
    [Description(@"Used when the payment will be modified to solve an investigation case.")]
    ModificationWillFollow,
    
    /// <summary>
    /// Used when a requested cancellation is pending.
    /// Encoded/decoded by serializers as "PendingCancellationRequest".
    /// </summary>
    [EnumMember(Value = "PDCR")]
    [IsoId("_uaBFgvRYEeuLhpyIdtJzwg")]
    [Description(@"Used when a requested cancellation is pending.")]
    PendingCancellationRequest,
    
    /// <summary>
    /// Used when a requested cancellation has been partially executed.
    /// Encoded/decoded by serializers as "PartiallyExecutedCancellationRequest".
    /// </summary>
    [EnumMember(Value = "PECR")]
    [IsoId("_uaBFhfRYEeuLhpyIdtJzwg")]
    [Description(@"Used when a requested cancellation has been partially executed.")]
    PartiallyExecutedCancellationRequest,
    
    /// <summary>
    /// Further purpose details are provided to resolve the case.
    /// Encoded/decoded by serializers as "PurposeDetailsProvided".
    /// </summary>
    [EnumMember(Value = "PURP")]
    [IsoId("_uaBFiPRYEeuLhpyIdtJzwg")]
    [Description(@"Further purpose details are provided to resolve the case.")]
    PurposeDetailsProvided,
    
    /// <summary>
    /// Used when a requested cancellation has been rejected.
    /// Encoded/decoded by serializers as "RejectedCancellationRequest".
    /// </summary>
    [EnumMember(Value = "RJCR")]
    [IsoId("_uaBFi_RYEeuLhpyIdtJzwg")]
    [Description(@"Used when a requested cancellation has been rejected.")]
    RejectedCancellationRequest,
    
    /// <summary>
    /// The claim for non-receipt of a payment instruction is rejected.
    /// Encoded/decoded by serializers as "RejectedClaimNonReceipt".
    /// </summary>
    [EnumMember(Value = "RJNR")]
    [IsoId("_uaKPcvRYEeuLhpyIdtJzwg")]
    [Description(@"The claim for non-receipt of a payment instruction is rejected.")]
    RejectedClaimNonReceipt,
    
    /// <summary>
    /// The claim for value date correction is rejected.
    /// Encoded/decoded by serializers as "RejectedValueDateAdjustment".
    /// </summary>
    [EnumMember(Value = "RJVA")]
    [IsoId("_uaKPdfRYEeuLhpyIdtJzwg")]
    [Description(@"The claim for value date correction is rejected.")]
    RejectedValueDateAdjustment,
    
    /// <summary>
    /// Used when the entry in the statement is correct.
    /// Encoded/decoded by serializers as "StatementEntryCorrect".
    /// </summary>
    [EnumMember(Value = "SMTC")]
    [IsoId("_uaUAcvRYEeuLhpyIdtJzwg")]
    [Description(@"Used when the entry in the statement is correct.")]
    StatementEntryCorrect,
    
    /// <summary>
    /// Used when the entry in the statement is incorrect and further information is provided with the resolution.
    /// Encoded/decoded by serializers as "StatementEntryIncorrect".
    /// </summary>
    [EnumMember(Value = "SMTI")]
    [IsoId("_uaUAdfRYEeuLhpyIdtJzwg")]
    [Description(@"Used when the entry in the statement is incorrect and further information is provided with the resolution.")]
    StatementEntryIncorrect,
    
    /// <summary>
    /// Used when sender wants to respond to an assignment with an Unable To Apply workflow.
    /// Encoded/decoded by serializers as "UnableToApplyWillFollow".
    /// </summary>
    [EnumMember(Value = "UWFW")]
    [IsoId("_uaUAePRYEeuLhpyIdtJzwg")]
    [Description(@"Used when sender wants to respond to an assignment with an Unable To Apply workflow.")]
    UnableToApplyWillFollow,
    
    /// <summary>
    /// Process a cancellation request but batch already settled.
    /// Encoded/decoded by serializers as "BatchInstructionAlreadySettled".
    /// </summary>
    [EnumMember(Value = "BIAS")]
    [IsoId("_eSPVoQTrEey95qpfbNuEwg")]
    [Description(@"Process a cancellation request but batch already settled.")]
    BatchInstructionAlreadySettled,
    
    /// <summary>
    /// Process a  Batch Cancellation "using an incorrect batch sequence number”.
    /// Encoded/decoded by serializers as "InstructionDoesNotExist".
    /// </summary>
    [EnumMember(Value = "IDNE")]
    [IsoId("_ekkbwQTrEey95qpfbNuEwg")]
    [Description(@"Process a  Batch Cancellation ""using an incorrect batch sequence number”.")]
    InstructionDoesNotExist,
    
    /// <summary>
    /// Process a cancellation request with incorrect reference to original batch.
    /// Encoded/decoded by serializers as "InvalidCancellationRequest".
    /// </summary>
    [EnumMember(Value = "IVCR")]
    [IsoId("_erSHwQTrEey95qpfbNuEwg")]
    [Description(@"Process a cancellation request with incorrect reference to original batch.")]
    InvalidCancellationRequest,
    
    /// <summary>
    /// Used when additional information has been sent to the beneficiary of a payment.
    /// Encoded/decoded by serializers as "AdditionalInformationSent".
    /// </summary>
    [EnumMember(Value = "INFO")]
    [IsoId("_G4loYRRyEeyk6Lq9x6ij-w")]
    [Description(@"Used when additional information has been sent to the beneficiary of a payment.")]
    AdditionalInformationSent,
    
    /// <summary>
    /// Used when no additional information is available.
    /// Encoded/decoded by serializers as "NoInformationAvailable".
    /// </summary>
    [EnumMember(Value = "NINF")]
    [IsoId("_pWiy8iemEe2VkIu7jTuNaA")]
    [Description(@"Used when no additional information is available.")]
    NoInformationAvailable,
    
    /// <summary>
    /// Used to inform that a response to an investigation is pending.
    /// Encoded/decoded by serializers as "Pending".
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_H78O8ienEe2VkIu7jTuNaA")]
    [Description(@"Used to inform that a response to an investigation is pending.")]
    Pending,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalInvestigationExecutionConfirmation1CodeMetadataExtensions
{
    private static readonly ExternalInvestigationExecutionConfirmation1CodeDropdownSource _dropdownSource = new ExternalInvestigationExecutionConfirmation1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalInvestigationExecutionConfirmation1CodeDropdownRow GetMetadata(this ExternalInvestigationExecutionConfirmation1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


