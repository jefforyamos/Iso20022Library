﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CertificationFormatType1Code.  ISO2002 ID# _a78HINp-Ed-ak6NoX_4Aeg_-1603295237.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the certification format required, that is, physical or electronic format.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a78HINp-Ed-ak6NoX_4Aeg_-1603295237")]
[Description(@"Specifies the certification format required, that is, physical or electronic format.")]
[DerivedFrom(typeof(CertificationFormatTypeCode))]
public enum CertificationFormatType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Electronic".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a78HIdp-Ed-ak6NoX_4Aeg_-1559890547")]
    [Description(@"??")]
    Electronic,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Physical".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_a78HItp-Ed-ak6NoX_4Aeg_-1559890529")]
    [Description(@"??")]
    Physical,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CertificationFormatType1CodeMetadataExtensions
{
    private static readonly CertificationFormatType1CodeDropdownSource _dropdownSource = new CertificationFormatType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICertificationFormatType1CodeDropdownRow GetMetadata(this CertificationFormatType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


