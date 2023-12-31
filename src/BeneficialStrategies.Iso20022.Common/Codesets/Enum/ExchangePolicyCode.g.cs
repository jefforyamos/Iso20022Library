﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExchangePolicyCode.  ISO2002 ID# _KR1s8X1DEeCF8NjrBemJWQ_-1574352782.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Exchange policy between parties.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KR1s8X1DEeCF8NjrBemJWQ_-1574352782")]
[Description(@"Exchange policy between parties.")]
[Derivations(typeof(ExchangePolicy1Code),typeof(ExchangePolicy2Code))]
// External derivations that should be provided by the proper interface are: 
public enum ExchangePolicyCode
{
    /// <summary>
    /// Exchange is performed if requested by the acquirer in a previous exchange, or at any time by the acceptor.
    /// Encoded/decoded by serializers as "ONDM".
    /// </summary>
    [EnumMember(Value = "ONDM")]
    [IsoId("_KR1s8n1DEeCF8NjrBemJWQ_-1538833043")]
    [Description(@"Exchange is performed if requested by the acquirer in a previous exchange, or at any time by the acceptor.")]
    OnDemand,
    
    /// <summary>
    /// Exchange is performed just after the transaction completion.
    /// Encoded/decoded by serializers as "IMMD".
    /// </summary>
    [EnumMember(Value = "IMMD")]
    [IsoId("_KR1s831DEeCF8NjrBemJWQ_1759061900")]
    [Description(@"Exchange is performed just after the transaction completion.")]
    Immediately,
    
    /// <summary>
    /// As soon as the acquirer is contacted, for example with the next on-line transaction.
    /// Encoded/decoded by serializers as "ASAP".
    /// </summary>
    [EnumMember(Value = "ASAP")]
    [IsoId("_KR1s9H1DEeCF8NjrBemJWQ_-1360714371")]
    [Description(@"As soon as the acquirer is contacted, for example with the next on-line transaction.")]
    AsSoonAsPossible,
    
    /// <summary>
    /// Exchanges are performed after reaching a maximum number of transaction or time period.
    /// Encoded/decoded by serializers as "AGRP".
    /// </summary>
    [EnumMember(Value = "AGRP")]
    [IsoId("_KR1s9X1DEeCF8NjrBemJWQ_1937180572")]
    [Description(@"Exchanges are performed after reaching a maximum number of transaction or time period.")]
    AsGroup,
    
    /// <summary>
    /// Exchange is performed after reaching a number of transactions without exchanges with the acquirer.
    /// Encoded/decoded by serializers as "NBLT".
    /// </summary>
    [EnumMember(Value = "NBLT")]
    [IsoId("_KR1s9n1DEeCF8NjrBemJWQ_-1652672109")]
    [Description(@"Exchange is performed after reaching a number of transactions without exchanges with the acquirer.")]
    NumberLimit,
    
    /// <summary>
    /// Exchange is performed after reaching a cumulative amount of transactions without exchanges with the acquirer.
    /// Encoded/decoded by serializers as "TTLT".
    /// </summary>
    [EnumMember(Value = "TTLT")]
    [IsoId("_KR1s931DEeCF8NjrBemJWQ_-1474553437")]
    [Description(@"Exchange is performed after reaching a cumulative amount of transactions without exchanges with the acquirer.")]
    TotalLimit,
    
    /// <summary>
    /// Cyclic exchanges based on the related time conditions.
    /// Encoded/decoded by serializers as "CYCL".
    /// </summary>
    [EnumMember(Value = "CYCL")]
    [IsoId("_KR1s-H1DEeCF8NjrBemJWQ_182113240")]
    [Description(@"Cyclic exchanges based on the related time conditions.")]
    Cyclic,
    
    /// <summary>
    /// No exchange.
    /// Encoded/decoded by serializers as "NONE".
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_KR1s-X1DEeCF8NjrBemJWQ_-612711196")]
    [Description(@"No exchange.")]
    None,
    
    /// <summary>
    /// All pending process must be paused until exchange is exclusively performed just after the transaction completion.
    /// Encoded/decoded by serializers as "BLCK".
    /// </summary>
    [EnumMember(Value = "BLCK")]
    [IsoId("_xQvLkA0vEeqUVL7sB4m7NA")]
    [Description(@"All pending process must be paused until exchange is exclusively performed just after the transaction completion.")]
    Blocking,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExchangePolicyCodeMetadataExtensions
{
    private static readonly ExchangePolicyCodeDropdownSource _dropdownSource = new ExchangePolicyCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExchangePolicyCodeDropdownRow GetMetadata(this ExchangePolicyCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


