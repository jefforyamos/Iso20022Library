﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MarginProduct1Code.  ISO2002 ID# _YZq-tNp-Ed-ak6NoX_4Aeg_115662957.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the underlying product of the margin.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YZq-tNp-Ed-ak6NoX_4Aeg_115662957")]
[Description(@"Specifies the underlying product of the margin.")]
[DerivedFrom(typeof(MarginProductCode))]
public enum MarginProduct1Code
{
    /// <summary>
    /// Specifies that the margin is related to equities.
    /// Encoded/decoded by serializers as "EQUI".
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_YZq-tdp-Ed-ak6NoX_4Aeg_1188512534")]
    [Description(@"Specifies that the margin is related to equities.")]
    Equities = MarginProductCode.Equities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specifies that the margin is related to fixed income.
    /// Encoded/decoded by serializers as "FIXI".
    /// </summary>
    [EnumMember(Value = "FIXI")]
    [IsoId("_YZq-ttp-Ed-ak6NoX_4Aeg_1074673468")]
    [Description(@"Specifies that the margin is related to fixed income.")]
    FixedIncome = MarginProductCode.FixedIncome, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MarginProduct1CodeMetadataExtensions
{
    private static readonly MarginProduct1CodeDropdownSource _dropdownSource = new MarginProduct1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMarginProduct1CodeDropdownRow GetMetadata(this MarginProduct1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


