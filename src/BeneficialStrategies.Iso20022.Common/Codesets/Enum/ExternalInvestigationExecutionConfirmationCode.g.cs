﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalInvestigationExecutionConfirmationCode.  ISO2002 ID# _RNLFpYmxEeeKR__nUfxjwA.
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
[IsoId("_RNLFpYmxEeeKR__nUfxjwA")]
[Description(@"Specifies the result of an investigation, as published in an external investigation execution confirmation code set. External code sets can be downloaded from www.iso20022.org.")]
public enum ExternalInvestigationExecutionConfirmationCode
{
    /// <summary>
    /// Used when a requested cancellation is successful.
    /// Encoded/decoded by serializers as "CNCL".
    /// </summary>
    [EnumMember(Value = "CNCL")]
    [IsoId("_RNLFqImxEeeKR__nUfxjwA")]
    [Description(@"Used when a requested cancellation is successful.")]
    CancelledAsPerRequest,
    
    /// <summary>
    /// Used when a requested modification is successful.
    /// Encoded/decoded by serializers as "MODI".
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_RNLFr4mxEeeKR__nUfxjwA")]
    [Description(@"Used when a requested modification is successful.")]
    ModifiedAsPerRequest,
    
    /// <summary>
    /// Used when a creditor accepts the debit authorisation.
    /// Encoded/decoded by serializers as "ACDA".
    /// </summary>
    [EnumMember(Value = "ACDA")]
    [IsoId("_RNLFtImxEeeKR__nUfxjwA")]
    [Description(@"Used when a creditor accepts the debit authorisation.")]
    AcceptedDebitAuthorisation,
    
    /// <summary>
    /// Used when the result of an investigation is, or will be, the initiation of a payment instruction.
    /// Encoded/decoded by serializers as "IPAY".
    /// </summary>
    [EnumMember(Value = "IPAY")]
    [IsoId("_RNLFuImxEeeKR__nUfxjwA")]
    [Description(@"Used when the result of an investigation is, or will be, the initiation of a payment instruction.")]
    PaymentInitiated,
    
    /// <summary>
    /// Used when a transfer of funds has been initiated (a cover payment) to resolve a case.
    /// Encoded/decoded by serializers as "ICOV".
    /// </summary>
    [EnumMember(Value = "ICOV")]
    [IsoId("_RNLFpomxEeeKR__nUfxjwA")]
    [Description(@"Used when a transfer of funds has been initiated (a cover payment) to resolve a case.")]
    CoverInitiated,
    
    /// <summary>
    /// Used when a transfer of funds has been modified (a cover payment) to resolve a case.
    /// Encoded/decoded by serializers as "MCOV".
    /// </summary>
    [EnumMember(Value = "MCOV")]
    [IsoId("_RNLFtYmxEeeKR__nUfxjwA")]
    [Description(@"Used when a transfer of funds has been modified (a cover payment) to resolve a case.")]
    CoverModified,
    
    /// <summary>
    /// Used when a payment instruction (eg. MT103) has been initiated to resolve a case.
    /// Encoded/decoded by serializers as "IPYI".
    /// </summary>
    [EnumMember(Value = "IPYI")]
    [IsoId("_RNLFp4mxEeeKR__nUfxjwA")]
    [Description(@"Used when a payment instruction (eg. MT103) has been initiated to resolve a case.")]
    PaymentInstructionInitiated,
    
    /// <summary>
    /// Used when additional information has been sent to the beneficiary of a payment.
    /// Encoded/decoded by serializers as "INFO".
    /// </summary>
    [EnumMember(Value = "INFO")]
    [IsoId("_RNLFuYmxEeeKR__nUfxjwA")]
    [Description(@"Used when additional information has been sent to the beneficiary of a payment.")]
    AdditionalInformationSent,
    
    /// <summary>
    /// Used when a payment has been checked and was correctly executed without any intervention.
    /// Encoded/decoded by serializers as "CONF".
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_RNLFqomxEeeKR__nUfxjwA")]
    [Description(@"Used when a payment has been checked and was correctly executed without any intervention.")]
    ConfirmationOfPayment,
    
    /// <summary>
    /// Used when a payment will be cancelled to solve an investigation case.
    /// Encoded/decoded by serializers as "CWFW".
    /// </summary>
    [EnumMember(Value = "CWFW")]
    [IsoId("_RNLFromxEeeKR__nUfxjwA")]
    [Description(@"Used when a payment will be cancelled to solve an investigation case.")]
    CancellationWillFollow,
    
    /// <summary>
    /// Used when the payment will be modified to solve an investigation case.
    /// Encoded/decoded by serializers as "MWFW".
    /// </summary>
    [EnumMember(Value = "MWFW")]
    [IsoId("_RNLFsYmxEeeKR__nUfxjwA")]
    [Description(@"Used when the payment will be modified to solve an investigation case.")]
    ModificationWillFollow,
    
    /// <summary>
    /// Used when sender wants to respond to an assignment with an Unable To Apply workflow.
    /// Encoded/decoded by serializers as "UWFW".
    /// </summary>
    [EnumMember(Value = "UWFW")]
    [IsoId("_RNLFsImxEeeKR__nUfxjwA")]
    [Description(@"Used when sender wants to respond to an assignment with an Unable To Apply workflow.")]
    UnableToApplyWillFollow,
    
    /// <summary>
    /// Used when a requested cancellation has been partially executed.
    /// Encoded/decoded by serializers as "PECR".
    /// </summary>
    [EnumMember(Value = "PECR")]
    [IsoId("_RNLFs4mxEeeKR__nUfxjwA")]
    [Description(@"Used when a requested cancellation has been partially executed.")]
    PartiallyExecutedCancellationRequest,
    
    /// <summary>
    /// Used when a requested cancellation has been rejected.
    /// Encoded/decoded by serializers as "RJCR".
    /// </summary>
    [EnumMember(Value = "RJCR")]
    [IsoId("_RNLFsomxEeeKR__nUfxjwA")]
    [Description(@"Used when a requested cancellation has been rejected.")]
    RejectedCancellationRequest,
    
    /// <summary>
    /// Used when a requested cancellation is pending.
    /// Encoded/decoded by serializers as "PDCR".
    /// </summary>
    [EnumMember(Value = "PDCR")]
    [IsoId("_RNLFtomxEeeKR__nUfxjwA")]
    [Description(@"Used when a requested cancellation is pending.")]
    PendingCancellationRequest,
    
    /// <summary>
    /// Used when the entry in the statement is correct.
    /// Encoded/decoded by serializers as "SMTC".
    /// </summary>
    [EnumMember(Value = "SMTC")]
    [IsoId("_RNLFq4mxEeeKR__nUfxjwA")]
    [Description(@"Used when the entry in the statement is correct.")]
    StatementEntryCorrect,
    
    /// <summary>
    /// Used when the entry in the statement is incorrect and further information is provided with the resolution.
    /// Encoded/decoded by serializers as "SMTI".
    /// </summary>
    [EnumMember(Value = "SMTI")]
    [IsoId("_RNLFt4mxEeeKR__nUfxjwA")]
    [Description(@"Used when the entry in the statement is incorrect and further information is provided with the resolution.")]
    StatementEntryIncorrect,
    
    /// <summary>
    /// Further charges details are provided to resolve the case.
    /// Encoded/decoded by serializers as "CHRG".
    /// </summary>
    [EnumMember(Value = "CHRG")]
    [IsoId("_RNLFrImxEeeKR__nUfxjwA")]
    [Description(@"Further charges details are provided to resolve the case.")]
    ChargesDetailsProvided,
    
    /// <summary>
    /// Further purpose details are provided to resolve the case.
    /// Encoded/decoded by serializers as "PURP".
    /// </summary>
    [EnumMember(Value = "PURP")]
    [IsoId("_RNLFrYmxEeeKR__nUfxjwA")]
    [Description(@"Further purpose details are provided to resolve the case.")]
    PurposeDetailsProvided,
    
    /// <summary>
    /// Used when the requested check for a possible duplicate instruction is confirmed.
    /// Encoded/decoded by serializers as "IDUP".
    /// </summary>
    [EnumMember(Value = "IDUP")]
    [IsoId("_RNLFqYmxEeeKR__nUfxjwA")]
    [Description(@"Used when the requested check for a possible duplicate instruction is confirmed.")]
    InstructionIsDuplicate,
    
    /// <summary>
    /// The claim for non-receipt of a payment instruction is accepted.
    /// Encoded/decoded by serializers as "ACNR".
    /// </summary>
    [EnumMember(Value = "ACNR")]
    [IsoId("_uZRepvRYEeuLhpyIdtJzwg")]
    [Description(@"The claim for non-receipt of a payment instruction is accepted.")]
    AcceptedClaimNonReceipt,
    
    /// <summary>
    /// The claim for value date correction is accepted.
    /// Encoded/decoded by serializers as "ACVA".
    /// </summary>
    [EnumMember(Value = "ACVA")]
    [IsoId("_uZaokPRYEeuLhpyIdtJzwg")]
    [Description(@"The claim for value date correction is accepted.")]
    AcceptedValueDateAdjustment,
    
    /// <summary>
    /// The original value date was correct.
    /// Encoded/decoded by serializers as "CVAA".
    /// </summary>
    [EnumMember(Value = "CVAA")]
    [IsoId("_uZkZkPRYEeuLhpyIdtJzwg")]
    [Description(@"The original value date was correct.")]
    CorrectValueDateAlreadyApplied,
    
    /// <summary>
    /// The cancellation request has been forwarded to the next agent for execution.|Usage: This code should only be utilised where a Case Id is not present.
    /// Encoded/decoded by serializers as "FTNA".
    /// </summary>
    [EnumMember(Value = "FTNA")]
    [IsoId("_uZkZlvRYEeuLhpyIdtJzwg")]
    [Description(@"The cancellation request has been forwarded to the next agent for execution.|Usage: This code should only be utilised where a Case Id is not present.")]
    CancellationRequestForwardedToTheNextAgent,
    
    /// <summary>
    /// The claim for non-receipt of a payment instruction is rejected.
    /// Encoded/decoded by serializers as "RJNR".
    /// </summary>
    [EnumMember(Value = "RJNR")]
    [IsoId("_uaKPcPRYEeuLhpyIdtJzwg")]
    [Description(@"The claim for non-receipt of a payment instruction is rejected.")]
    RejectedClaimNonReceipt,
    
    /// <summary>
    /// The claim for value date correction is rejected.
    /// Encoded/decoded by serializers as "RJVA".
    /// </summary>
    [EnumMember(Value = "RJVA")]
    [IsoId("_uaKPc_RYEeuLhpyIdtJzwg")]
    [Description(@"The claim for value date correction is rejected.")]
    RejectedValueDateAdjustment,
    
    /// <summary>
    /// Process a  Batch Cancellation "using an incorrect batch sequence number”.
    /// Encoded/decoded by serializers as "IDNE".
    /// </summary>
    [EnumMember(Value = "IDNE")]
    [IsoId("_4MHTIATqEey95qpfbNuEwg")]
    [Description(@"Process a  Batch Cancellation ""using an incorrect batch sequence number”.")]
    InstructionDoesNotExist,
    
    /// <summary>
    /// Process a cancellation request with incorrect reference to original batch.
    /// Encoded/decoded by serializers as "IVCR".
    /// </summary>
    [EnumMember(Value = "IVCR")]
    [IsoId("_DehbgATrEey95qpfbNuEwg")]
    [Description(@"Process a cancellation request with incorrect reference to original batch.")]
    InvalidCancellationRequest,
    
    /// <summary>
    /// Process a cancellation request but batch already settled.
    /// Encoded/decoded by serializers as "BIAS".
    /// </summary>
    [EnumMember(Value = "BIAS")]
    [IsoId("_NHI7kATrEey95qpfbNuEwg")]
    [Description(@"Process a cancellation request but batch already settled.")]
    BatchInstructionAlreadySettled,
    
    /// <summary>
    /// Used when no additional information is available.
    /// Encoded/decoded by serializers as "NINF".
    /// </summary>
    [EnumMember(Value = "NINF")]
    [IsoId("_pWiy8CemEe2VkIu7jTuNaA")]
    [Description(@"Used when no additional information is available.")]
    NoInformationAvailable,
    
    /// <summary>
    /// Used to inform that a response to an investigation is pending.
    /// Encoded/decoded by serializers as "PDNG".
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_H78O8CenEe2VkIu7jTuNaA")]
    [Description(@"Used to inform that a response to an investigation is pending.")]
    Pending,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalInvestigationExecutionConfirmationCodeMetadataExtensions
{
    private static readonly ExternalInvestigationExecutionConfirmationCodeDropdownSource _dropdownSource = new ExternalInvestigationExecutionConfirmationCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalInvestigationExecutionConfirmationCodeDropdownRow GetMetadata(this ExternalInvestigationExecutionConfirmationCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


