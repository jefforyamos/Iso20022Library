﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ATMMediaType3Code.  ISO2002 ID# _Xci-AK4DEeWL1uap3dNhCQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

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
    /// Detected counterfeit media.
    /// Encoded/decoded by serializers as "CNTR".
    /// </summary>
    [EnumMember(Value = "CNTR")]
    [IsoId("_dBRK0a4DEeWL1uap3dNhCQ")]
    [Description(@"Detected counterfeit media.")]
    Counterfeit = ATMMediaTypeCode.Counterfeit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fit media.
    /// Encoded/decoded by serializers as "FITN".
    /// </summary>
    [EnumMember(Value = "FITN")]
    [IsoId("_dPbio64DEeWL1uap3dNhCQ")]
    [Description(@"Fit media.")]
    Fit = ATMMediaTypeCode.Fit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fit or unfit media, if fitness cannot be determined.
    /// Encoded/decoded by serializers as "FITU".
    /// </summary>
    [EnumMember(Value = "FITU")]
    [IsoId("_daqiQ64DEeWL1uap3dNhCQ")]
    [Description(@"Fit or unfit media, if fitness cannot be determined.")]
    FitAndUnfit = ATMMediaTypeCode.FitAndUnfit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Suspect media.
    /// Encoded/decoded by serializers as "SPCT".
    /// </summary>
    [EnumMember(Value = "SPCT")]
    [IsoId("_ecYd864DEeWL1uap3dNhCQ")]
    [Description(@"Suspect media.")]
    Suspect = ATMMediaTypeCode.Suspect, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unfit media (unacceptable quality).
    /// Encoded/decoded by serializers as "UNFT".
    /// </summary>
    [EnumMember(Value = "UNFT")]
    [IsoId("_euKxg64DEeWL1uap3dNhCQ")]
    [Description(@"Unfit media (unacceptable quality).")]
    Unfit = ATMMediaTypeCode.Unfit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised media.
    /// Encoded/decoded by serializers as "UNRG".
    /// </summary>
    [EnumMember(Value = "UNRG")]
    [IsoId("_e3j-E64DEeWL1uap3dNhCQ")]
    [Description(@"Unrecognised media.")]
    Unrecognised = ATMMediaTypeCode.Unrecognised, // same ordinal as derivation source for type conversions
    
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


