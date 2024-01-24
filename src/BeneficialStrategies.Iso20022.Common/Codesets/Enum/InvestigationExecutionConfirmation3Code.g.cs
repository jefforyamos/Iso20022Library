﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InvestigationExecutionConfirmation3Code.  ISO2002 ID# _abKVUNp-Ed-ak6NoX_4Aeg_-2079093126.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the result of an investigation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_abKVUNp-Ed-ak6NoX_4Aeg_-2079093126")]
[Description(@"Specifies the result of an investigation.")]
[DerivedFrom(typeof(InvestigationExecutionConfirmationCode))]
public enum InvestigationExecutionConfirmation3Code
{
    /// <summary>
    /// Used when a requested cancellation is successful.
    /// Encoded/decoded by serializers as "CNCL".
    /// </summary>
    [EnumMember(Value = "CNCL")]
    [IsoId("_abKVUdp-Ed-ak6NoX_4Aeg_-2079093124")]
    [Description(@"Used when a requested cancellation is successful.")]
    CancelledAsPerRequest = InvestigationExecutionConfirmationCode.CancelledAsPerRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when a requested modification is successful.
    /// Encoded/decoded by serializers as "MODI".
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_abKVUtp-Ed-ak6NoX_4Aeg_-2079092879")]
    [Description(@"Used when a requested modification is successful.")]
    ModifiedAsPerRequest = InvestigationExecutionConfirmationCode.ModifiedAsPerRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when the result of an investigation is, or will be, the initiation of a payment instruction.
    /// Encoded/decoded by serializers as "IPAY".
    /// </summary>
    [EnumMember(Value = "IPAY")]
    [IsoId("_abKVU9p-Ed-ak6NoX_4Aeg_-2079092848")]
    [Description(@"Used when the result of an investigation is, or will be, the initiation of a payment instruction.")]
    PaymentInitiated = InvestigationExecutionConfirmationCode.PaymentInitiated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when a transfer of funds has been initiated (a cover payment) to resolve a case.
    /// Encoded/decoded by serializers as "ICOV".
    /// </summary>
    [EnumMember(Value = "ICOV")]
    [IsoId("_abKVVNp-Ed-ak6NoX_4Aeg_-2079092847")]
    [Description(@"Used when a transfer of funds has been initiated (a cover payment) to resolve a case.")]
    CoverInitiated = InvestigationExecutionConfirmationCode.CoverInitiated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when a transfer of funds has been modified (a cover payment) to resolve a case.
    /// Encoded/decoded by serializers as "MCOV".
    /// </summary>
    [EnumMember(Value = "MCOV")]
    [IsoId("_abKVVdp-Ed-ak6NoX_4Aeg_-2079092818")]
    [Description(@"Used when a transfer of funds has been modified (a cover payment) to resolve a case.")]
    CoverModified = InvestigationExecutionConfirmationCode.CoverModified, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when additional information has been sent to the beneficiary of a payment.
    /// Encoded/decoded by serializers as "INFO".
    /// </summary>
    [EnumMember(Value = "INFO")]
    [IsoId("_abKVVtp-Ed-ak6NoX_4Aeg_-2079092817")]
    [Description(@"Used when additional information has been sent to the beneficiary of a payment.")]
    AdditionalInformationSent = InvestigationExecutionConfirmationCode.AdditionalInformationSent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when a payment has been checked and was correctly executed without any intervention.
    /// Encoded/decoded by serializers as "CONF".
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_abKVV9p-Ed-ak6NoX_4Aeg_-2079092787")]
    [Description(@"Used when a payment has been checked and was correctly executed without any intervention.")]
    ConfirmationOfPayment = InvestigationExecutionConfirmationCode.ConfirmationOfPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when a payment will be cancelled to solve an investigation case.
    /// Encoded/decoded by serializers as "CWFW".
    /// </summary>
    [EnumMember(Value = "CWFW")]
    [IsoId("_abKVWNp-Ed-ak6NoX_4Aeg_-2079092786")]
    [Description(@"Used when a payment will be cancelled to solve an investigation case.")]
    CancellationWillFollow = InvestigationExecutionConfirmationCode.CancellationWillFollow, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when the payment will be modified to solve an investigation case.
    /// Encoded/decoded by serializers as "MWFW".
    /// </summary>
    [EnumMember(Value = "MWFW")]
    [IsoId("_abKVWdp-Ed-ak6NoX_4Aeg_-2079092756")]
    [Description(@"Used when the payment will be modified to solve an investigation case.")]
    ModificationWillFollow = InvestigationExecutionConfirmationCode.ModificationWillFollow, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when sender wants to respond to an assignment with an Unable To Apply workflow.
    /// Encoded/decoded by serializers as "UWFW".
    /// </summary>
    [EnumMember(Value = "UWFW")]
    [IsoId("_abTfQNp-Ed-ak6NoX_4Aeg_-2079092726")]
    [Description(@"Used when sender wants to respond to an assignment with an Unable To Apply workflow.")]
    UnableToApplyWillFollow = InvestigationExecutionConfirmationCode.UnableToApplyWillFollow, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when a requested cancellation has been partially executed.
    /// Encoded/decoded by serializers as "PECR".
    /// </summary>
    [EnumMember(Value = "PECR")]
    [IsoId("_abTfQdp-Ed-ak6NoX_4Aeg_-1345816597")]
    [Description(@"Used when a requested cancellation has been partially executed.")]
    PartiallyExecutedCancellationRequest = InvestigationExecutionConfirmationCode.PartiallyExecutedCancellationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when a requested cancellation is pending.
    /// Encoded/decoded by serializers as "PDCR".
    /// </summary>
    [EnumMember(Value = "PDCR")]
    [IsoId("_abTfQtp-Ed-ak6NoX_4Aeg_-296799305")]
    [Description(@"Used when a requested cancellation is pending.")]
    PendingCancellationRequest = InvestigationExecutionConfirmationCode.PendingCancellationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when a requested cancellation has been rejected.
    /// Encoded/decoded by serializers as "RJCR".
    /// </summary>
    [EnumMember(Value = "RJCR")]
    [IsoId("_abTfQ9p-Ed-ak6NoX_4Aeg_-1345816567")]
    [Description(@"Used when a requested cancellation has been rejected.")]
    RejectedCancellationRequest = InvestigationExecutionConfirmationCode.RejectedCancellationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when the entry in the statement is correct.
    /// Encoded/decoded by serializers as "SMTC".
    /// </summary>
    [EnumMember(Value = "SMTC")]
    [IsoId("_abTfRNp-Ed-ak6NoX_4Aeg_-468064811")]
    [Description(@"Used when the entry in the statement is correct.")]
    StatementEntryCorrect = InvestigationExecutionConfirmationCode.StatementEntryCorrect, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when the entry in the statement is incorrect and further information is provided with the resolution.
    /// Encoded/decoded by serializers as "SMTI".
    /// </summary>
    [EnumMember(Value = "SMTI")]
    [IsoId("_abTfRdp-Ed-ak6NoX_4Aeg_-508698788")]
    [Description(@"Used when the entry in the statement is incorrect and further information is provided with the resolution.")]
    StatementEntryIncorrect = InvestigationExecutionConfirmationCode.StatementEntryIncorrect, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Further charges details are provided to resolve the case.
    /// Encoded/decoded by serializers as "CHRG".
    /// </summary>
    [EnumMember(Value = "CHRG")]
    [IsoId("_abTfRtp-Ed-ak6NoX_4Aeg_-508698479")]
    [Description(@"Further charges details are provided to resolve the case.")]
    ChargesDetailsProvided = InvestigationExecutionConfirmationCode.ChargesDetailsProvided, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Further purpose details are provided to resolve the case.
    /// Encoded/decoded by serializers as "PURP".
    /// </summary>
    [EnumMember(Value = "PURP")]
    [IsoId("_abTfR9p-Ed-ak6NoX_4Aeg_-508698449")]
    [Description(@"Further purpose details are provided to resolve the case.")]
    PurposeDetailsProvided = InvestigationExecutionConfirmationCode.PurposeDetailsProvided, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when the requested check for a possible duplicate instruction is confirmed.
    /// Encoded/decoded by serializers as "IDUP".
    /// </summary>
    [EnumMember(Value = "IDUP")]
    [IsoId("_abTfSNp-Ed-ak6NoX_4Aeg_-192405012")]
    [Description(@"Used when the requested check for a possible duplicate instruction is confirmed.")]
    InstructionIsDuplicate = InvestigationExecutionConfirmationCode.InstructionIsDuplicate, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InvestigationExecutionConfirmation3CodeMetadataExtensions
{
    private static readonly InvestigationExecutionConfirmation3CodeDropdownSource _dropdownSource = new InvestigationExecutionConfirmation3CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInvestigationExecutionConfirmation3CodeDropdownRow GetMetadata(this InvestigationExecutionConfirmation3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


