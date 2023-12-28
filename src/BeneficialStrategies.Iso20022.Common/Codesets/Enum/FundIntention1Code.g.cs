﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FundIntention1Code.  ISO2002 ID# _WCVqYCDYEeWCLu74WLgP4w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if the fund is intended for qualified investors.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WCVqYCDYEeWCLu74WLgP4w")]
[Description(@"Specifies if the fund is intended for qualified investors.")]
[DerivedFrom(typeof(FundIntentionCode))]
public enum FundIntention1Code
{
    /// <summary>
    /// Qualified.
    /// Encoded/decoded by serializers as "Qualified".
    /// </summary>
    [EnumMember(Value = "YQUA")]
    [IsoId("_YBiiASDYEeWCLu74WLgP4w")]
    [Description(@"Qualified.")]
    Qualified,
    
    /// <summary>
    /// Not qualified.
    /// Encoded/decoded by serializers as "NotQualified".
    /// </summary>
    [EnumMember(Value = "NQUA")]
    [IsoId("_uOC44TavEeWxoIK_IhudJg")]
    [Description(@"Not qualified.")]
    NotQualified,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FundIntention1CodeMetadataExtensions
{
    private static readonly FundIntention1CodeDropdownSource _dropdownSource = new FundIntention1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFundIntention1CodeDropdownRow GetMetadata(this FundIntention1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


