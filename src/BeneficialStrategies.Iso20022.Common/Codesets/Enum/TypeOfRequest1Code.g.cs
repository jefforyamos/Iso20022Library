﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TypeOfRequest1Code.  ISO2002 ID# _EuVucNveEeqxGfKJubfhIw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EuVucNveEeqxGfKJubfhIw")]
[Description(@"Specifies a type of request.")]
[DerivedFrom(typeof(TypeOfRequestCode))]
public enum TypeOfRequest1Code
{
    /// <summary>
    /// Request for information.
    /// Encoded/decoded by serializers as "Information".
    /// </summary>
    [EnumMember(Value = "INFO")]
    [IsoId("_GYj0kdveEeqxGfKJubfhIw")]
    [Description(@"Request for information.")]
    Information,
    
    /// <summary>
    /// Request for status.
    /// Encoded/decoded by serializers as "Status".
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_GhCbIdveEeqxGfKJubfhIw")]
    [Description(@"Request for status.")]
    Status,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TypeOfRequest1CodeMetadataExtensions
{
    private static readonly TypeOfRequest1CodeDropdownSource _dropdownSource = new TypeOfRequest1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITypeOfRequest1CodeDropdownRow GetMetadata(this TypeOfRequest1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


