﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CommissionValueType1Code.  ISO2002 ID# _bAkIcdp-Ed-ak6NoX_4Aeg_-623760703.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of value of the commission.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bAkIcdp-Ed-ak6NoX_4Aeg_-623760703")]
[Description(@"Specifies a type of value of the commission.")]
[DerivedFrom(typeof(PriceValueTypeCode))]
public enum CommissionValueType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PerUnit".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bAkIctp-Ed-ak6NoX_4Aeg_-559114087")]
    [Description(@"??")]
    PerUnit,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Absolute".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bAkIc9p-Ed-ak6NoX_4Aeg_-555420258")]
    [Description(@"??")]
    Absolute,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CommissionValueType1CodeMetadataExtensions
{
    private static readonly CommissionValueType1CodeDropdownSource _dropdownSource = new CommissionValueType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICommissionValueType1CodeDropdownRow GetMetadata(this CommissionValueType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


