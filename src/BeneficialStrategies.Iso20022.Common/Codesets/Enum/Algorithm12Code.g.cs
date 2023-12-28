﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Algorithm12Code.  ISO2002 ID# _h6npMWi7EeS87LmvcA55sg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Cryptographic algorithms for the MAC (Message Authentication Code).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_h6npMWi7EeS87LmvcA55sg")]
[Description(@"Cryptographic algorithms for the MAC (Message Authentication Code).")]
[DerivedFrom(typeof(AlgorithmCode))]
public enum Algorithm12Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RetailCBCMAC".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_iHlHIWi7EeS87LmvcA55sg")]
    [Description(@"??")]
    RetailCBCMAC,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RetailSHA256MAC".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_iHlHI2i7EeS87LmvcA55sg")]
    [Description(@"??")]
    RetailSHA256MAC,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SHA256CMACwithAES128".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_iHlHJWi7EeS87LmvcA55sg")]
    [Description(@"??")]
    SHA256CMACwithAES128,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RetailSHA1MAC".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_BK51QWi8EeS87LmvcA55sg")]
    [Description(@"??")]
    RetailSHA1MAC,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SHA384CMACwithAES192".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_DoWIEWi8EeS87LmvcA55sg")]
    [Description(@"??")]
    SHA384CMACwithAES192,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SHA512CMACwithAES256".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Ew-kEWi8EeS87LmvcA55sg")]
    [Description(@"??")]
    SHA512CMACwithAES256,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Algorithm12CodeMetadataExtensions
{
    private static readonly Algorithm12CodeDropdownSource _dropdownSource = new Algorithm12CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAlgorithm12CodeDropdownRow GetMetadata(this Algorithm12Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


