﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MessageFunction44Code.  ISO2002 ID# _eYxeEEGJEeyZG7AU5fJYtQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of process related to a specific message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_eYxeEEGJEeyZG7AU5fJYtQ")]
[Description(@"Type of process related to a specific message.")]
[DerivedFrom(typeof(MessageFunctionCode))]
public enum MessageFunction44Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Advice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_idxkkUGJEeyZG7AU5fJYtQ")]
    [Description(@"??")]
    Advice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Notification".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_j4yKAUGJEeyZG7AU5fJYtQ")]
    [Description(@"??")]
    Notification,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Instructure".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_kUU2gUGJEeyZG7AU5fJYtQ")]
    [Description(@"??")]
    Instructure,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Request".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_lxafkUGJEeyZG7AU5fJYtQ")]
    [Description(@"??")]
    Request,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MessageFunction44CodeMetadataExtensions
{
    private static readonly MessageFunction44CodeDropdownSource _dropdownSource = new MessageFunction44CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMessageFunction44CodeDropdownRow GetMetadata(this MessageFunction44Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

