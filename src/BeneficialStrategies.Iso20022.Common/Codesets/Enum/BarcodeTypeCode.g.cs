﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BarcodeTypeCode.  ISO2002 ID# _1dJHwNuYEeiB5uLfkg9ZJA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of Barcode coding.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1dJHwNuYEeiB5uLfkg9ZJA")]
[Description(@"Type of Barcode coding.")]
public enum BarcodeTypeCode
{
    /// <summary>
    /// Barcode encoded according to the EAN8 standard.
    /// </summary>
    [EnumMember(Value = "EAN8")]
    [IsoId("_QG8Q4NuZEeiB5uLfkg9ZJA")]
    [Description(@"Barcode encoded according to the EAN8 standard.")]
    EAN8,
    
    /// <summary>
    /// Barcode encoded according to the EAN13 standard.
    /// </summary>
    [EnumMember(Value = "EA13")]
    [IsoId("_VyLVYNuZEeiB5uLfkg9ZJA")]
    [Description(@"Barcode encoded according to the EAN13 standard.")]
    EA13,
    
    /// <summary>
    /// Barcode encoded according to the Code 39 standard.
    /// </summary>
    [EnumMember(Value = "C039")]
    [IsoId("_ZRfU4NuZEeiB5uLfkg9ZJA")]
    [Description(@"Barcode encoded according to the Code 39 standard.")]
    C039,
    
    /// <summary>
    /// Barcode encoded according to the UPCA standard.
    /// </summary>
    [EnumMember(Value = "UPCA")]
    [IsoId("_dcmDYNuZEeiB5uLfkg9ZJA")]
    [Description(@"Barcode encoded according to the UPCA standard.")]
    UPCA,
    
    /// <summary>
    /// Barcode encoded according to the Code 25 standard.
    /// </summary>
    [EnumMember(Value = "C025")]
    [IsoId("_hhElcNuZEeiB5uLfkg9ZJA")]
    [Description(@"Barcode encoded according to the Code 25 standard.")]
    C025,
    
    /// <summary>
    /// Barcode encoded according to the Code 128 standard.
    /// </summary>
    [EnumMember(Value = "C128")]
    [IsoId("_laFeYNuZEeiB5uLfkg9ZJA")]
    [Description(@"Barcode encoded according to the Code 128 standard.")]
    C128,
    
    /// <summary>
    /// Barcode encoded according to the PDF417 standard.
    /// </summary>
    [EnumMember(Value = "P417")]
    [IsoId("_oyYP4NuZEeiB5uLfkg9ZJA")]
    [Description(@"Barcode encoded according to the PDF417 standard.")]
    P417,
    
    /// <summary>
    /// Barcode encoded according to the 2Dimensions Quick Response Code Standard.
    /// </summary>
    [EnumMember(Value = "COQR")]
    [IsoId("_sx0g8NuZEeiB5uLfkg9ZJA")]
    [Description(@"Barcode encoded according to the 2Dimensions Quick Response Code Standard.")]
    COQR,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BarcodeTypeCodeMetadataExtensions
{
    private static readonly BarcodeTypeCodeDropdownSource _dropdownSource = new BarcodeTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBarcodeTypeCodeDropdownRow GetMetadata(this BarcodeTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


