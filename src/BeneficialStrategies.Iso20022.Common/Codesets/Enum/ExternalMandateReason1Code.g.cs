﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalMandateReason1Code.  ISO2002 ID# _ame0g9p-Ed-ak6NoX_4Aeg_-2059737298.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external mandate processing reason code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ame0g9p-Ed-ak6NoX_4Aeg_-2059737298")]
[Description(@"Specifies the external mandate processing reason code in the format of character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalMandateReasonCode))]
public enum ExternalMandateReason1Code
{
    /// <summary>
    /// Format of the account number specified is not correct
    /// Encoded/decoded by serializers as "IncorrectAccountNumber".
    /// </summary>
    [EnumMember(Value = "AC01")]
    [IsoId("_tqLkC_RYEeuLhpyIdtJzwg")]
    [Description(@"Format of the account number specified is not correct")]
    IncorrectAccountNumber,
    
    /// <summary>
    /// Account number specified has been closed on the Receiver's books
    /// Encoded/decoded by serializers as "ClosedAccountNumber".
    /// </summary>
    [EnumMember(Value = "AC04")]
    [IsoId("_tqVVAvRYEeuLhpyIdtJzwg")]
    [Description(@"Account number specified has been closed on the Receiver's books")]
    ClosedAccountNumber,
    
    /// <summary>
    /// Account specified is blocked, prohibiting posting of transactions against it.
    /// Encoded/decoded by serializers as "BlockedAccount".
    /// </summary>
    [EnumMember(Value = "AC06")]
    [IsoId("_tqVVBfRYEeuLhpyIdtJzwg")]
    [Description(@"Account specified is blocked, prohibiting posting of transactions against it.")]
    BlockedAccount,
    
    /// <summary>
    /// Transaction forbidden on this type of account (formerly NoAgreement)
    /// Encoded/decoded by serializers as "TransactionForbidden".
    /// </summary>
    [EnumMember(Value = "AG01")]
    [IsoId("_tqVVCPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction forbidden on this type of account (formerly NoAgreement)")]
    TransactionForbidden,
    
    /// <summary>
    /// Bank Operation code specified in the message is not valid for receiver
    /// Encoded/decoded by serializers as "InvalidBankOperationCode".
    /// </summary>
    [EnumMember(Value = "AG02")]
    [IsoId("_tqee8vRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Operation code specified in the message is not valid for receiver")]
    InvalidBankOperationCode,
    
    /// <summary>
    /// Specific transaction/message amount is greater than allowed maximum
    /// Encoded/decoded by serializers as "NotAllowedAmount".
    /// </summary>
    [EnumMember(Value = "AM02")]
    [IsoId("_tqee9fRYEeuLhpyIdtJzwg")]
    [Description(@"Specific transaction/message amount is greater than allowed maximum")]
    NotAllowedAmount,
    
    /// <summary>
    /// Specified message amount is a non processable currency outside of existing agreement
    /// Encoded/decoded by serializers as "NotAllowedCurrency".
    /// </summary>
    [EnumMember(Value = "AM03")]
    [IsoId("_tqee-PRYEeuLhpyIdtJzwg")]
    [Description(@"Specified message amount is a non processable currency outside of existing agreement")]
    NotAllowedCurrency,
    
    /// <summary>
    /// Duplication 
    /// Encoded/decoded by serializers as "Duplication".
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_tqoP8vRYEeuLhpyIdtJzwg")]
    [Description(@"Duplication ")]
    Duplication,
    
    /// <summary>
    /// Identification of end customer is not consistent with associated account number. (formerly CreditorConsistency).
    /// Encoded/decoded by serializers as "InconsistenWithEndCustomer".
    /// </summary>
    [EnumMember(Value = "BE01")]
    [IsoId("_tqoP9fRYEeuLhpyIdtJzwg")]
    [Description(@"Identification of end customer is not consistent with associated account number. (formerly CreditorConsistency).")]
    InconsistenWithEndCustomer,
    
    /// <summary>
    /// Specification of creditor's address, which is required for payment, is missing/not correct (formerly IncorrectCreditorAddress).
    /// Encoded/decoded by serializers as "MissingCreditorAddress".
    /// </summary>
    [EnumMember(Value = "BE04")]
    [IsoId("_tqoP-PRYEeuLhpyIdtJzwg")]
    [Description(@"Specification of creditor's address, which is required for payment, is missing/not correct (formerly IncorrectCreditorAddress).")]
    MissingCreditorAddress,
    
    /// <summary>
    /// Party who initiated the message is not recognised by the end customer
    /// Encoded/decoded by serializers as "UnrecognisedInitiatingParty".
    /// </summary>
    [EnumMember(Value = "BE05")]
    [IsoId("_tqoP-_RYEeuLhpyIdtJzwg")]
    [Description(@"Party who initiated the message is not recognised by the end customer")]
    UnrecognisedInitiatingParty,
    
    /// <summary>
    /// End customer specified is not known at associated Sort/National Bank Code or does no longer exist in the books
    /// Encoded/decoded by serializers as "UnknownEndCustomer".
    /// </summary>
    [EnumMember(Value = "BE06")]
    [IsoId("_tqyA8vRYEeuLhpyIdtJzwg")]
    [Description(@"End customer specified is not known at associated Sort/National Bank Code or does no longer exist in the books")]
    UnknownEndCustomer,
    
    /// <summary>
    /// Specification of debtor's address, which is required for payment, is missing/not correct.
    /// Encoded/decoded by serializers as "MissingDebtorAddress".
    /// </summary>
    [EnumMember(Value = "BE07")]
    [IsoId("_tqyA9fRYEeuLhpyIdtJzwg")]
    [Description(@"Specification of debtor's address, which is required for payment, is missing/not correct.")]
    MissingDebtorAddress,
    
    /// <summary>
    /// Invalid date (eg, wrong settlement date)
    /// Encoded/decoded by serializers as "InvalidDate".
    /// </summary>
    [EnumMember(Value = "DT01")]
    [IsoId("_tqyA-PRYEeuLhpyIdtJzwg")]
    [Description(@"Invalid date (eg, wrong settlement date)")]
    InvalidDate,
    
    /// <summary>
    /// File format incomplete or invalid
    /// Encoded/decoded by serializers as "InvalidFileFormat".
    /// </summary>
    [EnumMember(Value = "FF01")]
    [IsoId("_tq7K4vRYEeuLhpyIdtJzwg")]
    [Description(@"File format incomplete or invalid")]
    InvalidFileFormat,
    
    /// <summary>
    /// No Mandate
    /// Encoded/decoded by serializers as "NoMandate".
    /// </summary>
    [EnumMember(Value = "MD01")]
    [IsoId("_tq7K5fRYEeuLhpyIdtJzwg")]
    [Description(@"No Mandate")]
    NoMandate,
    
    /// <summary>
    /// Mandate related information data required by the scheme is missing.
    /// Encoded/decoded by serializers as "MissingMandatoryInformationInMandate".
    /// </summary>
    [EnumMember(Value = "MD02")]
    [IsoId("_tq7K6PRYEeuLhpyIdtJzwg")]
    [Description(@"Mandate related information data required by the scheme is missing.")]
    MissingMandatoryInformationInMandate,
    
    /// <summary>
    /// End customer is deceased.
    /// Encoded/decoded by serializers as "EndCustomerDeceased".
    /// </summary>
    [EnumMember(Value = "MD07")]
    [IsoId("_tq7K6_RYEeuLhpyIdtJzwg")]
    [Description(@"End customer is deceased.")]
    EndCustomerDeceased,
    
    /// <summary>
    /// Receiving agent does not offer specified Mandate services
    /// Encoded/decoded by serializers as "NoMandateServiceByAgent".
    /// </summary>
    [EnumMember(Value = "MD08")]
    [IsoId("_trE74vRYEeuLhpyIdtJzwg")]
    [Description(@"Receiving agent does not offer specified Mandate services")]
    NoMandateServiceByAgent,
    
    /// <summary>
    /// Account is not open to specified Mandates services
    /// Encoded/decoded by serializers as "NoMandateServiceOnCustomer".
    /// </summary>
    [EnumMember(Value = "MD09")]
    [IsoId("_trE75fRYEeuLhpyIdtJzwg")]
    [Description(@"Account is not open to specified Mandates services")]
    NoMandateServiceOnCustomer,
    
    /// <summary>
    /// Account is not open to specified Mandates services for this particular creditor
    /// Encoded/decoded by serializers as "NoMandateServiceForSpecified".
    /// </summary>
    [EnumMember(Value = "MD10")]
    [IsoId("_trE76PRYEeuLhpyIdtJzwg")]
    [Description(@"Account is not open to specified Mandates services for this particular creditor")]
    NoMandateServiceForSpecified,
    
    /// <summary>
    /// Agent to whom the message needs to be forwarded cannot be located
    /// Encoded/decoded by serializers as "UnrecognisedAgent".
    /// </summary>
    [EnumMember(Value = "MD11")]
    [IsoId("_trE76_RYEeuLhpyIdtJzwg")]
    [Description(@"Agent to whom the message needs to be forwarded cannot be located")]
    UnrecognisedAgent,
    
    /// <summary>
    /// Mandate identification is not unique to the creditor
    /// Encoded/decoded by serializers as "NotUniqueMandateReference".
    /// </summary>
    [EnumMember(Value = "MD12")]
    [IsoId("_trOs4vRYEeuLhpyIdtJzwg")]
    [Description(@"Mandate identification is not unique to the creditor")]
    NotUniqueMandateReference,
    
    /// <summary>
    /// There is a problem with the customer authentication
    /// Encoded/decoded by serializers as "IncorrectCustomerAuthentication".
    /// </summary>
    [EnumMember(Value = "MD13")]
    [IsoId("_trOs5fRYEeuLhpyIdtJzwg")]
    [Description(@"There is a problem with the customer authentication")]
    IncorrectCustomerAuthentication,
    
    /// <summary>
    /// Agent in the payment workflow is incorrect
    /// Encoded/decoded by serializers as "IncorrectAgent".
    /// </summary>
    [EnumMember(Value = "MD14")]
    [IsoId("_trOs6PRYEeuLhpyIdtJzwg")]
    [Description(@"Agent in the payment workflow is incorrect")]
    IncorrectAgent,
    
    /// <summary>
    /// Currency of the transaction is incorrect
    /// Encoded/decoded by serializers as "IncorrectCurrency".
    /// </summary>
    [EnumMember(Value = "MD15")]
    [IsoId("_trOs6_RYEeuLhpyIdtJzwg")]
    [Description(@"Currency of the transaction is incorrect")]
    IncorrectCurrency,
    
    /// <summary>
    /// Cancellation/amendment requested by the debtor
    /// Encoded/decoded by serializers as "RequestedByCustomer".
    /// </summary>
    [EnumMember(Value = "MD16")]
    [IsoId("_trOs7vRYEeuLhpyIdtJzwg")]
    [Description(@"Cancellation/amendment requested by the debtor")]
    RequestedByCustomer,
    
    /// <summary>
    /// Cancellation/amendment requested by the creditor
    /// Encoded/decoded by serializers as "RequestedByInitiatingParty".
    /// </summary>
    [EnumMember(Value = "MD17")]
    [IsoId("_trX20vRYEeuLhpyIdtJzwg")]
    [Description(@"Cancellation/amendment requested by the creditor")]
    RequestedByInitiatingParty,
    
    /// <summary>
    /// Cancellation/amendment requested by the creditor and the debtor
    /// Encoded/decoded by serializers as "RequestedByInitiatingPartyAndCustomer".
    /// </summary>
    [EnumMember(Value = "MD18")]
    [IsoId("_trX21fRYEeuLhpyIdtJzwg")]
    [Description(@"Cancellation/amendment requested by the creditor and the debtor")]
    RequestedByInitiatingPartyAndCustomer,
    
    /// <summary>
    /// Mandate cancellation following early reimbursement of the debit by the debtor
    /// Encoded/decoded by serializers as "MandateCancelledDueToEarlySettlement".
    /// </summary>
    [EnumMember(Value = "MD19")]
    [IsoId("_trX22PRYEeuLhpyIdtJzwg")]
    [Description(@"Mandate cancellation following early reimbursement of the debit by the debtor")]
    MandateCancelledDueToEarlySettlement,
    
    /// <summary>
    /// Mandate cancellation following validity expiration
    /// Encoded/decoded by serializers as "MandateExpired".
    /// </summary>
    [EnumMember(Value = "MD20")]
    [IsoId("_trX22_RYEeuLhpyIdtJzwg")]
    [Description(@"Mandate cancellation following validity expiration")]
    MandateExpired,
    
    /// <summary>
    /// Mandate cancellation due to suspected fraud
    /// Encoded/decoded by serializers as "MandateCancelledDueToFraud".
    /// </summary>
    [EnumMember(Value = "MD21")]
    [IsoId("_trhn0vRYEeuLhpyIdtJzwg")]
    [Description(@"Mandate cancellation due to suspected fraud")]
    MandateCancelledDueToFraud,
    
    /// <summary>
    /// Mandate cancellation following mandate initiation cancellation
    /// Encoded/decoded by serializers as "MandateInitiationCancelled".
    /// </summary>
    [EnumMember(Value = "MD22")]
    [IsoId("_trhn1fRYEeuLhpyIdtJzwg")]
    [Description(@"Mandate cancellation following mandate initiation cancellation")]
    MandateInitiationCancelled,
    
    /// <summary>
    /// Mandate cancellation following mandate amendment cancellation
    /// Encoded/decoded by serializers as "MandateAmendmentCancelled".
    /// </summary>
    [EnumMember(Value = "MD23")]
    [IsoId("_trhn2PRYEeuLhpyIdtJzwg")]
    [Description(@"Mandate cancellation following mandate amendment cancellation")]
    MandateAmendmentCancelled,
    
    /// <summary>
    /// Reason has not been specified by end customer
    /// Encoded/decoded by serializers as "NotSpecifiedReasonCustomerGenerated".
    /// </summary>
    [EnumMember(Value = "MS02")]
    [IsoId("_trhn2_RYEeuLhpyIdtJzwg")]
    [Description(@"Reason has not been specified by end customer")]
    NotSpecifiedReasonCustomerGenerated,
    
    /// <summary>
    /// Reason has not been specified by agent.
    /// Encoded/decoded by serializers as "NotSpecifiedReasonAgentGenerated".
    /// </summary>
    [EnumMember(Value = "MS03")]
    [IsoId("_trhn3vRYEeuLhpyIdtJzwg")]
    [Description(@"Reason has not been specified by agent.")]
    NotSpecifiedReasonAgentGenerated,
    
    /// <summary>
    /// Reason is provided as narrative information in the additional reason information.
    /// Encoded/decoded by serializers as "Narrative".
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_trqxwvRYEeuLhpyIdtJzwg")]
    [Description(@"Reason is provided as narrative information in the additional reason information.")]
    Narrative,
    
    /// <summary>
    /// Bank Identifier code specified in the message has an incorrect format (formerly IncorrectFormatForRoutingCode).
    /// Encoded/decoded by serializers as "BankIdentifierIncorrect".
    /// </summary>
    [EnumMember(Value = "RC01")]
    [IsoId("_trqxxfRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Identifier code specified in the message has an incorrect format (formerly IncorrectFormatForRoutingCode).")]
    BankIdentifierIncorrect,
    
    /// <summary>
    /// Transaction reference is not unique within the message.
    /// Encoded/decoded by serializers as "NotUniqueTransactionReference".
    /// </summary>
    [EnumMember(Value = "RF01")]
    [IsoId("_trqxyPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction reference is not unique within the message.")]
    NotUniqueTransactionReference,
    
    /// <summary>
    /// Specification of the debtor’s account or unique identification needed for reasons of regulatory requirements is insufficient or missing
    /// Encoded/decoded by serializers as "MissingDebtorAccountOrIdentification".
    /// </summary>
    [EnumMember(Value = "RR01")]
    [IsoId("_tr0iwvRYEeuLhpyIdtJzwg")]
    [Description(@"Specification of the debtor’s account or unique identification needed for reasons of regulatory requirements is insufficient or missing")]
    MissingDebtorAccountOrIdentification,
    
    /// <summary>
    /// Specification of the debtor’s name and/or address needed for regulatory requirements is insufficient or missing.
    /// Encoded/decoded by serializers as "MissingDebtorNameOrAddress".
    /// </summary>
    [EnumMember(Value = "RR02")]
    [IsoId("_tr0ixfRYEeuLhpyIdtJzwg")]
    [Description(@"Specification of the debtor’s name and/or address needed for regulatory requirements is insufficient or missing.")]
    MissingDebtorNameOrAddress,
    
    /// <summary>
    /// Specification of the creditor’s name and/or address needed for regulatory requirements is insufficient or missing.
    /// Encoded/decoded by serializers as "MissingCreditorNameOrAddress".
    /// </summary>
    [EnumMember(Value = "RR03")]
    [IsoId("_tr0iyPRYEeuLhpyIdtJzwg")]
    [Description(@"Specification of the creditor’s name and/or address needed for regulatory requirements is insufficient or missing.")]
    MissingCreditorNameOrAddress,
    
    /// <summary>
    /// Regulatory Reason
    /// Encoded/decoded by serializers as "RegulatoryReason".
    /// </summary>
    [EnumMember(Value = "RR04")]
    [IsoId("_tr0iy_RYEeuLhpyIdtJzwg")]
    [Description(@"Regulatory Reason")]
    RegulatoryReason,
    
    /// <summary>
    /// Due to specific service offered by the Debtor Agent
    /// Encoded/decoded by serializers as "SpecificServiceOfferedByDebtorAgent".
    /// </summary>
    [EnumMember(Value = "SL01")]
    [IsoId("_tr-TwvRYEeuLhpyIdtJzwg")]
    [Description(@"Due to specific service offered by the Debtor Agent")]
    SpecificServiceOfferedByDebtorAgent,
    
    /// <summary>
    /// Whitelisting service offered by the Debtor Agent; Debtor has not included the Creditor on its “Whitelist” (yet). In the Whitelist the Debtor may list all allowed Creditors to debit Debtor bank account.
    /// Encoded/decoded by serializers as "CreditorNotOnWhitelistOfDebtor".
    /// </summary>
    [EnumMember(Value = "SL11")]
    [IsoId("_tr-TxfRYEeuLhpyIdtJzwg")]
    [Description(@"Whitelisting service offered by the Debtor Agent; Debtor has not included the Creditor on its “Whitelist” (yet). In the Whitelist the Debtor may list all allowed Creditors to debit Debtor bank account.")]
    CreditorNotOnWhitelistOfDebtor,
    
    /// <summary>
    /// Blacklisting service offered by the Debtor Agent; Debtor included the Creditor on his “Blacklist”. In the Blacklist the Debtor may list all Creditors not allowed to debit Debtor bank account.
    /// Encoded/decoded by serializers as "CreditorOnBlacklistOfDebtor".
    /// </summary>
    [EnumMember(Value = "SL12")]
    [IsoId("_tr-TyPRYEeuLhpyIdtJzwg")]
    [Description(@"Blacklisting service offered by the Debtor Agent; Debtor included the Creditor on his “Blacklist”. In the Blacklist the Debtor may list all Creditors not allowed to debit Debtor bank account.")]
    CreditorOnBlacklistOfDebtor,
    
    /// <summary>
    /// Due to Maximum allowed Direct Debit Transactions per period service offered by the Debtor Agent.
    /// Encoded/decoded by serializers as "MaximumNumberOfDirectDebitTransactionsExceeded".
    /// </summary>
    [EnumMember(Value = "SL13")]
    [IsoId("_tr-Ty_RYEeuLhpyIdtJzwg")]
    [Description(@"Due to Maximum allowed Direct Debit Transactions per period service offered by the Debtor Agent.")]
    MaximumNumberOfDirectDebitTransactionsExceeded,
    
    /// <summary>
    /// Due to Maximum allowed Direct Debit Transaction amount service offered by the Debtor Agent.
    /// Encoded/decoded by serializers as "MaximumDirectDebitTransactionAmountExceeded".
    /// </summary>
    [EnumMember(Value = "SL14")]
    [IsoId("_tr-TzvRYEeuLhpyIdtJzwg")]
    [Description(@"Due to Maximum allowed Direct Debit Transaction amount service offered by the Debtor Agent.")]
    MaximumDirectDebitTransactionAmountExceeded,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalMandateReason1CodeMetadataExtensions
{
    private static readonly ExternalMandateReason1CodeDropdownSource _dropdownSource = new ExternalMandateReason1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalMandateReason1CodeDropdownRow GetMetadata(this ExternalMandateReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


