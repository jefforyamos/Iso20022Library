﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PaymentModificationRejection1Code.  ISO2002 ID# _Z0uAZ9p-Ed-ak6NoX_4Aeg_-1179991966.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the reason for rejecting a modification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z0uAZ9p-Ed-ak6NoX_4Aeg_-1179991966")]
[Description(@"Indicates the reason for rejecting a modification.")]
public enum PaymentModificationRejection1Code
{
    /// <summary>
    /// RelatedReference cannot be modified.
    /// Encoded/decoded by serializers as "UM01".
    /// </summary>
    [EnumMember(Value = "UM01")]
    [IsoId("_Z0uAaNp-Ed-ak6NoX_4Aeg_-844026403")]
    [Description(@"RelatedReference cannot be modified.")]
    UnableToModifyRelatedReference,
    
    /// <summary>
    /// BankOperationCode cannot be modified.
    /// Encoded/decoded by serializers as "UM02".
    /// </summary>
    [EnumMember(Value = "UM02")]
    [IsoId("_Z03KUNp-Ed-ak6NoX_4Aeg_-735050957")]
    [Description(@"BankOperationCode cannot be modified.")]
    UnableToModifyBankOperationCode,
    
    /// <summary>
    /// InstructionCode cannot be modified.
    /// Encoded/decoded by serializers as "UM03".
    /// </summary>
    [EnumMember(Value = "UM03")]
    [IsoId("_Z03KUdp-Ed-ak6NoX_4Aeg_-745208311")]
    [Description(@"InstructionCode cannot be modified.")]
    UnableToModifyInstructionCode,
    
    /// <summary>
    /// RequestedExecutionDate cannot be modified.
    /// Encoded/decoded by serializers as "UM04".
    /// </summary>
    [EnumMember(Value = "UM04")]
    [IsoId("_Z03KUtp-Ed-ak6NoX_4Aeg_-748903849")]
    [Description(@"RequestedExecutionDate cannot be modified.")]
    UnableToModifyRequestedExecutionDate,
    
    /// <summary>
    /// ValueDate cannot be modified.
    /// Encoded/decoded by serializers as "UM05".
    /// </summary>
    [EnumMember(Value = "UM05")]
    [IsoId("_Z03KU9p-Ed-ak6NoX_4Aeg_-758138656")]
    [Description(@"ValueDate cannot be modified.")]
    UnableToModifyValueDate,
    
    /// <summary>
    /// InterbankSettlementAccount cannot be modified.
    /// Encoded/decoded by serializers as "UM06".
    /// </summary>
    [EnumMember(Value = "UM06")]
    [IsoId("_Z03KVNp-Ed-ak6NoX_4Aeg_-762755580")]
    [Description(@"InterbankSettlementAccount cannot be modified.")]
    UnableToModifyInterbankSettlementAccount,
    
    /// <summary>
    /// Debtor cannot be modified.
    /// Encoded/decoded by serializers as "UM07".
    /// </summary>
    [EnumMember(Value = "UM07")]
    [IsoId("_Z03KVdp-Ed-ak6NoX_4Aeg_-1121809587")]
    [Description(@"Debtor cannot be modified.")]
    UnableToModifyDebtor,
    
    /// <summary>
    /// DebtorAccount cannot be modified.
    /// Encoded/decoded by serializers as "UM08".
    /// </summary>
    [EnumMember(Value = "UM08")]
    [IsoId("_Z03KVtp-Ed-ak6NoX_4Aeg_-793959245")]
    [Description(@"DebtorAccount cannot be modified.")]
    UnableToModifyDebtorAccount,
    
    /// <summary>
    /// ReceiverCorrespondent cannot be modified.
    /// Encoded/decoded by serializers as "UM09".
    /// </summary>
    [EnumMember(Value = "UM09")]
    [IsoId("_Z03KV9p-Ed-ak6NoX_4Aeg_-684062681")]
    [Description(@"ReceiverCorrespondent cannot be modified.")]
    UnableToModifyReceiverCorrespondent,
    
    /// <summary>
    /// ThirdReimbursementInstitution cannot be modified.
    /// Encoded/decoded by serializers as "UM10".
    /// </summary>
    [EnumMember(Value = "UM10")]
    [IsoId("_Z03KWNp-Ed-ak6NoX_4Aeg_-609256607")]
    [Description(@"ThirdReimbursementInstitution cannot be modified.")]
    UnableToModifyThirdReimbursementInstitution,
    
    /// <summary>
    /// PaymentScheme cannot be modified.
    /// Encoded/decoded by serializers as "UM11".
    /// </summary>
    [EnumMember(Value = "UM11")]
    [IsoId("_Z03KWdp-Ed-ak6NoX_4Aeg_-335894272")]
    [Description(@"PaymentScheme cannot be modified.")]
    UnableToModifyPaymentScheme,
    
    /// <summary>
    /// AccountOfBeneficiaryInstitution cannot be modified.
    /// Encoded/decoded by serializers as "UM12".
    /// </summary>
    [EnumMember(Value = "UM12")]
    [IsoId("_Z03KWtp-Ed-ak6NoX_4Aeg_-294335314")]
    [Description(@"AccountOfBeneficiaryInstitution cannot be modified.")]
    UnableToModifyAccountofBeneficiaryInstitution,
    
    /// <summary>
    /// Creditor cannot be modified.
    /// Encoded/decoded by serializers as "UM13".
    /// </summary>
    [EnumMember(Value = "UM13")]
    [IsoId("_Z1A7UNp-Ed-ak6NoX_4Aeg_5810825")]
    [Description(@"Creditor cannot be modified.")]
    UnableToModifyCreditor,
    
    /// <summary>
    /// CreditorAccount cannot be modified.
    /// Encoded/decoded by serializers as "UM14".
    /// </summary>
    [EnumMember(Value = "UM14")]
    [IsoId("_Z1A7Udp-Ed-ak6NoX_4Aeg_62142413")]
    [Description(@"CreditorAccount cannot be modified.")]
    UnableToModifyCreditorAccount,
    
    /// <summary>
    /// RemittanceInformation cannot be modified.
    /// Encoded/decoded by serializers as "UM15".
    /// </summary>
    [EnumMember(Value = "UM15")]
    [IsoId("_Z1A7Utp-Ed-ak6NoX_4Aeg_121249964")]
    [Description(@"RemittanceInformation cannot be modified.")]
    UnableToModifyRemittanceInformation,
    
    /// <summary>
    /// PaymentPurpose cannot be modified.
    /// Encoded/decoded by serializers as "UM16".
    /// </summary>
    [EnumMember(Value = "UM16")]
    [IsoId("_Z1A7U9p-Ed-ak6NoX_4Aeg_208060668")]
    [Description(@"PaymentPurpose cannot be modified.")]
    UnableToModifyPaymentPurpose,
    
    /// <summary>
    /// DetailsOfCharges cannot be modified.
    /// Encoded/decoded by serializers as "UM17".
    /// </summary>
    [EnumMember(Value = "UM17")]
    [IsoId("_Z1A7VNp-Ed-ak6NoX_4Aeg_247772941")]
    [Description(@"DetailsOfCharges cannot be modified.")]
    UnableToModifyDetailsOfCharges,
    
    /// <summary>
    /// SenderToReceiver cannot be modified.
    /// Encoded/decoded by serializers as "UM18".
    /// </summary>
    [EnumMember(Value = "UM18")]
    [IsoId("_Z1A7Vdp-Ed-ak6NoX_4Aeg_494350274")]
    [Description(@"SenderToReceiver cannot be modified.")]
    UnableToModifySenderToReceiverInformation,
    
    /// <summary>
    /// InstructionForFinalAgent cannot be modified.
    /// Encoded/decoded by serializers as "UM19".
    /// </summary>
    [EnumMember(Value = "UM19")]
    [IsoId("_Z1A7Vtp-Ed-ak6NoX_4Aeg_565463309")]
    [Description(@"InstructionForFinalAgent cannot be modified.")]
    UnableToModifyInstructionForFinalAgent,
    
    /// <summary>
    /// Used to inform of cancellation and request a new payment instruction. This should only be used if an agent does not want to modify a pending payment.
    /// Encoded/decoded by serializers as "UM20".
    /// </summary>
    [EnumMember(Value = "UM20")]
    [IsoId("_Z1A7V9p-Ed-ak6NoX_4Aeg_608870103")]
    [Description(@"Used to inform of cancellation and request a new payment instruction. This should only be used if an agent does not want to modify a pending payment.")]
    InstructionCancelledSubmitNewInstruction,
    
    /// <summary>
    /// Modification is not possible and the cancellation is requested.
    /// Encoded/decoded by serializers as "UM21".
    /// </summary>
    [EnumMember(Value = "UM21")]
    [IsoId("_Z4lzwNp-Ed-ak6NoX_4Aeg_-1330652258")]
    [Description(@"Modification is not possible and the cancellation is requested.")]
    UnableToModifySubmitCancellation,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PaymentModificationRejection1CodeMetadataExtensions
{
    private static readonly PaymentModificationRejection1CodeDropdownSource _dropdownSource = new PaymentModificationRejection1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPaymentModificationRejection1CodeDropdownRow GetMetadata(this PaymentModificationRejection1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


