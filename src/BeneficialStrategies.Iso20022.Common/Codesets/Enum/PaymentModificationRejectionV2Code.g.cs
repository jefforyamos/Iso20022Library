﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PaymentModificationRejectionV2Code.  ISO2002 ID# _Z4u9sNp-Ed-ak6NoX_4Aeg_-2057540990.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for the reject of a modification request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z4u9sNp-Ed-ak6NoX_4Aeg_-2057540990")]
[Description(@"Specifies the reason for the reject of a modification request.")]
[Derivations(typeof(ModificationRejection2Code))]
// External derivations that should be provided by the proper interface are: 
public enum PaymentModificationRejectionV2Code
{
    /// <summary>
    /// Related transaction reference cannot be modified.
    /// Encoded/decoded by serializers as "UM01".
    /// </summary>
    [EnumMember(Value = "UM01")]
    [IsoId("_Z4u9sdp-Ed-ak6NoX_4Aeg_-1946716667")]
    [Description(@"Related transaction reference cannot be modified.")]
    UnableToModifyRelatedReference,
    
    /// <summary>
    /// Service level element of payment type cannot be modified(former UnableToModifyBankOperationCode).
    /// Encoded/decoded by serializers as "UM02".
    /// </summary>
    [EnumMember(Value = "UM02")]
    [IsoId("_Z4u9stp-Ed-ak6NoX_4Aeg_-1946716666")]
    [Description(@"Service level element of payment type cannot be modified(former UnableToModifyBankOperationCode).")]
    UnableToModifyPaymentServiceLevel,
    
    /// <summary>
    /// Category purpose element of payment type cannot be modified (former UnableToModifyInstructionCode).
    /// Encoded/decoded by serializers as "UM03".
    /// </summary>
    [EnumMember(Value = "UM03")]
    [IsoId("_Z4u9s9p-Ed-ak6NoX_4Aeg_-1946716636")]
    [Description(@"Category purpose element of payment type cannot be modified (former UnableToModifyInstructionCode).")]
    UnableToModifyCategoryPurpose,
    
    /// <summary>
    /// RequestedExecutionDate cannot be modified.
    /// Encoded/decoded by serializers as "UM04".
    /// </summary>
    [EnumMember(Value = "UM04")]
    [IsoId("_Z4u9tNp-Ed-ak6NoX_4Aeg_-1946716635")]
    [Description(@"RequestedExecutionDate cannot be modified.")]
    UnableToModifyRequestedExecutionDate,
    
    /// <summary>
    /// InterbankSettlementDate cannot be modified (former UnableToModifyValueDate).
    /// Encoded/decoded by serializers as "UM05".
    /// </summary>
    [EnumMember(Value = "UM05")]
    [IsoId("_Z4u9tdp-Ed-ak6NoX_4Aeg_-1946716606")]
    [Description(@"InterbankSettlementDate cannot be modified (former UnableToModifyValueDate).")]
    UnableToModifyInterbankSettlementDate,
    
    /// <summary>
    /// SettlementAccount cannot be modified (former UnableToModifyInterbankSettlementAccount).
    /// Encoded/decoded by serializers as "UM06".
    /// </summary>
    [EnumMember(Value = "UM06")]
    [IsoId("_Z4u9ttp-Ed-ak6NoX_4Aeg_-1946716575")]
    [Description(@"SettlementAccount cannot be modified (former UnableToModifyInterbankSettlementAccount).")]
    UnableToModifyInterbankSettlementAccount,
    
    /// <summary>
    /// Debtor cannot be modified.
    /// Encoded/decoded by serializers as "UM07".
    /// </summary>
    [EnumMember(Value = "UM07")]
    [IsoId("_Z4u9t9p-Ed-ak6NoX_4Aeg_-1946716574")]
    [Description(@"Debtor cannot be modified.")]
    UnableToModifyDebtor,
    
    /// <summary>
    /// DebtorAccount cannot be modified.
    /// Encoded/decoded by serializers as "UM08".
    /// </summary>
    [EnumMember(Value = "UM08")]
    [IsoId("_Z4u9uNp-Ed-ak6NoX_4Aeg_-1946716544")]
    [Description(@"DebtorAccount cannot be modified.")]
    UnableToModifyDebtorAccount,
    
    /// <summary>
    /// InstructedReimbursementAgent cannot be modified (former UnableToModifyReceiverCorrespondent).
    /// Encoded/decoded by serializers as "UM09".
    /// </summary>
    [EnumMember(Value = "UM09")]
    [IsoId("_Z4u9udp-Ed-ak6NoX_4Aeg_-1946716543")]
    [Description(@"InstructedReimbursementAgent cannot be modified (former UnableToModifyReceiverCorrespondent).")]
    UnableToModifyInstructedReimbursementAgent,
    
    /// <summary>
    /// ThirdReimbursementAgent cannot be modified (former UnableToModifyThirdReimbursementInstitution).
    /// Encoded/decoded by serializers as "UM10".
    /// </summary>
    [EnumMember(Value = "UM10")]
    [IsoId("_Z44usNp-Ed-ak6NoX_4Aeg_-1946716514")]
    [Description(@"ThirdReimbursementAgent cannot be modified (former UnableToModifyThirdReimbursementInstitution).")]
    UnableToModifyThirdReimbursementAgent,
    
    /// <summary>
    /// Clearing Channel element of payment type cannot be modified (former UnableToModifyPaymentScheme).
    /// Encoded/decoded by serializers as "UM11".
    /// </summary>
    [EnumMember(Value = "UM11")]
    [IsoId("_Z44usdp-Ed-ak6NoX_4Aeg_-1946716513")]
    [Description(@"Clearing Channel element of payment type cannot be modified (former UnableToModifyPaymentScheme).")]
    UnableToModifyPaymentClearingChannel,
    
    /// <summary>
    /// Creditor agent account cannot be modified (former UnableToModifyAccountOfBeneficiaryInstitution).
    /// Encoded/decoded by serializers as "UM12".
    /// </summary>
    [EnumMember(Value = "UM12")]
    [IsoId("_Z44ustp-Ed-ak6NoX_4Aeg_-1946716483")]
    [Description(@"Creditor agent account cannot be modified (former UnableToModifyAccountOfBeneficiaryInstitution).")]
    UnableToModifyCreditorAgentAccount,
    
    /// <summary>
    /// Creditor cannot be modified.
    /// Encoded/decoded by serializers as "UM13".
    /// </summary>
    [EnumMember(Value = "UM13")]
    [IsoId("_Z44us9p-Ed-ak6NoX_4Aeg_-1946716453")]
    [Description(@"Creditor cannot be modified.")]
    UnableToModifyCreditor,
    
    /// <summary>
    /// Creditor account cannot be modified.
    /// Encoded/decoded by serializers as "UM14".
    /// </summary>
    [EnumMember(Value = "UM14")]
    [IsoId("_Z44utNp-Ed-ak6NoX_4Aeg_-1946716452")]
    [Description(@"Creditor account cannot be modified.")]
    UnableToModifyCreditorAccount,
    
    /// <summary>
    /// Remittance information cannot be modified.
    /// Encoded/decoded by serializers as "UM15".
    /// </summary>
    [EnumMember(Value = "UM15")]
    [IsoId("_Z44utdp-Ed-ak6NoX_4Aeg_-1946716422")]
    [Description(@"Remittance information cannot be modified.")]
    UnableToModifyRemittanceInformation,
    
    /// <summary>
    /// PaymentPurpose cannot be modified.
    /// Encoded/decoded by serializers as "UM16".
    /// </summary>
    [EnumMember(Value = "UM16")]
    [IsoId("_Z44uttp-Ed-ak6NoX_4Aeg_-1946716421")]
    [Description(@"PaymentPurpose cannot be modified.")]
    UnableToModifyPaymentPurpose,
    
    /// <summary>
    /// Charge bearer cannot be modified (former UnableToModifyDetailsOfCharges).
    /// Encoded/decoded by serializers as "UM17".
    /// </summary>
    [EnumMember(Value = "UM17")]
    [IsoId("_Z44ut9p-Ed-ak6NoX_4Aeg_-1946716144")]
    [Description(@"Charge bearer cannot be modified (former UnableToModifyDetailsOfCharges).")]
    UnableToModifyChargeBearer,
    
    /// <summary>
    /// Instruction for next agent cannot be modified (former UnableToModifySenderToReceiver).
    /// Encoded/decoded by serializers as "UM18".
    /// </summary>
    [EnumMember(Value = "UM18")]
    [IsoId("_Z44uuNp-Ed-ak6NoX_4Aeg_-1946716143")]
    [Description(@"Instruction for next agent cannot be modified (former UnableToModifySenderToReceiver).")]
    UnableToModifyInstructionForNextAgent,
    
    /// <summary>
    /// Instruction for creditor agent cannot be modified. (former UnableToModifyInstructionForFinalAgent).
    /// Encoded/decoded by serializers as "UM19".
    /// </summary>
    [EnumMember(Value = "UM19")]
    [IsoId("_Z44uudp-Ed-ak6NoX_4Aeg_-1946716113")]
    [Description(@"Instruction for creditor agent cannot be modified. (former UnableToModifyInstructionForFinalAgent).")]
    UnableToModifyInstructionForCreditorAgent,
    
    /// <summary>
    /// Used to inform of cancellation and request a new payment instruction. This should only be used if an agent does not want to modify a pending payment.
    /// Encoded/decoded by serializers as "UM20".
    /// </summary>
    [EnumMember(Value = "UM20")]
    [IsoId("_Z5CfsNp-Ed-ak6NoX_4Aeg_-1946716082")]
    [Description(@"Used to inform of cancellation and request a new payment instruction. This should only be used if an agent does not want to modify a pending payment.")]
    InstructionCancelledSubmitNewInstruction,
    
    /// <summary>
    /// Modification is not possible and the cancellation is requested.
    /// Encoded/decoded by serializers as "UM21".
    /// </summary>
    [EnumMember(Value = "UM21")]
    [IsoId("_Z5Cfsdp-Ed-ak6NoX_4Aeg_-1946716081")]
    [Description(@"Modification is not possible and the cancellation is requested.")]
    UnableToModifySubmitCancellation,
    
    /// <summary>
    /// Debtor agent account cannot be modified (applicable for direct debits).
    /// Encoded/decoded by serializers as "UM22".
    /// </summary>
    [EnumMember(Value = "UM22")]
    [IsoId("_Z5Cfstp-Ed-ak6NoX_4Aeg_-666012404")]
    [Description(@"Debtor agent account cannot be modified (applicable for direct debits).")]
    UnableToModifyDebtorAgentAccount,
    
    /// <summary>
    /// Interbank settlement amount cannot be modified.
    /// Encoded/decoded by serializers as "UM23".
    /// </summary>
    [EnumMember(Value = "UM23")]
    [IsoId("_Z5Cfs9p-Ed-ak6NoX_4Aeg_-606907289")]
    [Description(@"Interbank settlement amount cannot be modified.")]
    UnableToModifyInterbankSettlementAmount,
    
    /// <summary>
    /// Instruction for debtor agent cannot be modified (applicable for direct debits).
    /// Encoded/decoded by serializers as "UM24".
    /// </summary>
    [EnumMember(Value = "UM24")]
    [IsoId("_Z5CftNp-Ed-ak6NoX_4Aeg_46948941")]
    [Description(@"Instruction for debtor agent cannot be modified (applicable for direct debits).")]
    UnableToModifyInstructionForDebtorAgent,
    
    /// <summary>
    /// Requested collection date cannot be modified (applicable for direct debits).
    /// Encoded/decoded by serializers as "UM25".
    /// </summary>
    [EnumMember(Value = "UM25")]
    [IsoId("_Z5Cftdp-Ed-ak6NoX_4Aeg_1249104693")]
    [Description(@"Requested collection date cannot be modified (applicable for direct debits).")]
    UnableToModifyRequestedCollectionDate,
    
    /// <summary>
    /// Payment type cannot be modified.
    /// Encoded/decoded by serializers as "UM26".
    /// </summary>
    [EnumMember(Value = "UM26")]
    [IsoId("_Z5Cfttp-Ed-ak6NoX_4Aeg_1695166859")]
    [Description(@"Payment type cannot be modified.")]
    UnableToModifyPaymentType,
    
    /// <summary>
    /// Instructed or equivalent amount cannot be modified.
    /// Encoded/decoded by serializers as "UM27".
    /// </summary>
    [EnumMember(Value = "UM27")]
    [IsoId("_Z5Cft9p-Ed-ak6NoX_4Aeg_1761659391")]
    [Description(@"Instructed or equivalent amount cannot be modified.")]
    UnableToModifyInstructedAmount,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PaymentModificationRejectionV2CodeMetadataExtensions
{
    private static readonly PaymentModificationRejectionV2CodeDropdownSource _dropdownSource = new PaymentModificationRejectionV2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPaymentModificationRejectionV2CodeDropdownRow GetMetadata(this PaymentModificationRejectionV2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


