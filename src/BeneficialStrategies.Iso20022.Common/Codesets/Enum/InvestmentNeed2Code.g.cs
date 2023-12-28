﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InvestmentNeed2Code.  ISO2002 ID# _gKzBAKDtEequlaOyi6MUhw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies an investment need.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gKzBAKDtEequlaOyi6MUhw")]
[Description(@"Specifies an investment need.")]
[DerivedFrom(typeof(InvestmentNeedCode))]
public enum InvestmentNeed2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "None".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_i8cCMaDtEequlaOyi6MUhw")]
    [Description(@"??")]
    None,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jD4G8aDtEequlaOyi6MUhw")]
    [Description(@"??")]
    Other,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "IslamicBanking".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jK3fwaDtEequlaOyi6MUhw")]
    [Description(@"??")]
    IslamicBanking,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InvestmentNeed2CodeMetadataExtensions
{
    private static readonly InvestmentNeed2CodeDropdownSource _dropdownSource = new InvestmentNeed2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInvestmentNeed2CodeDropdownRow GetMetadata(this InvestmentNeed2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

