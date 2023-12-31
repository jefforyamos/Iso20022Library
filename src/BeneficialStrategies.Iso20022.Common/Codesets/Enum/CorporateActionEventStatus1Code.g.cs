﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionEventStatus1Code.  ISO2002 ID# _bEJA4dp-Ed-ak6NoX_4Aeg_2009797754.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of the CA event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bEJA4dp-Ed-ak6NoX_4Aeg_2009797754")]
[Description(@"Specifies the status of the CA event.")]
[DerivedFrom(typeof(CorporateActionEventStatusCode))]
public enum CorporateActionEventStatus1Code
{
    /// <summary>
    /// The CA event is active.
    /// Encoded/decoded by serializers as "Active".
    /// </summary>
    [EnumMember(Value = "ACTI")]
    [IsoId("_bEJA4tp-Ed-ak6NoX_4Aeg_2009797756")]
    [Description(@"The CA event is active.")]
    Active,
    
    /// <summary>
    /// The CA event is deactivated. The clients cannot send instruction anymore.
    /// Encoded/decoded by serializers as "Deactivated".
    /// </summary>
    [EnumMember(Value = "DEAC")]
    [IsoId("_bEJA49p-Ed-ak6NoX_4Aeg_2009797785")]
    [Description(@"The CA event is deactivated. The clients cannot send instruction anymore.")]
    Deactivated,
    
    /// <summary>
    /// The CA event is expired, no more processing, claims, transformations take place.
    /// Encoded/decoded by serializers as "Expired".
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_bEJA5Np-Ed-ak6NoX_4Aeg_2009797786")]
    [Description(@"The CA event is expired, no more processing, claims, transformations take place.")]
    Expired,
    
    /// <summary>
    /// The CA event is cancelled.
    /// Encoded/decoded by serializers as "Cancelled".
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_bEJA5dp-Ed-ak6NoX_4Aeg_2009797815")]
    [Description(@"The CA event is cancelled.")]
    Cancelled,
    
    /// <summary>
    /// The CA event is withrawn, ie, cancelled by the market.
    /// Encoded/decoded by serializers as "Withdrawn".
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_bEJA5tp-Ed-ak6NoX_4Aeg_2009797846")]
    [Description(@"The CA event is withrawn, ie, cancelled by the market.")]
    Withdrawn,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionEventStatus1CodeMetadataExtensions
{
    private static readonly CorporateActionEventStatus1CodeDropdownSource _dropdownSource = new CorporateActionEventStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionEventStatus1CodeDropdownRow GetMetadata(this CorporateActionEventStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


