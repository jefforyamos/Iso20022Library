﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionEventStatus2Code.  ISO2002 ID# _bEJA59p-Ed-ak6NoX_4Aeg_2035657818.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of the CA option.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bEJA59p-Ed-ak6NoX_4Aeg_2035657818")]
[Description(@"Specifies the status of the CA option.")]
[DerivedFrom(typeof(CorporateActionEventStatusCode))]
public enum CorporateActionEventStatus2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Active".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bEJA6Np-Ed-ak6NoX_4Aeg_2035657828")]
    [Description(@"??")]
    Active,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Cancelled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bESK0Np-Ed-ak6NoX_4Aeg_2035657849")]
    [Description(@"??")]
    Cancelled,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Inactive".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bESK0dp-Ed-ak6NoX_4Aeg_2035657858")]
    [Description(@"??")]
    Inactive,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionEventStatus2CodeMetadataExtensions
{
    private static readonly CorporateActionEventStatus2CodeDropdownSource _dropdownSource = new CorporateActionEventStatus2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionEventStatus2CodeDropdownRow GetMetadata(this CorporateActionEventStatus2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

