﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for LiabilityCode.  ISO2002 ID# _uQbcgCDMEeWPMvNwVtiMsA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the party responsible for the liability.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_uQbcgCDMEeWPMvNwVtiMsA")]
[Description(@"Specifies the party responsible for the liability.")]
public enum LiabilityCode
{
    /// <summary>
    /// Investor is responsible.
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_1MIqYCDMEeWPMvNwVtiMsA")]
    [Description(@"Investor is responsible.")]
    INVE,
    
    /// <summary>
    /// Investor is not assumed responsibile.
    /// </summary>
    [EnumMember(Value = "NINV")]
    [IsoId("_7hUDwCDMEeWPMvNwVtiMsA")]
    [Description(@"Investor is not assumed responsibile.")]
    NINV,
    
    /// <summary>
    /// Broker is responsible.
    /// </summary>
    [EnumMember(Value = "BROK")]
    [IsoId("_9TbU4Da1EeWxoIK_IhudJg")]
    [Description(@"Broker is responsible.")]
    BROK,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class LiabilityCodeMetadataExtensions
{
    private static readonly LiabilityCodeDropdownSource _dropdownSource = new LiabilityCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ILiabilityCodeDropdownRow GetMetadata(this LiabilityCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


