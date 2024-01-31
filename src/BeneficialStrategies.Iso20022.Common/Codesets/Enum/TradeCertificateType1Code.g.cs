﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TradeCertificateType1Code.  ISO2002 ID# _YmCmyNp-Ed-ak6NoX_4Aeg_-427114470.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of trade certificate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YmCmyNp-Ed-ak6NoX_4Aeg_-427114470")]
[Description(@"Specifies the type of trade certificate.")]
[DerivedFrom(typeof(TradeCertificateTypeCode))]
public enum TradeCertificateType1Code
{
    /// <summary>
    /// Certificate of analysis.
    /// Encoded/decoded by serializers as "ANLY".
    /// </summary>
    [EnumMember(Value = "ANLY")]
    [IsoId("_YmLwsNp-Ed-ak6NoX_4Aeg_133463751")]
    [Description(@"Certificate of analysis.")]
    Analysis = TradeCertificateTypeCode.Analysis, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certificate of quality.
    /// Encoded/decoded by serializers as "QUAL".
    /// </summary>
    [EnumMember(Value = "QUAL")]
    [IsoId("_YmLwsdp-Ed-ak6NoX_4Aeg_171327058")]
    [Description(@"Certificate of quality.")]
    Quality = TradeCertificateTypeCode.Quality, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certificate of quantity.
    /// Encoded/decoded by serializers as "QUAN".
    /// </summary>
    [EnumMember(Value = "QUAN")]
    [IsoId("_YmLwstp-Ed-ak6NoX_4Aeg_199955222")]
    [Description(@"Certificate of quantity.")]
    Quantity = TradeCertificateTypeCode.Quantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certificate of weight.
    /// Encoded/decoded by serializers as "WEIG".
    /// </summary>
    [EnumMember(Value = "WEIG")]
    [IsoId("_YmLws9p-Ed-ak6NoX_4Aeg_476088181")]
    [Description(@"Certificate of weight.")]
    Weight = TradeCertificateTypeCode.Weight, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certificate of origin.
    /// Encoded/decoded by serializers as "ORIG".
    /// </summary>
    [EnumMember(Value = "ORIG")]
    [IsoId("_YmLwtNp-Ed-ak6NoX_4Aeg_489018208")]
    [Description(@"Certificate of origin.")]
    Origin = TradeCertificateTypeCode.Origin, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certificate of health.
    /// Encoded/decoded by serializers as "HEAL".
    /// </summary>
    [EnumMember(Value = "HEAL")]
    [IsoId("_YmLwtdp-Ed-ak6NoX_4Aeg_501024056")]
    [Description(@"Certificate of health.")]
    Health = TradeCertificateTypeCode.Health, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Phytosanitary certificate.
    /// Encoded/decoded by serializers as "PHYT".
    /// </summary>
    [EnumMember(Value = "PHYT")]
    [IsoId("_YmLwttp-Ed-ak6NoX_4Aeg_504719603")]
    [Description(@"Phytosanitary certificate.")]
    Phytosanitary = TradeCertificateTypeCode.Phytosanitary, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TradeCertificateType1CodeMetadataExtensions
{
    private static readonly TradeCertificateType1CodeDropdownSource _dropdownSource = new TradeCertificateType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITradeCertificateType1CodeDropdownRow GetMetadata(this TradeCertificateType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


