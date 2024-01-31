﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PriceValueType5Code.  ISO2002 ID# _aJk2E9p-Ed-ak6NoX_4Aeg_-647834844.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the value of a price.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aJk2E9p-Ed-ak6NoX_4Aeg_-647834844")]
[Description(@"Specifies the value of a price.")]
[DerivedFrom(typeof(PriceValueTypeCode))]
public enum PriceValueType5Code
{
    /// <summary>
    /// Price is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as "UKWN".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_aJk2FNp-Ed-ak6NoX_4Aeg_-647834596")]
    [Description(@"Price is unknown by the sender or has not been established.")]
    Unknown = PriceValueTypeCode.Unknown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price has not been established.
    /// Encoded/decoded by serializers as "OPEN".
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_aJk2Fdp-Ed-ak6NoX_4Aeg_-647834587")]
    [Description(@"Price has not been established.")]
    OpenDated = PriceValueTypeCode.OpenDated, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PriceValueType5CodeMetadataExtensions
{
    private static readonly PriceValueType5CodeDropdownSource _dropdownSource = new PriceValueType5CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPriceValueType5CodeDropdownRow GetMetadata(this PriceValueType5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


