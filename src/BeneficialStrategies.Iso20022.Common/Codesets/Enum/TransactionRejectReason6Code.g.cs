﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransactionRejectReason6Code.  ISO2002 ID# _VxSAINp-Ed-ak6NoX_4Aeg_1027067779.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a transaction to be rejected or returned by an instructed agent or somebody acting on behalf of an instructed agent.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VxSAINp-Ed-ak6NoX_4Aeg_1027067779")]
[Description(@"Specifies the reason for a transaction to be rejected or returned by an instructed agent or somebody acting on behalf of an instructed agent.")]
[DerivedFrom(typeof(TransactionReasonCode))]
public enum TransactionRejectReason6Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IncorrectAccountNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VxSAIdp-Ed-ak6NoX_4Aeg_1027067810")]
    [Description(@"??")]
    IncorrectAccountNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ClosedAccountNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VxSAItp-Ed-ak6NoX_4Aeg_1027067811")]
    [Description(@"??")]
    ClosedAccountNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BlockedAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VxSAI9p-Ed-ak6NoX_4Aeg_1027067841")]
    [Description(@"??")]
    BlockedAccount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TransactionForbidden".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VxSAJNp-Ed-ak6NoX_4Aeg_1027067842")]
    [Description(@"??")]
    TransactionForbidden,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidBankOperationCode".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VxSAJdp-Ed-ak6NoX_4Aeg_1027067871")]
    [Description(@"??")]
    InvalidBankOperationCode,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InsufficientFunds".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VxSAJtp-Ed-ak6NoX_4Aeg_1027067872")]
    [Description(@"??")]
    InsufficientFunds,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Duplication".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VxSAJ9p-Ed-ak6NoX_4Aeg_1027067902")]
    [Description(@"??")]
    Duplication,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NoMandate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VxSAKNp-Ed-ak6NoX_4Aeg_1027068149")]
    [Description(@"??")]
    NoMandate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MissingMandatoryInformationInMandate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VxSAKdp-Ed-ak6NoX_4Aeg_1027068150")]
    [Description(@"??")]
    MissingMandatoryInformationInMandate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InvalidFileFormatForOtherReasonThanGroupingIndicator".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VxbxINp-Ed-ak6NoX_4Aeg_1027068180")]
    [Description(@"??")]
    InvalidFileFormatForOtherReasonThanGroupingIndicator,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BankIdentifierIncorrect".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VxbxIdp-Ed-ak6NoX_4Aeg_1027068181")]
    [Description(@"??")]
    BankIdentifierIncorrect,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EndCustomerDeceased".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VxbxItp-Ed-ak6NoX_4Aeg_1027068211")]
    [Description(@"??")]
    EndCustomerDeceased,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NotSpecifiedReasonCustomerGenerated".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VxbxI9p-Ed-ak6NoX_4Aeg_1700958883")]
    [Description(@"??")]
    NotSpecifiedReasonCustomerGenerated,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NotSpecifiedReasonAgentGenerated".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VxbxJNp-Ed-ak6NoX_4Aeg_1027068212")]
    [Description(@"??")]
    NotSpecifiedReasonAgentGenerated,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CutOffTime".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VxbxJdp-Ed-ak6NoX_4Aeg_1027068241")]
    [Description(@"??")]
    CutOffTime,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransactionRejectReason6CodeMetadataExtensions
{
    private static readonly TransactionRejectReason6CodeDropdownSource _dropdownSource = new TransactionRejectReason6CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransactionRejectReason6CodeDropdownRow GetMetadata(this TransactionRejectReason6Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

