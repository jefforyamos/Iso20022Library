﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for GeneralInvestmentAccountType2Code.  ISO2002 ID# _HO62UJNvEembCsVG-3f_AA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of investment account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_HO62UJNvEembCsVG-3f_AA")]
[Description(@"Specifies a type of investment account.")]
[DerivedFrom(typeof(GeneralInvestmentAccountTypeCode))]
public enum GeneralInvestmentAccountType2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Any".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_PDJ8YZgJEemu1vK8dsrXIw")]
    [Description(@"??")]
    Any,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ShareSavingsAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_PI9CYZgJEemu1vK8dsrXIw")]
    [Description(@"??")]
    ShareSavingsAccount,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class GeneralInvestmentAccountType2CodeMetadataExtensions
{
    private static readonly GeneralInvestmentAccountType2CodeDropdownSource _dropdownSource = new GeneralInvestmentAccountType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IGeneralInvestmentAccountType2CodeDropdownRow GetMetadata(this GeneralInvestmentAccountType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


