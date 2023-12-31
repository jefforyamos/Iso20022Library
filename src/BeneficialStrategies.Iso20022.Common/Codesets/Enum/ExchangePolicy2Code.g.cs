﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExchangePolicy2Code.  ISO2002 ID# _mEFs8Q0vEeqUVL7sB4m7NA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Exchange policy between parties.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_mEFs8Q0vEeqUVL7sB4m7NA")]
[Description(@"Exchange policy between parties.")]
[DerivedFrom(typeof(ExchangePolicyCode))]
public enum ExchangePolicy2Code
{
    /// <summary>
    /// Exchange is performed if requested by the acquirer in a previous exchange, or at any time by the acceptor.
    /// Encoded/decoded by serializers as "OnDemand".
    /// </summary>
    [EnumMember(Value = "ONDM")]
    [IsoId("_mQNdYQ0vEeqUVL7sB4m7NA")]
    [Description(@"Exchange is performed if requested by the acquirer in a previous exchange, or at any time by the acceptor.")]
    OnDemand,
    
    /// <summary>
    /// Exchange is performed just after the transaction completion.
    /// Encoded/decoded by serializers as "Immediately".
    /// </summary>
    [EnumMember(Value = "IMMD")]
    [IsoId("_mQNdYw0vEeqUVL7sB4m7NA")]
    [Description(@"Exchange is performed just after the transaction completion.")]
    Immediately,
    
    /// <summary>
    /// As soon as the acquirer is contacted, for example with the next on-line transaction.
    /// Encoded/decoded by serializers as "AsSoonAsPossible".
    /// </summary>
    [EnumMember(Value = "ASAP")]
    [IsoId("_mQNdZQ0vEeqUVL7sB4m7NA")]
    [Description(@"As soon as the acquirer is contacted, for example with the next on-line transaction.")]
    AsSoonAsPossible,
    
    /// <summary>
    /// Exchanges are performed after reaching a maximum number of transaction or time period.
    /// Encoded/decoded by serializers as "AsGroup".
    /// </summary>
    [EnumMember(Value = "AGRP")]
    [IsoId("_mQNdZw0vEeqUVL7sB4m7NA")]
    [Description(@"Exchanges are performed after reaching a maximum number of transaction or time period.")]
    AsGroup,
    
    /// <summary>
    /// Exchange is performed after reaching a number of transactions without exchanges with the acquirer.
    /// Encoded/decoded by serializers as "NumberLimit".
    /// </summary>
    [EnumMember(Value = "NBLT")]
    [IsoId("_mQNdaQ0vEeqUVL7sB4m7NA")]
    [Description(@"Exchange is performed after reaching a number of transactions without exchanges with the acquirer.")]
    NumberLimit,
    
    /// <summary>
    /// Exchange is performed after reaching a cumulative amount of transactions without exchanges with the acquirer.
    /// Encoded/decoded by serializers as "TotalLimit".
    /// </summary>
    [EnumMember(Value = "TTLT")]
    [IsoId("_mQNdaw0vEeqUVL7sB4m7NA")]
    [Description(@"Exchange is performed after reaching a cumulative amount of transactions without exchanges with the acquirer.")]
    TotalLimit,
    
    /// <summary>
    /// Cyclic exchanges based on the related time conditions.
    /// Encoded/decoded by serializers as "Cyclic".
    /// </summary>
    [EnumMember(Value = "CYCL")]
    [IsoId("_mQNdbQ0vEeqUVL7sB4m7NA")]
    [Description(@"Cyclic exchanges based on the related time conditions.")]
    Cyclic,
    
    /// <summary>
    /// No exchange.
    /// Encoded/decoded by serializers as "None".
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_mQNdbw0vEeqUVL7sB4m7NA")]
    [Description(@"No exchange.")]
    None,
    
    /// <summary>
    /// All pending process must be paused until exchange is exclusively performed just after the transaction completion.
    /// Encoded/decoded by serializers as "Blocking".
    /// </summary>
    [EnumMember(Value = "BLCK")]
    [IsoId("_Lya6gQ0wEeqUVL7sB4m7NA")]
    [Description(@"All pending process must be paused until exchange is exclusively performed just after the transaction completion.")]
    Blocking,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExchangePolicy2CodeMetadataExtensions
{
    private static readonly ExchangePolicy2CodeDropdownSource _dropdownSource = new ExchangePolicy2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExchangePolicy2CodeDropdownRow GetMetadata(this ExchangePolicy2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


