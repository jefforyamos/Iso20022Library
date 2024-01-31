﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for EncryptionFormat1Code.  ISO2002 ID# _IJtXQGi4EeS87LmvcA55sg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Format of data before encryption, if the format is not plaintext or implicit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_IJtXQGi4EeS87LmvcA55sg")]
[Description(@"Format of data before encryption, if the format is not plaintext or implicit.")]
[DerivedFrom(typeof(EncryptionFormatCode))]
public enum EncryptionFormat1Code
{
    /// <summary>
    /// Format of a cryptographic key specified by the ANSI X9 TR-31 standard.
    /// Encoded/decoded by serializers as "TR31".
    /// </summary>
    [EnumMember(Value = "TR31")]
    [IsoId("_KUksUGi4EeS87LmvcA55sg")]
    [Description(@"Format of a cryptographic key specified by the ANSI X9 TR-31 standard.")]
    TR31 = EncryptionFormatCode.TR31, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Format of a cryptographic key specified by the ANSI X9 TR-34 standard.
    /// Encoded/decoded by serializers as "TR34".
    /// </summary>
    [EnumMember(Value = "TR34")]
    [IsoId("_KfMn8Wi4EeS87LmvcA55sg")]
    [Description(@"Format of a cryptographic key specified by the ANSI X9 TR-34 standard.")]
    TR34 = EncryptionFormatCode.TR34, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class EncryptionFormat1CodeMetadataExtensions
{
    private static readonly EncryptionFormat1CodeDropdownSource _dropdownSource = new EncryptionFormat1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IEncryptionFormat1CodeDropdownRow GetMetadata(this EncryptionFormat1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


