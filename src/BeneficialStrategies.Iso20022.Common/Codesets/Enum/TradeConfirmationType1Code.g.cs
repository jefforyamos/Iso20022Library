﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TradeConfirmationType1Code.  ISO2002 ID# _2EE7YA26EeWmAKKPnqYEVQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the contract was electronically confirmed or non-electronically confirmed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2EE7YA26EeWmAKKPnqYEVQ")]
[Description(@"Specifies whether the contract was electronically confirmed or non-electronically confirmed.")]
[DerivedFrom(typeof(TradeConfirmationTypeCode))]
public enum TradeConfirmationType1Code
{
    /// <summary>
    /// Electronically confirmed.
    /// Encoded/decoded by serializers as "ECNF".
    /// </summary>
    [EnumMember(Value = "ECNF")]
    [IsoId("_5vcZ4Q26EeWmAKKPnqYEVQ")]
    [Description(@"Electronically confirmed.")]
    ElectronicallyConfirmed = TradeConfirmationTypeCode.ElectronicallyConfirmed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Non-electronically confirmed.
    /// Encoded/decoded by serializers as "YCNF".
    /// </summary>
    [EnumMember(Value = "YCNF")]
    [IsoId("_5-dtUQ26EeWmAKKPnqYEVQ")]
    [Description(@"Non-electronically confirmed.")]
    NonElectronicallyConfirmed = TradeConfirmationTypeCode.NonElectronicallyConfirmed, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TradeConfirmationType1CodeMetadataExtensions
{
    private static readonly TradeConfirmationType1CodeDropdownSource _dropdownSource = new TradeConfirmationType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITradeConfirmationType1CodeDropdownRow GetMetadata(this TradeConfirmationType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


