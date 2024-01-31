﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for GeneralInvestmentAccountTypeCode.  ISO2002 ID# _pXBs0F2cEeiFXdiLi_Nf4A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of investment account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_pXBs0F2cEeiFXdiLi_Nf4A")]
[Description(@"Specifies a type of investment account.")]
[Derivations(typeof(GeneralInvestmentAccountType1Code),typeof(GeneralInvestmentAccountType2Code))]
public enum GeneralInvestmentAccountTypeCode
{
    /// <summary>
    /// General shares or equity savings account.
    /// Encoded/decoded by serializers as "EQUI".
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_sSL2YF2cEeiFXdiLi_Nf4A")]
    [Description(@"General shares or equity savings account.")]
    ShareSavingsAccount,
    
    /// <summary>
    /// Any type of general investment account.
    /// Encoded/decoded by serializers as "ANYY".
    /// </summary>
    [EnumMember(Value = "ANYY")]
    [IsoId("_8neWgJNuEembCsVG-3f_AA")]
    [Description(@"Any type of general investment account.")]
    Any,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class GeneralInvestmentAccountTypeCodeMetadataExtensions
{
    private static readonly GeneralInvestmentAccountTypeCodeDropdownSource _dropdownSource = new GeneralInvestmentAccountTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IGeneralInvestmentAccountTypeCodeDropdownRow GetMetadata(this GeneralInvestmentAccountTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


