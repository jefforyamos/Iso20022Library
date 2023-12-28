﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PutTypeCode.  ISO2002 ID# _ha1js2liEeGaMcKyqKNRfQ_477387752.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the type of execution of the put feature.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ha1js2liEeGaMcKyqKNRfQ_477387752")]
[Description(@"Defines the type of execution of the put feature.")]
public enum PutTypeCode
{
    /// <summary>
    /// Type of execution of the put feature is mandatory.
    /// Encoded/decoded by serializers as "MAND".
    /// </summary>
    [EnumMember(Value = "MAND")]
    [IsoId("_ha1jtGliEeGaMcKyqKNRfQ_-304925813")]
    [Description(@"Type of execution of the put feature is mandatory.")]
    Mandatory,
    
    /// <summary>
    /// Type of execution of the put feature is optional.
    /// Encoded/decoded by serializers as "OPTI".
    /// </summary>
    [EnumMember(Value = "OPTI")]
    [IsoId("_ha1jtWliEeGaMcKyqKNRfQ_-1889555559")]
    [Description(@"Type of execution of the put feature is optional.")]
    Optional,
    
    /// <summary>
    /// Type of execution of the put feature could be optional or mandatory.
    /// Encoded/decoded by serializers as "TWOS".
    /// </summary>
    [EnumMember(Value = "TWOS")]
    [IsoId("_ha1jtmliEeGaMcKyqKNRfQ_-1569124192")]
    [Description(@"Type of execution of the put feature could be optional or mandatory.")]
    Both,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PutTypeCodeMetadataExtensions
{
    private static readonly PutTypeCodeDropdownSource _dropdownSource = new PutTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPutTypeCodeDropdownRow GetMetadata(this PutTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

