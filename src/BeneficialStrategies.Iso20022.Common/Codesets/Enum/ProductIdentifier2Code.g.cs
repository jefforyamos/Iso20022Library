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
    /// Product identifier assigned by the buyer.
    /// Encoded/decoded by serializers as "BuyersItemNumber".
    /// </summary>
    [EnumMember(Value = "BINR")]
    [IsoId("_ZVuXSNp-Ed-ak6NoX_4Aeg_1808391590")]
    [Description(@"Product identifier assigned by the buyer.")]
    BuyersItemNumber,
    
    /// <summary>
    /// A code to identify a product based on applicable commercial conditions.
    /// Encoded/decoded by serializers as "CommercialDescriptionCodeName".
    /// </summary>
    [EnumMember(Value = "COMD")]
    [IsoId("_ZVuXSdp-Ed-ak6NoX_4Aeg_1808391591")]
    [Description(@"A code to identify a product based on applicable commercial conditions.")]
    CommercialDescriptionCodeName,
    
    /// <summary>
    /// The unique EAN (European Article Number) code.
    /// Encoded/decoded by serializers as "EAN".
    /// </summary>
    [EnumMember(Value = "EANC")]
    [IsoId("_ZV3hMNp-Ed-ak6NoX_4Aeg_1808391608")]
    [Description(@"The unique EAN (European Article Number) code.")]
    EAN,
    
    /// <summary>
    /// Classification of goods as developed by the Customs Cooperation council.
    /// Encoded/decoded by serializers as "HarmonizedTariffCodeName".
    /// </summary>
    [EnumMember(Value = "HRTR")]
    [IsoId("_ZV3hMdp-Ed-ak6NoX_4Aeg_1808391609")]
    [Description(@"Classification of goods as developed by the Customs Cooperation council.")]
    HarmonizedTariffCodeName,
    
    /// <summary>
    /// Product identifier as assigned by the manufacturer.
    /// Encoded/decoded by serializers as "ManufacturersItemNumber".
    /// </summary>
    [EnumMember(Value = "MANI")]
    [IsoId("_ZV3hMtp-Ed-ak6NoX_4Aeg_1808391850")]
    [Description(@"Product identifier as assigned by the manufacturer.")]
    ManufacturersItemNumber,
    
    /// <summary>
    /// Reference number assigned by the manufacturer to differentiate variations in similar products in a class or group.
    /// Encoded/decoded by serializers as "ModelNumber".
    /// </summary>
    [EnumMember(Value = "MODL")]
    [IsoId("_ZV3hM9p-Ed-ak6NoX_4Aeg_1808391867")]
    [Description(@"Reference number assigned by the manufacturer to differentiate variations in similar products in a class or group.")]
    ModelNumber,
    
    /// <summary>
    /// Reference assigned by the manufacturer to a product part.
    /// Encoded/decoded by serializers as "PartNumber".
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_ZV3hNNp-Ed-ak6NoX_4Aeg_1808391868")]
    [Description(@"Reference assigned by the manufacturer to a product part.")]
    PartNumber,
    
    /// <summary>
    /// Product identifier used by the retail industry.
    /// Encoded/decoded by serializers as "QuotaCategory".
    /// </summary>
    [EnumMember(Value = "QOTA")]
    [IsoId("_ZV3hNdp-Ed-ak6NoX_4Aeg_1808391885")]
    [Description(@"Product identifier used by the retail industry.")]
    QuotaCategory,
    
    /// <summary>
    /// Identification of the style of a product.
    /// Encoded/decoded by serializers as "StyleNumber".
    /// </summary>
    [EnumMember(Value = "STYL")]
    [IsoId("_ZV3hNtp-Ed-ak6NoX_4Aeg_1808391886")]
    [Description(@"Identification of the style of a product.")]
    StyleNumber,
    
    /// <summary>
    /// Number assigned to an article by the supplier of that article.
    /// Encoded/decoded by serializers as "SuppliersItemNumber".
    /// </summary>
    [EnumMember(Value = "SUPI")]
    [IsoId("_ZV3hN9p-Ed-ak6NoX_4Aeg_-2058986456")]
    [Description(@"Number assigned to an article by the supplier of that article.")]
    SuppliersItemNumber,
    
    /// <summary>
    /// Number assigned to a manufacturer's product by the Product Code Council.
    /// Encoded/decoded by serializers as "UniversalProductCode".
    /// </summary>
    [EnumMember(Value = "UPCC")]
    [IsoId("_ZV3hONp-Ed-ak6NoX_4Aeg_-2016505606")]
    [Description(@"Number assigned to a manufacturer's product by the Product Code Council.")]
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


