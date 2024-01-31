﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UndertakingIssuanceName1Code.  ISO2002 ID# _-IP4InltEeG7BsjMvd1mEw_-583646723.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the issued undertaking name.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-IP4InltEeG7BsjMvd1mEw_-583646723")]
[Description(@"Specifies the issued undertaking name.")]
[DerivedFrom(typeof(UndertakingIssuanceNameCode))]
public enum UndertakingIssuanceName1Code
{
    /// <summary>
    /// Standby letter of credit.
    /// Encoded/decoded by serializers as "STBY".
    /// </summary>
    [EnumMember(Value = "STBY")]
    [IsoId("_03AwIq-NEeG6R7UXUOz4dQ")]
    [Description(@"Standby letter of credit.")]
    Standby = UndertakingIssuanceNameCode.Standby, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Demand guarantee.
    /// Encoded/decoded by serializers as "DGAR".
    /// </summary>
    [EnumMember(Value = "DGAR")]
    [IsoId("_nvg48q-OEeG6R7UXUOz4dQ")]
    [Description(@"Demand guarantee.")]
    Guarantee = UndertakingIssuanceNameCode.Guarantee, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class UndertakingIssuanceName1CodeMetadataExtensions
{
    private static readonly UndertakingIssuanceName1CodeDropdownSource _dropdownSource = new UndertakingIssuanceName1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IUndertakingIssuanceName1CodeDropdownRow GetMetadata(this UndertakingIssuanceName1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


