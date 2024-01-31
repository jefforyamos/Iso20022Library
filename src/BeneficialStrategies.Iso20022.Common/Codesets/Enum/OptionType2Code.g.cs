﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OptionType2Code.  ISO2002 ID# __qH_IwNzEeWksqGoe-EFrg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether it is a call option (right to purchase a specific underlying asset) or a put option (right to sell a specific underlying asset) or any other type of option.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__qH_IwNzEeWksqGoe-EFrg")]
[Description(@"Specifies whether it is a call option (right to purchase a specific underlying asset) or a put option (right to sell a specific underlying asset) or any other type of option.")]
[DerivedFrom(typeof(OptionDefinitionTypeCode))]
public enum OptionType2Code
{
    /// <summary>
    /// Right to buy a quantity of an asset for an agreed price at exercise date.
    /// Encoded/decoded by serializers as "CALL".
    /// </summary>
    [EnumMember(Value = "CALL")]
    [IsoId("__qRwIANzEeWksqGoe-EFrg")]
    [Description(@"Right to buy a quantity of an asset for an agreed price at exercise date.")]
    Call = OptionDefinitionTypeCode.Call, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Right to sell a quantity of an asset for an agreed price at exercise date.
    /// Encoded/decoded by serializers as "PUTO".
    /// </summary>
    [EnumMember(Value = "PUTO")]
    [IsoId("__qRwIQNzEeWksqGoe-EFrg")]
    [Description(@"Right to sell a quantity of an asset for an agreed price at exercise date.")]
    Put = OptionDefinitionTypeCode.Put, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Right where the holder of the option decides whether the option is put or call.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_2SzHUQjtEeW36pGcc5RpFw")]
    [Description(@"Right where the holder of the option decides whether the option is put or call.")]
    Other = OptionDefinitionTypeCode.Other, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OptionType2CodeMetadataExtensions
{
    private static readonly OptionType2CodeDropdownSource _dropdownSource = new OptionType2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOptionType2CodeDropdownRow GetMetadata(this OptionType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


