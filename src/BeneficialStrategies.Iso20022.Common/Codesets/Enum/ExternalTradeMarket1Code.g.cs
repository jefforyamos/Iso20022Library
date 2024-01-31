﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalTradeMarket1Code.  ISO2002 ID# _NzE0NzM2-AOSNFX-5096928.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external trade market code in the format of character string with a maximum length of 4 characters.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_NzE0NzM2-AOSNFX-5096928")]
[Description(@"Specifies the external trade market code in the format of character string with a maximum length of 4 characters.|External code sets can be downloaded from www.iso20022.org.|")]
[DerivedFrom(typeof(ExternalTradeMarketCode))]
public enum ExternalTradeMarket1Code
{
    /// <summary>
    /// Factoring service provider, Factoring client and third party in the same country
    /// Encoded/decoded by serializers as "FDMS".
    /// </summary>
    [EnumMember(Value = "FDMS")]
    [IsoId("_uTUAmPRYEeuLhpyIdtJzwg")]
    [Description(@"Factoring service provider, Factoring client and third party in the same country")]
    FactoringDomestic = ExternalTradeMarketCode.FactoringDomestic, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Factoring service provider, Factoring client in the same country, third party in another country
    /// Encoded/decoded by serializers as "FEXP".
    /// </summary>
    [EnumMember(Value = "FEXP")]
    [IsoId("_uTUAm_RYEeuLhpyIdtJzwg")]
    [Description(@"Factoring service provider, Factoring client in the same country, third party in another country")]
    FactoringExport = ExternalTradeMarketCode.FactoringExport, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Factoring client and third party in the same country, Factoring service provider in another country
    /// Encoded/decoded by serializers as "FFDM".
    /// </summary>
    [EnumMember(Value = "FFDM")]
    [IsoId("_uTdKgvRYEeuLhpyIdtJzwg")]
    [Description(@"Factoring client and third party in the same country, Factoring service provider in another country")]
    FactoringForeignDomestic = ExternalTradeMarketCode.FactoringForeignDomestic, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Factoring service provider, Factoring client and third party in the same country, but factoring client has an exceptional VAT ruling, for example if it’s overseas
    /// Encoded/decoded by serializers as "FFDT".
    /// </summary>
    [EnumMember(Value = "FFDT")]
    [IsoId("_uTdKhfRYEeuLhpyIdtJzwg")]
    [Description(@"Factoring service provider, Factoring client and third party in the same country, but factoring client has an exceptional VAT ruling, for example if it’s overseas")]
    FactoringFrenchDomTom = ExternalTradeMarketCode.FactoringFrenchDomTom, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Factoring service provider and third party in the same country, Factoring client in another country
    /// Encoded/decoded by serializers as "FIMP".
    /// </summary>
    [EnumMember(Value = "FIMP")]
    [IsoId("_uTdKiPRYEeuLhpyIdtJzwg")]
    [Description(@"Factoring service provider and third party in the same country, Factoring client in another country")]
    FactoringImport = ExternalTradeMarketCode.FactoringImport, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Factoring service provider, Factoring client and third party in three different countries
    /// Encoded/decoded by serializers as "FREX".
    /// </summary>
    [EnumMember(Value = "FREX")]
    [IsoId("_uTdKi_RYEeuLhpyIdtJzwg")]
    [Description(@"Factoring service provider, Factoring client and third party in three different countries")]
    FactoringReexportedExport = ExternalTradeMarketCode.FactoringReexportedExport, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalTradeMarket1CodeMetadataExtensions
{
    private static readonly ExternalTradeMarket1CodeDropdownSource _dropdownSource = new ExternalTradeMarket1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalTradeMarket1CodeDropdownRow GetMetadata(this ExternalTradeMarket1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


