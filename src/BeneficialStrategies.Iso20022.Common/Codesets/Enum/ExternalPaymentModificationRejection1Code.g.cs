﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalPaymentModificationRejection1Code.  ISO2002 ID# _eDCG4IlzEeePr-EGJjGYzQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for the rejection of a modification, as published in an external payment modification rejection code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_eDCG4IlzEeePr-EGJjGYzQ")]
[Description(@"Specifies the reason for the rejection of a modification, as published in an external payment modification rejection code set.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalPaymentModificationRejectionCode))]
public enum ExternalPaymentModificationRejection1Code
{
    /// <summary>
    /// Related transaction reference cannot be modified.
    /// Encoded/decoded by serializers as "UM01".
    /// </summary>
    [EnumMember(Value = "UM01")]
    [IsoId("_ucP6JfRYEeuLhpyIdtJzwg")]
    [Description(@"Related transaction reference cannot be modified.")]
    UnableToModifyRelatedReference = ExternalPaymentModificationRejectionCode.UnableToModifyRelatedReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Service level element of payment type cannot be modified(former UnableToModifyBankOperationCode).
    /// Encoded/decoded by serializers as "UM02".
    /// </summary>
    [EnumMember(Value = "UM02")]
    [IsoId("_ucP6KPRYEeuLhpyIdtJzwg")]
    [Description(@"Service level element of payment type cannot be modified(former UnableToModifyBankOperationCode).")]
    UnableToModifyPaymentServiceLevel = ExternalPaymentModificationRejectionCode.UnableToModifyPaymentServiceLevel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Category purpose element of payment type cannot be modified (former UnableToModifyInstructionCode).
    /// Encoded/decoded by serializers as "UM03".
    /// </summary>
    [EnumMember(Value = "UM03")]
    [IsoId("_ucP6K_RYEeuLhpyIdtJzwg")]
    [Description(@"Category purpose element of payment type cannot be modified (former UnableToModifyInstructionCode).")]
    UnableToModifyCategoryPurpose = ExternalPaymentModificationRejectionCode.UnableToModifyCategoryPurpose, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// RequestedExecutionDate cannot be modified.
    /// Encoded/decoded by serializers as "UM04".
    /// </summary>
    [EnumMember(Value = "UM04")]
    [IsoId("_ucZrIvRYEeuLhpyIdtJzwg")]
    [Description(@"RequestedExecutionDate cannot be modified.")]
    UnableToModifyRequestedExecutionDate = ExternalPaymentModificationRejectionCode.UnableToModifyRequestedExecutionDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// InterbankSettlementDate cannot be modified (former UnableToModifyValueDate).
    /// Encoded/decoded by serializers as "UM05".
    /// </summary>
    [EnumMember(Value = "UM05")]
    [IsoId("_ucZrJfRYEeuLhpyIdtJzwg")]
    [Description(@"InterbankSettlementDate cannot be modified (former UnableToModifyValueDate).")]
    UnableToModifyInterbankSettlementDate = ExternalPaymentModificationRejectionCode.UnableToModifyInterbankSettlementDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// SettlementAccount cannot be modified (former UnableToModifyInterbankSettlementAccount).
    /// Encoded/decoded by serializers as "UM06".
    /// </summary>
    [EnumMember(Value = "UM06")]
    [IsoId("_ucZrKPRYEeuLhpyIdtJzwg")]
    [Description(@"SettlementAccount cannot be modified (former UnableToModifyInterbankSettlementAccount).")]
    UnableToModifyInterbankSettlementAccount = ExternalPaymentModificationRejectionCode.UnableToModifyInterbankSettlementAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor cannot be modified.
    /// Encoded/decoded by serializers as "UM07".
    /// </summary>
    [EnumMember(Value = "UM07")]
    [IsoId("_ucZrK_RYEeuLhpyIdtJzwg")]
    [Description(@"Debtor cannot be modified.")]
    UnableToModifyDebtor = ExternalPaymentModificationRejectionCode.UnableToModifyDebtor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DebtorAccount cannot be modified.
    /// Encoded/decoded by serializers as "UM08".
    /// </summary>
    [EnumMember(Value = "UM08")]
    [IsoId("_ucZrLvRYEeuLhpyIdtJzwg")]
    [Description(@"DebtorAccount cannot be modified.")]
    UnableToModifyDebtorAccount = ExternalPaymentModificationRejectionCode.UnableToModifyDebtorAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// InstructedReimbursementAgent cannot be modified (former UnableToModifyReceiverCorrespondent).
    /// Encoded/decoded by serializers as "UM09".
    /// </summary>
    [EnumMember(Value = "UM09")]
    [IsoId("_uci1EvRYEeuLhpyIdtJzwg")]
    [Description(@"InstructedReimbursementAgent cannot be modified (former UnableToModifyReceiverCorrespondent).")]
    UnableToModifyInstructedReimbursementAgent = ExternalPaymentModificationRejectionCode.UnableToModifyInstructedReimbursementAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// ThirdReimbursementAgent cannot be modified (former UnableToModifyThirdReimbursementInstitution).
    /// Encoded/decoded by serializers as "UM10".
    /// </summary>
    [EnumMember(Value = "UM10")]
    [IsoId("_uci1FfRYEeuLhpyIdtJzwg")]
    [Description(@"ThirdReimbursementAgent cannot be modified (former UnableToModifyThirdReimbursementInstitution).")]
    UnableToModifyThirdReimbursementAgent = ExternalPaymentModificationRejectionCode.UnableToModifyThirdReimbursementAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Clearing Channel element of payment type cannot be modified (former UnableToModifyPaymentScheme)
    /// Encoded/decoded by serializers as "UM11".
    /// </summary>
    [EnumMember(Value = "UM11")]
    [IsoId("_uci1GPRYEeuLhpyIdtJzwg")]
    [Description(@"Clearing Channel element of payment type cannot be modified (former UnableToModifyPaymentScheme)")]
    UnableToModifyPaymentClearingChannel = ExternalPaymentModificationRejectionCode.UnableToModifyPaymentClearingChannel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor agent account cannot be modified (former UnableToModifyAccountOfBeneficiaryInstitution)
    /// Encoded/decoded by serializers as "UM12".
    /// </summary>
    [EnumMember(Value = "UM12")]
    [IsoId("_ucsmEvRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor agent account cannot be modified (former UnableToModifyAccountOfBeneficiaryInstitution)")]
    UnableToModifyCreditorAgentAccount = ExternalPaymentModificationRejectionCode.UnableToModifyCreditorAgentAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor cannot be modified.
    /// Encoded/decoded by serializers as "UM13".
    /// </summary>
    [EnumMember(Value = "UM13")]
    [IsoId("_ucsmFfRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor cannot be modified.")]
    UnableToModifyCreditor = ExternalPaymentModificationRejectionCode.UnableToModifyCreditor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor account cannot be modified.
    /// Encoded/decoded by serializers as "UM14".
    /// </summary>
    [EnumMember(Value = "UM14")]
    [IsoId("_ucsmGPRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor account cannot be modified.")]
    UnableToModifyCreditorAccount = ExternalPaymentModificationRejectionCode.UnableToModifyCreditorAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Remittance information cannot be modified.
    /// Encoded/decoded by serializers as "UM15".
    /// </summary>
    [EnumMember(Value = "UM15")]
    [IsoId("_ucsmG_RYEeuLhpyIdtJzwg")]
    [Description(@"Remittance information cannot be modified.")]
    UnableToModifyRemittanceInformation = ExternalPaymentModificationRejectionCode.UnableToModifyRemittanceInformation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// PaymentPurpose cannot be modified.
    /// Encoded/decoded by serializers as "UM16".
    /// </summary>
    [EnumMember(Value = "UM16")]
    [IsoId("_ucsmHvRYEeuLhpyIdtJzwg")]
    [Description(@"PaymentPurpose cannot be modified.")]
    UnableToModifyPaymentPurpose = ExternalPaymentModificationRejectionCode.UnableToModifyPaymentPurpose, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge bearer cannot be modified (former UnableToModifyDetailsOfCharges).
    /// Encoded/decoded by serializers as "UM17".
    /// </summary>
    [EnumMember(Value = "UM17")]
    [IsoId("_uc2XEvRYEeuLhpyIdtJzwg")]
    [Description(@"Charge bearer cannot be modified (former UnableToModifyDetailsOfCharges).")]
    UnableToModifyChargeBearer = ExternalPaymentModificationRejectionCode.UnableToModifyChargeBearer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction for next agent cannot be modified (former UnableToModifySenderToReceiver).
    /// Encoded/decoded by serializers as "UM18".
    /// </summary>
    [EnumMember(Value = "UM18")]
    [IsoId("_uc_hAvRYEeuLhpyIdtJzwg")]
    [Description(@"Instruction for next agent cannot be modified (former UnableToModifySenderToReceiver).")]
    UnableToModifyInstructionForNextAgent = ExternalPaymentModificationRejectionCode.UnableToModifyInstructionForNextAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction for creditor agent cannot be modified. (former UnableToModifyInstructionForFinalAgent).
    /// Encoded/decoded by serializers as "UM19".
    /// </summary>
    [EnumMember(Value = "UM19")]
    [IsoId("_uc_hBfRYEeuLhpyIdtJzwg")]
    [Description(@"Instruction for creditor agent cannot be modified. (former UnableToModifyInstructionForFinalAgent).")]
    UnableToModifyInstructionForCreditorAgent = ExternalPaymentModificationRejectionCode.UnableToModifyInstructionForCreditorAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used to inform of cancellation and request a new payment instruction. This should only be used if an agent does not want to modify a pending payment.
    /// Encoded/decoded by serializers as "UM20".
    /// </summary>
    [EnumMember(Value = "UM20")]
    [IsoId("_udJSAvRYEeuLhpyIdtJzwg")]
    [Description(@"Used to inform of cancellation and request a new payment instruction. This should only be used if an agent does not want to modify a pending payment.")]
    InstructionCancelledSubmitNewInstruction = ExternalPaymentModificationRejectionCode.InstructionCancelledSubmitNewInstruction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Modification is not possible and the cancellation is requested.
    /// Encoded/decoded by serializers as "UM21".
    /// </summary>
    [EnumMember(Value = "UM21")]
    [IsoId("_udJSBfRYEeuLhpyIdtJzwg")]
    [Description(@"Modification is not possible and the cancellation is requested.")]
    UnableToModifySubmitCancellation = ExternalPaymentModificationRejectionCode.UnableToModifySubmitCancellation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor agent account cannot be modified (applicable for direct debits).
    /// Encoded/decoded by serializers as "UM22".
    /// </summary>
    [EnumMember(Value = "UM22")]
    [IsoId("_udJSCPRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor agent account cannot be modified (applicable for direct debits).")]
    UnableToModifyDebtorAgentAccount = ExternalPaymentModificationRejectionCode.UnableToModifyDebtorAgentAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Interbank settlement amount cannot be modified.
    /// Encoded/decoded by serializers as "UM23".
    /// </summary>
    [EnumMember(Value = "UM23")]
    [IsoId("_udTDAvRYEeuLhpyIdtJzwg")]
    [Description(@"Interbank settlement amount cannot be modified.")]
    UnableToModifyInterbankSettlementAmount = ExternalPaymentModificationRejectionCode.UnableToModifyInterbankSettlementAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction for debtor agent cannot be modified (applicable for direct debits)
    /// Encoded/decoded by serializers as "UM24".
    /// </summary>
    [EnumMember(Value = "UM24")]
    [IsoId("_udTDBfRYEeuLhpyIdtJzwg")]
    [Description(@"Instruction for debtor agent cannot be modified (applicable for direct debits)")]
    UnableToModifyInstructionForDebtorAgent = ExternalPaymentModificationRejectionCode.UnableToModifyInstructionForDebtorAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Requested collection date cannot be modified (applicable for direct debits)
    /// Encoded/decoded by serializers as "UM25".
    /// </summary>
    [EnumMember(Value = "UM25")]
    [IsoId("_udcM8vRYEeuLhpyIdtJzwg")]
    [Description(@"Requested collection date cannot be modified (applicable for direct debits)")]
    UnableToModifyRequestedCollectionDate = ExternalPaymentModificationRejectionCode.UnableToModifyRequestedCollectionDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment type cannot be modified.
    /// Encoded/decoded by serializers as "UM26".
    /// </summary>
    [EnumMember(Value = "UM26")]
    [IsoId("_udcM9fRYEeuLhpyIdtJzwg")]
    [Description(@"Payment type cannot be modified.")]
    UnableToModifyPaymentType = ExternalPaymentModificationRejectionCode.UnableToModifyPaymentType, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instructed or equivalent amount cannot be modified.
    /// Encoded/decoded by serializers as "UM27".
    /// </summary>
    [EnumMember(Value = "UM27")]
    [IsoId("_udcM-PRYEeuLhpyIdtJzwg")]
    [Description(@"Instructed or equivalent amount cannot be modified.")]
    UnableToModifyInstructedAmount = ExternalPaymentModificationRejectionCode.UnableToModifyInstructedAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Priority of payment message cannot be modified.
    /// Encoded/decoded by serializers as "UM28".
    /// </summary>
    [EnumMember(Value = "UM28")]
    [IsoId("_udl98vRYEeuLhpyIdtJzwg")]
    [Description(@"Priority of payment message cannot be modified.")]
    UnableToModifyPriority = ExternalPaymentModificationRejectionCode.UnableToModifyPriority, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalPaymentModificationRejection1CodeMetadataExtensions
{
    private static readonly ExternalPaymentModificationRejection1CodeDropdownSource _dropdownSource = new ExternalPaymentModificationRejection1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalPaymentModificationRejection1CodeDropdownRow GetMetadata(this ExternalPaymentModificationRejection1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


