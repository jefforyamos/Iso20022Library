﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransactionReturnReason1Code.  ISO2002 ID# _Vw_FMdp-Ed-ak6NoX_4Aeg_1585481359.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a transaction to be rejected or returned by an instructed agent or somebody acting on behalf of an instructed agent.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vw_FMdp-Ed-ak6NoX_4Aeg_1585481359")]
[Description(@"Specifies the reason for a transaction to be rejected or returned by an instructed agent or somebody acting on behalf of an instructed agent.")]
[DerivedFrom(typeof(TransactionReasonCode))]
public enum TransactionReturnReason1Code
{
    /// <summary>
    /// Format of the account number specified is not correct.
    /// Encoded/decoded by serializers as "IncorrectAccountNumber".
    /// </summary>
    [EnumMember(Value = "AC01")]
    [IsoId("_Vw_FMtp-Ed-ak6NoX_4Aeg_1585481412")]
    [Description(@"Format of the account number specified is not correct.")]
    IncorrectAccountNumber,
    
    /// <summary>
    /// Account number specified has been closed on the Receiver's books.
    /// Encoded/decoded by serializers as "ClosedAccountNumber".
    /// </summary>
    [EnumMember(Value = "AC04")]
    [IsoId("_Vw_FM9p-Ed-ak6NoX_4Aeg_1585481443")]
    [Description(@"Account number specified has been closed on the Receiver's books.")]
    ClosedAccountNumber,
    
    /// <summary>
    /// Account specified is blocked, prohibiting posting of transactions against it.
    /// Encoded/decoded by serializers as "BlockedAccount".
    /// </summary>
    [EnumMember(Value = "AC06")]
    [IsoId("_Vw_FNNp-Ed-ak6NoX_4Aeg_1585481473")]
    [Description(@"Account specified is blocked, prohibiting posting of transactions against it.")]
    BlockedAccount,
    
    /// <summary>
    /// Transaction forbidden on this type of account (formerly NoAgreement).
    /// Encoded/decoded by serializers as "TransactionForbidden".
    /// </summary>
    [EnumMember(Value = "AG01")]
    [IsoId("_Vw_FNdp-Ed-ak6NoX_4Aeg_1585481504")]
    [Description(@"Transaction forbidden on this type of account (formerly NoAgreement).")]
    TransactionForbidden,
    
    /// <summary>
    /// Bank Operation code specified in the message is not valid for receiver.
    /// Encoded/decoded by serializers as "InvalidBankOperationCode".
    /// </summary>
    [EnumMember(Value = "AG02")]
    [IsoId("_Vw_FNtp-Ed-ak6NoX_4Aeg_1585481505")]
    [Description(@"Bank Operation code specified in the message is not valid for receiver.")]
    InvalidBankOperationCode,
    
    /// <summary>
    /// Amount of funds available to cover specified message amount is insufficient.
    /// Encoded/decoded by serializers as "InsufficientFunds".
    /// </summary>
    [EnumMember(Value = "AM04")]
    [IsoId("_Vw_FN9p-Ed-ak6NoX_4Aeg_1585481535")]
    [Description(@"Amount of funds available to cover specified message amount is insufficient.")]
    InsufficientFunds,
    
    /// <summary>
    /// This message appears to have been duplicated.
    /// Encoded/decoded by serializers as "Duplication".
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_Vw_FONp-Ed-ak6NoX_4Aeg_1585481536")]
    [Description(@"This message appears to have been duplicated.")]
    Duplication,
    
    /// <summary>
    /// Mandate is cancelled or invalid.
    /// Encoded/decoded by serializers as "NoMandate".
    /// </summary>
    [EnumMember(Value = "MD01")]
    [IsoId("_VxI2MNp-Ed-ak6NoX_4Aeg_1585481813")]
    [Description(@"Mandate is cancelled or invalid.")]
    NoMandate,
    
    /// <summary>
    /// Specification of creditor's address, which is required for payment, is missing/not correct (formerly IncorrectCreditorAddress).
    /// Encoded/decoded by serializers as "MissingCreditorAddress".
    /// </summary>
    [EnumMember(Value = "BE04")]
    [IsoId("_VxI2Mdp-Ed-ak6NoX_4Aeg_1585481844")]
    [Description(@"Specification of creditor's address, which is required for payment, is missing/not correct (formerly IncorrectCreditorAddress).")]
    MissingCreditorAddress,
    
    /// <summary>
    /// File format incomplete or invalid.
    /// Encoded/decoded by serializers as "InvalidFileFormatForOtherReasonThanGroupingIndicator".
    /// </summary>
    [EnumMember(Value = "MD03")]
    [IsoId("_VxI2Mtp-Ed-ak6NoX_4Aeg_1585481845")]
    [Description(@"File format incomplete or invalid.")]
    InvalidFileFormatForOtherReasonThanGroupingIndicator,
    
    /// <summary>
    /// Bank identifier code specified in the message has an incorrect format (formerly IncorrectFormatForRoutingCode).
    /// Encoded/decoded by serializers as "BankIdentifierIncorrect".
    /// </summary>
    [EnumMember(Value = "RC01")]
    [IsoId("_VxI2M9p-Ed-ak6NoX_4Aeg_1585481874")]
    [Description(@"Bank identifier code specified in the message has an incorrect format (formerly IncorrectFormatForRoutingCode).")]
    BankIdentifierIncorrect,
    
    /// <summary>
    /// Return of funds requested by end customer.
    /// Encoded/decoded by serializers as "RefundRequestByEndCustomer".
    /// </summary>
    [EnumMember(Value = "MD06")]
    [IsoId("_VxI2NNp-Ed-ak6NoX_4Aeg_574444668")]
    [Description(@"Return of funds requested by end customer.")]
    RefundRequestByEndCustomer,
    
    /// <summary>
    /// End customer is deceased.
    /// Encoded/decoded by serializers as "EndCustomerDeceased".
    /// </summary>
    [EnumMember(Value = "MD07")]
    [IsoId("_VxI2Ndp-Ed-ak6NoX_4Aeg_1585481875")]
    [Description(@"End customer is deceased.")]
    EndCustomerDeceased,
    
    /// <summary>
    /// Reason has not been specified by end customer.
    /// Encoded/decoded by serializers as "NotSpecifiedReasonCustomerGenerated".
    /// </summary>
    [EnumMember(Value = "MS02")]
    [IsoId("_VxI2Ntp-Ed-ak6NoX_4Aeg_1585481905")]
    [Description(@"Reason has not been specified by end customer.")]
    NotSpecifiedReasonCustomerGenerated,
    
    /// <summary>
    /// Reason has not been specified by agent.
    /// Encoded/decoded by serializers as "NotSpecifiedReasonAgentGenerated".
    /// </summary>
    [EnumMember(Value = "MS03")]
    [IsoId("_VxI2N9p-Ed-ak6NoX_4Aeg_1585481906")]
    [Description(@"Reason has not been specified by agent.")]
    NotSpecifiedReasonAgentGenerated,
    
    /// <summary>
    /// Associated message was received after agreed processing cut-off time.
    /// Encoded/decoded by serializers as "CutOffTime".
    /// </summary>
    [EnumMember(Value = "TM01")]
    [IsoId("_VxI2ONp-Ed-ak6NoX_4Aeg_1585481935")]
    [Description(@"Associated message was received after agreed processing cut-off time.")]
    CutOffTime,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransactionReturnReason1CodeMetadataExtensions
{
    private static readonly TransactionReturnReason1CodeDropdownSource _dropdownSource = new TransactionReturnReason1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransactionReturnReason1CodeDropdownRow GetMetadata(this TransactionReturnReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


