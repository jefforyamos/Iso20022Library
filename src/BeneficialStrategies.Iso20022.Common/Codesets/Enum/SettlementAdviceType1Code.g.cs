﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SettlementAdviceType1Code.  ISO2002 ID# _CEe5kHyiEeGWJuGCfvwOsQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

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
    /// ??
    /// Encoded/decoded by serializers as "UndertakingAmendment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_KhLZFnyiEeGWJuGCfvwOsQ")]
    [Description(@"??")]
    UndertakingAmendment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AutomaticChargesBooking".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Km_tNnyiEeGWJuGCfvwOsQ")]
    [Description(@"??")]
    AutomaticChargesBooking,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PaymentClaim".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Ks9LRnyiEeGWJuGCfvwOsQ")]
    [Description(@"??")]
    PaymentClaim,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CorrespondentBankCharges".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_KzNkRnyiEeGWJuGCfvwOsQ")]
    [Description(@"??")]
    CorrespondentBankCharges,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UndertakingIssuance".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_K5xfRnyiEeGWJuGCfvwOsQ")]
    [Description(@"??")]
    UndertakingIssuance,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ManualChargesBooking".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_LALpRnyiEeGWJuGCfvwOsQ")]
    [Description(@"??")]
    ManualChargesBooking,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Refund".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_LHfLJnyiEeGWJuGCfvwOsQ")]
    [Description(@"??")]
    Refund,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Termination".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_LOCfFnyiEeGWJuGCfvwOsQ")]
    [Description(@"??")]
    Termination,
    
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

