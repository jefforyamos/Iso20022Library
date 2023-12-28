﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExchangeRateAgreementTypeCode.  ISO2002 ID# _c9M7QIZ5EeuSbct6WWD-Ng.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of Exchange Rate agreement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_c9M7QIZ5EeuSbct6WWD-Ng")]
[Description(@"Type of Exchange Rate agreement.")]
public enum ExchangeRateAgreementTypeCode
{
    /// <summary>
    /// Normal exchange rate agreement type.
    /// Encoded/decoded by serializers as "NORM".
    /// </summary>
    [EnumMember(Value = "NORM")]
    [IsoId("_qOpjMIZ5EeuSbct6WWD-Ng")]
    [Description(@"Normal exchange rate agreement type.")]
    Normal,
    
    /// <summary>
    /// Spot agreement exchange rate type.
    /// Encoded/decoded by serializers as "SPOT".
    /// </summary>
    [EnumMember(Value = "SPOT")]
    [IsoId("_vLLHkIZ5EeuSbct6WWD-Ng")]
    [Description(@"Spot agreement exchange rate type.")]
    Spot,
    
    /// <summary>
    /// Forward contract exchange rate type.
    /// Encoded/decoded by serializers as "FWCT".
    /// </summary>
    [EnumMember(Value = "FWCT")]
    [IsoId("_zdOyoIZ5EeuSbct6WWD-Ng")]
    [Description(@"Forward contract exchange rate type.")]
    ForwardContract,
    
    /// <summary>
    /// Other exchange rate agreement type defined at national level.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_7OiLwIZ5EeuSbct6WWD-Ng")]
    [Description(@"Other exchange rate agreement type defined at national level.")]
    OtherNational,
    
    /// <summary>
    /// Other exchange rate agreement type that is privately defined.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_ENkjUIZ6EeuSbct6WWD-Ng")]
    [Description(@"Other exchange rate agreement type that is privately defined.")]
    OtherPrivate,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExchangeRateAgreementTypeCodeMetadataExtensions
{
    private static readonly ExchangeRateAgreementTypeCodeDropdownSource _dropdownSource = new ExchangeRateAgreementTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExchangeRateAgreementTypeCodeDropdownRow GetMetadata(this ExchangeRateAgreementTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


