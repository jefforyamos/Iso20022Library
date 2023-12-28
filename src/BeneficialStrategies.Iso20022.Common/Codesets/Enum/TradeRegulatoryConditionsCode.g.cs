﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TradeRegulatoryConditionsCode.  ISO2002 ID# __yXpItojEeC60axPepSq7g_-160167061.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// indicates if the Trade Regulatory Conditions is solicited or not.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__yXpItojEeC60axPepSq7g_-160167061")]
[Description(@"indicates if the Trade Regulatory Conditions is solicited or not.")]
public enum TradeRegulatoryConditionsCode
{
    /// <summary>
    /// Trade was solicited by the executing broker. The broker has suggested to his client to buy/sell financial instruments.
    /// Encoded/decoded by serializers as "SOLI".
    /// </summary>
    [EnumMember(Value = "SOLI")]
    [IsoId("__yXpI9ojEeC60axPepSq7g_-1107312564")]
    [Description(@"Trade was solicited by the executing broker. The broker has suggested to his client to buy/sell financial instruments.")]
    Solicited,
    
    /// <summary>
    /// Trade was unsolicited. The client acts on its own without advice from the executing broker.
    /// Encoded/decoded by serializers as "USOL".
    /// </summary>
    [EnumMember(Value = "USOL")]
    [IsoId("__yXpJNojEeC60axPepSq7g_-1334779676")]
    [Description(@"Trade was unsolicited. The client acts on its own without advice from the executing broker.")]
    Unsolicited,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TradeRegulatoryConditionsCodeMetadataExtensions
{
    private static readonly TradeRegulatoryConditionsCodeDropdownSource _dropdownSource = new TradeRegulatoryConditionsCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITradeRegulatoryConditionsCodeDropdownRow GetMetadata(this TradeRegulatoryConditionsCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

