﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MessageFunction23Code.  ISO2002 ID# _DZ7GgFULEeetiruPyDPo0Q.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies messages related to a network management process.
/// ISO 8583 MTI
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DZ7GgFULEeetiruPyDPo0Q")]
[Description(@"Identifies messages related to a network management process. ISO 8583 MTI")]
[DerivedFrom(typeof(MessageFunctionCode))]
public enum MessageFunction23Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Advice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_W52kcemuEemNVKPwszFC-A")]
    [Description(@"??")]
    Advice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Request".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YVDXIemuEemNVKPwszFC-A")]
    [Description(@"??")]
    Request,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MessageFunction23CodeMetadataExtensions
{
    private static readonly MessageFunction23CodeDropdownSource _dropdownSource = new MessageFunction23CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMessageFunction23CodeDropdownRow GetMetadata(this MessageFunction23Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

