﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OptionDefinitionTypeCode.  ISO2002 ID# _ADxVkLcQEeKuGrOch6U_ZQ_1001230530.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ADxVkLcQEeKuGrOch6U_ZQ_1001230530")]
[Description(@"Indicates whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).")]
public enum OptionDefinitionTypeCode
{
    /// <summary>
    /// Right to buy a quantity of an asset for an agreed price at exercise date.
    /// </summary>
    [EnumMember(Value = "CALL")]
    [IsoId("_AD7GkLcQEeKuGrOch6U_ZQ_-1963859091")]
    [Description(@"Right to buy a quantity of an asset for an agreed price at exercise date.")]
    CALL,
    
    /// <summary>
    /// Right to sell a quantity of an asset for an agreed price at exercise date.
    /// </summary>
    [EnumMember(Value = "PUTO")]
    [IsoId("_AD7GkbcQEeKuGrOch6U_ZQ_1096309774")]
    [Description(@"Right to sell a quantity of an asset for an agreed price at exercise date.")]
    PUTO,
    
    /// <summary>
    /// Right where the holder of the option decides whether the option is put or call.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_q5GEIAjtEeW36pGcc5RpFw")]
    [Description(@"Right where the holder of the option decides whether the option is put or call.")]
    OTHR,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OptionDefinitionTypeCodeMetadataExtensions
{
    private static readonly OptionDefinitionTypeCodeDropdownSource _dropdownSource = new OptionDefinitionTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOptionDefinitionTypeCodeDropdownRow GetMetadata(this OptionDefinitionTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


