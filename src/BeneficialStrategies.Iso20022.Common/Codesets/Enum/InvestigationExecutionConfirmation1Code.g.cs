﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InvestigationExecutionConfirmation1Code.  ISO2002 ID# _VnJzxtp-Ed-ak6NoX_4Aeg_804338895.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the result of an investigation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VnJzxtp-Ed-ak6NoX_4Aeg_804338895")]
[Description(@"Indicates the result of an investigation.")]
[DerivedFrom(typeof(InvestigationExecutionConfirmationCode))]
public enum InvestigationExecutionConfirmation1Code
{
    /// <summary>
    /// Used when a requested cancellation is successful.
    /// Encoded/decoded by serializers as "CancelledAsPerRequest".
    /// </summary>
    [EnumMember(Value = "CNCL")]
    [IsoId("_VnJzx9p-Ed-ak6NoX_4Aeg_-2046947598")]
    [Description(@"Used when a requested cancellation is successful.")]
    CancelledAsPerRequest,
    
    /// <summary>
    /// Used when a requested modification is successful.
    /// Encoded/decoded by serializers as "ModifiedAsPerRequest".
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_VnTkwNp-Ed-ak6NoX_4Aeg_707009024")]
    [Description(@"Used when a requested modification is successful.")]
    ModifiedAsPerRequest,
    
    /// <summary>
    /// Used when a creditor accepts the debit authorisation.
    /// Encoded/decoded by serializers as "AcceptedDebitAuthorisation".
    /// </summary>
    [EnumMember(Value = "ACDA")]
    [IsoId("_VnTkwdp-Ed-ak6NoX_4Aeg_-339444773")]
    [Description(@"Used when a creditor accepts the debit authorisation.")]
    AcceptedDebitAuthorisation,
    
    /// <summary>
    /// Used when the result of an investigation is, or will be, the initiation of a payment instruction.
    /// Encoded/decoded by serializers as "PaymentInitiated".
    /// </summary>
    [EnumMember(Value = "IPAY")]
    [IsoId("_VnTkwtp-Ed-ak6NoX_4Aeg_873569556")]
    [Description(@"Used when the result of an investigation is, or will be, the initiation of a payment instruction.")]
    PaymentInitiated,
    
    /// <summary>
    /// Used when a transfer of funds has been initiated (a cover payment) to resolve a case.
    /// Encoded/decoded by serializers as "CoverInitiated".
    /// </summary>
    [EnumMember(Value = "ICOV")]
    [IsoId("_VnTkw9p-Ed-ak6NoX_4Aeg_1763240392")]
    [Description(@"Used when a transfer of funds has been initiated (a cover payment) to resolve a case.")]
    CoverInitiated,
    
    /// <summary>
    /// Used when a transfer of funds has been modified (a cover payment) to resolve a case.
    /// Encoded/decoded by serializers as "CoverModified".
    /// </summary>
    [EnumMember(Value = "MCOV")]
    [IsoId("_VnTkxNp-Ed-ak6NoX_4Aeg_306413424")]
    [Description(@"Used when a transfer of funds has been modified (a cover payment) to resolve a case.")]
    CoverModified,
    
    /// <summary>
    /// Used when a payment instruction (eg. MT103) has been initiated to resolve a case.
    /// Encoded/decoded by serializers as "PaymentInstructionInitiated".
    /// </summary>
    [EnumMember(Value = "IPYI")]
    [IsoId("_VnTkxdp-Ed-ak6NoX_4Aeg_-2074584448")]
    [Description(@"Used when a payment instruction (eg. MT103) has been initiated to resolve a case.")]
    PaymentInstructionInitiated,
    
    /// <summary>
    /// Used when additional information has been sent to the beneficiary of a payment.
    /// Encoded/decoded by serializers as "AdditionalInformationSent".
    /// </summary>
    [EnumMember(Value = "INFO")]
    [IsoId("_VnTkxtp-Ed-ak6NoX_4Aeg_1186128186")]
    [Description(@"Used when additional information has been sent to the beneficiary of a payment.")]
    AdditionalInformationSent,
    
    /// <summary>
    /// Used when a payment has been checked and was correctly executed without any intervention.
    /// Encoded/decoded by serializers as "ConfirmationOfPayment".
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_VncusNp-Ed-ak6NoX_4Aeg_-1993347823")]
    [Description(@"Used when a payment has been checked and was correctly executed without any intervention.")]
    ConfirmationOfPayment,
    
    /// <summary>
    /// Used when a payment will be cancelled to solve an investigation case.
    /// Encoded/decoded by serializers as "CancellationWillFollow".
    /// </summary>
    [EnumMember(Value = "CWFW")]
    [IsoId("_Vncusdp-Ed-ak6NoX_4Aeg_1747345458")]
    [Description(@"Used when a payment will be cancelled to solve an investigation case.")]
    CancellationWillFollow,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InvestigationExecutionConfirmation1CodeMetadataExtensions
{
    private static readonly InvestigationExecutionConfirmation1CodeDropdownSource _dropdownSource = new InvestigationExecutionConfirmation1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInvestigationExecutionConfirmation1CodeDropdownRow GetMetadata(this InvestigationExecutionConfirmation1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


