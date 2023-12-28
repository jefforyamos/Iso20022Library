﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Response10Code.  ISO2002 ID# _gImmcPBkEeesZ516Jn5sHw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Response codes for verification
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gImmcPBkEeesZ516Jn5sHw")]
[Description(@"Response codes for verification")]
[DerivedFrom(typeof(ResponseCode))]
public enum Response10Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InProgress".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_SpLhgX0mEemfrNOe0zHQyg")]
    [Description(@"??")]
    InProgress,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "UnderReview".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_SpLhg30mEemfrNOe0zHQyg")]
    [Description(@"??")]
    UnderReview,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_SpLhhX0mEemfrNOe0zHQyg")]
    [Description(@"??")]
    OtherPrivate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_SpLhh30mEemfrNOe0zHQyg")]
    [Description(@"??")]
    OtherNational,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Failure".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bt7vcX06Eem0U9m89kippg")]
    [Description(@"??")]
    Failure,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Success".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_cQcmoX06Eem0U9m89kippg")]
    [Description(@"??")]
    Success,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Response10CodeMetadataExtensions
{
    private static readonly Response10CodeDropdownSource _dropdownSource = new Response10CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IResponse10CodeDropdownRow GetMetadata(this Response10Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


