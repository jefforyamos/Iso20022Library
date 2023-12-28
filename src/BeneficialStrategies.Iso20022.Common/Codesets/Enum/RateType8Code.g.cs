﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RateType8Code.  ISO2002 ID# _ZZmKp9p-Ed-ak6NoX_4Aeg_-516051900.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of tax rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZZmKp9p-Ed-ak6NoX_4Aeg_-516051900")]
[Description(@"Specifies the type of tax rate.")]
[DerivedFrom(typeof(RateTypeCode))]
public enum RateType8Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "WithholdingOfLocalTax".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZZvUkNp-Ed-ak6NoX_4Aeg_-440320575")]
    [Description(@"??")]
    WithholdingOfLocalTax,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "WithholdingOfForeignTax".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZZvUkdp-Ed-ak6NoX_4Aeg_-71837844")]
    [Description(@"??")]
    WithholdingOfForeignTax,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LocalTax".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZZvUktp-Ed-ak6NoX_4Aeg_-98555748")]
    [Description(@"??")]
    LocalTax,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RateType8CodeMetadataExtensions
{
    private static readonly RateType8CodeDropdownSource _dropdownSource = new RateType8CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRateType8CodeDropdownRow GetMetadata(this RateType8Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


