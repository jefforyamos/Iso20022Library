﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UnableToApplyIncorrectInfo1Code.  ISO2002 ID# _Vncustp-Ed-ak6NoX_4Aeg_1226420909.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Used when the unable to apply is due to incorrect information.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vncustp-Ed-ak6NoX_4Aeg_1226420909")]
[Description(@"Used when the unable to apply is due to incorrect information.")]
[DerivedFrom(typeof(UnableToApplyIncorrectInfoCode))]
public enum UnableToApplyIncorrectInfo1Code
{
    /// <summary>
    /// RelatedReference is incorrect.
    /// Encoded/decoded by serializers as "IncorrectRelatedReference".
    /// </summary>
    [EnumMember(Value = "IN01")]
    [IsoId("_Vncus9p-Ed-ak6NoX_4Aeg_-121794033")]
    [Description(@"RelatedReference is incorrect.")]
    IncorrectRelatedReference,
    
    /// <summary>
    /// BankOperationCode is incorrect.
    /// Encoded/decoded by serializers as "IncorrectBankOperationCode".
    /// </summary>
    [EnumMember(Value = "IN02")]
    [IsoId("_VncutNp-Ed-ak6NoX_4Aeg_-121793700")]
    [Description(@"BankOperationCode is incorrect.")]
    IncorrectBankOperationCode,
    
    /// <summary>
    /// InstructionCode is incorrect.
    /// Encoded/decoded by serializers as "IncorrectInstructionCode".
    /// </summary>
    [EnumMember(Value = "IN03")]
    [IsoId("_Vncutdp-Ed-ak6NoX_4Aeg_-121793665")]
    [Description(@"InstructionCode is incorrect.")]
    IncorrectInstructionCode,
    
    /// <summary>
    /// RequestedExecutionDate is incorrect.
    /// Encoded/decoded by serializers as "IncorrectRequestedExecutionDate".
    /// </summary>
    [EnumMember(Value = "IN04")]
    [IsoId("_Vncuttp-Ed-ak6NoX_4Aeg_-121793630")]
    [Description(@"RequestedExecutionDate is incorrect.")]
    IncorrectRequestedExecutionDate,
    
    /// <summary>
    /// ValueDate is incorrect.
    /// Encoded/decoded by serializers as "IncorrectValueDate".
    /// </summary>
    [EnumMember(Value = "IN05")]
    [IsoId("_Vncut9p-Ed-ak6NoX_4Aeg_-121793588")]
    [Description(@"ValueDate is incorrect.")]
    IncorrectValueDate,
    
    /// <summary>
    /// InterbankSettledAmount is incorrect.
    /// Encoded/decoded by serializers as "IncorrectInterbankSettledAmount".
    /// </summary>
    [EnumMember(Value = "IN06")]
    [IsoId("_VncuuNp-Ed-ak6NoX_4Aeg_-121793570")]
    [Description(@"InterbankSettledAmount is incorrect.")]
    IncorrectInterbankSettledAmount,
    
    /// <summary>
    /// Debtor is incorrect.
    /// Encoded/decoded by serializers as "IncorrectDebtor".
    /// </summary>
    [EnumMember(Value = "IN07")]
    [IsoId("_VnmfsNp-Ed-ak6NoX_4Aeg_-121793528")]
    [Description(@"Debtor is incorrect.")]
    IncorrectDebtor,
    
    /// <summary>
    /// DebtorAccount is incorrect.
    /// Encoded/decoded by serializers as "IncorrectDebtorAccount".
    /// </summary>
    [EnumMember(Value = "IN08")]
    [IsoId("_Vnmfsdp-Ed-ak6NoX_4Aeg_-121793493")]
    [Description(@"DebtorAccount is incorrect.")]
    IncorrectDebtorAccount,
    
    /// <summary>
    /// ReceiverCorrespondent is incorrect.
    /// Encoded/decoded by serializers as "IncorrectReceiverCorrespondent".
    /// </summary>
    [EnumMember(Value = "IN09")]
    [IsoId("_Vnmfstp-Ed-ak6NoX_4Aeg_-121793233")]
    [Description(@"ReceiverCorrespondent is incorrect.")]
    IncorrectReceiverCorrespondent,
    
    /// <summary>
    /// ThirdReimbursementInstitution is incorrect.
    /// Encoded/decoded by serializers as "IncorrectThirdReimbursementInstitution".
    /// </summary>
    [EnumMember(Value = "IN10")]
    [IsoId("_Vnmfs9p-Ed-ak6NoX_4Aeg_-121793198")]
    [Description(@"ThirdReimbursementInstitution is incorrect.")]
    IncorrectThirdReimbursementInstitution,
    
    /// <summary>
    /// PaymentScheme is incorrect.
    /// Encoded/decoded by serializers as "IncorrectPaymentScheme".
    /// </summary>
    [EnumMember(Value = "IN11")]
    [IsoId("_VnmftNp-Ed-ak6NoX_4Aeg_-121793156")]
    [Description(@"PaymentScheme is incorrect.")]
    IncorrectPaymentScheme,
    
    /// <summary>
    /// AccountOfBeneficiaryInstitution is incorrect.
    /// Encoded/decoded by serializers as "IncorrectAccountOfBeneficiaryInstitution".
    /// </summary>
    [EnumMember(Value = "IN12")]
    [IsoId("_Vnmftdp-Ed-ak6NoX_4Aeg_-121793121")]
    [Description(@"AccountOfBeneficiaryInstitution is incorrect.")]
    IncorrectAccountOfBeneficiaryInstitution,
    
    /// <summary>
    /// Creditor is incorrect.
    /// Encoded/decoded by serializers as "IncorrectCreditor".
    /// </summary>
    [EnumMember(Value = "IN13")]
    [IsoId("_Vnmfttp-Ed-ak6NoX_4Aeg_-121793078")]
    [Description(@"Creditor is incorrect.")]
    IncorrectCreditor,
    
    /// <summary>
    /// CreditorAccount is incorrect.
    /// Encoded/decoded by serializers as "IncorrectCreditorAccount".
    /// </summary>
    [EnumMember(Value = "IN14")]
    [IsoId("_Vnmft9p-Ed-ak6NoX_4Aeg_-121792795")]
    [Description(@"CreditorAccount is incorrect.")]
    IncorrectCreditorAccount,
    
    /// <summary>
    /// RemittanceInformation is incorrect.
    /// Encoded/decoded by serializers as "IncorrectRemittanceInformation".
    /// </summary>
    [EnumMember(Value = "IN15")]
    [IsoId("_VnmfuNp-Ed-ak6NoX_4Aeg_-121792734")]
    [Description(@"RemittanceInformation is incorrect.")]
    IncorrectRemittanceInformation,
    
    /// <summary>
    /// PaymentPurpose is incorrect.
    /// Encoded/decoded by serializers as "IncorrectPaymentPurpose".
    /// </summary>
    [EnumMember(Value = "IN16")]
    [IsoId("_Vnmfudp-Ed-ak6NoX_4Aeg_-121792614")]
    [Description(@"PaymentPurpose is incorrect.")]
    IncorrectPaymentPurpose,
    
    /// <summary>
    /// DetailsOfCharges is incorrect.
    /// Encoded/decoded by serializers as "IncorrectDetailsOfCharges".
    /// </summary>
    [EnumMember(Value = "IN17")]
    [IsoId("_VnvpoNp-Ed-ak6NoX_4Aeg_-121792579")]
    [Description(@"DetailsOfCharges is incorrect.")]
    IncorrectDetailsOfCharges,
    
    /// <summary>
    /// SenderToReceiverInformation is incorrect.
    /// Encoded/decoded by serializers as "IncorrectSenderToReceiverInformation".
    /// </summary>
    [EnumMember(Value = "IN18")]
    [IsoId("_Vnvpodp-Ed-ak6NoX_4Aeg_-121792519")]
    [Description(@"SenderToReceiverInformation is incorrect.")]
    IncorrectSenderToReceiverInformation,
    
    /// <summary>
    /// InstructionForFinalAgent is incorrect.
    /// Encoded/decoded by serializers as "IncorrectInstructionForFinalAgent".
    /// </summary>
    [EnumMember(Value = "IN19")]
    [IsoId("_Vnvpotp-Ed-ak6NoX_4Aeg_-121792267")]
    [Description(@"InstructionForFinalAgent is incorrect.")]
    IncorrectInstructionForFinalAgent,
    
    /// <summary>
    /// Name and Account of Creditor mismatched.
    /// Encoded/decoded by serializers as "MismatchCreditorNameAccount".
    /// </summary>
    [EnumMember(Value = "MM20")]
    [IsoId("_Vnvpo9p-Ed-ak6NoX_4Aeg_1717924661")]
    [Description(@"Name and Account of Creditor mismatched.")]
    MismatchCreditorNameAccount,
    
    /// <summary>
    /// Name and Account of Debtor mismatched.
    /// Encoded/decoded by serializers as "MismatchDebtorNameAccount".
    /// </summary>
    [EnumMember(Value = "MM21")]
    [IsoId("_VnvppNp-Ed-ak6NoX_4Aeg_1807504359")]
    [Description(@"Name and Account of Debtor mismatched.")]
    MismatchDebtorNameAccount,
    
    /// <summary>
    /// Name and Account of FinalAgent mismatched.
    /// Encoded/decoded by serializers as "MismatchFinalAgentNameAccount".
    /// </summary>
    [EnumMember(Value = "MM22")]
    [IsoId("_Vnvppdp-Ed-ak6NoX_4Aeg_1849988214")]
    [Description(@"Name and Account of FinalAgent mismatched.")]
    MismatchFinalAgentNameAccount,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class UnableToApplyIncorrectInfo1CodeMetadataExtensions
{
    private static readonly UnableToApplyIncorrectInfo1CodeDropdownSource _dropdownSource = new UnableToApplyIncorrectInfo1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IUnableToApplyIncorrectInfo1CodeDropdownRow GetMetadata(this UnableToApplyIncorrectInfo1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


