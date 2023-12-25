﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CollateralPurposeCode.  ISO2002 ID# _YZXcuNp-Ed-ak6NoX_4Aeg_1268885357.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates whether the collateral has been posted against the variation margin or the segregated independent amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YZXcuNp-Ed-ak6NoX_4Aeg_1268885357")]
[Description(@"Indicates whether the collateral has been posted against the variation margin or the segregated independent amount.")]
public enum CollateralPurposeCode
{
    /// <summary>
    /// Collateral has been posted against the variation margin.
    /// </summary>
    [EnumMember(Value = "VAMA")]
    [IsoId("_YZXcudp-Ed-ak6NoX_4Aeg_-2132642673")]
    [Description(@"Collateral has been posted against the variation margin.")]
    VAMA,
    
    /// <summary>
    /// Collateral has been posted against the segregated independent amount.
    /// </summary>
    [EnumMember(Value = "SINA")]
    [IsoId("_YZXcutp-Ed-ak6NoX_4Aeg_846367471")]
    [Description(@"Collateral has been posted against the segregated independent amount.")]
    SINA,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CollateralPurposeCodeMetadataExtensions
{
    private static readonly CollateralPurposeCodeDropdownSource _dropdownSource = new CollateralPurposeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICollateralPurposeCodeDropdownRow GetMetadata(this CollateralPurposeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


