﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PartialGroupStatus1Code.  ISO2002 ID# _YZEhx9p-Ed-ak6NoX_4Aeg_1562452239.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the status of a single payment transaction or of a group of payment transactions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YZEhx9p-Ed-ak6NoX_4Aeg_1562452239")]
[Description(@"Indicates the status of a single payment transaction or of a group of payment transactions.")]
[DerivedFrom(typeof(PaymentStatusCode))]
public enum PartialGroupStatus1Code
{
    /// <summary>
    /// Authentication and syntactical and semantical validation are successful.
    /// Encoded/decoded by serializers as "ACTC".
    /// </summary>
    [EnumMember(Value = "ACTC")]
    [IsoId("_YZEhyNp-Ed-ak6NoX_4Aeg_1562452241")]
    [Description(@"Authentication and syntactical and semantical validation are successful.")]
    AcceptedTechnicalValidation = PaymentStatusCode.AcceptedTechnicalValidation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Preceding check of technical validation was successful. Customer profile check was also successful.
    /// Encoded/decoded by serializers as "ACCP".
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_YZOSwNp-Ed-ak6NoX_4Aeg_1562452392")]
    [Description(@"Preceding check of technical validation was successful. Customer profile check was also successful.")]
    AcceptedCustomerProfile = PaymentStatusCode.AcceptedCustomerProfile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// All preceding checks such as technical validation and customer profile were successful and therefore the payment initiation has been accepted for execution.
    /// Encoded/decoded by serializers as "ACSP".
    /// </summary>
    [EnumMember(Value = "ACSP")]
    [IsoId("_YZOSwdp-Ed-ak6NoX_4Aeg_1562452393")]
    [Description(@"All preceding checks such as technical validation and customer profile were successful and therefore the payment initiation has been accepted for execution.")]
    AcceptedSettlementInProcess = PaymentStatusCode.AcceptedSettlementInProcess, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement on the debtor's account has been completed. ||Usage : this can be used by the first agent to report to the debtor that the transaction has been completed. Warning : this status is provided for transaction status reasons, not for financial information. It can only be used after bilateral agreement
    /// Encoded/decoded by serializers as "ACSC".
    /// </summary>
    [EnumMember(Value = "ACSC")]
    [IsoId("_YZOSwtp-Ed-ak6NoX_4Aeg_1562452414")]
    [Description(@"Settlement on the debtor's account has been completed. ||Usage : this can be used by the first agent to report to the debtor that the transaction has been completed. Warning : this status is provided for transaction status reasons, not for financial information. It can only be used after bilateral agreement")]
    AcceptedSettlementCompleted = PaymentStatusCode.AcceptedSettlementCompleted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation is accepted.
    /// Encoded/decoded by serializers as "ACCR".
    /// </summary>
    [EnumMember(Value = "ACCR")]
    [IsoId("_YZOSw9p-Ed-ak6NoX_4Aeg_1562452476")]
    [Description(@"Cancellation is accepted.")]
    AcceptedCancellationRequest = PaymentStatusCode.AcceptedCancellationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is accepted but a change will be made, such as date or remittance not sent.
    /// Encoded/decoded by serializers as "ACWC".
    /// </summary>
    [EnumMember(Value = "ACWC")]
    [IsoId("_YZOSxNp-Ed-ak6NoX_4Aeg_1562452723")]
    [Description(@"Instruction is accepted but a change will be made, such as date or remittance not sent.")]
    AcceptedWithChange = PaymentStatusCode.AcceptedWithChange, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PartialGroupStatus1CodeMetadataExtensions
{
    private static readonly PartialGroupStatus1CodeDropdownSource _dropdownSource = new PartialGroupStatus1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPartialGroupStatus1CodeDropdownRow GetMetadata(this PartialGroupStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


