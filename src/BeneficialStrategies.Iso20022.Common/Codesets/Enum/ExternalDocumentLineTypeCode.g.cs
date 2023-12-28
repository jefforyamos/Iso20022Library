﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalDocumentLineTypeCode.  ISO2002 ID# _RxJesLf7EeeNBs0sDWdcSw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the document line type as published in an external document type code list.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RxJesLf7EeeNBs0sDWdcSw")]
[Description(@"Specifies the document line type as published in an external document type code list.")]
public enum ExternalDocumentLineTypeCode
{
    /// <summary>
    /// Line item reference is an additional product identification assigned by the manufacturer.
    /// Encoded/decoded by serializers as "ADPI".
    /// </summary>
    [EnumMember(Value = "ADPI")]
    [IsoId("_uSQ3vPRYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is an additional product identification assigned by the manufacturer.")]
    AdditionalProductIdentificationAssignedByTheManufacturer,
    
    /// <summary>
    /// Line item reference is an alternate International Standard Book Number (ISBN).
    /// Encoded/decoded by serializers as "AISB".
    /// </summary>
    [EnumMember(Value = "AISB")]
    [IsoId("_uSaosPRYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is an alternate International Standard Book Number (ISBN).")]
    AlternateISBN,
    
    /// <summary>
    /// Line item reference is an asset number.
    /// Encoded/decoded by serializers as "ASNB".
    /// </summary>
    [EnumMember(Value = "ASNB")]
    [IsoId("_uSaos_RYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is an asset number.")]
    AssetNumber,
    
    /// <summary>
    /// Line item reference is a catalog number.
    /// Encoded/decoded by serializers as "CTNB".
    /// </summary>
    [EnumMember(Value = "CTNB")]
    [IsoId("_uSaotvRYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is a catalog number.")]
    CatalogNumber,
    
    /// <summary>
    /// Line item reference is Dun & Bradstreet Standard Product and Service code.
    /// Encoded/decoded by serializers as "DBSP".
    /// </summary>
    [EnumMember(Value = "DBSP")]
    [IsoId("_uSjyoPRYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is Dun & Bradstreet Standard Product and Service code.")]
    DunBradstreetStandardProductAndServiceCode,
    
    /// <summary>
    /// Line item reference is an European Article Number (EAN).
    /// Encoded/decoded by serializers as "EANN".
    /// </summary>
    [EnumMember(Value = "EANN")]
    [IsoId("_uSjyo_RYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is an European Article Number (EAN).")]
    EuropeanArticleNumberEAN2551,
    
    /// <summary>
    /// Line item reference is an equipment identification number.
    /// Encoded/decoded by serializers as "EINB".
    /// </summary>
    [EnumMember(Value = "EINB")]
    [IsoId("_uSjypvRYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is an equipment identification number.")]
    EquipmentIdentificationNumber,
    
    /// <summary>
    /// Line item reference is a general specification number.
    /// Encoded/decoded by serializers as "GSNB".
    /// </summary>
    [EnumMember(Value = "GSNB")]
    [IsoId("_uStjoPRYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is a general specification number.")]
    GeneralSpecificationNumber,
    
    /// <summary>
    /// Line item reference is a Health Care Industry Bar Code (HIBC)
    /// Encoded/decoded by serializers as "HIBC".
    /// </summary>
    [EnumMember(Value = "HIBC")]
    [IsoId("_uStjo_RYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is a Health Care Industry Bar Code (HIBC)")]
    HIBCHealthCareIndustryBarCode,
    
    /// <summary>
    /// Line item reference is an International Standard Book Number (ISBN).
    /// Encoded/decoded by serializers as "ISBN".
    /// </summary>
    [EnumMember(Value = "ISBN")]
    [IsoId("_uStjpvRYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is an International Standard Book Number (ISBN).")]
    InternationalStandardBookNumberISBN,
    
    /// <summary>
    /// Line item reference is a lot number.
    /// Encoded/decoded by serializers as "LTNB".
    /// </summary>
    [EnumMember(Value = "LTNB")]
    [IsoId("_uS3UoPRYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is a lot number.")]
    LotNumber,
    
    /// <summary>
    /// Line item reference is a model number
    /// Encoded/decoded by serializers as "MDNB".
    /// </summary>
    [EnumMember(Value = "MDNB")]
    [IsoId("_uS3Uo_RYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is a model number")]
    ModelNumber,
    
    /// <summary>
    /// Line item reference is a part reference number.
    /// Encoded/decoded by serializers as "PRNB".
    /// </summary>
    [EnumMember(Value = "PRNB")]
    [IsoId("_uS3UpvRYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is a part reference number.")]
    PartNumber,
    
    /// <summary>
    /// Line item reference is a product type code.
    /// Encoded/decoded by serializers as "PTCD".
    /// </summary>
    [EnumMember(Value = "PTCD")]
    [IsoId("_uS3UqfRYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is a product type code.")]
    ProductTypeCode,
    
    /// <summary>
    /// Line item reference is a stock number.
    /// Encoded/decoded by serializers as "SKNB".
    /// </summary>
    [EnumMember(Value = "SKNB")]
    [IsoId("_uS3UrPRYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is a stock number.")]
    StockNumber,
    
    /// <summary>
    /// Line item reference is a style number.
    /// Encoded/decoded by serializers as "STNB".
    /// </summary>
    [EnumMember(Value = "STNB")]
    [IsoId("_uTAekPRYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is a style number.")]
    StyleNumber,
    
    /// <summary>
    /// Line item reference is a technical order number.
    /// Encoded/decoded by serializers as "TONB".
    /// </summary>
    [EnumMember(Value = "TONB")]
    [IsoId("_uTAek_RYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is a technical order number.")]
    TechnicalOrderNumber,
    
    /// <summary>
    /// Line item reference is an UPC consumer package code.
    /// Encoded/decoded by serializers as "UPCC".
    /// </summary>
    [EnumMember(Value = "UPCC")]
    [IsoId("_uTAelvRYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is an UPC consumer package code.")]
    UPCConsumerPackageCode,
    
    /// <summary>
    /// Line item reference is an Universal Product Number.
    /// Encoded/decoded by serializers as "UPNB".
    /// </summary>
    [EnumMember(Value = "UPNB")]
    [IsoId("_uTKPkPRYEeuLhpyIdtJzwg")]
    [Description(@"Line item reference is an Universal Product Number.")]
    UniversalProductNumber,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalDocumentLineTypeCodeMetadataExtensions
{
    private static readonly ExternalDocumentLineTypeCodeDropdownSource _dropdownSource = new ExternalDocumentLineTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalDocumentLineTypeCodeDropdownRow GetMetadata(this ExternalDocumentLineTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


