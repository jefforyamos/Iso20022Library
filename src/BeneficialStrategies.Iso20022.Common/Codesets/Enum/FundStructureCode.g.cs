﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FundStructureCode.  ISO2002 ID# _atyWZNp-Ed-ak6NoX_4Aeg_-1618399361.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the structure of the fund.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_atyWZNp-Ed-ak6NoX_4Aeg_-1618399361")]
[Description(@"Specifies the structure of the fund.")]
public enum FundStructureCode
{
    /// <summary>
    /// Investment fund that contains more than one investment fund class.
    /// Encoded/decoded by serializers as "MFUN".
    /// </summary>
    [EnumMember(Value = "MFUN")]
    [IsoId("_atyWZdp-Ed-ak6NoX_4Aeg_-1363507035")]
    [Description(@"Investment fund that contains more than one investment fund class.")]
    MultiClassFund,
    
    /// <summary>
    /// Investment fund that contains only one investment fund class.
    /// Encoded/decoded by serializers as "SFUN".
    /// </summary>
    [EnumMember(Value = "SFUN")]
    [IsoId("_atyWZtp-Ed-ak6NoX_4Aeg_-904519550")]
    [Description(@"Investment fund that contains only one investment fund class.")]
    SingleClassFund,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FundStructureCodeMetadataExtensions
{
    private static readonly FundStructureCodeDropdownSource _dropdownSource = new FundStructureCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFundStructureCodeDropdownRow GetMetadata(this FundStructureCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


