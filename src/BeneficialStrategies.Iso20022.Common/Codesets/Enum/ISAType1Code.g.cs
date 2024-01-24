﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ISAType1Code.  ISO2002 ID# _adZJ-Np-Ed-ak6NoX_4Aeg_948801052.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of the current year ISA.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_adZJ-Np-Ed-ak6NoX_4Aeg_948801052")]
[Description(@"Specifies the type of the current year ISA.")]
[DerivedFrom(typeof(ISATypeCode))]
public enum ISAType1Code
{
    /// <summary>
    /// Type of ISA that offers a stocks and shares component only (no cash).
    /// Encoded/decoded by serializers as "MINE".
    /// </summary>
    [EnumMember(Value = "MINE")]
    [IsoId("_adi68Np-Ed-ak6NoX_4Aeg_1030991907")]
    [Description(@"Type of ISA that offers a stocks and shares component only (no cash).")]
    MiniEquity = ISATypeCode.MiniEquity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Type of ISA that must offer a stocks and shares component and, optionally, a cash component.
    /// Encoded/decoded by serializers as "MAXI".
    /// </summary>
    [EnumMember(Value = "MAXI")]
    [IsoId("_adi68dp-Ed-ak6NoX_4Aeg_1030991924")]
    [Description(@"Type of ISA that must offer a stocks and shares component and, optionally, a cash component.")]
    Maxi = ISATypeCode.Maxi, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Type of ISA that offers a cash component only (no stock).
    /// Encoded/decoded by serializers as "MINC".
    /// </summary>
    [EnumMember(Value = "MINC")]
    [IsoId("_adi68tp-Ed-ak6NoX_4Aeg_1030991942")]
    [Description(@"Type of ISA that offers a cash component only (no stock).")]
    MiniCash = ISATypeCode.MiniCash, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ISAType1CodeMetadataExtensions
{
    private static readonly ISAType1CodeDropdownSource _dropdownSource = new ISAType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IISAType1CodeDropdownRow GetMetadata(this ISAType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


