﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TaxLiability1Code.  ISO2002 ID# _YiBCYdp-Ed-ak6NoX_4Aeg_230817252.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the tax role capacity of the instructing party.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YiBCYdp-Ed-ak6NoX_4Aeg_230817252")]
[Description(@"Specifies the tax role capacity of the instructing party.")]
[DerivedFrom(typeof(TaxLiabilityCode))]
public enum TaxLiability1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TaxPrincipal".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YiBCYtp-Ed-ak6NoX_4Aeg_-1137204905")]
    [Description(@"??")]
    TaxPrincipal,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TaxAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YiBCY9p-Ed-ak6NoX_4Aeg_1016400725")]
    [Description(@"??")]
    TaxAgent,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TaxLiability1CodeMetadataExtensions
{
    private static readonly TaxLiability1CodeDropdownSource _dropdownSource = new TaxLiability1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITaxLiability1CodeDropdownRow GetMetadata(this TaxLiability1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


