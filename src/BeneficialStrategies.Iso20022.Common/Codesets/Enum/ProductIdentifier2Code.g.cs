﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ProductIdentifier2Code.  ISO2002 ID# _ZVuXR9p-Ed-ak6NoX_4Aeg_1808391573.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of identifier of a product.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZVuXR9p-Ed-ak6NoX_4Aeg_1808391573")]
[Description(@"Specifies the type of identifier of a product.")]
[DerivedFrom(typeof(ProductIdentifierCode))]
public enum ProductIdentifier2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BuyersItemNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZVuXSNp-Ed-ak6NoX_4Aeg_1808391590")]
    [Description(@"??")]
    BuyersItemNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CommercialDescriptionCodeName".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZVuXSdp-Ed-ak6NoX_4Aeg_1808391591")]
    [Description(@"??")]
    CommercialDescriptionCodeName,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "EAN".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZV3hMNp-Ed-ak6NoX_4Aeg_1808391608")]
    [Description(@"??")]
    EAN,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "HarmonizedTariffCodeName".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZV3hMdp-Ed-ak6NoX_4Aeg_1808391609")]
    [Description(@"??")]
    HarmonizedTariffCodeName,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ManufacturersItemNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZV3hMtp-Ed-ak6NoX_4Aeg_1808391850")]
    [Description(@"??")]
    ManufacturersItemNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ModelNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZV3hM9p-Ed-ak6NoX_4Aeg_1808391867")]
    [Description(@"??")]
    ModelNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PartNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZV3hNNp-Ed-ak6NoX_4Aeg_1808391868")]
    [Description(@"??")]
    PartNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "QuotaCategory".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZV3hNdp-Ed-ak6NoX_4Aeg_1808391885")]
    [Description(@"??")]
    QuotaCategory,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StyleNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZV3hNtp-Ed-ak6NoX_4Aeg_1808391886")]
    [Description(@"??")]
    StyleNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SuppliersItemNumber".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZV3hN9p-Ed-ak6NoX_4Aeg_-2058986456")]
    [Description(@"??")]
    SuppliersItemNumber,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UniversalProductCode".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZV3hONp-Ed-ak6NoX_4Aeg_-2016505606")]
    [Description(@"??")]
    UniversalProductCode,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ProductIdentifier2CodeMetadataExtensions
{
    private static readonly ProductIdentifier2CodeDropdownSource _dropdownSource = new ProductIdentifier2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IProductIdentifier2CodeDropdownRow GetMetadata(this ProductIdentifier2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

