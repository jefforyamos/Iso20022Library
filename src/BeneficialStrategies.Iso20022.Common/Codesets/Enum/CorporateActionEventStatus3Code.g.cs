﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionEventStatus3Code.  ISO2002 ID# _bESK0tp-Ed-ak6NoX_4Aeg_2065210906.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of the CA event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bESK0tp-Ed-ak6NoX_4Aeg_2065210906")]
[Description(@"Specifies the status of the CA event.")]
[DerivedFrom(typeof(CorporateActionEventStatusCode))]
public enum CorporateActionEventStatus3Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Cancelled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bESK09p-Ed-ak6NoX_4Aeg_2065210908")]
    [Description(@"??")]
    Cancelled,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Inactive".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bESK1Np-Ed-ak6NoX_4Aeg_2065210936")]
    [Description(@"??")]
    Inactive,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionEventStatus3CodeMetadataExtensions
{
    private static readonly CorporateActionEventStatus3CodeDropdownSource _dropdownSource = new CorporateActionEventStatus3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionEventStatus3CodeDropdownRow GetMetadata(this CorporateActionEventStatus3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

