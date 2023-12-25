﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PartialSettlementV2Code.  ISO2002 ID# _-oaa0ENHEeGHJ_bHJRPaIQ_1875185490.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Information about partial settlement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-oaa0ENHEeGHJ_bHJRPaIQ_1875185490")]
[Description(@"Information about partial settlement.")]
public enum PartialSettlementV2Code
{
    /// <summary>
    /// Confirmation is for partial settlement. Part of the transaction remains unsettled.
    /// </summary>
    [EnumMember(Value = "PAIN")]
    [IsoId("_-oaa0UNHEeGHJ_bHJRPaIQ_1761346424")]
    [Description(@"Confirmation is for partial settlement. Part of the transaction remains unsettled.")]
    PAIN,
    
    /// <summary>
    /// Confirmation is for partial settlement. No additional settlement will take place.
    /// </summary>
    [EnumMember(Value = "PARC")]
    [IsoId("_-oaa0kNHEeGHJ_bHJRPaIQ_1056231809")]
    [Description(@"Confirmation is for partial settlement. No additional settlement will take place.")]
    PARC,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PartialSettlementV2CodeMetadataExtensions
{
    private static readonly PartialSettlementV2CodeDropdownSource _dropdownSource = new PartialSettlementV2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPartialSettlementV2CodeDropdownRow GetMetadata(this PartialSettlementV2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


