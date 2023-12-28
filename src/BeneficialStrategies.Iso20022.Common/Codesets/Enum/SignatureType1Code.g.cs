﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SignatureType1Code.  ISO2002 ID# _ZPUNQdp-Ed-ak6NoX_4Aeg_1678391514.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of signature form.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZPUNQdp-Ed-ak6NoX_4Aeg_1678391514")]
[Description(@"Type of signature form.")]
[DerivedFrom(typeof(SignatureTypeCode))]
public enum SignatureType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Original".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZPUNQtp-Ed-ak6NoX_4Aeg_1976689877")]
    [Description(@"??")]
    Original,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Digital".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZPUNQ9p-Ed-ak6NoX_4Aeg_1976689878")]
    [Description(@"??")]
    Digital,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Electronic".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZPUNRNp-Ed-ak6NoX_4Aeg_1976689908")]
    [Description(@"??")]
    Electronic,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "None".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZPUNRdp-Ed-ak6NoX_4Aeg_1976689909")]
    [Description(@"??")]
    None,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SignatureType1CodeMetadataExtensions
{
    private static readonly SignatureType1CodeDropdownSource _dropdownSource = new SignatureType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISignatureType1CodeDropdownRow GetMetadata(this SignatureType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


