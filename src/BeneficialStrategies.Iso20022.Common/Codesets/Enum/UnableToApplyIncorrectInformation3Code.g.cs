﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UnableToApplyIncorrectInformation3Code.  ISO2002 ID# _Y0MXh9p-Ed-ak6NoX_4Aeg_-660282894.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason of an unable to apply due to incorrect information.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y0MXh9p-Ed-ak6NoX_4Aeg_-660282894")]
[Description(@"Specifies the reason of an unable to apply due to incorrect information.")]
[DerivedFrom(typeof(UnableToApplyIncorrectInformationV2Code))]
public enum UnableToApplyIncorrectInformation3Code
{
    /// <summary>
    /// Related transaction reference is incorrect.
    /// Encoded/decoded by serializers as "IncorrectRelatedReference".
    /// </summary>
    [EnumMember(Value = "IN01")]
    [IsoId("_Y0MXiNp-Ed-ak6NoX_4Aeg_-660282892")]
    [Description(@"Related transaction reference is incorrect.")]
    IncorrectRelatedReference,
    
    /// <summary>
    /// Payment type service level is incorrect (former IncorrectBankOperationCode).
    /// Encoded/decoded by serializers as "IncorrectPaymentServiceLevel".
    /// </summary>
    [EnumMember(Value = "IN02")]
    [IsoId("_Y0MXidp-Ed-ak6NoX_4Aeg_-660282891")]
    [Description(@"Payment type service level is incorrect (former IncorrectBankOperationCode).")]
    IncorrectPaymentServiceLevel,
    
    /// <summary>
    /// Payment type category purpose is incorrect (former IncorrectInstructionCode).
    /// Encoded/decoded by serializers as "IncorrectCategoryPurpose".
    /// </summary>
    [EnumMember(Value = "IN03")]
    [IsoId("_Y0WIgNp-Ed-ak6NoX_4Aeg_-660282864")]
    [Description(@"Payment type category purpose is incorrect (former IncorrectInstructionCode).")]
    IncorrectCategoryPurpose,
    
    /// <summary>
    /// RequestedExecutionDate is incorrect.
    /// Encoded/decoded by serializers as "IncorrectRequestedExecutionDate".
    /// </summary>
    [EnumMember(Value = "IN04")]
    [IsoId("_Y0WIgdp-Ed-ak6NoX_4Aeg_-660282863")]
    [Description(@"RequestedExecutionDate is incorrect.")]
    IncorrectRequestedExecutionDate,
    
    /// <summary>
    /// Interbank settlement date is incorrect (former IncorrectValueDate).
    /// Encoded/decoded by serializers as "IncorrectInterbankSettlementDate".
    /// </summary>
    [EnumMember(Value = "IN05")]
    [IsoId("_Y0WIgtp-Ed-ak6NoX_4Aeg_-660282862")]
    [Description(@"Interbank settlement date is incorrect (former IncorrectValueDate).")]
    IncorrectInterbankSettlementDate,
    
    /// <summary>
    /// Interbank settlement amount is incorrect (former IncorrectSettledAmount).
    /// Encoded/decoded by serializers as "IncorrectInterbankSettlementAmount".
    /// </summary>
    [EnumMember(Value = "IN06")]
    [IsoId("_Y0WIg9p-Ed-ak6NoX_4Aeg_-660282833")]
    [Description(@"Interbank settlement amount is incorrect (former IncorrectSettledAmount).")]
    IncorrectInterbankSettlementAmount,
    
    /// <summary>
    /// Debtor is incorrect.
    /// Encoded/decoded by serializers as "IncorrectDebtor".
    /// </summary>
    [EnumMember(Value = "IN07")]
    [IsoId("_Y0WIhNp-Ed-ak6NoX_4Aeg_-660282832")]
    [Description(@"Debtor is incorrect.")]
    IncorrectDebtor,
    
    /// <summary>
    /// DebtorAccount is incorrect.
    /// Encoded/decoded by serializers as "IncorrectDebtorAccount".
    /// </summary>
    [EnumMember(Value = "IN08")]
    [IsoId("_Y0WIhdp-Ed-ak6NoX_4Aeg_-660282811")]
    [Description(@"DebtorAccount is incorrect.")]
    IncorrectDebtorAccount,
    
    /// <summary>
    /// InstructedReimbursementAgent is incorrect (former IncorrectReceiverCorrespondent).
    /// Encoded/decoded by serializers as "IncorrectInstructedReimbursementAgent".
    /// </summary>
    [EnumMember(Value = "IN09")]
    [IsoId("_Y0WIhtp-Ed-ak6NoX_4Aeg_-660282585")]
    [Description(@"InstructedReimbursementAgent is incorrect (former IncorrectReceiverCorrespondent).")]
    IncorrectInstructedReimbursementAgent,
    
    /// <summary>
    /// ThirdReimbursementAgent is incorrect (former IncorrectThirdReimbursementInstitution).
    /// Encoded/decoded by serializers as "IncorrectThirdReimbursementAgent".
    /// </summary>
    [EnumMember(Value = "IN10")]
    [IsoId("_Y0WIh9p-Ed-ak6NoX_4Aeg_-660282584")]
    [Description(@"ThirdReimbursementAgent is incorrect (former IncorrectThirdReimbursementInstitution).")]
    IncorrectThirdReimbursementAgent,
    
    /// <summary>
    /// Payment type clearing channel is incorrect (former PaymentScheme).
    /// Encoded/decoded by serializers as "IncorrectPaymentClearingChannel".
    /// </summary>
    [EnumMember(Value = "IN11")]
    [IsoId("_Y0WIiNp-Ed-ak6NoX_4Aeg_-660282563")]
    [Description(@"Payment type clearing channel is incorrect (former PaymentScheme).")]
    IncorrectPaymentClearingChannel,
    
    /// <summary>
    /// CreditorAgentAccount is incorrect (former IncorrectAccountOfBeneficiaryInstitution).
    /// Encoded/decoded by serializers as "IncorrectCreditorAgentAccount".
    /// </summary>
    [EnumMember(Value = "IN12")]
    [IsoId("_Y0WIidp-Ed-ak6NoX_4Aeg_-660282554")]
    [Description(@"CreditorAgentAccount is incorrect (former IncorrectAccountOfBeneficiaryInstitution).")]
    IncorrectCreditorAgentAccount,
    
    /// <summary>
    /// Creditor is incorrect.
    /// Encoded/decoded by serializers as "IncorrectCreditor".
    /// </summary>
    [EnumMember(Value = "IN13")]
    [IsoId("_Y0WIitp-Ed-ak6NoX_4Aeg_-660282553")]
    [Description(@"Creditor is incorrect.")]
    IncorrectCreditor,
    
    /// <summary>
    /// Creditor account is incorrect.
    /// Encoded/decoded by serializers as "IncorrectCreditorAccount".
    /// </summary>
    [EnumMember(Value = "IN14")]
    [IsoId("_Y0fScNp-Ed-ak6NoX_4Aeg_-660282532")]
    [Description(@"Creditor account is incorrect.")]
    IncorrectCreditorAccount,
    
    /// <summary>
    /// RemittanceInformation is incorrect.
    /// Encoded/decoded by serializers as "IncorrectRemittanceInformation".
    /// </summary>
    [EnumMember(Value = "IN15")]
    [IsoId("_Y0fScdp-Ed-ak6NoX_4Aeg_-660282523")]
    [Description(@"RemittanceInformation is incorrect.")]
    IncorrectRemittanceInformation,
    
    /// <summary>
    /// Transaction payment purpose is incorrect.
    /// Encoded/decoded by serializers as "IncorrectPaymentPurpose".
    /// </summary>
    [EnumMember(Value = "IN16")]
    [IsoId("_Y0fSctp-Ed-ak6NoX_4Aeg_-660282502")]
    [Description(@"Transaction payment purpose is incorrect.")]
    IncorrectPaymentPurpose,
    
    /// <summary>
    /// ChargeBearer is incorrect (former IncorrectDetailsOfCharges).
    /// Encoded/decoded by serializers as "IncorrectChargeBearer".
    /// </summary>
    [EnumMember(Value = "IN17")]
    [IsoId("_Y0fSc9p-Ed-ak6NoX_4Aeg_-660282501")]
    [Description(@"ChargeBearer is incorrect (former IncorrectDetailsOfCharges).")]
    IncorrectChargeBearer,
    
    /// <summary>
    /// Instruction for next agent is incorrect (former IncorrectSenderToReceiverInformation).
    /// Encoded/decoded by serializers as "IncorrectInstructionForNextAgent".
    /// </summary>
    [EnumMember(Value = "IN18")]
    [IsoId("_Y0fSdNp-Ed-ak6NoX_4Aeg_-660282492")]
    [Description(@"Instruction for next agent is incorrect (former IncorrectSenderToReceiverInformation).")]
    IncorrectInstructionForNextAgent,
    
    /// <summary>
    /// Instruction for creditor agent is incorrect (former IncorrectInstructionForFinalAgent).
    /// Encoded/decoded by serializers as "IncorrectInstructionForCreditorAgent".
    /// </summary>
    [EnumMember(Value = "IN19")]
    [IsoId("_Y0fSddp-Ed-ak6NoX_4Aeg_-660282471")]
    [Description(@"Instruction for creditor agent is incorrect (former IncorrectInstructionForFinalAgent).")]
    IncorrectInstructionForCreditorAgent,
    
    /// <summary>
    /// Name and account of creditor are not matching.
    /// Encoded/decoded by serializers as "MismatchCreditorNameAccount".
    /// </summary>
    [EnumMember(Value = "MM20")]
    [IsoId("_Y0fSdtp-Ed-ak6NoX_4Aeg_-660282470")]
    [Description(@"Name and account of creditor are not matching.")]
    MismatchCreditorNameAccount,
    
    /// <summary>
    /// Name and account of debtor are not matching.
    /// Encoded/decoded by serializers as "MismatchDebtorNameAccount".
    /// </summary>
    [EnumMember(Value = "MM21")]
    [IsoId("_Y0fSd9p-Ed-ak6NoX_4Aeg_-660282440")]
    [Description(@"Name and account of debtor are not matching.")]
    MismatchDebtorNameAccount,
    
    /// <summary>
    /// Name and account of creditor agent (former FinalAgent) are not matching.
    /// Encoded/decoded by serializers as "MismatchCreditorAgentNameAccount".
    /// </summary>
    [EnumMember(Value = "MM22")]
    [IsoId("_Y0fSeNp-Ed-ak6NoX_4Aeg_-660282439")]
    [Description(@"Name and account of creditor agent (former FinalAgent) are not matching.")]
    MismatchCreditorAgentNameAccount,
    
    /// <summary>
    /// Payment is pending execution. For reasons of regulatory requirements we request further information on the account number or unique identification of the debtor.
    /// Encoded/decoded by serializers as "PendingExecutionDebtorAccountOrIdentification".
    /// </summary>
    [EnumMember(Value = "MM25")]
    [IsoId("_Y0fSedp-Ed-ak6NoX_4Aeg_-608567221")]
    [Description(@"Payment is pending execution. For reasons of regulatory requirements we request further information on the account number or unique identification of the debtor.")]
    PendingExecutionDebtorAccountOrIdentification,
    
    /// <summary>
    /// Payment is pending execution. For reasons of regulatory requirements we request further information on the name and/or address of the debtor.
    /// Encoded/decoded by serializers as "PendingExecutionDebtorNameOrAddress".
    /// </summary>
    [EnumMember(Value = "MM26")]
    [IsoId("_Y0pDcNp-Ed-ak6NoX_4Aeg_-608567190")]
    [Description(@"Payment is pending execution. For reasons of regulatory requirements we request further information on the name and/or address of the debtor.")]
    PendingExecutionDebtorNameOrAddress,
    
    /// <summary>
    /// Payment has been executed. For reasons of regulatory requirements we request further information on the account number or unique identification of the debtor.
    /// Encoded/decoded by serializers as "PaymentExecutedDebtorAccountOrIdentification".
    /// </summary>
    [EnumMember(Value = "MM27")]
    [IsoId("_Y0pDcdp-Ed-ak6NoX_4Aeg_-608567159")]
    [Description(@"Payment has been executed. For reasons of regulatory requirements we request further information on the account number or unique identification of the debtor.")]
    PaymentExecutedDebtorAccountOrIdentification,
    
    /// <summary>
    /// Payment has been executed. For reasons of regulatory requirements we request further information on the name and/or address of the debtor.
    /// Encoded/decoded by serializers as "PaymentExecutedDebtorNameOrAddress".
    /// </summary>
    [EnumMember(Value = "MM28")]
    [IsoId("_Y0pDctp-Ed-ak6NoX_4Aeg_-608566888")]
    [Description(@"Payment has been executed. For reasons of regulatory requirements we request further information on the name and/or address of the debtor.")]
    PaymentExecutedDebtorNameOrAddress,
    
    /// <summary>
    /// Payment is pending execution. For reasons of regulatory requirements we request further information on the account number or unique identification of the creditor.
    /// Encoded/decoded by serializers as "PendingExecutionCreditorAccountOrIdentification".
    /// </summary>
    [EnumMember(Value = "MM29")]
    [IsoId("_Y0pDc9p-Ed-ak6NoX_4Aeg_-573472475")]
    [Description(@"Payment is pending execution. For reasons of regulatory requirements we request further information on the account number or unique identification of the creditor.")]
    PendingExecutionCreditorAccountOrIdentification,
    
    /// <summary>
    /// Payment is pending execution. For reasons of regulatory requirements we request further information on the name and/or address of the creditor.
    /// Encoded/decoded by serializers as "PendingExecutionCreditorNameOrAddress".
    /// </summary>
    [EnumMember(Value = "MM30")]
    [IsoId("_Y0pDdNp-Ed-ak6NoX_4Aeg_-573472444")]
    [Description(@"Payment is pending execution. For reasons of regulatory requirements we request further information on the name and/or address of the creditor.")]
    PendingExecutionCreditorNameOrAddress,
    
    /// <summary>
    /// Payment has been executed. For reasons of regulatory requirements we request further information on the account number or unique identification of the creditor.
    /// Encoded/decoded by serializers as "PaymentExecutedCreditorAccountOrIdentification".
    /// </summary>
    [EnumMember(Value = "MM31")]
    [IsoId("_Y0pDddp-Ed-ak6NoX_4Aeg_-573472413")]
    [Description(@"Payment has been executed. For reasons of regulatory requirements we request further information on the account number or unique identification of the creditor.")]
    PaymentExecutedCreditorAccountOrIdentification,
    
    /// <summary>
    /// Payment has been executed. For reasons of regulatory requirements we request further information on the name and/or address of the creditor.
    /// Encoded/decoded by serializers as "PaymentExecutedCreditorNameOrAddress".
    /// </summary>
    [EnumMember(Value = "MM32")]
    [IsoId("_Y0pDdtp-Ed-ak6NoX_4Aeg_-573472135")]
    [Description(@"Payment has been executed. For reasons of regulatory requirements we request further information on the name and/or address of the creditor.")]
    PaymentExecutedCreditorNameOrAddress,
    
    /// <summary>
    /// Amount in statement entry is incorrect.
    /// Encoded/decoded by serializers as "IncorrectReportEntryAmount".
    /// </summary>
    [EnumMember(Value = "IN33")]
    [IsoId("_Y0pDd9p-Ed-ak6NoX_4Aeg_1278533508")]
    [Description(@"Amount in statement entry is incorrect.")]
    IncorrectReportEntryAmount,
    
    /// <summary>
    /// Insufficient charges details provided.
    /// Encoded/decoded by serializers as "InsufficientChargesDetails".
    /// </summary>
    [EnumMember(Value = "MM34")]
    [IsoId("_Y0pDeNp-Ed-ak6NoX_4Aeg_1278533561")]
    [Description(@"Insufficient charges details provided.")]
    InsufficientChargesDetails,
    
    /// <summary>
    /// Payment purpose needs to be further specified.
    /// Encoded/decoded by serializers as "InsufficientPaymentPurpose".
    /// </summary>
    [EnumMember(Value = "MM35")]
    [IsoId("_Y0pDedp-Ed-ak6NoX_4Aeg_1278533592")]
    [Description(@"Payment purpose needs to be further specified.")]
    InsufficientPaymentPurpose,
    
    /// <summary>
    /// SettlementAccount is incorrect.
    /// Encoded/decoded by serializers as "IncorrectSettlementAccount".
    /// </summary>
    [EnumMember(Value = "IN36")]
    [IsoId("_Y0pDetp-Ed-ak6NoX_4Aeg_1278533653")]
    [Description(@"SettlementAccount is incorrect.")]
    IncorrectSettlementAccount,
    
    /// <summary>
    /// Instructing reimbursement agent is incorrect.
    /// Encoded/decoded by serializers as "IncorrectInstructingReimbursementAgent".
    /// </summary>
    [EnumMember(Value = "IN37")]
    [IsoId("_Y0yNYNp-Ed-ak6NoX_4Aeg_1149300637")]
    [Description(@"Instructing reimbursement agent is incorrect.")]
    IncorrectInstructingReimbursementAgent,
    
    /// <summary>
    /// Debtor's address is incorrect.
    /// Encoded/decoded by serializers as "IncorrectDebtorAddress".
    /// </summary>
    [EnumMember(Value = "IN38")]
    [IsoId("_Y0yNYdp-Ed-ak6NoX_4Aeg_-1115296674")]
    [Description(@"Debtor's address is incorrect.")]
    IncorrectDebtorAddress,
    
    /// <summary>
    /// Creditor's address is incorrect.
    /// Encoded/decoded by serializers as "IncorrectCreditorAddress".
    /// </summary>
    [EnumMember(Value = "IN39")]
    [IsoId("_Y0yNYtp-Ed-ak6NoX_4Aeg_-1115296644")]
    [Description(@"Creditor's address is incorrect.")]
    IncorrectCreditorAddress,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class UnableToApplyIncorrectInformation3CodeMetadataExtensions
{
    private static readonly UnableToApplyIncorrectInformation3CodeDropdownSource _dropdownSource = new UnableToApplyIncorrectInformation3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IUnableToApplyIncorrectInformation3CodeDropdownRow GetMetadata(this UnableToApplyIncorrectInformation3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


