﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TradeConfirmationTypeCode.  ISO2002 ID# _aR8RMQ26EeWmAKKPnqYEVQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the contract was electronically confirmed, non-electronically confirmed or remains unconfirmed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aR8RMQ26EeWmAKKPnqYEVQ")]
[Description(@"Specifies whether the contract was electronically confirmed, non-electronically confirmed or remains unconfirmed.")]
[Derivations(typeof(TradeConfirmationType2Code),typeof(TradeConfirmationType1Code))]
public enum TradeConfirmationTypeCode
{
    /// <summary>
    /// Non-electronically confirmed.
    /// Encoded/decoded by serializers as "YCNF".
    /// </summary>
    [EnumMember(Value = "YCNF")]
    [IsoId("_iuIaYA26EeWmAKKPnqYEVQ")]
    [Description(@"Non-electronically confirmed.")]
    NonElectronicallyConfirmed,
    
    /// <summary>
    /// Electronically confirmed.
    /// Encoded/decoded by serializers as "ECNF".
    /// </summary>
    [EnumMember(Value = "ECNF")]
    [IsoId("_lzHOUA26EeWmAKKPnqYEVQ")]
    [Description(@"Electronically confirmed.")]
    ElectronicallyConfirmed,
    
    /// <summary>
    /// Non-confirmed.
    /// Encoded/decoded by serializers as "NCNF".
    /// </summary>
    [EnumMember(Value = "NCNF")]
    [IsoId("_l_myMA26EeWmAKKPnqYEVQ")]
    [Description(@"Non-confirmed.")]
    NonConfirmed,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TradeConfirmationTypeCodeMetadataExtensions
{
    private static readonly TradeConfirmationTypeCodeDropdownSource _dropdownSource = new TradeConfirmationTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITradeConfirmationTypeCodeDropdownRow GetMetadata(this TradeConfirmationTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


