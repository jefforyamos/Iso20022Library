﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TypeOfRequestCode.  ISO2002 ID# _92aNUNvdEeqxGfKJubfhIw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_92aNUNvdEeqxGfKJubfhIw")]
[Description(@"Specifies a type of request.")]
[Derivations(typeof(TypeOfRequest1Code))]
public enum TypeOfRequestCode
{
    /// <summary>
    /// Request for status.
    /// Encoded/decoded by serializers as "STAT".
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("__q5pwNvdEeqxGfKJubfhIw")]
    [Description(@"Request for status.")]
    Status,
    
    /// <summary>
    /// Request for information.
    /// Encoded/decoded by serializers as "INFO".
    /// </summary>
    [EnumMember(Value = "INFO")]
    [IsoId("_BILgENveEeqxGfKJubfhIw")]
    [Description(@"Request for information.")]
    Information,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TypeOfRequestCodeMetadataExtensions
{
    private static readonly TypeOfRequestCodeDropdownSource _dropdownSource = new TypeOfRequestCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITypeOfRequestCodeDropdownRow GetMetadata(this TypeOfRequestCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


