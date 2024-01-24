﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UnableToApplyIncorrectInformationV2Code.  ISO2002 ID# _Y0yNY9p-Ed-ak6NoX_4Aeg_-1880255090.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason of an unable to apply due to incorrect information.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y0yNY9p-Ed-ak6NoX_4Aeg_-1880255090")]
[Description(@"Specifies the reason of an unable to apply due to incorrect information.")]
[Derivations(typeof(UnableToApplyIncorrectInformation3Code),typeof(UnableToApplyIncorrectInformation4Code))]
public enum UnableToApplyIncorrectInformationV2Code
{
    /// <summary>
    /// Related transaction reference is incorrect.
    /// Encoded/decoded by serializers as "IN01".
    /// </summary>
    [EnumMember(Value = "IN01")]
    [IsoId("_Y0yNZNp-Ed-ak6NoX_4Aeg_-1491451794")]
    [Description(@"Related transaction reference is incorrect.")]
    IncorrectRelatedReference,
    
    /// <summary>
    /// Payment type service level is incorrect (former IncorrectBankOperationCode).
    /// Encoded/decoded by serializers as "IN02".
    /// </summary>
    [EnumMember(Value = "IN02")]
    [IsoId("_Y0yNZdp-Ed-ak6NoX_4Aeg_-1491451764")]
    [Description(@"Payment type service level is incorrect (former IncorrectBankOperationCode).")]
    IncorrectPaymentServiceLevel,
    
    /// <summary>
    /// Payment type category purpose is incorrect (former IncorrectInstructionCode).
    /// Encoded/decoded by serializers as "IN03".
    /// </summary>
    [EnumMember(Value = "IN03")]
    [IsoId("_Y0yNZtp-Ed-ak6NoX_4Aeg_-1491451763")]
    [Description(@"Payment type category purpose is incorrect (former IncorrectInstructionCode).")]
    IncorrectCategoryPurpose,
    
    /// <summary>
    /// RequestedExecutionDate is incorrect.
    /// Encoded/decoded by serializers as "IN04".
    /// </summary>
    [EnumMember(Value = "IN04")]
    [IsoId("_Y0yNZ9p-Ed-ak6NoX_4Aeg_-1491451733")]
    [Description(@"RequestedExecutionDate is incorrect.")]
    IncorrectRequestedExecutionDate,
    
    /// <summary>
    /// Interbank settlement date is incorrect (former IncorrectValueDate).
    /// Encoded/decoded by serializers as "IN05".
    /// </summary>
    [EnumMember(Value = "IN05")]
    [IsoId("_Y0yNaNp-Ed-ak6NoX_4Aeg_-1491451711")]
    [Description(@"Interbank settlement date is incorrect (former IncorrectValueDate).")]
    IncorrectInterbankSettlementDate,
    
    /// <summary>
    /// Interbank settlement amount is incorrect (former IncorrectSettledAmount).
    /// Encoded/decoded by serializers as "IN06".
    /// </summary>
    [EnumMember(Value = "IN06")]
    [IsoId("_Y0yNadp-Ed-ak6NoX_4Aeg_-1491451485")]
    [Description(@"Interbank settlement amount is incorrect (former IncorrectSettledAmount).")]
    IncorrectInterbankSettlementAmount,
    
    /// <summary>
    /// Debtor is incorrect.
    /// Encoded/decoded by serializers as "IN07".
    /// </summary>
    [EnumMember(Value = "IN07")]
    [IsoId("_Y07-YNp-Ed-ak6NoX_4Aeg_-1491451463")]
    [Description(@"Debtor is incorrect.")]
    IncorrectDebtor,
    
    /// <summary>
    /// DebtorAccount is incorrect.
    /// Encoded/decoded by serializers as "IN08".
    /// </summary>
    [EnumMember(Value = "IN08")]
    [IsoId("_Y07-Ydp-Ed-ak6NoX_4Aeg_-1491451432")]
    [Description(@"DebtorAccount is incorrect.")]
    IncorrectDebtorAccount,
    
    /// <summary>
    /// InstructedReimbursementAgent is incorrect (former IncorrectReceiverCorrespondent).
    /// Encoded/decoded by serializers as "IN09".
    /// </summary>
    [EnumMember(Value = "IN09")]
    [IsoId("_Y07-Ytp-Ed-ak6NoX_4Aeg_-1491451423")]
    [Description(@"InstructedReimbursementAgent is incorrect (former IncorrectReceiverCorrespondent).")]
    IncorrectInstructedReimbursementAgent,
    
    /// <summary>
    /// ThirdReimbursementAgent is incorrect (former IncorrectThirdReimbursementInstitution).
    /// Encoded/decoded by serializers as "IN10".
    /// </summary>
    [EnumMember(Value = "IN10")]
    [IsoId("_Y07-Y9p-Ed-ak6NoX_4Aeg_-1491451402")]
    [Description(@"ThirdReimbursementAgent is incorrect (former IncorrectThirdReimbursementInstitution).")]
    IncorrectThirdReimbursementAgent,
    
    /// <summary>
    /// Payment type clearing channel is incorrect (former PaymentScheme).
    /// Encoded/decoded by serializers as "IN11".
    /// </summary>
    [EnumMember(Value = "IN11")]
    [IsoId("_Y07-ZNp-Ed-ak6NoX_4Aeg_-1491451371")]
    [Description(@"Payment type clearing channel is incorrect (former PaymentScheme).")]
    IncorrectPaymentClearingChannel,
    
    /// <summary>
    /// CreditorAgentAccount is incorrect (former IncorrectAccountOfBeneficiaryInstitution).
    /// Encoded/decoded by serializers as "IN12".
    /// </summary>
    [EnumMember(Value = "IN12")]
    [IsoId("_Y07-Zdp-Ed-ak6NoX_4Aeg_-1491451370")]
    [Description(@"CreditorAgentAccount is incorrect (former IncorrectAccountOfBeneficiaryInstitution).")]
    IncorrectCreditorAgentAccount,
    
    /// <summary>
    /// Creditor is incorrect.
    /// Encoded/decoded by serializers as "IN13".
    /// </summary>
    [EnumMember(Value = "IN13")]
    [IsoId("_Y07-Ztp-Ed-ak6NoX_4Aeg_-1491451340")]
    [Description(@"Creditor is incorrect.")]
    IncorrectCreditor,
    
    /// <summary>
    /// Creditor account is incorrect.
    /// Encoded/decoded by serializers as "IN14".
    /// </summary>
    [EnumMember(Value = "IN14")]
    [IsoId("_Y07-Z9p-Ed-ak6NoX_4Aeg_-1491451310")]
    [Description(@"Creditor account is incorrect.")]
    IncorrectCreditorAccount,
    
    /// <summary>
    /// RemittanceInformation is incorrect.
    /// Encoded/decoded by serializers as "IN15".
    /// </summary>
    [EnumMember(Value = "IN15")]
    [IsoId("_Y07-aNp-Ed-ak6NoX_4Aeg_-1491451031")]
    [Description(@"RemittanceInformation is incorrect.")]
    IncorrectRemittanceInformation,
    
    /// <summary>
    /// Transaction payment purpose is incorrect.
    /// Encoded/decoded by serializers as "IN16".
    /// </summary>
    [EnumMember(Value = "IN16")]
    [IsoId("_Y07-adp-Ed-ak6NoX_4Aeg_-1491451001")]
    [Description(@"Transaction payment purpose is incorrect.")]
    IncorrectPaymentPurpose,
    
    /// <summary>
    /// ChargeBearer is incorrect (former IncorrectDetailsOfCharges).
    /// Encoded/decoded by serializers as "IN17".
    /// </summary>
    [EnumMember(Value = "IN17")]
    [IsoId("_Y1FvYNp-Ed-ak6NoX_4Aeg_-1491450970")]
    [Description(@"ChargeBearer is incorrect (former IncorrectDetailsOfCharges).")]
    IncorrectChargeBearer,
    
    /// <summary>
    /// Instruction for next agent is incorrect (former IncorrectSenderToReceiverInformation).
    /// Encoded/decoded by serializers as "IN18".
    /// </summary>
    [EnumMember(Value = "IN18")]
    [IsoId("_Y1FvYdp-Ed-ak6NoX_4Aeg_-1491450969")]
    [Description(@"Instruction for next agent is incorrect (former IncorrectSenderToReceiverInformation).")]
    IncorrectInstructionForNextAgent,
    
    /// <summary>
    /// Instruction for creditor agent is incorrect (former IncorrectInstructionForFinalAgent).
    /// Encoded/decoded by serializers as "IN19".
    /// </summary>
    [EnumMember(Value = "IN19")]
    [IsoId("_Y1FvYtp-Ed-ak6NoX_4Aeg_-1491450939")]
    [Description(@"Instruction for creditor agent is incorrect (former IncorrectInstructionForFinalAgent).")]
    IncorrectInstructionForCreditorAgent,
    
    /// <summary>
    /// Name and account of creditor are not matching.
    /// Encoded/decoded by serializers as "MM20".
    /// </summary>
    [EnumMember(Value = "MM20")]
    [IsoId("_Y1FvY9p-Ed-ak6NoX_4Aeg_-1491450817")]
    [Description(@"Name and account of creditor are not matching.")]
    MismatchCreditorNameAccount,
    
    /// <summary>
    /// Name and account of debtor are not matching.
    /// Encoded/decoded by serializers as "MM21".
    /// </summary>
    [EnumMember(Value = "MM21")]
    [IsoId("_Y1FvZNp-Ed-ak6NoX_4Aeg_-1491450515")]
    [Description(@"Name and account of debtor are not matching.")]
    MismatchDebtorNameAccount,
    
    /// <summary>
    /// Name and account of creditor agent (former FinalAgent) are not matching.
    /// Encoded/decoded by serializers as "MM22".
    /// </summary>
    [EnumMember(Value = "MM22")]
    [IsoId("_Y1FvZdp-Ed-ak6NoX_4Aeg_-1491450484")]
    [Description(@"Name and account of creditor agent (former FinalAgent) are not matching.")]
    MismatchCreditorAgentNameAccount,
    
    /// <summary>
    /// Insufficient or incoherent details about the debtor with respect to regulatory requirements.
    /// Encoded/decoded by serializers as "MM23".
    /// </summary>
    [EnumMember(Value = "MM23")]
    [IsoId("_Y1FvZtp-Ed-ak6NoX_4Aeg_-1476677331")]
    [Description(@"Insufficient or incoherent details about the debtor with respect to regulatory requirements.")]
    InsufficientDebtorDetails,
    
    /// <summary>
    /// Insufficient or incoherent details about the creditor with respect to regulatory requirements.
    /// Encoded/decoded by serializers as "MM24".
    /// </summary>
    [EnumMember(Value = "MM24")]
    [IsoId("_Y1FvZ9p-Ed-ak6NoX_4Aeg_-1476677300")]
    [Description(@"Insufficient or incoherent details about the creditor with respect to regulatory requirements.")]
    InsufficientCreditorDetails,
    
    /// <summary>
    /// Payment is pending execution. For reasons of regulatory requirements we request further information on the account number or unique identification of the debtor.
    /// Encoded/decoded by serializers as "MM25".
    /// </summary>
    [EnumMember(Value = "MM25")]
    [IsoId("_Y1FvaNp-Ed-ak6NoX_4Aeg_-1459129606")]
    [Description(@"Payment is pending execution. For reasons of regulatory requirements we request further information on the account number or unique identification of the debtor.")]
    PendingExecutionDebtorAccountOrIdentification,
    
    /// <summary>
    /// Payment is pending execution. For reasons of regulatory requirements we request further information on the name and/or address of the debtor.
    /// Encoded/decoded by serializers as "MM26".
    /// </summary>
    [EnumMember(Value = "MM26")]
    [IsoId("_Y1Fvadp-Ed-ak6NoX_4Aeg_-1065707728")]
    [Description(@"Payment is pending execution. For reasons of regulatory requirements we request further information on the name and/or address of the debtor.")]
    PendingExecutionDebtorNameOrAddress,
    
    /// <summary>
    /// Payment has been executed. For reasons of regulatory requirements we request further information on the account number or unique identification of the debtor.
    /// Encoded/decoded by serializers as "MM27".
    /// </summary>
    [EnumMember(Value = "MM27")]
    [IsoId("_Y1Fvatp-Ed-ak6NoX_4Aeg_-1007525450")]
    [Description(@"Payment has been executed. For reasons of regulatory requirements we request further information on the account number or unique identification of the debtor.")]
    PaymentExecutedDebtorAccountOrIdentification,
    
    /// <summary>
    /// Payment has been executed. For reasons of regulatory requirements we request further information on the name and/or address of the debtor.
    /// Encoded/decoded by serializers as "MM28".
    /// </summary>
    [EnumMember(Value = "MM28")]
    [IsoId("_Y1O5UNp-Ed-ak6NoX_4Aeg_-964122806")]
    [Description(@"Payment has been executed. For reasons of regulatory requirements we request further information on the name and/or address of the debtor.")]
    PaymentExecutedDebtorNameOrAddress,
    
    /// <summary>
    /// Payment is pending execution. For reasons of regulatory requirements we request further information on the account number or unique identification of the creditor.
    /// Encoded/decoded by serializers as "MM29".
    /// </summary>
    [EnumMember(Value = "MM29")]
    [IsoId("_Y1O5Udp-Ed-ak6NoX_4Aeg_-485736601")]
    [Description(@"Payment is pending execution. For reasons of regulatory requirements we request further information on the account number or unique identification of the creditor.")]
    PendingExecutionCreditorAccountOrIdentification,
    
    /// <summary>
    /// Payment is pending execution. For reasons of regulatory requirements we request further information on the name and/or address of the creditor.
    /// Encoded/decoded by serializers as "MM30".
    /// </summary>
    [EnumMember(Value = "MM30")]
    [IsoId("_Y1O5Utp-Ed-ak6NoX_4Aeg_-485736478")]
    [Description(@"Payment is pending execution. For reasons of regulatory requirements we request further information on the name and/or address of the creditor.")]
    PendingExecutionCreditorNameOrAddress,
    
    /// <summary>
    /// Payment has been executed. For reasons of regulatory requirements we request further information on the account number or unique identification of the creditor.
    /// Encoded/decoded by serializers as "MM31".
    /// </summary>
    [EnumMember(Value = "MM31")]
    [IsoId("_Y1O5U9p-Ed-ak6NoX_4Aeg_-485736394")]
    [Description(@"Payment has been executed. For reasons of regulatory requirements we request further information on the account number or unique identification of the creditor.")]
    PaymentExecutedCreditorAccountOrIdentification,
    
    /// <summary>
    /// Payment has been executed. For reasons of regulatory requirements we request further information on the name and/or address of the creditor.
    /// Encoded/decoded by serializers as "MM32".
    /// </summary>
    [EnumMember(Value = "MM32")]
    [IsoId("_Y1O5VNp-Ed-ak6NoX_4Aeg_-478351375")]
    [Description(@"Payment has been executed. For reasons of regulatory requirements we request further information on the name and/or address of the creditor.")]
    PaymentExecutedCreditorNameOrAddress,
    
    /// <summary>
    /// Amount in statement entry is incorrect.
    /// Encoded/decoded by serializers as "IN33".
    /// </summary>
    [EnumMember(Value = "IN33")]
    [IsoId("_Y1O5Vdp-Ed-ak6NoX_4Aeg_783181284")]
    [Description(@"Amount in statement entry is incorrect.")]
    IncorrectReportEntryAmount,
    
    /// <summary>
    /// Insufficient charges details provided.
    /// Encoded/decoded by serializers as "MM34".
    /// </summary>
    [EnumMember(Value = "MM34")]
    [IsoId("_Y1O5Vtp-Ed-ak6NoX_4Aeg_1254176047")]
    [Description(@"Insufficient charges details provided.")]
    InsufficientChargesDetails,
    
    /// <summary>
    /// Payment purpose needs to be further specified.
    /// Encoded/decoded by serializers as "MM35".
    /// </summary>
    [EnumMember(Value = "MM35")]
    [IsoId("_Y1O5V9p-Ed-ak6NoX_4Aeg_1567247885")]
    [Description(@"Payment purpose needs to be further specified.")]
    InsufficientPaymentPurpose,
    
    /// <summary>
    /// SettlementAccount is incorrect.
    /// Encoded/decoded by serializers as "IN36".
    /// </summary>
    [EnumMember(Value = "IN36")]
    [IsoId("_Y1YqUNp-Ed-ak6NoX_4Aeg_-1693093653")]
    [Description(@"SettlementAccount is incorrect.")]
    IncorrectSettlementAccount,
    
    /// <summary>
    /// Instructing reimbursement agent is incorrect.
    /// Encoded/decoded by serializers as "IN37".
    /// </summary>
    [EnumMember(Value = "IN37")]
    [IsoId("_Y1YqUdp-Ed-ak6NoX_4Aeg_838074029")]
    [Description(@"Instructing reimbursement agent is incorrect.")]
    IncorrectInstructingReimbursementAgent,
    
    /// <summary>
    /// Debtor's address is incorrect.
    /// Encoded/decoded by serializers as "IN38".
    /// </summary>
    [EnumMember(Value = "IN38")]
    [IsoId("_Y1YqUtp-Ed-ak6NoX_4Aeg_-1463463483")]
    [Description(@"Debtor's address is incorrect.")]
    IncorrectDebtorAddress,
    
    /// <summary>
    /// Creditor's address is incorrect.
    /// Encoded/decoded by serializers as "IN39".
    /// </summary>
    [EnumMember(Value = "IN39")]
    [IsoId("_Y1YqU9p-Ed-ak6NoX_4Aeg_-1461615238")]
    [Description(@"Creditor's address is incorrect.")]
    IncorrectCreditorAddress,
    
    /// <summary>
    /// See narrative field for additional information.
    /// Encoded/decoded by serializers as "NARR".
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_0SCIsUgsEeaGKYpLDboHPQ")]
    [Description(@"See narrative field for additional information.")]
    Narrative,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class UnableToApplyIncorrectInformationV2CodeMetadataExtensions
{
    private static readonly UnableToApplyIncorrectInformationV2CodeDropdownSource _dropdownSource = new UnableToApplyIncorrectInformationV2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IUnableToApplyIncorrectInformationV2CodeDropdownRow GetMetadata(this UnableToApplyIncorrectInformationV2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


