﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FundIntentionCode.  ISO2002 ID# _xgI4wCDXEeWCLu74WLgP4w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if the fund is intended for qualified investors.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xgI4wCDXEeWCLu74WLgP4w")]
[Description(@"Specifies if the fund is intended for qualified investors.")]
[Derivations(typeof(FundIntention1Code))]
// External derivations that should be provided by the proper interface are: 
public enum FundIntentionCode
{
    /// <summary>
    /// Qualified.
    /// Encoded/decoded by serializers as "YQUA".
    /// </summary>
    [EnumMember(Value = "YQUA")]
    [IsoId("_4WlzMCDXEeWCLu74WLgP4w")]
    [Description(@"Qualified.")]
    Qualified,
    
    /// <summary>
    /// Not qualified.
    /// Encoded/decoded by serializers as "NQUA".
    /// </summary>
    [EnumMember(Value = "NQUA")]
    [IsoId("_8clYMCDXEeWCLu74WLgP4w")]
    [Description(@"Not qualified.")]
    NotQualified,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FundIntentionCodeMetadataExtensions
{
    private static readonly FundIntentionCodeDropdownSource _dropdownSource = new FundIntentionCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFundIntentionCodeDropdownRow GetMetadata(this FundIntentionCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


