﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RegulatoryTradingCapacity1Code.  ISO2002 ID# _905ZYO8bEeSLA89yUYsVSw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the regulatory trading capacity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_905ZYO8bEeSLA89yUYsVSw")]
[Description(@"Specifies the regulatory trading capacity.")]
[DerivedFrom(typeof(RegulatoryTradingCapacityCode))]
public enum RegulatoryTradingCapacity1Code
{
    /// <summary>
    /// Transaction was carried out as a matched principal trading.
    /// Encoded/decoded by serializers as "MTCH".
    /// </summary>
    [EnumMember(Value = "MTCH")]
    [IsoId("_Am-fce8cEeSLA89yUYsVSw")]
    [Description(@"Transaction was carried out as a matched principal trading.")]
    MatchedPrincipal = RegulatoryTradingCapacityCode.MatchedPrincipal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction was carried out as a deal under own account.
    /// Encoded/decoded by serializers as "DEAL".
    /// </summary>
    [EnumMember(Value = "DEAL")]
    [IsoId("_AuSBUe8cEeSLA89yUYsVSw")]
    [Description(@"Transaction was carried out as a deal under own account.")]
    DealOnOwnAccount = RegulatoryTradingCapacityCode.DealOnOwnAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction was carried out as an agent.
    /// Encoded/decoded by serializers as "AOTC".
    /// </summary>
    [EnumMember(Value = "AOTC")]
    [IsoId("_A1hRwe8cEeSLA89yUYsVSw")]
    [Description(@"Transaction was carried out as an agent.")]
    AnyOtherCapacity = RegulatoryTradingCapacityCode.AnyOtherCapacity, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RegulatoryTradingCapacity1CodeMetadataExtensions
{
    private static readonly RegulatoryTradingCapacity1CodeDropdownSource _dropdownSource = new RegulatoryTradingCapacity1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRegulatoryTradingCapacity1CodeDropdownRow GetMetadata(this RegulatoryTradingCapacity1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


