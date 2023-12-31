﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalUnableToApplyIncorrectDataCode.  ISO2002 ID# _p-vHSt4jEeqt1ZcLzWyWFw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason of an unable to apply due to incorrect data, as published in an external unable to apply incorrect data code set.
/// External code sets can be downloaded from www.iso20022.org.
/// 
/// </summary>
[DataContract]
[Serializable]
[IsoId("_p-vHSt4jEeqt1ZcLzWyWFw")]
[Description(@"Specifies the reason of an unable to apply due to incorrect data, as published in an external unable to apply incorrect data code set. External code sets can be downloaded from www.iso20022.org. ")]
[Derivations(typeof(ExternalUnableToApplyIncorrectData1Code))]
// External derivations that should be provided by the proper interface are: 
public enum ExternalUnableToApplyIncorrectDataCode
{
    /// <summary>
    /// Related transaction reference is incorrect.
    /// Encoded/decoded by serializers as "IN01".
    /// </summary>
    [EnumMember(Value = "IN01")]
    [IsoId("_p-vHYN4jEeqt1ZcLzWyWFw")]
    [Description(@"Related transaction reference is incorrect.")]
    IncorrectRelatedReference,
    
    /// <summary>
    /// Payment type service level is incorrect (former IncorrectBankOperationCode).
    /// Encoded/decoded by serializers as "IN02".
    /// </summary>
    [EnumMember(Value = "IN02")]
    [IsoId("_p-vHad4jEeqt1ZcLzWyWFw")]
    [Description(@"Payment type service level is incorrect (former IncorrectBankOperationCode).")]
    IncorrectPaymentServiceLevel,
    
    /// <summary>
    /// Payment type category purpose is incorrect (former IncorrectInstructionCode).
    /// Encoded/decoded by serializers as "IN03".
    /// </summary>
    [EnumMember(Value = "IN03")]
    [IsoId("_p-vHcd4jEeqt1ZcLzWyWFw")]
    [Description(@"Payment type category purpose is incorrect (former IncorrectInstructionCode).")]
    IncorrectCategoryPurpose,
    
    /// <summary>
    /// RequestedExecutionDate is incorrect.
    /// Encoded/decoded by serializers as "IN04".
    /// </summary>
    [EnumMember(Value = "IN04")]
    [IsoId("_p-vHXd4jEeqt1ZcLzWyWFw")]
    [Description(@"RequestedExecutionDate is incorrect.")]
    IncorrectRequestedExecutionDate,
    
    /// <summary>
    /// Interbank settlement date is incorrect (former IncorrectValueDate).
    /// Encoded/decoded by serializers as "IN05".
    /// </summary>
    [EnumMember(Value = "IN05")]
    [IsoId("_p-vHbN4jEeqt1ZcLzWyWFw")]
    [Description(@"Interbank settlement date is incorrect (former IncorrectValueDate).")]
    IncorrectInterbankSettlementDate,
    
    /// <summary>
    /// Interbank settlement amount is incorrect (former IncorrectSettledAmount).
    /// Encoded/decoded by serializers as "IN06".
    /// </summary>
    [EnumMember(Value = "IN06")]
    [IsoId("_p-vHU94jEeqt1ZcLzWyWFw")]
    [Description(@"Interbank settlement amount is incorrect (former IncorrectSettledAmount).")]
    IncorrectInterbankSettlementAmount,
    
    /// <summary>
    /// Debtor is incorrect.
    /// Encoded/decoded by serializers as "IN07".
    /// </summary>
    [EnumMember(Value = "IN07")]
    [IsoId("_p-vHZt4jEeqt1ZcLzWyWFw")]
    [Description(@"Debtor is incorrect.")]
    IncorrectDebtor,
    
    /// <summary>
    /// DebtorAccount is incorrect.
    /// Encoded/decoded by serializers as "IN08".
    /// </summary>
    [EnumMember(Value = "IN08")]
    [IsoId("_p-vHXN4jEeqt1ZcLzWyWFw")]
    [Description(@"DebtorAccount is incorrect.")]
    IncorrectDebtorAccount,
    
    /// <summary>
    /// InstructedReimbursementAgent is incorrect (former IncorrectReceiverCorrespondent).
    /// Encoded/decoded by serializers as "IN09".
    /// </summary>
    [EnumMember(Value = "IN09")]
    [IsoId("_p-vHct4jEeqt1ZcLzWyWFw")]
    [Description(@"InstructedReimbursementAgent is incorrect (former IncorrectReceiverCorrespondent).")]
    IncorrectInstructedReimbursementAgent,
    
    /// <summary>
    /// ThirdReimbursementAgent is incorrect (former IncorrectThirdReimbursementInstitution).
    /// Encoded/decoded by serializers as "IN10".
    /// </summary>
    [EnumMember(Value = "IN10")]
    [IsoId("_p-vHcN4jEeqt1ZcLzWyWFw")]
    [Description(@"ThirdReimbursementAgent is incorrect (former IncorrectThirdReimbursementInstitution).")]
    IncorrectThirdReimbursementAgent,
    
    /// <summary>
    /// Payment type clearing channel is incorrect (former PaymentScheme).
    /// Encoded/decoded by serializers as "IN11".
    /// </summary>
    [EnumMember(Value = "IN11")]
    [IsoId("_p-vHUN4jEeqt1ZcLzWyWFw")]
    [Description(@"Payment type clearing channel is incorrect (former PaymentScheme).")]
    IncorrectPaymentClearingChannel,
    
    /// <summary>
    /// CreditorAgentAccount is incorrect (former IncorrectAccountOfBeneficiaryInstitution).
    /// Encoded/decoded by serializers as "IN12".
    /// </summary>
    [EnumMember(Value = "IN12")]
    [IsoId("_p-vHXt4jEeqt1ZcLzWyWFw")]
    [Description(@"CreditorAgentAccount is incorrect (former IncorrectAccountOfBeneficiaryInstitution).")]
    IncorrectCreditorAgentAccount,
    
    /// <summary>
    /// Creditor is incorrect.
    /// Encoded/decoded by serializers as "IN13".
    /// </summary>
    [EnumMember(Value = "IN13")]
    [IsoId("_p-vHWd4jEeqt1ZcLzWyWFw")]
    [Description(@"Creditor is incorrect.")]
    IncorrectCreditor,
    
    /// <summary>
    /// Creditor account is incorrect.
    /// Encoded/decoded by serializers as "IN14".
    /// </summary>
    [EnumMember(Value = "IN14")]
    [IsoId("_p-vHTd4jEeqt1ZcLzWyWFw")]
    [Description(@"Creditor account is incorrect.")]
    IncorrectCreditorAccount,
    
    /// <summary>
    /// RemittanceInformation is incorrect.
    /// Encoded/decoded by serializers as "IN15".
    /// </summary>
    [EnumMember(Value = "IN15")]
    [IsoId("_p-vHV94jEeqt1ZcLzWyWFw")]
    [Description(@"RemittanceInformation is incorrect.")]
    IncorrectRemittanceInformation,
    
    /// <summary>
    /// Transaction payment purpose is incorrect.
    /// Encoded/decoded by serializers as "IN16".
    /// </summary>
    [EnumMember(Value = "IN16")]
    [IsoId("_p-vHWt4jEeqt1ZcLzWyWFw")]
    [Description(@"Transaction payment purpose is incorrect.")]
    IncorrectPaymentPurpose,
    
    /// <summary>
    /// ChargeBearer is incorrect (former IncorrectDetailsOfCharges).
    /// Encoded/decoded by serializers as "IN17".
    /// </summary>
    [EnumMember(Value = "IN17")]
    [IsoId("_p-vHWN4jEeqt1ZcLzWyWFw")]
    [Description(@"ChargeBearer is incorrect (former IncorrectDetailsOfCharges).")]
    IncorrectChargeBearer,
    
    /// <summary>
    /// Instruction for next agent is incorrect (former IncorrectSenderToReceiverInformation).
    /// Encoded/decoded by serializers as "IN18".
    /// </summary>
    [EnumMember(Value = "IN18")]
    [IsoId("_p-vHZd4jEeqt1ZcLzWyWFw")]
    [Description(@"Instruction for next agent is incorrect (former IncorrectSenderToReceiverInformation).")]
    IncorrectInstructionForNextAgent,
    
    /// <summary>
    /// Instruction for creditor agent is incorrect (former IncorrectInstructionForFinalAgent).
    /// Encoded/decoded by serializers as "IN19".
    /// </summary>
    [EnumMember(Value = "IN19")]
    [IsoId("_p-vHX94jEeqt1ZcLzWyWFw")]
    [Description(@"Instruction for creditor agent is incorrect (former IncorrectInstructionForFinalAgent).")]
    IncorrectInstructionForCreditorAgent,
    
    /// <summary>
    /// Name and account of creditor are not matching.
    /// Encoded/decoded by serializers as "MM20".
    /// </summary>
    [EnumMember(Value = "MM20")]
    [IsoId("_p-vHTt4jEeqt1ZcLzWyWFw")]
    [Description(@"Name and account of creditor are not matching.")]
    MismatchCreditorNameAccount,
    
    /// <summary>
    /// Name and account of debtor are not matching.
    /// Encoded/decoded by serializers as "MM21".
    /// </summary>
    [EnumMember(Value = "MM21")]
    [IsoId("_p-vHT94jEeqt1ZcLzWyWFw")]
    [Description(@"Name and account of debtor are not matching.")]
    MismatchDebtorNameAccount,
    
    /// <summary>
    /// Name and account of creditor agent (former FinalAgent) are not matching.
    /// Encoded/decoded by serializers as "MM22".
    /// </summary>
    [EnumMember(Value = "MM22")]
    [IsoId("_p-vHa94jEeqt1ZcLzWyWFw")]
    [Description(@"Name and account of creditor agent (former FinalAgent) are not matching.")]
    MismatchCreditorAgentNameAccount,
    
    /// <summary>
    /// Insufficient or incoherent details about the debtor with respect to regulatory requirements.
    /// Encoded/decoded by serializers as "MM23".
    /// </summary>
    [EnumMember(Value = "MM23")]
    [IsoId("_p-vHat4jEeqt1ZcLzWyWFw")]
    [Description(@"Insufficient or incoherent details about the debtor with respect to regulatory requirements.")]
    InsufficientDebtorDetails,
    
    /// <summary>
    /// Insufficient or incoherent details about the creditor with respect to regulatory requirements.
    /// Encoded/decoded by serializers as "MM24".
    /// </summary>
    [EnumMember(Value = "MM24")]
    [IsoId("_p-vHVN4jEeqt1ZcLzWyWFw")]
    [Description(@"Insufficient or incoherent details about the creditor with respect to regulatory requirements.")]
    InsufficientCreditorDetails,
    
    /// <summary>
    /// Payment is pending execution. For reasons of regulatory requirements we request further information on the account number or unique identification of the debtor.
    /// Encoded/decoded by serializers as "MM25".
    /// </summary>
    [EnumMember(Value = "MM25")]
    [IsoId("_p-vHY94jEeqt1ZcLzWyWFw")]
    [Description(@"Payment is pending execution. For reasons of regulatory requirements we request further information on the account number or unique identification of the debtor.")]
    PendingExecutionDebtorAccountOrIdentification,
    
    /// <summary>
    /// Payment is pending execution. For reasons of regulatory requirements we request further information on the name and/or address of the debtor.
    /// Encoded/decoded by serializers as "MM26".
    /// </summary>
    [EnumMember(Value = "MM26")]
    [IsoId("_p-vHYd4jEeqt1ZcLzWyWFw")]
    [Description(@"Payment is pending execution. For reasons of regulatory requirements we request further information on the name and/or address of the debtor.")]
    PendingExecutionDebtorNameOrAddress,
    
    /// <summary>
    /// Payment has been executed. For reasons of regulatory requirements we request further information on the account number or unique identification of the debtor.
    /// Encoded/decoded by serializers as "MM27".
    /// </summary>
    [EnumMember(Value = "MM27")]
    [IsoId("_p-vHW94jEeqt1ZcLzWyWFw")]
    [Description(@"Payment has been executed. For reasons of regulatory requirements we request further information on the account number or unique identification of the debtor.")]
    PaymentExecutedDebtorAccountOrIdentification,
    
    /// <summary>
    /// Payment has been executed. For reasons of regulatory requirements we request further information on the name and/or address of the debtor.
    /// Encoded/decoded by serializers as "MM28".
    /// </summary>
    [EnumMember(Value = "MM28")]
    [IsoId("_p-vHc94jEeqt1ZcLzWyWFw")]
    [Description(@"Payment has been executed. For reasons of regulatory requirements we request further information on the name and/or address of the debtor.")]
    PaymentExecutedDebtorNameOrAddress,
    
    /// <summary>
    /// Payment is pending execution. For reasons of regulatory requirements we request further information on the account number or unique identification of the creditor.
    /// Encoded/decoded by serializers as "MM29".
    /// </summary>
    [EnumMember(Value = "MM29")]
    [IsoId("_p-vHbt4jEeqt1ZcLzWyWFw")]
    [Description(@"Payment is pending execution. For reasons of regulatory requirements we request further information on the account number or unique identification of the creditor.")]
    PendingExecutionCreditorAccountOrIdentification,
    
    /// <summary>
    /// Payment is pending execution. For reasons of regulatory requirements we request further information on the name and/or address of the creditor.
    /// Encoded/decoded by serializers as "MM30".
    /// </summary>
    [EnumMember(Value = "MM30")]
    [IsoId("_p-vHUt4jEeqt1ZcLzWyWFw")]
    [Description(@"Payment is pending execution. For reasons of regulatory requirements we request further information on the name and/or address of the creditor.")]
    PendingExecutionCreditorNameOrAddress,
    
    /// <summary>
    /// Payment has been executed. For reasons of regulatory requirements we request further information on the account number or unique identification of the creditor.
    /// Encoded/decoded by serializers as "MM31".
    /// </summary>
    [EnumMember(Value = "MM31")]
    [IsoId("_p-vHS94jEeqt1ZcLzWyWFw")]
    [Description(@"Payment has been executed. For reasons of regulatory requirements we request further information on the account number or unique identification of the creditor.")]
    PaymentExecutedCreditorAccountOrIdentification,
    
    /// <summary>
    /// Payment has been executed. For reasons of regulatory requirements we request further information on the name and/or address of the creditor.
    /// Encoded/decoded by serializers as "MM32".
    /// </summary>
    [EnumMember(Value = "MM32")]
    [IsoId("_p-vHYt4jEeqt1ZcLzWyWFw")]
    [Description(@"Payment has been executed. For reasons of regulatory requirements we request further information on the name and/or address of the creditor.")]
    PaymentExecutedCreditorNameOrAddress,
    
    /// <summary>
    /// Amount in statement entry is incorrect.
    /// Encoded/decoded by serializers as "IN33".
    /// </summary>
    [EnumMember(Value = "IN33")]
    [IsoId("_p-vHZN4jEeqt1ZcLzWyWFw")]
    [Description(@"Amount in statement entry is incorrect.")]
    IncorrectReportEntryAmount,
    
    /// <summary>
    /// Insufficient charges details provided.
    /// Encoded/decoded by serializers as "MM34".
    /// </summary>
    [EnumMember(Value = "MM34")]
    [IsoId("_p-vHbd4jEeqt1ZcLzWyWFw")]
    [Description(@"Insufficient charges details provided.")]
    InsufficientChargesDetails,
    
    /// <summary>
    /// Payment purpose needs to be further specified.
    /// Encoded/decoded by serializers as "MM35".
    /// </summary>
    [EnumMember(Value = "MM35")]
    [IsoId("_p-vHZ94jEeqt1ZcLzWyWFw")]
    [Description(@"Payment purpose needs to be further specified.")]
    InsufficientPaymentPurpose,
    
    /// <summary>
    /// SettlementAccount is incorrect.
    /// Encoded/decoded by serializers as "IN36".
    /// </summary>
    [EnumMember(Value = "IN36")]
    [IsoId("_p-vHUd4jEeqt1ZcLzWyWFw")]
    [Description(@"SettlementAccount is incorrect.")]
    IncorrectSettlementAccount,
    
    /// <summary>
    /// Instructing reimbursement agent is incorrect.
    /// Encoded/decoded by serializers as "IN37".
    /// </summary>
    [EnumMember(Value = "IN37")]
    [IsoId("_p-vHVt4jEeqt1ZcLzWyWFw")]
    [Description(@"Instructing reimbursement agent is incorrect.")]
    IncorrectInstructingReimbursementAgent,
    
    /// <summary>
    /// Debtor's address is incorrect.
    /// Encoded/decoded by serializers as "IN38".
    /// </summary>
    [EnumMember(Value = "IN38")]
    [IsoId("_p-vHTN4jEeqt1ZcLzWyWFw")]
    [Description(@"Debtor's address is incorrect.")]
    IncorrectDebtorAddress,
    
    /// <summary>
    /// Creditor's address is incorrect.
    /// Encoded/decoded by serializers as "IN39".
    /// </summary>
    [EnumMember(Value = "IN39")]
    [IsoId("_p-vHVd4jEeqt1ZcLzWyWFw")]
    [Description(@"Creditor's address is incorrect.")]
    IncorrectCreditorAddress,
    
    /// <summary>
    /// See narrative field for additional information.
    /// Encoded/decoded by serializers as "NARR".
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_p-vHb94jEeqt1ZcLzWyWFw")]
    [Description(@"See narrative field for additional information.")]
    Narrative,
    
    /// <summary>
    /// RelatedRemittanceInformation is incorrect.
    /// Encoded/decoded by serializers as "IN40".
    /// </summary>
    [EnumMember(Value = "IN40")]
    [IsoId("_p-vHaN4jEeqt1ZcLzWyWFw")]
    [Description(@"RelatedRemittanceInformation is incorrect.")]
    IncorrectRelatedRemittanceInformation,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalUnableToApplyIncorrectDataCodeMetadataExtensions
{
    private static readonly ExternalUnableToApplyIncorrectDataCodeDropdownSource _dropdownSource = new ExternalUnableToApplyIncorrectDataCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalUnableToApplyIncorrectDataCodeDropdownRow GetMetadata(this ExternalUnableToApplyIncorrectDataCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


