﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalMandateStatusCode.  ISO2002 ID# _C0GiwPS8EeiAX8EjdnKKRw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external mandate status code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_C0GiwPS8EeiAX8EjdnKKRw")]
[Description(@"Specifies the external mandate status code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalMandateStatus1Code))]
public enum ExternalMandateStatusCode
{
    /// <summary>
    /// The mandate is active.
    /// Encoded/decoded by serializers as "ACTV".
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_uYrBs_RYEeuLhpyIdtJzwg")]
    [Description(@"The mandate is active.")]
    Active,
    
    /// <summary>
    /// The mandate is cancelled.
    /// Encoded/decoded by serializers as "CANC".
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_uYrBtvRYEeuLhpyIdtJzwg")]
    [Description(@"The mandate is cancelled.")]
    Cancelled,
    
    /// <summary>
    /// The mandate has passed the end date.
    /// Encoded/decoded by serializers as "EXPI".
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_uYrBufRYEeuLhpyIdtJzwg")]
    [Description(@"The mandate has passed the end date.")]
    Expired,
    
    /// <summary>
    /// The mandate is put on hold.
    /// Encoded/decoded by serializers as "SUSP".
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_uY0ysPRYEeuLhpyIdtJzwg")]
    [Description(@"The mandate is put on hold.")]
    Suspended,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalMandateStatusCodeMetadataExtensions
{
    private static readonly ExternalMandateStatusCodeDropdownSource _dropdownSource = new ExternalMandateStatusCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalMandateStatusCodeDropdownRow GetMetadata(this ExternalMandateStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


