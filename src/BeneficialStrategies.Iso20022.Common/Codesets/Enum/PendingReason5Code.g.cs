﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PendingReason5Code.  ISO2002 ID# _aCuAJdp-Ed-ak6NoX_4Aeg_1990265941.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Standard code to specify the reason why the instruction/event has a pending status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aCuAJdp-Ed-ak6NoX_4Aeg_1990265941")]
[Description(@"Standard code to specify the reason why the instruction/event has a pending status.")]
[DerivedFrom(typeof(PendingFailingReasonCode))]
public enum PendingReason5Code
{
    /// <summary>
    /// Instruction was received after the account servicer's deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as "ADEA".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_aCuAJtp-Ed-ak6NoX_4Aeg_2037365544")]
    [Description(@"Instruction was received after the account servicer's deadline. Processed on best effort basis.")]
    AccountServicerDeadlineMissed = PendingFailingReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax reclaim has been sent to the tax authorities.
    /// Encoded/decoded by serializers as "AUTH".
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_aCuAJ9p-Ed-ak6NoX_4Aeg_2091854785")]
    [Description(@"Tax reclaim has been sent to the tax authorities.")]
    SentToTaxAuthorities = PendingFailingReasonCode.SentToTaxAuthorities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Quantity of financial instruments does not match.
    /// Encoded/decoded by serializers as "DQUA".
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_aCuAKNp-Ed-ak6NoX_4Aeg_-1874339404")]
    [Description(@"Quantity of financial instruments does not match.")]
    QuantityDisagreement = PendingFailingReasonCode.QuantityDisagreement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient financial instruments in your account.
    /// Encoded/decoded by serializers as "LACK".
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_aC3xINp-Ed-ak6NoX_4Aeg_-1685018813")]
    [Description(@"Insufficient financial instruments in your account.")]
    LackOfSecurities = PendingFailingReasonCode.LackOfSecurities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction was received after market deadline.
    /// Encoded/decoded by serializers as "LATE".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_aC3xIdp-Ed-ak6NoX_4Aeg_-1726574756")]
    [Description(@"Instruction was received after market deadline.")]
    MarketDeadlineMissed = PendingFailingReasonCode.MarketDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Awaiting receipt of adequate certification.
    /// Encoded/decoded by serializers as "MCER".
    /// </summary>
    [EnumMember(Value = "MCER")]
    [IsoId("_aC3xItp-Ed-ak6NoX_4Aeg_-1012693474")]
    [Description(@"Awaiting receipt of adequate certification.")]
    MissingCertification = PendingFailingReasonCode.MissingCertification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient money in your account.
    /// Encoded/decoded by serializers as "MONY".
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("_aC3xI9p-Ed-ak6NoX_4Aeg_499437231")]
    [Description(@"Insufficient money in your account.")]
    InsufficientMoney = PendingFailingReasonCode.InsufficientMoney, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_aC3xJNp-Ed-ak6NoX_4Aeg_-1844786885")]
    [Description(@"Other. See Narrative.")]
    Other = PendingFailingReasonCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment has not been made by issuer.
    /// Encoded/decoded by serializers as "NPAY".
    /// </summary>
    [EnumMember(Value = "NPAY")]
    [IsoId("_aC3xJdp-Ed-ak6NoX_4Aeg_565006367")]
    [Description(@"Payment has not been made by issuer.")]
    NoPayment = PendingFailingReasonCode.NoPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial instruments have not been delivered by the issuer.
    /// Encoded/decoded by serializers as "NSEC".
    /// </summary>
    [EnumMember(Value = "NSEC")]
    [IsoId("_aC3xJtp-Ed-ak6NoX_4Aeg_-1504868153")]
    [Description(@"Financial instruments have not been delivered by the issuer.")]
    NotDelivered = PendingFailingReasonCode.NotDelivered, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The instruction is pending receipt of securities, for example, from a purchase, loan etc.
    /// Encoded/decoded by serializers as "PENR".
    /// </summary>
    [EnumMember(Value = "PENR")]
    [IsoId("_aC3xJ9p-Ed-ak6NoX_4Aeg_-1340545879")]
    [Description(@"The instruction is pending receipt of securities, for example, from a purchase, loan etc.")]
    PendingReceipt = PendingFailingReasonCode.PendingReceipt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// For tax reclaim, the event is pending, the tax reclaim is valid for the tax authorities.
    /// Encoded/decoded by serializers as "VLDA".
    /// </summary>
    [EnumMember(Value = "VLDA")]
    [IsoId("_aC3xKNp-Ed-ak6NoX_4Aeg_-1790299084")]
    [Description(@"For tax reclaim, the event is pending, the tax reclaim is valid for the tax authorities.")]
    ValidForTaxAuthorities = PendingFailingReasonCode.ValidForTaxAuthorities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certificate number error.
    /// Encoded/decoded by serializers as "CERT".
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_aC3xKdp-Ed-ak6NoX_4Aeg_-254621043")]
    [Description(@"Certificate number error.")]
    WrongCertificatesNumbers = PendingFailingReasonCode.WrongCertificatesNumbers, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PendingReason5CodeMetadataExtensions
{
    private static readonly PendingReason5CodeDropdownSource _dropdownSource = new PendingReason5CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPendingReason5CodeDropdownRow GetMetadata(this PendingReason5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


