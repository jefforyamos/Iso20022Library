﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InitialPhysicalForm1Code.  ISO2002 ID# _hblKnGliEeGaMcKyqKNRfQ_-1870538349.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the physical form of the securities.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hblKnGliEeGaMcKyqKNRfQ_-1870538349")]
[Description(@"Indicates the physical form of the securities.")]
[DerivedFrom(typeof(InitialPhysicalFormCode))]
public enum InitialPhysicalForm1Code
{
    /// <summary>
    /// Initial Physical Form is GT.
    /// Encoded/decoded by serializers as "GT".
    /// </summary>
    [EnumMember(Value = "GTGT")]
    [IsoId("_hblKnWliEeGaMcKyqKNRfQ_-933244343")]
    [Description(@"Initial Physical Form is GT.")]
    GT,
    
    /// <summary>
    /// Initial Physical Form is GP.
    /// Encoded/decoded by serializers as "GP".
    /// </summary>
    [EnumMember(Value = "GPGP")]
    [IsoId("_hblKnmliEeGaMcKyqKNRfQ_1809811702")]
    [Description(@"Initial Physical Form is GP.")]
    GP,
    
    /// <summary>
    /// Initial Physical Form is definitive.
    /// Encoded/decoded by serializers as "Definitive".
    /// </summary>
    [EnumMember(Value = "DERN")]
    [IsoId("_hblKn2liEeGaMcKyqKNRfQ_-2031068325")]
    [Description(@"Initial Physical Form is definitive.")]
    Definitive,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InitialPhysicalForm1CodeMetadataExtensions
{
    private static readonly InitialPhysicalForm1CodeDropdownSource _dropdownSource = new InitialPhysicalForm1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInitialPhysicalForm1CodeDropdownRow GetMetadata(this InitialPhysicalForm1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


