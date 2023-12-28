﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AttributeType2Code.  ISO2002 ID# _xXLcMI4TEeW6h7rGyYlyTg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Attributes of certificate extensions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xXLcMI4TEeW6h7rGyYlyTg")]
[Description(@"Attributes of certificate extensions.")]
[DerivedFrom(typeof(AttributeTypeCode))]
public enum AttributeType2Code
{
    /// <summary>
    /// Email address of the certificate subject.
    /// Encoded/decoded by serializers as "EmailAddress".
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_56IUsY4TEeW6h7rGyYlyTg")]
    [Description(@"Email address of the certificate subject.")]
    EmailAddress,
    
    /// <summary>
    /// Password by which an entity may request certificate revocation.
    /// Encoded/decoded by serializers as "ChallengePassword".
    /// </summary>
    [EnumMember(Value = "CHLG")]
    [IsoId("_6f_a044TEeW6h7rGyYlyTg")]
    [Description(@"Password by which an entity may request certificate revocation.")]
    ChallengePassword,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AttributeType2CodeMetadataExtensions
{
    private static readonly AttributeType2CodeDropdownSource _dropdownSource = new AttributeType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAttributeType2CodeDropdownRow GetMetadata(this AttributeType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


