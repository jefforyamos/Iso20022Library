﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InterestTypeCode.  ISO2002 ID# __215c9ojEeC60axPepSq7g_-1926390567.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates if the deal price is excluding or including the accrued interest.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__215c9ojEeC60axPepSq7g_-1926390567")]
[Description(@"Indicates if the deal price is excluding or including the accrued interest.")]
public enum InterestTypeCode
{
    /// <summary>
    /// Indicates deal price including accrued interest.
    /// Encoded/decoded by serializers as "CINT".
    /// </summary>
    [EnumMember(Value = "CINT")]
    [IsoId("__215dNojEeC60axPepSq7g_-1809717898")]
    [Description(@"Indicates deal price including accrued interest.")]
    CumInterest,
    
    /// <summary>
    /// Indicates deal price excluding accrued interest.
    /// Encoded/decoded by serializers as "XINT".
    /// </summary>
    [EnumMember(Value = "XINT")]
    [IsoId("__215ddojEeC60axPepSq7g_1908799161")]
    [Description(@"Indicates deal price excluding accrued interest.")]
    ExInterest,
    
    /// <summary>
    /// Indicates that the type of interest is a zero coupon.
    /// Encoded/decoded by serializers as "ZCPN".
    /// </summary>
    [EnumMember(Value = "ZCPN")]
    [IsoId("_ha_UtWliEeGaMcKyqKNRfQ_405889650")]
    [Description(@"Indicates that the type of interest is a zero coupon.")]
    ZeroCoupon,
    
    /// <summary>
    /// Indicates that the type of interest is discounted.
    /// Encoded/decoded by serializers as "DSCO".
    /// </summary>
    [EnumMember(Value = "DSCO")]
    [IsoId("_ha_UumliEeGaMcKyqKNRfQ_83685420")]
    [Description(@"Indicates that the type of interest is discounted.")]
    Discounted,
    
    /// <summary>
    /// Indicates that the type of interest is index.
    /// Encoded/decoded by serializers as "INDE".
    /// </summary>
    [EnumMember(Value = "INDE")]
    [IsoId("_ha_UuWliEeGaMcKyqKNRfQ_-1767325736")]
    [Description(@"Indicates that the type of interest is index.")]
    Index,
    
    /// <summary>
    /// Indicates that the type of interest is a dual basis.
    /// Encoded/decoded by serializers as "DUAL".
    /// </summary>
    [EnumMember(Value = "DUAL")]
    [IsoId("_ha_UuGliEeGaMcKyqKNRfQ_-1760597089")]
    [Description(@"Indicates that the type of interest is a dual basis.")]
    DualBasis,
    
    /// <summary>
    /// Indicates that the type of interest is a floating rate note.
    /// Encoded/decoded by serializers as "FLRN".
    /// </summary>
    [EnumMember(Value = "FLRN")]
    [IsoId("_ha_Ut2liEeGaMcKyqKNRfQ_-624589778")]
    [Description(@"Indicates that the type of interest is a floating rate note.")]
    FloatingRateNote,
    
    /// <summary>
    /// Indicates that the type of interest is fixed.
    /// Encoded/decoded by serializers as "FIXD".
    /// </summary>
    [EnumMember(Value = "FIXD")]
    [IsoId("_ha_UtmliEeGaMcKyqKNRfQ_-590551397")]
    [Description(@"Indicates that the type of interest is fixed.")]
    Fixed,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InterestTypeCodeMetadataExtensions
{
    private static readonly InterestTypeCodeDropdownSource _dropdownSource = new InterestTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInterestTypeCodeDropdownRow GetMetadata(this InterestTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

