﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TaxationBasis2Code.  ISO2002 ID# _ZScZxNp-Ed-ak6NoX_4Aeg_986778431.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the tax basis.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZScZxNp-Ed-ak6NoX_4Aeg_986778431")]
[Description(@"Specifies the tax basis.")]
[DerivedFrom(typeof(TaxationBasisCode))]
public enum TaxationBasis2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Flat".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZScZxdp-Ed-ak6NoX_4Aeg_986778433")]
    [Description(@"??")]
    Flat,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PerUnit".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZScZxtp-Ed-ak6NoX_4Aeg_986778434")]
    [Description(@"??")]
    PerUnit,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TaxationBasis2CodeMetadataExtensions
{
    private static readonly TaxationBasis2CodeDropdownSource _dropdownSource = new TaxationBasis2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITaxationBasis2CodeDropdownRow GetMetadata(this TaxationBasis2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


