﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RiskReductionServiceCode.  ISO2002 ID# _LecYgCi6EeuKKc2MztSwPw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// RiskReductionServiceCode definition here
/// </summary>
[DataContract]
[Serializable]
[IsoId("_LecYgCi6EeuKKc2MztSwPw")]
[Description(@"RiskReductionServiceCode definition here")]
public enum RiskReductionServiceCode
{
    /// <summary>
    /// Portfolio Compression without a third-party service provider.
    /// Encoded/decoded by serializers as "PWOS".
    /// </summary>
    [EnumMember(Value = "PWOS")]
    [IsoId("_aTUiECi6EeuKKc2MztSwPw")]
    [Description(@"Portfolio Compression without a third-party service provider.")]
    NoThirdPartyPortfolioCompression,
    
    /// <summary>
    /// Portfolio Compression with a third-party service provider or CCP.
    /// Encoded/decoded by serializers as "PWAS".
    /// </summary>
    [EnumMember(Value = "PWAS")]
    [IsoId("_bNo1QCi6EeuKKc2MztSwPw")]
    [Description(@"Portfolio Compression with a third-party service provider or CCP.")]
    ThirdPartyPortfolioCompression,
    
    /// <summary>
    /// Portfolio rebalancing or margin management.
    /// Encoded/decoded by serializers as "PRBM".
    /// </summary>
    [EnumMember(Value = "PRBM")]
    [IsoId("_cplO0Ci6EeuKKc2MztSwPw")]
    [Description(@"Portfolio rebalancing or margin management.")]
    PortfolioRebalancing,
    
    /// <summary>
    /// There is no portfolio compression.
    /// Encoded/decoded by serializers as "NORR".
    /// </summary>
    [EnumMember(Value = "NORR")]
    [IsoId("_eBy-8Ci6EeuKKc2MztSwPw")]
    [Description(@"There is no portfolio compression.")]
    NoRiskReduction,
    
    /// <summary>
    /// Other portfolio compression.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_i2NJICi6EeuKKc2MztSwPw")]
    [Description(@"Other portfolio compression.")]
    OtherCompression,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RiskReductionServiceCodeMetadataExtensions
{
    private static readonly RiskReductionServiceCodeDropdownSource _dropdownSource = new RiskReductionServiceCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRiskReductionServiceCodeDropdownRow GetMetadata(this RiskReductionServiceCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

