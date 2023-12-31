﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RiskReductionService1Code.  ISO2002 ID# _3WO5sIKOEeyi6unpji8kcA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicator of a type of a post trade risk reduction operation for the purpose of reporting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3WO5sIKOEeyi6unpji8kcA")]
[Description(@"Indicator of a type of a post trade risk reduction operation for the purpose of reporting.")]
[DerivedFrom(typeof(RiskReductionServiceCode))]
public enum RiskReductionService1Code
{
    /// <summary>
    /// There is no portfolio compression.
    /// Encoded/decoded by serializers as "NoRiskReduction".
    /// </summary>
    [EnumMember(Value = "NORR")]
    [IsoId("_IMhhYYKPEeyi6unpji8kcA")]
    [Description(@"There is no portfolio compression.")]
    NoRiskReduction,
    
    /// <summary>
    /// Portfolio Compression without a third-party service provider.
    /// Encoded/decoded by serializers as "NoThirdPartyPortfolioCompression".
    /// </summary>
    [EnumMember(Value = "PWOS")]
    [IsoId("_ITNYMYKPEeyi6unpji8kcA")]
    [Description(@"Portfolio Compression without a third-party service provider.")]
    NoThirdPartyPortfolioCompression,
    
    /// <summary>
    /// Other portfolio compression.
    /// Encoded/decoded by serializers as "OtherCompression".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_IYeSsYKPEeyi6unpji8kcA")]
    [Description(@"Other portfolio compression.")]
    OtherCompression,
    
    /// <summary>
    /// Portfolio rebalancing or margin management.
    /// Encoded/decoded by serializers as "PortfolioRebalancing".
    /// </summary>
    [EnumMember(Value = "PRBM")]
    [IsoId("_IeBhEYKPEeyi6unpji8kcA")]
    [Description(@"Portfolio rebalancing or margin management.")]
    PortfolioRebalancing,
    
    /// <summary>
    /// Portfolio Compression with a third-party service provider or CCP.
    /// Encoded/decoded by serializers as "ThirdPartyPortfolioCompression".
    /// </summary>
    [EnumMember(Value = "PWAS")]
    [IsoId("_IilQ8YKPEeyi6unpji8kcA")]
    [Description(@"Portfolio Compression with a third-party service provider or CCP.")]
    ThirdPartyPortfolioCompression,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RiskReductionService1CodeMetadataExtensions
{
    private static readonly RiskReductionService1CodeDropdownSource _dropdownSource = new RiskReductionService1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRiskReductionService1CodeDropdownRow GetMetadata(this RiskReductionService1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


