﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UnableToApplyIncorrectInformation4Code.  ISO2002 ID# _hRURCEgsEeaGKYpLDboHPQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason of an unable to apply due to incorrect information.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hRURCEgsEeaGKYpLDboHPQ")]
[Description(@"Specifies the reason of an unable to apply due to incorrect information.")]
[DerivedFrom(typeof(UnableToApplyIncorrectInformationV2Code))]
public enum UnableToApplyIncorrectInformation4Code
{
    /// <summary>
    /// Related transaction reference is incorrect.
    /// Encoded/decoded by serializers as "IN01".
    /// </summary>
    [EnumMember(Value = "IN01")]
    [IsoId("_hRURIUgsEeaGKYpLDboHPQ")]
    [Description(@"Related transaction reference is incorrect.")]
    IncorrectRelatedReference = UnableToApplyIncorrectInformationV2Code.IncorrectRelatedReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment type service level is incorrect (former IncorrectBankOperationCode).
    /// Encoded/decoded by serializers as "IN02".
    /// </summary>
    [EnumMember(Value = "IN02")]
    [IsoId("_hRURIEgsEeaGKYpLDboHPQ")]
    [Description(@"Payment type service level is incorrect (former IncorrectBankOperationCode).")]
    IncorrectPaymentServiceLevel = UnableToApplyIncorrectInformationV2Code.IncorrectPaymentServiceLevel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment type category purpose is incorrect (former IncorrectInstructionCode).
    /// Encoded/decoded by serializers as "IN03".
    /// </summary>
    [EnumMember(Value = "IN03")]
    [IsoId("_hRURCUgsEeaGKYpLDboHPQ")]
    [Description(@"Payment type category purpose is incorrect (former IncorrectInstructionCode).")]
    IncorrectCategoryPurpose = UnableToApplyIncorrectInformationV2Code.IncorrectCategoryPurpose, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// RequestedExecutionDate is incorrect.
    /// Encoded/decoded by serializers as "IN04".
    /// </summary>
    [EnumMember(Value = "IN04")]
    [IsoId("_hRURGEgsEeaGKYpLDboHPQ")]
    [Description(@"RequestedExecutionDate is incorrect.")]
    IncorrectRequestedExecutionDate = UnableToApplyIncorrectInformationV2Code.IncorrectRequestedExecutionDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Interbank settlement date is incorrect (former IncorrectValueDate).
    /// Encoded/decoded by serializers as "IN05".
    /// </summary>
    [EnumMember(Value = "IN05")]
    [IsoId("_hRURJkgsEeaGKYpLDboHPQ")]
    [Description(@"Interbank settlement date is incorrect (former IncorrectValueDate).")]
    IncorrectInterbankSettlementDate = UnableToApplyIncorrectInformationV2Code.IncorrectInterbankSettlementDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Interbank settlement amount is incorrect (former IncorrectSettledAmount).
    /// Encoded/decoded by serializers as "IN06".
    /// </summary>
    [EnumMember(Value = "IN06")]
    [IsoId("_hRURI0gsEeaGKYpLDboHPQ")]
    [Description(@"Interbank settlement amount is incorrect (former IncorrectSettledAmount).")]
    IncorrectInterbankSettlementAmount = UnableToApplyIncorrectInformationV2Code.IncorrectInterbankSettlementAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor is incorrect.
    /// Encoded/decoded by serializers as "IN07".
    /// </summary>
    [EnumMember(Value = "IN07")]
    [IsoId("_hRURJUgsEeaGKYpLDboHPQ")]
    [Description(@"Debtor is incorrect.")]
    IncorrectDebtor = UnableToApplyIncorrectInformationV2Code.IncorrectDebtor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DebtorAccount is incorrect.
    /// Encoded/decoded by serializers as "IN08".
    /// </summary>
    [EnumMember(Value = "IN08")]
    [IsoId("_hRURLUgsEeaGKYpLDboHPQ")]
    [Description(@"DebtorAccount is incorrect.")]
    IncorrectDebtorAccount = UnableToApplyIncorrectInformationV2Code.IncorrectDebtorAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// InstructedReimbursementAgent is incorrect (former IncorrectReceiverCorrespondent).
    /// Encoded/decoded by serializers as "IN09".
    /// </summary>
    [EnumMember(Value = "IN09")]
    [IsoId("_hRURFEgsEeaGKYpLDboHPQ")]
    [Description(@"InstructedReimbursementAgent is incorrect (former IncorrectReceiverCorrespondent).")]
    IncorrectInstructedReimbursementAgent = UnableToApplyIncorrectInformationV2Code.IncorrectInstructedReimbursementAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// ThirdReimbursementAgent is incorrect (former IncorrectThirdReimbursementInstitution).
    /// Encoded/decoded by serializers as "IN10".
    /// </summary>
    [EnumMember(Value = "IN10")]
    [IsoId("_hRURK0gsEeaGKYpLDboHPQ")]
    [Description(@"ThirdReimbursementAgent is incorrect (former IncorrectThirdReimbursementInstitution).")]
    IncorrectThirdReimbursementAgent = UnableToApplyIncorrectInformationV2Code.IncorrectThirdReimbursementAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment type clearing channel is incorrect (former PaymentScheme).
    /// Encoded/decoded by serializers as "IN11".
    /// </summary>
    [EnumMember(Value = "IN11")]
    [IsoId("_hRURLEgsEeaGKYpLDboHPQ")]
    [Description(@"Payment type clearing channel is incorrect (former PaymentScheme).")]
    IncorrectPaymentClearingChannel = UnableToApplyIncorrectInformationV2Code.IncorrectPaymentClearingChannel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// CreditorAgentAccount is incorrect (former IncorrectAccountOfBeneficiaryInstitution).
    /// Encoded/decoded by serializers as "IN12".
    /// </summary>
    [EnumMember(Value = "IN12")]
    [IsoId("_hRURDUgsEeaGKYpLDboHPQ")]
    [Description(@"CreditorAgentAccount is incorrect (former IncorrectAccountOfBeneficiaryInstitution).")]
    IncorrectCreditorAgentAccount = UnableToApplyIncorrectInformationV2Code.IncorrectCreditorAgentAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor is incorrect.
    /// Encoded/decoded by serializers as "IN13".
    /// </summary>
    [EnumMember(Value = "IN13")]
    [IsoId("_hRURG0gsEeaGKYpLDboHPQ")]
    [Description(@"Creditor is incorrect.")]
    IncorrectCreditor = UnableToApplyIncorrectInformationV2Code.IncorrectCreditor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor account is incorrect.
    /// Encoded/decoded by serializers as "IN14".
    /// </summary>
    [EnumMember(Value = "IN14")]
    [IsoId("_hRURF0gsEeaGKYpLDboHPQ")]
    [Description(@"Creditor account is incorrect.")]
    IncorrectCreditorAccount = UnableToApplyIncorrectInformationV2Code.IncorrectCreditorAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// RemittanceInformation is incorrect.
    /// Encoded/decoded by serializers as "IN15".
    /// </summary>
    [EnumMember(Value = "IN15")]
    [IsoId("_hRURKUgsEeaGKYpLDboHPQ")]
    [Description(@"RemittanceInformation is incorrect.")]
    IncorrectRemittanceInformation = UnableToApplyIncorrectInformationV2Code.IncorrectRemittanceInformation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction payment purpose is incorrect.
    /// Encoded/decoded by serializers as "IN16".
    /// </summary>
    [EnumMember(Value = "IN16")]
    [IsoId("_hRURCkgsEeaGKYpLDboHPQ")]
    [Description(@"Transaction payment purpose is incorrect.")]
    IncorrectPaymentPurpose = UnableToApplyIncorrectInformationV2Code.IncorrectPaymentPurpose, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// ChargeBearer is incorrect (former IncorrectDetailsOfCharges).
    /// Encoded/decoded by serializers as "IN17".
    /// </summary>
    [EnumMember(Value = "IN17")]
    [IsoId("_hRURHUgsEeaGKYpLDboHPQ")]
    [Description(@"ChargeBearer is incorrect (former IncorrectDetailsOfCharges).")]
    IncorrectChargeBearer = UnableToApplyIncorrectInformationV2Code.IncorrectChargeBearer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction for next agent is incorrect (former IncorrectSenderToReceiverInformation).
    /// Encoded/decoded by serializers as "IN18".
    /// </summary>
    [EnumMember(Value = "IN18")]
    [IsoId("_hRURDkgsEeaGKYpLDboHPQ")]
    [Description(@"Instruction for next agent is incorrect (former IncorrectSenderToReceiverInformation).")]
    IncorrectInstructionForNextAgent = UnableToApplyIncorrectInformationV2Code.IncorrectInstructionForNextAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction for creditor agent is incorrect (former IncorrectInstructionForFinalAgent).
    /// Encoded/decoded by serializers as "IN19".
    /// </summary>
    [EnumMember(Value = "IN19")]
    [IsoId("_hRURE0gsEeaGKYpLDboHPQ")]
    [Description(@"Instruction for creditor agent is incorrect (former IncorrectInstructionForFinalAgent).")]
    IncorrectInstructionForCreditorAgent = UnableToApplyIncorrectInformationV2Code.IncorrectInstructionForCreditorAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Name and account of creditor are not matching.
    /// Encoded/decoded by serializers as "MM20".
    /// </summary>
    [EnumMember(Value = "MM20")]
    [IsoId("_hRURH0gsEeaGKYpLDboHPQ")]
    [Description(@"Name and account of creditor are not matching.")]
    MismatchCreditorNameAccount = UnableToApplyIncorrectInformationV2Code.MismatchCreditorNameAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Name and account of debtor are not matching.
    /// Encoded/decoded by serializers as "MM21".
    /// </summary>
    [EnumMember(Value = "MM21")]
    [IsoId("_hRURC0gsEeaGKYpLDboHPQ")]
    [Description(@"Name and account of debtor are not matching.")]
    MismatchDebtorNameAccount = UnableToApplyIncorrectInformationV2Code.MismatchDebtorNameAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Name and account of creditor agent (former FinalAgent) are not matching.
    /// Encoded/decoded by serializers as "MM22".
    /// </summary>
    [EnumMember(Value = "MM22")]
    [IsoId("_hRUREEgsEeaGKYpLDboHPQ")]
    [Description(@"Name and account of creditor agent (former FinalAgent) are not matching.")]
    MismatchCreditorAgentNameAccount = UnableToApplyIncorrectInformationV2Code.MismatchCreditorAgentNameAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is pending execution. For reasons of regulatory requirements we request further information on the account number or unique identification of the debtor.
    /// Encoded/decoded by serializers as "MM25".
    /// </summary>
    [EnumMember(Value = "MM25")]
    [IsoId("_hRURKkgsEeaGKYpLDboHPQ")]
    [Description(@"Payment is pending execution. For reasons of regulatory requirements we request further information on the account number or unique identification of the debtor.")]
    PendingExecutionDebtorAccountOrIdentification = UnableToApplyIncorrectInformationV2Code.PendingExecutionDebtorAccountOrIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is pending execution. For reasons of regulatory requirements we request further information on the name and/or address of the debtor.
    /// Encoded/decoded by serializers as "MM26".
    /// </summary>
    [EnumMember(Value = "MM26")]
    [IsoId("_hRURD0gsEeaGKYpLDboHPQ")]
    [Description(@"Payment is pending execution. For reasons of regulatory requirements we request further information on the name and/or address of the debtor.")]
    PendingExecutionDebtorNameOrAddress = UnableToApplyIncorrectInformationV2Code.PendingExecutionDebtorNameOrAddress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment has been executed. For reasons of regulatory requirements we request further information on the account number or unique identification of the debtor.
    /// Encoded/decoded by serializers as "MM27".
    /// </summary>
    [EnumMember(Value = "MM27")]
    [IsoId("_hRUREkgsEeaGKYpLDboHPQ")]
    [Description(@"Payment has been executed. For reasons of regulatory requirements we request further information on the account number or unique identification of the debtor.")]
    PaymentExecutedDebtorAccountOrIdentification = UnableToApplyIncorrectInformationV2Code.PaymentExecutedDebtorAccountOrIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment has been executed. For reasons of regulatory requirements we request further information on the name and/or address of the debtor.
    /// Encoded/decoded by serializers as "MM28".
    /// </summary>
    [EnumMember(Value = "MM28")]
    [IsoId("_hRURGkgsEeaGKYpLDboHPQ")]
    [Description(@"Payment has been executed. For reasons of regulatory requirements we request further information on the name and/or address of the debtor.")]
    PaymentExecutedDebtorNameOrAddress = UnableToApplyIncorrectInformationV2Code.PaymentExecutedDebtorNameOrAddress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is pending execution. For reasons of regulatory requirements we request further information on the account number or unique identification of the creditor.
    /// Encoded/decoded by serializers as "MM29".
    /// </summary>
    [EnumMember(Value = "MM29")]
    [IsoId("_hRURHEgsEeaGKYpLDboHPQ")]
    [Description(@"Payment is pending execution. For reasons of regulatory requirements we request further information on the account number or unique identification of the creditor.")]
    PendingExecutionCreditorAccountOrIdentification = UnableToApplyIncorrectInformationV2Code.PendingExecutionCreditorAccountOrIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is pending execution. For reasons of regulatory requirements we request further information on the name and/or address of the creditor.
    /// Encoded/decoded by serializers as "MM30".
    /// </summary>
    [EnumMember(Value = "MM30")]
    [IsoId("_hRURJEgsEeaGKYpLDboHPQ")]
    [Description(@"Payment is pending execution. For reasons of regulatory requirements we request further information on the name and/or address of the creditor.")]
    PendingExecutionCreditorNameOrAddress = UnableToApplyIncorrectInformationV2Code.PendingExecutionCreditorNameOrAddress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment has been executed. For reasons of regulatory requirements we request further information on the account number or unique identification of the creditor.
    /// Encoded/decoded by serializers as "MM31".
    /// </summary>
    [EnumMember(Value = "MM31")]
    [IsoId("_hRURJ0gsEeaGKYpLDboHPQ")]
    [Description(@"Payment has been executed. For reasons of regulatory requirements we request further information on the account number or unique identification of the creditor.")]
    PaymentExecutedCreditorAccountOrIdentification = UnableToApplyIncorrectInformationV2Code.PaymentExecutedCreditorAccountOrIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment has been executed. For reasons of regulatory requirements we request further information on the name and/or address of the creditor.
    /// Encoded/decoded by serializers as "MM32".
    /// </summary>
    [EnumMember(Value = "MM32")]
    [IsoId("_hRUREUgsEeaGKYpLDboHPQ")]
    [Description(@"Payment has been executed. For reasons of regulatory requirements we request further information on the name and/or address of the creditor.")]
    PaymentExecutedCreditorNameOrAddress = UnableToApplyIncorrectInformationV2Code.PaymentExecutedCreditorNameOrAddress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount in statement entry is incorrect.
    /// Encoded/decoded by serializers as "IN33".
    /// </summary>
    [EnumMember(Value = "IN33")]
    [IsoId("_hRURGUgsEeaGKYpLDboHPQ")]
    [Description(@"Amount in statement entry is incorrect.")]
    IncorrectReportEntryAmount = UnableToApplyIncorrectInformationV2Code.IncorrectReportEntryAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient charges details provided.
    /// Encoded/decoded by serializers as "MM34".
    /// </summary>
    [EnumMember(Value = "MM34")]
    [IsoId("_hRURFkgsEeaGKYpLDboHPQ")]
    [Description(@"Insufficient charges details provided.")]
    InsufficientChargesDetails = UnableToApplyIncorrectInformationV2Code.InsufficientChargesDetails, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment purpose needs to be further specified.
    /// Encoded/decoded by serializers as "MM35".
    /// </summary>
    [EnumMember(Value = "MM35")]
    [IsoId("_hRURKEgsEeaGKYpLDboHPQ")]
    [Description(@"Payment purpose needs to be further specified.")]
    InsufficientPaymentPurpose = UnableToApplyIncorrectInformationV2Code.InsufficientPaymentPurpose, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// SettlementAccount is incorrect.
    /// Encoded/decoded by serializers as "IN36".
    /// </summary>
    [EnumMember(Value = "IN36")]
    [IsoId("_hRURDEgsEeaGKYpLDboHPQ")]
    [Description(@"SettlementAccount is incorrect.")]
    IncorrectSettlementAccount = UnableToApplyIncorrectInformationV2Code.IncorrectSettlementAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instructing reimbursement agent is incorrect.
    /// Encoded/decoded by serializers as "IN37".
    /// </summary>
    [EnumMember(Value = "IN37")]
    [IsoId("_hRURHkgsEeaGKYpLDboHPQ")]
    [Description(@"Instructing reimbursement agent is incorrect.")]
    IncorrectInstructingReimbursementAgent = UnableToApplyIncorrectInformationV2Code.IncorrectInstructingReimbursementAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor's address is incorrect.
    /// Encoded/decoded by serializers as "IN38".
    /// </summary>
    [EnumMember(Value = "IN38")]
    [IsoId("_hRURFUgsEeaGKYpLDboHPQ")]
    [Description(@"Debtor's address is incorrect.")]
    IncorrectDebtorAddress = UnableToApplyIncorrectInformationV2Code.IncorrectDebtorAddress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor's address is incorrect.
    /// Encoded/decoded by serializers as "IN39".
    /// </summary>
    [EnumMember(Value = "IN39")]
    [IsoId("_hRURIkgsEeaGKYpLDboHPQ")]
    [Description(@"Creditor's address is incorrect.")]
    IncorrectCreditorAddress = UnableToApplyIncorrectInformationV2Code.IncorrectCreditorAddress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// See narrative field for additional information.
    /// Encoded/decoded by serializers as "NARR".
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_EY6FoUgtEeaGKYpLDboHPQ")]
    [Description(@"See narrative field for additional information.")]
    Narrative = UnableToApplyIncorrectInformationV2Code.Narrative, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class UnableToApplyIncorrectInformation4CodeMetadataExtensions
{
    private static readonly UnableToApplyIncorrectInformation4CodeDropdownSource _dropdownSource = new UnableToApplyIncorrectInformation4CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IUnableToApplyIncorrectInformation4CodeDropdownRow GetMetadata(this UnableToApplyIncorrectInformation4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


