﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Side5Code.  ISO2002 ID# _I0b5MOzkEeSBf_ghFpb9rQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Side taken by a party on an order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_I0b5MOzkEeSBf_ghFpb9rQ")]
[Description(@"Side taken by a party on an order.")]
[DerivedFrom(typeof(SideCode))]
public enum Side5Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SellShort".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_J93mcezkEeSBf_ghFpb9rQ")]
    [Description(@"??")]
    SellShort,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Sell".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_KGQtcezkEeSBf_ghFpb9rQ")]
    [Description(@"??")]
    Sell,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SellShortExempt".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Kaep8ezkEeSBf_ghFpb9rQ")]
    [Description(@"??")]
    SellShortExempt,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Undisclosed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_KA-CwaiqEeWRLJcxVQAwmw")]
    [Description(@"??")]
    Undisclosed,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Side5CodeMetadataExtensions
{
    private static readonly Side5CodeDropdownSource _dropdownSource = new Side5CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISide5CodeDropdownRow GetMetadata(this Side5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


