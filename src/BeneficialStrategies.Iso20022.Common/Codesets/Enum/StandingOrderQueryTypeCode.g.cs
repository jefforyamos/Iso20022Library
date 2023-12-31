﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for StandingOrderQueryTypeCode.  ISO2002 ID# _8NxfVaMgEeCJ6YNENx4h-w_73506953.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the query type for standing orders queries, that identifies the predefined key attributes expected in the response to the query.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8NxfVaMgEeCJ6YNENx4h-w_73506953")]
[Description(@"Defines the query type for standing orders queries, that identifies the predefined key attributes expected in the response to the query.")]
[Derivations(typeof(StandingOrderQueryType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum StandingOrderQueryTypeCode
{
    /// <summary>
    /// Used to query the list of liquidity transfer standing orders defined in the system.
    /// Encoded/decoded by serializers as "SLST".
    /// </summary>
    [EnumMember(Value = "SLST")]
    [IsoId("_8NxfVqMgEeCJ6YNENx4h-w_1271444425")]
    [Description(@"Used to query the list of liquidity transfer standing orders defined in the system.")]
    StandingOrderList,
    
    /// <summary>
    /// Used to query a specific liquidity transfer standing order based on a set of search criteria.
    /// Encoded/decoded by serializers as "SDTL".
    /// </summary>
    [EnumMember(Value = "SDTL")]
    [IsoId("_8NxfV6MgEeCJ6YNENx4h-w_-1200307099")]
    [Description(@"Used to query a specific liquidity transfer standing order based on a set of search criteria.")]
    StandingOrderDetails,
    
    /// <summary>
    /// Used to query the total amounts of predefined and user defined liquidity transfer standing orders for both defined and not yet executed orders.
    /// Encoded/decoded by serializers as "TAPS".
    /// </summary>
    [EnumMember(Value = "TAPS")]
    [IsoId("_8N7QUKMgEeCJ6YNENx4h-w_-975617921")]
    [Description(@"Used to query the total amounts of predefined and user defined liquidity transfer standing orders for both defined and not yet executed orders.")]
    TotalAmountPerStandingOrder,
    
    /// <summary>
    /// Used to query the list of liquidity transfer standing orders defined in a specific link set of sequenced standing orders. The link set is a collection of standing order defined in a specific sequence.
    /// Encoded/decoded by serializers as "SLSL".
    /// </summary>
    [EnumMember(Value = "SLSL")]
    [IsoId("_8N7QUaMgEeCJ6YNENx4h-w_-649215029")]
    [Description(@"Used to query the list of liquidity transfer standing orders defined in a specific link set of sequenced standing orders. The link set is a collection of standing order defined in a specific sequence.")]
    StandingOrderLinkSetList,
    
    /// <summary>
    /// Used to query a specific standing order within a link set of sequenced liquidity transfer standing orders. The link set is a collection of standing order defined in a specific sequence.
    /// Encoded/decoded by serializers as "SWLS".
    /// </summary>
    [EnumMember(Value = "SWLS")]
    [IsoId("_8N7QUqMgEeCJ6YNENx4h-w_688182461")]
    [Description(@"Used to query a specific standing order within a link set of sequenced liquidity transfer standing orders. The link set is a collection of standing order defined in a specific sequence.")]
    StandingOrderDetailsWithinLinkSet,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class StandingOrderQueryTypeCodeMetadataExtensions
{
    private static readonly StandingOrderQueryTypeCodeDropdownSource _dropdownSource = new StandingOrderQueryTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IStandingOrderQueryTypeCodeDropdownRow GetMetadata(this StandingOrderQueryTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


