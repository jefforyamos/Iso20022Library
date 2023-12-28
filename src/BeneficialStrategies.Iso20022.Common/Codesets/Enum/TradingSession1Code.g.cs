﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TradingSession1Code.  ISO2002 ID# _zdcnYg93EeGeV5vP7Mvdig_-213678965.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the factors that are/were applied in the event of pre-allocation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zdcnYg93EeGeV5vP7Mvdig_-213678965")]
[Description(@"Indicates the factors that are/were applied in the event of pre-allocation.")]
[DerivedFrom(typeof(TradingSessionCode))]
public enum TradingSession1Code
{
    /// <summary>
    /// Orders that are traded in regularly occuring auctions: orders are accumulated and executed on basis of defined algorithms.
    /// Encoded/decoded by serializers as "Auction".
    /// </summary>
    [EnumMember(Value = "AUCT")]
    [IsoId("_zdcnYw93EeGeV5vP7Mvdig_407428199")]
    [Description(@"Orders that are traded in regularly occuring auctions: orders are accumulated and executed on basis of defined algorithms.")]
    Auction,
    
    /// <summary>
    /// Trading process where orders are executed directly against each others as they hit the marketplace.
    /// Encoded/decoded by serializers as "Continuous".
    /// </summary>
    [EnumMember(Value = "CONT")]
    [IsoId("_zdcnZA93EeGeV5vP7Mvdig_574841635")]
    [Description(@"Trading process where orders are executed directly against each others as they hit the marketplace.")]
    Continuous,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TradingSession1CodeMetadataExtensions
{
    private static readonly TradingSession1CodeDropdownSource _dropdownSource = new TradingSession1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITradingSession1CodeDropdownRow GetMetadata(this TradingSession1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


