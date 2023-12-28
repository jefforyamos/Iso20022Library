﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ProtectionMethod1Code.  ISO2002 ID# _QaPzMJyBEeuo7tDc4CDHXg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Method used to protect the sensitive data.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QaPzMJyBEeuo7tDc4CDHXg")]
[Description(@"Method used to protect the sensitive data.")]
[DerivedFrom(typeof(ProtectionMethodCode))]
public enum ProtectionMethod1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_UuoZgZyBEeuo7tDc4CDHXg")]
    [Description(@"??")]
    OtherNational,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_U3W3sZyBEeuo7tDc4CDHXg")]
    [Description(@"??")]
    OtherPrivate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SecureElement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VdBJgZyBEeuo7tDc4CDHXg")]
    [Description(@"??")]
    SecureElement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SecureEnclave".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VdwJUZyBEeuo7tDc4CDHXg")]
    [Description(@"??")]
    SecureEnclave,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Software".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VegXQZyBEeuo7tDc4CDHXg")]
    [Description(@"??")]
    Software,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TrustedExectutionEnvironment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VfMTwZyBEeuo7tDc4CDHXg")]
    [Description(@"??")]
    TrustedExectutionEnvironment,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ProtectionMethod1CodeMetadataExtensions
{
    private static readonly ProtectionMethod1CodeDropdownSource _dropdownSource = new ProtectionMethod1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IProtectionMethod1CodeDropdownRow GetMetadata(this ProtectionMethod1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

