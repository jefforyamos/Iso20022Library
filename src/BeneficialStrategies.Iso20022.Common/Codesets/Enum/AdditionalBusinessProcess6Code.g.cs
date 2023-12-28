﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AdditionalBusinessProcess6Code.  ISO2002 ID# _YLOfAWH-EeWNUe-5HV3A_g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the additional business process linked to a corporate action event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YLOfAWH-EeWNUe-5HV3A_g")]
[Description(@"Specifies the additional business process linked to a corporate action event.")]
[DerivedFrom(typeof(AdditionalBusinessProcessCode))]
public enum AdditionalBusinessProcess6Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ClaimOrCompensation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YfT4oWH-EeWNUe-5HV3A_g")]
    [Description(@"??")]
    ClaimOrCompensation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NotificationOfReversal".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YfT4o2H-EeWNUe-5HV3A_g")]
    [Description(@"??")]
    NotificationOfReversal,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TaxRefund".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YfT4pWH-EeWNUe-5HV3A_g")]
    [Description(@"??")]
    TaxRefund,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PartialMandatoryPutRedemption".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a2w4MWH-EeWNUe-5HV3A_g")]
    [Description(@"??")]
    PartialMandatoryPutRedemption,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PartialPreFunding".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_mfSvoWIAEeWNUe-5HV3A_g")]
    [Description(@"??")]
    PartialPreFunding,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FullPrefunding".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ml_NgWIAEeWNUe-5HV3A_g")]
    [Description(@"??")]
    FullPrefunding,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RequiredAction".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_80PYIWKfEeWR9ZSfjmHwUA")]
    [Description(@"??")]
    RequiredAction,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AdditionalBusinessProcess6CodeMetadataExtensions
{
    private static readonly AdditionalBusinessProcess6CodeDropdownSource _dropdownSource = new AdditionalBusinessProcess6CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAdditionalBusinessProcess6CodeDropdownRow GetMetadata(this AdditionalBusinessProcess6Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


