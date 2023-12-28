﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalMandateStatus1Code.  ISO2002 ID# _qC1AgJm_Eeao_Z127E9uYg.
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
[IsoId("_qC1AgJm_Eeao_Z127E9uYg")]
[Description(@"Specifies the external mandate status code in the format of character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalMandateStatusCode))]
public enum ExternalMandateStatus1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Active".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uYrBtfRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Active,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Cancelled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uYrBuPRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Cancelled,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Expired".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uYrBu_RYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Expired,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Suspended".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_uY0ysvRYEeuLhpyIdtJzwg")]
    [Description(@"??")]
    Suspended,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalMandateStatus1CodeMetadataExtensions
{
    private static readonly ExternalMandateStatus1CodeDropdownSource _dropdownSource = new ExternalMandateStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalMandateStatus1CodeDropdownRow GetMetadata(this ExternalMandateStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


