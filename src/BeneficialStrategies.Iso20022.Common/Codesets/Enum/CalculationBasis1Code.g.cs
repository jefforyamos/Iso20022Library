﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CalculationBasis1Code.  ISO2002 ID# _VjbKVtp-Ed-ak6NoX_4Aeg_-1887209997.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the calculation basis.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VjbKVtp-Ed-ak6NoX_4Aeg_-1887209997")]
[Description(@"Specifies the calculation basis.")]
[DerivedFrom(typeof(CalculationBasisCode))]
public enum CalculationBasis1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Average".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VjbKV9p-Ed-ak6NoX_4Aeg_-1571364153")]
    [Description(@"??")]
    Average,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Daily".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_VjbKWNp-Ed-ak6NoX_4Aeg_-1568592785")]
    [Description(@"??")]
    Daily,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Vjk7UNp-Ed-ak6NoX_4Aeg_-855201061")]
    [Description(@"??")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CalculationBasis1CodeMetadataExtensions
{
    private static readonly CalculationBasis1CodeDropdownSource _dropdownSource = new CalculationBasis1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICalculationBasis1CodeDropdownRow GetMetadata(this CalculationBasis1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

