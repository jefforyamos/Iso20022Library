﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExposureConventionType1Code.  ISO2002 ID# _YczLMNp-Ed-ak6NoX_4Aeg_945714582.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Determines how the variation margin requirement will be calculated, either net or gross.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YczLMNp-Ed-ak6NoX_4Aeg_945714582")]
[Description(@"Determines how the variation margin requirement will be calculated, either net or gross.")]
[DerivedFrom(typeof(ExposureConventionTypeCode))]
public enum ExposureConventionType1Code
{
    /// <summary>
    /// Indicates that the exposed amount to party A and B will be netted together for the variation margin calculation, and then two separate variation margin requirements will be determined.
    /// Encoded/decoded by serializers as "GROS".
    /// </summary>
    [EnumMember(Value = "GROS")]
    [IsoId("_YczLMdp-Ed-ak6NoX_4Aeg_-886123604")]
    [Description(@"Indicates that the exposed amount to party A and B will be netted together for the variation margin calculation, and then two separate variation margin requirements will be determined.")]
    Gross = ExposureConventionTypeCode.Gross, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the exposed amount to party A and B will be netted together for the variation margin calculation.
    /// Encoded/decoded by serializers as "NET1".
    /// </summary>
    [EnumMember(Value = "NET1")]
    [IsoId("_YczLMtp-Ed-ak6NoX_4Aeg_528113018")]
    [Description(@"Indicates that the exposed amount to party A and B will be netted together for the variation margin calculation.")]
    Net = ExposureConventionTypeCode.Net, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExposureConventionType1CodeMetadataExtensions
{
    private static readonly ExposureConventionType1CodeDropdownSource _dropdownSource = new ExposureConventionType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExposureConventionType1CodeDropdownRow GetMetadata(this ExposureConventionType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


