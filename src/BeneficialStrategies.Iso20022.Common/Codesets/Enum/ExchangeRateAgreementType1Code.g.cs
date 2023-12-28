﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExchangeRateAgreementType1Code.  ISO2002 ID# _8WJeoIZ6EeuSbct6WWD-Ng.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of exchange rate agreement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8WJeoIZ6EeuSbct6WWD-Ng")]
[Description(@"Type of exchange rate agreement.")]
[DerivedFrom(typeof(ExchangeRateAgreementTypeCode))]
public enum ExchangeRateAgreementType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ForwardContract".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Dq8h8YZ7EeuSbct6WWD-Ng")]
    [Description(@"??")]
    ForwardContract,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Normal".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EVLKsYZ7EeuSbct6WWD-Ng")]
    [Description(@"??")]
    Normal,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EdpKMYZ7EeuSbct6WWD-Ng")]
    [Description(@"??")]
    OtherNational,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_FBk9sYZ7EeuSbct6WWD-Ng")]
    [Description(@"??")]
    OtherPrivate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Spot".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_FClDQYZ7EeuSbct6WWD-Ng")]
    [Description(@"??")]
    Spot,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExchangeRateAgreementType1CodeMetadataExtensions
{
    private static readonly ExchangeRateAgreementType1CodeDropdownSource _dropdownSource = new ExchangeRateAgreementType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExchangeRateAgreementType1CodeDropdownRow GetMetadata(this ExchangeRateAgreementType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

