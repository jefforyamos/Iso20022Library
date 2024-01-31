﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SettlementAdviceType1Code.  ISO2002 ID# _CEe5kHyiEeGWJuGCfvwOsQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of settlement advice.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CEe5kHyiEeGWJuGCfvwOsQ")]
[Description(@"Specifies the type of settlement advice.")]
[DerivedFrom(typeof(SettlementAdviceTypeCode))]
public enum SettlementAdviceType1Code
{
    /// <summary>
    /// Settlement advice related to an undertaking amendment.
    /// Encoded/decoded by serializers as "AMND".
    /// </summary>
    [EnumMember(Value = "AMND")]
    [IsoId("_KhLZFnyiEeGWJuGCfvwOsQ")]
    [Description(@"Settlement advice related to an undertaking amendment.")]
    UndertakingAmendment = SettlementAdviceTypeCode.UndertakingAmendment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement advice related to an automatic booking of charges.
    /// Encoded/decoded by serializers as "ACHG".
    /// </summary>
    [EnumMember(Value = "ACHG")]
    [IsoId("_Km_tNnyiEeGWJuGCfvwOsQ")]
    [Description(@"Settlement advice related to an automatic booking of charges.")]
    AutomaticChargesBooking = SettlementAdviceTypeCode.AutomaticChargesBooking, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement advice related to a claim for payment.
    /// Encoded/decoded by serializers as "CLAM".
    /// </summary>
    [EnumMember(Value = "CLAM")]
    [IsoId("_Ks9LRnyiEeGWJuGCfvwOsQ")]
    [Description(@"Settlement advice related to a claim for payment.")]
    PaymentClaim = SettlementAdviceTypeCode.PaymentClaim, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement advice related to correspondent bank charges.
    /// Encoded/decoded by serializers as "CORP".
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_KzNkRnyiEeGWJuGCfvwOsQ")]
    [Description(@"Settlement advice related to correspondent bank charges.")]
    CorrespondentBankCharges = SettlementAdviceTypeCode.CorrespondentBankCharges, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement advice related to an undertaking issuance.
    /// Encoded/decoded by serializers as "ISSU".
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_K5xfRnyiEeGWJuGCfvwOsQ")]
    [Description(@"Settlement advice related to an undertaking issuance.")]
    UndertakingIssuance = SettlementAdviceTypeCode.UndertakingIssuance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement advice related to a manual booking of charges.
    /// Encoded/decoded by serializers as "MCHG".
    /// </summary>
    [EnumMember(Value = "MCHG")]
    [IsoId("_LALpRnyiEeGWJuGCfvwOsQ")]
    [Description(@"Settlement advice related to a manual booking of charges.")]
    ManualChargesBooking = SettlementAdviceTypeCode.ManualChargesBooking, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement advice related to a refund.
    /// Encoded/decoded by serializers as "REFD".
    /// </summary>
    [EnumMember(Value = "REFD")]
    [IsoId("_LHfLJnyiEeGWJuGCfvwOsQ")]
    [Description(@"Settlement advice related to a refund.")]
    Refund = SettlementAdviceTypeCode.Refund, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement advice related to an undertaking termination.
    /// Encoded/decoded by serializers as "CLOS".
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_LOCfFnyiEeGWJuGCfvwOsQ")]
    [Description(@"Settlement advice related to an undertaking termination.")]
    Termination = SettlementAdviceTypeCode.Termination, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SettlementAdviceType1CodeMetadataExtensions
{
    private static readonly SettlementAdviceType1CodeDropdownSource _dropdownSource = new SettlementAdviceType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISettlementAdviceType1CodeDropdownRow GetMetadata(this SettlementAdviceType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


