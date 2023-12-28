﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExposureConventionTypeCode.  ISO2002 ID# _YczLM9p-Ed-ak6NoX_4Aeg_-483728852.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Determines how the variation margin requirement will be calculated, either net or gross.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YczLM9p-Ed-ak6NoX_4Aeg_-483728852")]
[Description(@"Determines how the variation margin requirement will be calculated, either net or gross.")]
public enum ExposureConventionTypeCode
{
    /// <summary>
    /// Indicates that the exposed amount to party A and B will be netted together for the variation margin calculation, and then two separate variation margin requirements will be determined.
    /// Encoded/decoded by serializers as "GROS".
    /// </summary>
    [EnumMember(Value = "GROS")]
    [IsoId("_YczLNNp-Ed-ak6NoX_4Aeg_1466690893")]
    [Description(@"Indicates that the exposed amount to party A and B will be netted together for the variation margin calculation, and then two separate variation margin requirements will be determined.")]
    Gross,
    
    /// <summary>
    /// Indicates that the exposed amount to party A and B will be netted together for the variation margin calculation.
    /// Encoded/decoded by serializers as "NET1".
    /// </summary>
    [EnumMember(Value = "NET1")]
    [IsoId("_YczLNdp-Ed-ak6NoX_4Aeg_1963652229")]
    [Description(@"Indicates that the exposed amount to party A and B will be netted together for the variation margin calculation.")]
    Net,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExposureConventionTypeCodeMetadataExtensions
{
    private static readonly ExposureConventionTypeCodeDropdownSource _dropdownSource = new ExposureConventionTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExposureConventionTypeCodeDropdownRow GetMetadata(this ExposureConventionTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


