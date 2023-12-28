﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TradingFloorOrderHandling1Code.  ISO2002 ID# _YqzyBdp-Ed-ak6NoX_4Aeg_530358384.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Description of the parameters under which an order must be handled on the floor.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YqzyBdp-Ed-ak6NoX_4Aeg_530358384")]
[Description(@"Description of the parameters under which an order must be handled on the floor.")]
[DerivedFrom(typeof(TradingFloorOrderHandlingCode))]
public enum TradingFloorOrderHandling1Code
{
    /// <summary>
    /// Indicates that the order should be executed automatically, private initiative, no broker intervention. Its sales trading desk will not be informed of the order and trade.
    /// Encoded/decoded by serializers as "AutomatedPrivate".
    /// </summary>
    [EnumMember(Value = "ATPR")]
    [IsoId("_YqzyBtp-Ed-ak6NoX_4Aeg_828654274")]
    [Description(@"Indicates that the order should be executed automatically, private initiative, no broker intervention. Its sales trading desk will not be informed of the order and trade.")]
    AutomatedPrivate,
    
    /// <summary>
    /// Indicates that the order should be executed automatically, public initiative, broker intervention allowed.
    /// Encoded/decoded by serializers as "AutomatedPublic".
    /// </summary>
    [EnumMember(Value = "ATPU")]
    [IsoId("_YqzyB9p-Ed-ak6NoX_4Aeg_828654317")]
    [Description(@"Indicates that the order should be executed automatically, public initiative, broker intervention allowed.")]
    AutomatedPublic,
    
    /// <summary>
    /// Manual order, best execution.
    /// Encoded/decoded by serializers as "Manual".
    /// </summary>
    [EnumMember(Value = "MANU")]
    [IsoId("_YqzyCNp-Ed-ak6NoX_4Aeg_828654352")]
    [Description(@"Manual order, best execution.")]
    Manual,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TradingFloorOrderHandling1CodeMetadataExtensions
{
    private static readonly TradingFloorOrderHandling1CodeDropdownSource _dropdownSource = new TradingFloorOrderHandling1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITradingFloorOrderHandling1CodeDropdownRow GetMetadata(this TradingFloorOrderHandling1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


