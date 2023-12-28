﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ATMMediaType3Code.  ISO2002 ID# _Xci-AK4DEeWL1uap3dNhCQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Category of media items.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Xci-AK4DEeWL1uap3dNhCQ")]
[Description(@"Category of media items.")]
[DerivedFrom(typeof(ATMMediaTypeCode))]
public enum ATMMediaType3Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Counterfeit".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dBRK0a4DEeWL1uap3dNhCQ")]
    [Description(@"??")]
    Counterfeit,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Fit".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dPbio64DEeWL1uap3dNhCQ")]
    [Description(@"??")]
    Fit,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FitAndUnfit".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_daqiQ64DEeWL1uap3dNhCQ")]
    [Description(@"??")]
    FitAndUnfit,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Suspect".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ecYd864DEeWL1uap3dNhCQ")]
    [Description(@"??")]
    Suspect,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Unfit".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_euKxg64DEeWL1uap3dNhCQ")]
    [Description(@"??")]
    Unfit,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Unrecognised".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_e3j-E64DEeWL1uap3dNhCQ")]
    [Description(@"??")]
    Unrecognised,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ATMMediaType3CodeMetadataExtensions
{
    private static readonly ATMMediaType3CodeDropdownSource _dropdownSource = new ATMMediaType3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IATMMediaType3CodeDropdownRow GetMetadata(this ATMMediaType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

