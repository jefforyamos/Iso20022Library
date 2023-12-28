﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Response11Code.  ISO2002 ID# _Tya4MS8NEeu125Ip9zFcsQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Result of the processing of the message
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Tya4MS8NEeu125Ip9zFcsQ")]
[Description(@"Result of the processing of the message")]
[DerivedFrom(typeof(ResponseCode))]
public enum Response11Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Warning".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_UGttMS8NEeu125Ip9zFcsQ")]
    [Description(@"??")]
    Warning,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Failure".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_UGttMy8NEeu125Ip9zFcsQ")]
    [Description(@"??")]
    Failure,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Success".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZqPAIS8NEeu125Ip9zFcsQ")]
    [Description(@"??")]
    Success,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Response11CodeMetadataExtensions
{
    private static readonly Response11CodeDropdownSource _dropdownSource = new Response11CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IResponse11CodeDropdownRow GetMetadata(this Response11Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


