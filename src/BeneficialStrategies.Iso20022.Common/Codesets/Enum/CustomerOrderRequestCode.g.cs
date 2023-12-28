﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CustomerOrderRequestCode.  ISO2002 ID# _ETkWwN6JEeiwsev40qZGEQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of customer orders that must be sent in response message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ETkWwN6JEeiwsev40qZGEQ")]
[Description(@"Type of customer orders that must be sent in response message.")]
[Derivations(typeof(CustomerOrderRequest1Code))]
// External derivations that should be provided by the proper interface are: 
public enum CustomerOrderRequestCode
{
    /// <summary>
    /// Customer order not completed.
    /// Encoded/decoded by serializers as "OPEN".
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_J3KiMN6JEeiwsev40qZGEQ")]
    [Description(@"Customer order not completed.")]
    Open,
    
    /// <summary>
    /// Completed customer orders.
    /// Encoded/decoded by serializers as "CLSD".
    /// </summary>
    [EnumMember(Value = "CLSD")]
    [IsoId("_J5EmsN6JEeiwsev40qZGEQ")]
    [Description(@"Completed customer orders.")]
    Closed,
    
    /// <summary>
    /// All types of CustomerOrder should be listed, some are open others closed.
    /// Encoded/decoded by serializers as "BOTH".
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_J-B_MN6JEeiwsev40qZGEQ")]
    [Description(@"All types of CustomerOrder should be listed, some are open others closed.")]
    Both,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CustomerOrderRequestCodeMetadataExtensions
{
    private static readonly CustomerOrderRequestCodeDropdownSource _dropdownSource = new CustomerOrderRequestCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICustomerOrderRequestCodeDropdownRow GetMetadata(this CustomerOrderRequestCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


