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
[Description(@"Specifies the reason for the rejection of a modification, as published in an external payment modification rejection code set. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalPaymentModificationRejectionCode))]
public enum ExternalPaymentModificationRejection1Code
{
    /// <summary>
    /// Related transaction reference cannot be modified.
    /// Encoded/decoded by serializers as "UnableToModifyRelatedReference".
    /// </summary>
    [EnumMember(Value = "UM01")]
    [IsoId("_ucP6JfRYEeuLhpyIdtJzwg")]
    [Description(@"Related transaction reference cannot be modified.")]
    UnableToModifyRelatedReference,
    
    /// <summary>
    /// Service level element of payment type cannot be modified(former UnableToModifyBankOperationCode).
    /// Encoded/decoded by serializers as "UnableToModifyPaymentServiceLevel".
    /// </summary>
    [EnumMember(Value = "UM02")]
    [IsoId("_ucP6KPRYEeuLhpyIdtJzwg")]
    [Description(@"Service level element of payment type cannot be modified(former UnableToModifyBankOperationCode).")]
    UnableToModifyPaymentServiceLevel,
    
    /// <summary>
    /// Category purpose element of payment type cannot be modified (former UnableToModifyInstructionCode).
    /// Encoded/decoded by serializers as "UnableToModifyCategoryPurpose".
    /// </summary>
    [EnumMember(Value = "UM03")]
    [IsoId("_ucP6K_RYEeuLhpyIdtJzwg")]
    [Description(@"Category purpose element of payment type cannot be modified (former UnableToModifyInstructionCode).")]
    UnableToModifyCategoryPurpose,
    
    /// <summary>
    /// RequestedExecutionDate cannot be modified.
    /// Encoded/decoded by serializers as "UnableToModifyRequestedExecutionDate".
    /// </summary>
    [EnumMember(Value = "UM04")]
    [IsoId("_ucZrIvRYEeuLhpyIdtJzwg")]
    [Description(@"RequestedExecutionDate cannot be modified.")]
    UnableToModifyRequestedExecutionDate,
    
    /// <summary>
    /// InterbankSettlementDate cannot be modified (former UnableToModifyValueDate).
    /// Encoded/decoded by serializers as "UnableToModifyInterbankSettlementDate".
    /// </summary>
    [EnumMember(Value = "UM05")]
    [IsoId("_ucZrJfRYEeuLhpyIdtJzwg")]
    [Description(@"InterbankSettlementDate cannot be modified (former UnableToModifyValueDate).")]
    UnableToModifyInterbankSettlementDate,
    
    /// <summary>
    /// SettlementAccount cannot be modified (former UnableToModifyInterbankSettlementAccount).
    /// Encoded/decoded by serializers as "UnableToModifyInterbankSettlementAccount".
    /// </summary>
    [EnumMember(Value = "UM06")]
    [IsoId("_ucZrKPRYEeuLhpyIdtJzwg")]
    [Description(@"SettlementAccount cannot be modified (former UnableToModifyInterbankSettlementAccount).")]
    UnableToModifyInterbankSettlementAccount,
    
    /// <summary>
    /// Debtor cannot be modified.
    /// Encoded/decoded by serializers as "UnableToModifyDebtor".
    /// </summary>
    [EnumMember(Value = "UM07")]
    [IsoId("_ucZrK_RYEeuLhpyIdtJzwg")]
    [Description(@"Debtor cannot be modified.")]
    UnableToModifyDebtor,
    
    /// <summary>
    /// DebtorAccount cannot be modified.
    /// Encoded/decoded by serializers as "UnableToModifyDebtorAccount".
    /// </summary>
    [EnumMember(Value = "UM08")]
    [IsoId("_ucZrLvRYEeuLhpyIdtJzwg")]
    [Description(@"DebtorAccount cannot be modified.")]
    UnableToModifyDebtorAccount,
    
    /// <summary>
    /// InstructedReimbursementAgent cannot be modified (former UnableToModifyReceiverCorrespondent).
    /// Encoded/decoded by serializers as "UnableToModifyInstructedReimbursementAgent".
    /// </summary>
    [EnumMember(Value = "UM09")]
    [IsoId("_uci1EvRYEeuLhpyIdtJzwg")]
    [Description(@"InstructedReimbursementAgent cannot be modified (former UnableToModifyReceiverCorrespondent).")]
    UnableToModifyInstructedReimbursementAgent,
    
    /// <summary>
    /// ThirdReimbursementAgent cannot be modified (former UnableToModifyThirdReimbursementInstitution).
    /// Encoded/decoded by serializers as "UnableToModifyThirdReimbursementAgent".
    /// </summary>
    [EnumMember(Value = "UM10")]
    [IsoId("_uci1FfRYEeuLhpyIdtJzwg")]
    [Description(@"ThirdReimbursementAgent cannot be modified (former UnableToModifyThirdReimbursementInstitution).")]
    UnableToModifyThirdReimbursementAgent,
    
    /// <summary>
    /// Clearing Channel element of payment type cannot be modified (former UnableToModifyPaymentScheme)
    /// Encoded/decoded by serializers as "UnableToModifyPaymentClearingChannel".
    /// </summary>
    [EnumMember(Value = "UM11")]
    [IsoId("_uci1GPRYEeuLhpyIdtJzwg")]
    [Description(@"Clearing Channel element of payment type cannot be modified (former UnableToModifyPaymentScheme)")]
    UnableToModifyPaymentClearingChannel,
    
    /// <summary>
    /// Creditor agent account cannot be modified (former UnableToModifyAccountOfBeneficiaryInstitution)
    /// Encoded/decoded by serializers as "UnableToModifyCreditorAgentAccount".
    /// </summary>
    [EnumMember(Value = "UM12")]
    [IsoId("_ucsmEvRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor agent account cannot be modified (former UnableToModifyAccountOfBeneficiaryInstitution)")]
    UnableToModifyCreditorAgentAccount,
    
    /// <summary>
    /// Creditor cannot be modified.
    /// Encoded/decoded by serializers as "UnableToModifyCreditor".
    /// </summary>
    [EnumMember(Value = "UM13")]
    [IsoId("_ucsmFfRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor cannot be modified.")]
    UnableToModifyCreditor,
    
    /// <summary>
    /// Creditor account cannot be modified.
    /// Encoded/decoded by serializers as "UnableToModifyCreditorAccount".
    /// </summary>
    [EnumMember(Value = "UM14")]
    [IsoId("_ucsmGPRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor account cannot be modified.")]
    UnableToModifyCreditorAccount,
    
    /// <summary>
    /// Remittance information cannot be modified.
    /// Encoded/decoded by serializers as "UnableToModifyRemittanceInformation".
    /// </summary>
    [EnumMember(Value = "UM15")]
    [IsoId("_ucsmG_RYEeuLhpyIdtJzwg")]
    [Description(@"Remittance information cannot be modified.")]
    UnableToModifyRemittanceInformation,
    
    /// <summary>
    /// PaymentPurpose cannot be modified.
    /// Encoded/decoded by serializers as "UnableToModifyPaymentPurpose".
    /// </summary>
    [EnumMember(Value = "UM16")]
    [IsoId("_ucsmHvRYEeuLhpyIdtJzwg")]
    [Description(@"PaymentPurpose cannot be modified.")]
    UnableToModifyPaymentPurpose,
    
    /// <summary>
    /// Charge bearer cannot be modified (former UnableToModifyDetailsOfCharges).
    /// Encoded/decoded by serializers as "UnableToModifyChargeBearer".
    /// </summary>
    [EnumMember(Value = "UM17")]
    [IsoId("_uc2XEvRYEeuLhpyIdtJzwg")]
    [Description(@"Charge bearer cannot be modified (former UnableToModifyDetailsOfCharges).")]
    UnableToModifyChargeBearer,
    
    /// <summary>
    /// Instruction for next agent cannot be modified (former UnableToModifySenderToReceiver).
    /// Encoded/decoded by serializers as "UnableToModifyInstructionForNextAgent".
    /// </summary>
    [EnumMember(Value = "UM18")]
    [IsoId("_uc_hAvRYEeuLhpyIdtJzwg")]
    [Description(@"Instruction for next agent cannot be modified (former UnableToModifySenderToReceiver).")]
    UnableToModifyInstructionForNextAgent,
    
    /// <summary>
    /// Instruction for creditor agent cannot be modified. (former UnableToModifyInstructionForFinalAgent).
    /// Encoded/decoded by serializers as "UnableToModifyInstructionForCreditorAgent".
    /// </summary>
    [EnumMember(Value = "UM19")]
    [IsoId("_uc_hBfRYEeuLhpyIdtJzwg")]
    [Description(@"Instruction for creditor agent cannot be modified. (former UnableToModifyInstructionForFinalAgent).")]
    UnableToModifyInstructionForCreditorAgent,
    
    /// <summary>
    /// Used to inform of cancellation and request a new payment instruction. This should only be used if an agent does not want to modify a pending payment.
    /// Encoded/decoded by serializers as "InstructionCancelledSubmitNewInstruction".
    /// </summary>
    [EnumMember(Value = "UM20")]
    [IsoId("_udJSAvRYEeuLhpyIdtJzwg")]
    [Description(@"Used to inform of cancellation and request a new payment instruction. This should only be used if an agent does not want to modify a pending payment.")]
    InstructionCancelledSubmitNewInstruction,
    
    /// <summary>
    /// Modification is not possible and the cancellation is requested.
    /// Encoded/decoded by serializers as "UnableToModifySubmitCancellation".
    /// </summary>
    [EnumMember(Value = "UM21")]
    [IsoId("_udJSBfRYEeuLhpyIdtJzwg")]
    [Description(@"Modification is not possible and the cancellation is requested.")]
    UnableToModifySubmitCancellation,
    
    /// <summary>
    /// Debtor agent account cannot be modified (applicable for direct debits).
    /// Encoded/decoded by serializers as "UnableToModifyDebtorAgentAccount".
    /// </summary>
    [EnumMember(Value = "UM22")]
    [IsoId("_udJSCPRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor agent account cannot be modified (applicable for direct debits).")]
    UnableToModifyDebtorAgentAccount,
    
    /// <summary>
    /// Interbank settlement amount cannot be modified.
    /// Encoded/decoded by serializers as "UnableToModifyInterbankSettlementAmount".
    /// </summary>
    [EnumMember(Value = "UM23")]
    [IsoId("_udTDAvRYEeuLhpyIdtJzwg")]
    [Description(@"Interbank settlement amount cannot be modified.")]
    UnableToModifyInterbankSettlementAmount,
    
    /// <summary>
    /// Instruction for debtor agent cannot be modified (applicable for direct debits)
    /// Encoded/decoded by serializers as "UnableToModifyInstructionForDebtorAgent".
    /// </summary>
    [EnumMember(Value = "UM24")]
    [IsoId("_udTDBfRYEeuLhpyIdtJzwg")]
    [Description(@"Instruction for debtor agent cannot be modified (applicable for direct debits)")]
    UnableToModifyInstructionForDebtorAgent,
    
    /// <summary>
    /// Requested collection date cannot be modified (applicable for direct debits)
    /// Encoded/decoded by serializers as "UnableToModifyRequestedCollectionDate".
    /// </summary>
    [EnumMember(Value = "UM25")]
    [IsoId("_udcM8vRYEeuLhpyIdtJzwg")]
    [Description(@"Requested collection date cannot be modified (applicable for direct debits)")]
    UnableToModifyRequestedCollectionDate,
    
    /// <summary>
    /// Payment type cannot be modified.
    /// Encoded/decoded by serializers as "UnableToModifyPaymentType".
    /// </summary>
    [EnumMember(Value = "UM26")]
    [IsoId("_udcM9fRYEeuLhpyIdtJzwg")]
    [Description(@"Payment type cannot be modified.")]
    UnableToModifyPaymentType,
    
    /// <summary>
    /// Instructed or equivalent amount cannot be modified.
    /// Encoded/decoded by serializers as "UnableToModifyInstructedAmount".
    /// </summary>
    [EnumMember(Value = "UM27")]
    [IsoId("_udcM-PRYEeuLhpyIdtJzwg")]
    [Description(@"Instructed or equivalent amount cannot be modified.")]
    UnableToModifyInstructedAmount,
    
    /// <summary>
    /// Priority of payment message cannot be modified.
    /// Encoded/decoded by serializers as "UnableToModifyPriority".
    /// </summary>
    [EnumMember(Value = "UM28")]
    [IsoId("_udl98vRYEeuLhpyIdtJzwg")]
    [Description(@"Priority of payment message cannot be modified.")]
    UnableToModifyPriority,
    
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


