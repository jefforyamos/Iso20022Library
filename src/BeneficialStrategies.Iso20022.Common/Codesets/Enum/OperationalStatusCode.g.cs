﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OperationalStatusCode.  ISO2002 ID# _w6pwoCDYEeWCLu74WLgP4w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifes the operational status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_w6pwoCDYEeWCLu74WLgP4w")]
[Description(@"Specifes the operational status.")]
[Derivations(typeof(OperationalStatus1Code))]
// External derivations that should be provided by the proper interface are: 
public enum OperationalStatusCode
{
    /// <summary>
    /// Enabled.
    /// Encoded/decoded by serializers as "ENAB".
    /// </summary>
    [EnumMember(Value = "ENAB")]
    [IsoId("_8DcqACDYEeWCLu74WLgP4w")]
    [Description(@"Enabled.")]
    Enabled,
    
    /// <summary>
    /// Special circumstances.
    /// Encoded/decoded by serializers as "SPEC".
    /// </summary>
    [EnumMember(Value = "SPEC")]
    [IsoId("__qqBQCDYEeWCLu74WLgP4w")]
    [Description(@"Special circumstances.")]
    SpecialCircumstances,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OperationalStatusCodeMetadataExtensions
{
    private static readonly OperationalStatusCodeDropdownSource _dropdownSource = new OperationalStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOperationalStatusCodeDropdownRow GetMetadata(this OperationalStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


