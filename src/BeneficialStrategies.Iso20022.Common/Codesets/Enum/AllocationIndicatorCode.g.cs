﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AllocationIndicatorCode.  ISO2002 ID# _jsRFAyjnEeK1Sbo8NpBROA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the trade is a pre-allocation or a post-allocation trade, or whether the trade is unallocated.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jsRFAyjnEeK1Sbo8NpBROA")]
[Description(@"Specifies whether the trade is a pre-allocation or a post-allocation trade, or whether the trade is unallocated.")]
public enum AllocationIndicatorCode
{
    /// <summary>
    /// Trade is a post-allocation trade.
    /// Encoded/decoded by serializers as "POST".
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_wb0g0CjnEeK1Sbo8NpBROA")]
    [Description(@"Trade is a post-allocation trade.")]
    Post_allocation,
    
    /// <summary>
    /// Trade is a pre-allocation trade.
    /// Encoded/decoded by serializers as "PREA".
    /// </summary>
    [EnumMember(Value = "PREA")]
    [IsoId("_EewDoCjoEeK1Sbo8NpBROA")]
    [Description(@"Trade is a pre-allocation trade.")]
    Pre_allocation,
    
    /// <summary>
    /// Trade is unallocated.
    /// Encoded/decoded by serializers as "UNAL".
    /// </summary>
    [EnumMember(Value = "UNAL")]
    [IsoId("_Fl21oCjoEeK1Sbo8NpBROA")]
    [Description(@"Trade is unallocated.")]
    Unallocated,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AllocationIndicatorCodeMetadataExtensions
{
    private static readonly AllocationIndicatorCodeDropdownSource _dropdownSource = new AllocationIndicatorCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAllocationIndicatorCodeDropdownRow GetMetadata(this AllocationIndicatorCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

