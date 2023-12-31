﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalUnableToApplyIncorrectData1Code.  ISO2002 ID# _p-vHiN4jEeqt1ZcLzWyWFw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason of an unable to apply due to incorrect data, as published in an external unable to apply incorrect data code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_p-vHiN4jEeqt1ZcLzWyWFw")]
[Description(@"Specifies the reason of an unable to apply due to incorrect data, as published in an external unable to apply incorrect data code set. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalUnableToApplyIncorrectDataCode))]
public enum ExternalUnableToApplyIncorrectData1Code
{
    /// <summary>
    /// Related transaction reference is incorrect.
    /// Encoded/decoded by serializers as "IncorrectRelatedReference".
    /// </summary>
    [EnumMember(Value = "IN01")]
    [IsoId("_uxjbxfRYEeuLhpyIdtJzwg")]
    [Description(@"Related transaction reference is incorrect.")]
    IncorrectRelatedReference,
    
    /// <summary>
    /// Payment type service level is incorrect (former IncorrectBankOperationCode).
    /// Encoded/decoded by serializers as "IncorrectPaymentServiceLevel".
    /// </summary>
    [EnumMember(Value = "IN02")]
    [IsoId("_uxjbyPRYEeuLhpyIdtJzwg")]
    [Description(@"Payment type service level is incorrect (former IncorrectBankOperationCode).")]
    IncorrectPaymentServiceLevel,
    
    /// <summary>
    /// Payment type category purpose is incorrect (former IncorrectInstructionCode).
    /// Encoded/decoded by serializers as "IncorrectCategoryPurpose".
    /// </summary>
    [EnumMember(Value = "IN03")]
    [IsoId("_uxjby_RYEeuLhpyIdtJzwg")]
    [Description(@"Payment type category purpose is incorrect (former IncorrectInstructionCode).")]
    IncorrectCategoryPurpose,
    
    /// <summary>
    /// RequestedExecutionDate is incorrect.
    /// Encoded/decoded by serializers as "IncorrectRequestedExecutionDate".
    /// </summary>
    [EnumMember(Value = "IN04")]
    [IsoId("_uxtMwvRYEeuLhpyIdtJzwg")]
    [Description(@"RequestedExecutionDate is incorrect.")]
    IncorrectRequestedExecutionDate,
    
    /// <summary>
    /// Interbank settlement date is incorrect (former IncorrectValueDate).
    /// Encoded/decoded by serializers as "IncorrectInterbankSettlementDate".
    /// </summary>
    [EnumMember(Value = "IN05")]
    [IsoId("_uxtMxfRYEeuLhpyIdtJzwg")]
    [Description(@"Interbank settlement date is incorrect (former IncorrectValueDate).")]
    IncorrectInterbankSettlementDate,
    
    /// <summary>
    /// Interbank settlement amount is incorrect (former IncorrectSettledAmount).
    /// Encoded/decoded by serializers as "IncorrectInterbankSettlementAmount".
    /// </summary>
    [EnumMember(Value = "IN06")]
    [IsoId("_uxtMyPRYEeuLhpyIdtJzwg")]
    [Description(@"Interbank settlement amount is incorrect (former IncorrectSettledAmount).")]
    IncorrectInterbankSettlementAmount,
    
    /// <summary>
    /// Debtor is incorrect.
    /// Encoded/decoded by serializers as "IncorrectDebtor".
    /// </summary>
    [EnumMember(Value = "IN07")]
    [IsoId("_ux29wvRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor is incorrect.")]
    IncorrectDebtor,
    
    /// <summary>
    /// DebtorAccount is incorrect.
    /// Encoded/decoded by serializers as "IncorrectDebtorAccount".
    /// </summary>
    [EnumMember(Value = "IN08")]
    [IsoId("_ux29xfRYEeuLhpyIdtJzwg")]
    [Description(@"DebtorAccount is incorrect.")]
    IncorrectDebtorAccount,
    
    /// <summary>
    /// InstructedReimbursementAgent is incorrect (former IncorrectReceiverCorrespondent).
    /// Encoded/decoded by serializers as "IncorrectInstructedReimbursementAgent".
    /// </summary>
    [EnumMember(Value = "IN09")]
    [IsoId("_ux29yPRYEeuLhpyIdtJzwg")]
    [Description(@"InstructedReimbursementAgent is incorrect (former IncorrectReceiverCorrespondent).")]
    IncorrectInstructedReimbursementAgent,
    
    /// <summary>
    /// ThirdReimbursementAgent is incorrect (former IncorrectThirdReimbursementInstitution).
    /// Encoded/decoded by serializers as "IncorrectThirdReimbursementAgent".
    /// </summary>
    [EnumMember(Value = "IN10")]
    [IsoId("_uyAHsvRYEeuLhpyIdtJzwg")]
    [Description(@"ThirdReimbursementAgent is incorrect (former IncorrectThirdReimbursementInstitution).")]
    IncorrectThirdReimbursementAgent,
    
    /// <summary>
    /// Payment type clearing channel is incorrect (former PaymentScheme).
    /// Encoded/decoded by serializers as "IncorrectPaymentClearingChannel".
    /// </summary>
    [EnumMember(Value = "IN11")]
    [IsoId("_uyAHtfRYEeuLhpyIdtJzwg")]
    [Description(@"Payment type clearing channel is incorrect (former PaymentScheme).")]
    IncorrectPaymentClearingChannel,
    
    /// <summary>
    /// CreditorAgentAccount is incorrect (former IncorrectAccountOfBeneficiaryInstitution).
    /// Encoded/decoded by serializers as "IncorrectCreditorAgentAccount".
    /// </summary>
    [EnumMember(Value = "IN12")]
    [IsoId("_uyAHuPRYEeuLhpyIdtJzwg")]
    [Description(@"CreditorAgentAccount is incorrect (former IncorrectAccountOfBeneficiaryInstitution).")]
    IncorrectCreditorAgentAccount,
    
    /// <summary>
    /// Creditor is incorrect.
    /// Encoded/decoded by serializers as "IncorrectCreditor".
    /// </summary>
    [EnumMember(Value = "IN13")]
    [IsoId("_uyJ4svRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor is incorrect.")]
    IncorrectCreditor,
    
    /// <summary>
    /// Creditor account is incorrect.
    /// Encoded/decoded by serializers as "IncorrectCreditorAccount".
    /// </summary>
    [EnumMember(Value = "IN14")]
    [IsoId("_uyJ4tfRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor account is incorrect.")]
    IncorrectCreditorAccount,
    
    /// <summary>
    /// RemittanceInformation is incorrect.
    /// Encoded/decoded by serializers as "IncorrectRemittanceInformation".
    /// </summary>
    [EnumMember(Value = "IN15")]
    [IsoId("_uyTpsvRYEeuLhpyIdtJzwg")]
    [Description(@"RemittanceInformation is incorrect.")]
    IncorrectRemittanceInformation,
    
    /// <summary>
    /// Transaction payment purpose is incorrect.
    /// Encoded/decoded by serializers as "IncorrectPaymentPurpose".
    /// </summary>
    [EnumMember(Value = "IN16")]
    [IsoId("_uyTptfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction payment purpose is incorrect.")]
    IncorrectPaymentPurpose,
    
    /// <summary>
    /// ChargeBearer is incorrect (former IncorrectDetailsOfCharges).
    /// Encoded/decoded by serializers as "IncorrectChargeBearer".
    /// </summary>
    [EnumMember(Value = "IN17")]
    [IsoId("_uyTpuPRYEeuLhpyIdtJzwg")]
    [Description(@"ChargeBearer is incorrect (former IncorrectDetailsOfCharges).")]
    IncorrectChargeBearer,
    
    /// <summary>
    /// Instruction for next agent is incorrect (former IncorrectSenderToReceiverInformation).
    /// Encoded/decoded by serializers as "IncorrectInstructionForNextAgent".
    /// </summary>
    [EnumMember(Value = "IN18")]
    [IsoId("_uyTpu_RYEeuLhpyIdtJzwg")]
    [Description(@"Instruction for next agent is incorrect (former IncorrectSenderToReceiverInformation).")]
    IncorrectInstructionForNextAgent,
    
    /// <summary>
    /// Instruction for creditor agent is incorrect (former IncorrectInstructionForFinalAgent).
    /// Encoded/decoded by serializers as "IncorrectInstructionForCreditorAgent".
    /// </summary>
    [EnumMember(Value = "IN19")]
    [IsoId("_uydasvRYEeuLhpyIdtJzwg")]
    [Description(@"Instruction for creditor agent is incorrect (former IncorrectInstructionForFinalAgent).")]
    IncorrectInstructionForCreditorAgent,
    
    /// <summary>
    /// Amount in statement entry is incorrect.
    /// Encoded/decoded by serializers as "IncorrectReportEntryAmount".
    /// </summary>
    [EnumMember(Value = "IN33")]
    [IsoId("_uymkovRYEeuLhpyIdtJzwg")]
    [Description(@"Amount in statement entry is incorrect.")]
    IncorrectReportEntryAmount,
    
    /// <summary>
    /// SettlementAccount is incorrect.
    /// Encoded/decoded by serializers as "IncorrectSettlementAccount".
    /// </summary>
    [EnumMember(Value = "IN36")]
    [IsoId("_uymkpfRYEeuLhpyIdtJzwg")]
    [Description(@"SettlementAccount is incorrect.")]
    IncorrectSettlementAccount,
    
    /// <summary>
    /// Instructing reimbursement agent is incorrect.
    /// Encoded/decoded by serializers as "IncorrectInstructingReimbursementAgent".
    /// </summary>
    [EnumMember(Value = "IN37")]
    [IsoId("_uywVovRYEeuLhpyIdtJzwg")]
    [Description(@"Instructing reimbursement agent is incorrect.")]
    IncorrectInstructingReimbursementAgent,
    
    /// <summary>
    /// Debtor's address is incorrect.
    /// Encoded/decoded by serializers as "IncorrectDebtorAddress".
    /// </summary>
    [EnumMember(Value = "IN38")]
    [IsoId("_uywVpfRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor's address is incorrect.")]
    IncorrectDebtorAddress,
    
    /// <summary>
    /// Creditor's address is incorrect.
    /// Encoded/decoded by serializers as "IncorrectCreditorAddress".
    /// </summary>
    [EnumMember(Value = "IN39")]
    [IsoId("_uywVqPRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor's address is incorrect.")]
    IncorrectCreditorAddress,
    
    /// <summary>
    /// RelatedRemittanceInformation is incorrect.
    /// Encoded/decoded by serializers as "IncorrectRelatedRemittanceInformation".
    /// </summary>
    [EnumMember(Value = "IN40")]
    [IsoId("_uywVq_RYEeuLhpyIdtJzwg")]
    [Description(@"RelatedRemittanceInformation is incorrect.")]
    IncorrectRelatedRemittanceInformation,
    
    /// <summary>
    /// Name and account of creditor are not matching.
    /// Encoded/decoded by serializers as "MismatchCreditorNameAccount".
    /// </summary>
    [EnumMember(Value = "MM20")]
    [IsoId("_uy5fkvRYEeuLhpyIdtJzwg")]
    [Description(@"Name and account of creditor are not matching.")]
    MismatchCreditorNameAccount,
    
    /// <summary>
    /// Name and account of debtor are not matching.
    /// Encoded/decoded by serializers as "MismatchDebtorNameAccount".
    /// </summary>
    [EnumMember(Value = "MM21")]
    [IsoId("_uy5flfRYEeuLhpyIdtJzwg")]
    [Description(@"Name and account of debtor are not matching.")]
    MismatchDebtorNameAccount,
    
    /// <summary>
    /// Name and account of creditor agent (former FinalAgent) are not matching.
    /// Encoded/decoded by serializers as "MismatchCreditorAgentNameAccount".
    /// </summary>
    [EnumMember(Value = "MM22")]
    [IsoId("_uy5fmPRYEeuLhpyIdtJzwg")]
    [Description(@"Name and account of creditor agent (former FinalAgent) are not matching.")]
    MismatchCreditorAgentNameAccount,
    
    /// <summary>
    /// Insufficient or incoherent details about the debtor with respect to regulatory requirements.
    /// Encoded/decoded by serializers as "InsufficientDebtorDetails".
    /// </summary>
    [EnumMember(Value = "MM23")]
    [IsoId("_uy5fm_RYEeuLhpyIdtJzwg")]
    [Description(@"Insufficient or incoherent details about the debtor with respect to regulatory requirements.")]
    InsufficientDebtorDetails,
    
    /// <summary>
    /// Insufficient or incoherent details about the creditor with respect to regulatory requirements.
    /// Encoded/decoded by serializers as "InsufficientCreditorDetails".
    /// </summary>
    [EnumMember(Value = "MM24")]
    [IsoId("_uzDQkvRYEeuLhpyIdtJzwg")]
    [Description(@"Insufficient or incoherent details about the creditor with respect to regulatory requirements.")]
    InsufficientCreditorDetails,
    
    /// <summary>
    /// Payment is pending execution. For reasons of regulatory requirements we request further information on the account number or unique identification of the debtor.
    /// Encoded/decoded by serializers as "PendingExecutionDebtorAccountOrIdentification".
    /// </summary>
    [EnumMember(Value = "MM25")]
    [IsoId("_uzDQlfRYEeuLhpyIdtJzwg")]
    [Description(@"Payment is pending execution. For reasons of regulatory requirements we request further information on the account number or unique identification of the debtor.")]
    PendingExecutionDebtorAccountOrIdentification,
    
    /// <summary>
    /// Payment is pending execution. For reasons of regulatory requirements we request further information on the name and/or address of the debtor.
    /// Encoded/decoded by serializers as "PendingExecutionDebtorNameOrAddress".
    /// </summary>
    [EnumMember(Value = "MM26")]
    [IsoId("_uzDQmPRYEeuLhpyIdtJzwg")]
    [Description(@"Payment is pending execution. For reasons of regulatory requirements we request further information on the name and/or address of the debtor.")]
    PendingExecutionDebtorNameOrAddress,
    
    /// <summary>
    /// Payment has been executed. For reasons of regulatory requirements we request further information on the account number or unique identification of the debtor.
    /// Encoded/decoded by serializers as "PaymentExecutedDebtorAccountOrIdentification".
    /// </summary>
    [EnumMember(Value = "MM27")]
    [IsoId("_uzDQm_RYEeuLhpyIdtJzwg")]
    [Description(@"Payment has been executed. For reasons of regulatory requirements we request further information on the account number or unique identification of the debtor.")]
    PaymentExecutedDebtorAccountOrIdentification,
    
    /// <summary>
    /// Payment has been executed. For reasons of regulatory requirements we request further information on the name and/or address of the debtor.
    /// Encoded/decoded by serializers as "PaymentExecutedDebtorNameOrAddress".
    /// </summary>
    [EnumMember(Value = "MM28")]
    [IsoId("_uzNBkvRYEeuLhpyIdtJzwg")]
    [Description(@"Payment has been executed. For reasons of regulatory requirements we request further information on the name and/or address of the debtor.")]
    PaymentExecutedDebtorNameOrAddress,
    
    /// <summary>
    /// Payment is pending execution. For reasons of regulatory requirements we request further information on the account number or unique identification of the creditor.
    /// Encoded/decoded by serializers as "PendingExecutionCreditorAccountOrIdentification".
    /// </summary>
    [EnumMember(Value = "MM29")]
    [IsoId("_uzNBlfRYEeuLhpyIdtJzwg")]
    [Description(@"Payment is pending execution. For reasons of regulatory requirements we request further information on the account number or unique identification of the creditor.")]
    PendingExecutionCreditorAccountOrIdentification,
    
    /// <summary>
    /// Payment is pending execution. For reasons of regulatory requirements we request further information on the name and/or address of the creditor.
    /// Encoded/decoded by serializers as "PendingExecutionCreditorNameOrAddress".
    /// </summary>
    [EnumMember(Value = "MM30")]
    [IsoId("_uzNBmPRYEeuLhpyIdtJzwg")]
    [Description(@"Payment is pending execution. For reasons of regulatory requirements we request further information on the name and/or address of the creditor.")]
    PendingExecutionCreditorNameOrAddress,
    
    /// <summary>
    /// Payment has been executed. For reasons of regulatory requirements we request further information on the account number or unique identification of the creditor.
    /// Encoded/decoded by serializers as "PaymentExecutedCreditorAccountOrIdentification".
    /// </summary>
    [EnumMember(Value = "MM31")]
    [IsoId("_uzNBm_RYEeuLhpyIdtJzwg")]
    [Description(@"Payment has been executed. For reasons of regulatory requirements we request further information on the account number or unique identification of the creditor.")]
    PaymentExecutedCreditorAccountOrIdentification,
    
    /// <summary>
    /// Payment has been executed. For reasons of regulatory requirements we request further information on the name and/or address of the creditor.
    /// Encoded/decoded by serializers as "PaymentExecutedCreditorNameOrAddress".
    /// </summary>
    [EnumMember(Value = "MM32")]
    [IsoId("_uzNBnvRYEeuLhpyIdtJzwg")]
    [Description(@"Payment has been executed. For reasons of regulatory requirements we request further information on the name and/or address of the creditor.")]
    PaymentExecutedCreditorNameOrAddress,
    
    /// <summary>
    /// Insufficient charges details provided.
    /// Encoded/decoded by serializers as "InsufficientChargesDetails".
    /// </summary>
    [EnumMember(Value = "MM34")]
    [IsoId("_uzWLgvRYEeuLhpyIdtJzwg")]
    [Description(@"Insufficient charges details provided.")]
    InsufficientChargesDetails,
    
    /// <summary>
    /// Payment purpose needs to be further specified.
    /// Encoded/decoded by serializers as "InsufficientPaymentPurpose".
    /// </summary>
    [EnumMember(Value = "MM35")]
    [IsoId("_uzWLhfRYEeuLhpyIdtJzwg")]
    [Description(@"Payment purpose needs to be further specified.")]
    InsufficientPaymentPurpose,
    
    /// <summary>
    /// See narrative field for additional information.
    /// Encoded/decoded by serializers as "Narrative".
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_uzf8gvRYEeuLhpyIdtJzwg")]
    [Description(@"See narrative field for additional information.")]
    Narrative,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalUnableToApplyIncorrectData1CodeMetadataExtensions
{
    private static readonly ExternalUnableToApplyIncorrectData1CodeDropdownSource _dropdownSource = new ExternalUnableToApplyIncorrectData1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalUnableToApplyIncorrectData1CodeDropdownRow GetMetadata(this ExternalUnableToApplyIncorrectData1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


