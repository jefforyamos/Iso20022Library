﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TradePostingCode.  ISO2002 ID# _-fsj1KMOEeCojJW5vEuTEQ_1016949174.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the trade is maintained as a separate individual position in the clearing account, or not.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-fsj1KMOEeCojJW5vEuTEQ_1016949174")]
[Description(@"Specifies the trade is maintained as a separate individual position in the clearing account, or not.")]
[Derivations(typeof(TradePosting1Code))]
public enum TradePostingCode
{
    /// <summary>
    /// Trade is maintained as a separate individual position in the clearing account.
    /// Encoded/decoded by serializers as "GROS".
    /// </summary>
    [EnumMember(Value = "GROS")]
    [IsoId("_-fsj1aMOEeCojJW5vEuTEQ_-309637518")]
    [Description(@"Trade is maintained as a separate individual position in the clearing account.")]
    Gross,
    
    /// <summary>
    /// Trade is maintained as a net position in the clearing account.
    /// Encoded/decoded by serializers as "NETT".
    /// </summary>
    [EnumMember(Value = "NETT")]
    [IsoId("_-fsj1qMOEeCojJW5vEuTEQ_-1574089543")]
    [Description(@"Trade is maintained as a net position in the clearing account.")]
    Net,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TradePostingCodeMetadataExtensions
{
    private static readonly TradePostingCodeDropdownSource _dropdownSource = new TradePostingCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITradePostingCodeDropdownRow GetMetadata(this TradePostingCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


