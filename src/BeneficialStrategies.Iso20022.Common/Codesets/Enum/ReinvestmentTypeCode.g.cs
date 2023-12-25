﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ReinvestmentTypeCode.  ISO2002 ID# _mPNa4I68EeaxxtxaoOwzAg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides details on the  type of the cash reinvestment in a given currency.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_mPNa4I68EeaxxtxaoOwzAg")]
[Description(@"Provides details on the  type of the cash reinvestment in a given currency.")]
public enum ReinvestmentTypeCode
{
    /// <summary>
    /// Reinvestment type is registered money market fund that is a public debt constant net asset value money market fund, low volatility net asset value money market fund or variable net asset value money market fund.
    /// </summary>
    [EnumMember(Value = "MMFT")]
    [IsoId("_uUQPYI68EeaxxtxaoOwzAg")]
    [Description(@"Reinvestment type is registered money market fund that is a public debt constant net asset value money market fund, low volatility net asset value money market fund or variable net asset value money market fund.")]
    MMFT,
    
    /// <summary>
    /// Reinvestment type is a pool of commingled assets.
    /// </summary>
    [EnumMember(Value = "OCMP")]
    [IsoId("_yAyykI68EeaxxtxaoOwzAg")]
    [Description(@"Reinvestment type is a pool of commingled assets.")]
    OCMP,
    
    /// <summary>
    /// Reinvestment type is market where repurchase agreements are traded. 
    /// </summary>
    [EnumMember(Value = "REPM")]
    [IsoId("_07ZigI68EeaxxtxaoOwzAg")]
    [Description(@"Reinvestment type is market where repurchase agreements are traded. ")]
    REPM,
    
    /// <summary>
    /// Reinvestment type is direct purchase of securities.
    /// </summary>
    [EnumMember(Value = "SDPU")]
    [IsoId("_3fNjEI68EeaxxtxaoOwzAg")]
    [Description(@"Reinvestment type is direct purchase of securities.")]
    SDPU,
    
    /// <summary>
    /// Other type of reinvestment.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_7TWjEI68EeaxxtxaoOwzAg")]
    [Description(@"Other type of reinvestment.")]
    OTHR,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ReinvestmentTypeCodeMetadataExtensions
{
    private static readonly ReinvestmentTypeCodeDropdownSource _dropdownSource = new ReinvestmentTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IReinvestmentTypeCodeDropdownRow GetMetadata(this ReinvestmentTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


