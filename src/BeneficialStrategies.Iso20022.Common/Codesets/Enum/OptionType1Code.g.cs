﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OptionType1Code.  ISO2002 ID# _aQbsAdp-Ed-ak6NoX_4Aeg_-835357153.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aQbsAdp-Ed-ak6NoX_4Aeg_-835357153")]
[Description(@"Indicates whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).")]
[DerivedFrom(typeof(OptionDefinitionTypeCode))]
public enum OptionType1Code
{
    /// <summary>
    /// Right to buy a quantity of an asset for an agreed price at exercise date.
    /// Encoded/decoded by serializers as "CALL".
    /// </summary>
    [EnumMember(Value = "CALL")]
    [IsoId("_aQbsAtp-Ed-ak6NoX_4Aeg_-539829511")]
    [Description(@"Right to buy a quantity of an asset for an agreed price at exercise date.")]
    Call = OptionDefinitionTypeCode.Call, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Right to sell a quantity of an asset for an agreed price at exercise date.
    /// Encoded/decoded by serializers as "PUTO".
    /// </summary>
    [EnumMember(Value = "PUTO")]
    [IsoId("_aQbsA9p-Ed-ak6NoX_4Aeg_-539829469")]
    [Description(@"Right to sell a quantity of an asset for an agreed price at exercise date.")]
    Put = OptionDefinitionTypeCode.Put, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OptionType1CodeMetadataExtensions
{
    private static readonly OptionType1CodeDropdownSource _dropdownSource = new OptionType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOptionType1CodeDropdownRow GetMetadata(this OptionType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


