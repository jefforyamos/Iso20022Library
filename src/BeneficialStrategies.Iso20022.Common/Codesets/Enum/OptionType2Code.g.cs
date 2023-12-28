﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OptionType2Code.  ISO2002 ID# __qH_IwNzEeWksqGoe-EFrg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

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
    /// ??
    /// Encoded/decoded by serializers as "Call".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__qRwIANzEeWksqGoe-EFrg")]
    [Description(@"??")]
    Call,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Put".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__qRwIQNzEeWksqGoe-EFrg")]
    [Description(@"??")]
    Put,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_2SzHUQjtEeW36pGcc5RpFw")]
    [Description(@"??")]
    Other,
    
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


