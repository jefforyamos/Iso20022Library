﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UseCasesCode.  ISO2002 ID# _Ya3Rgdp-Ed-ak6NoX_4Aeg_1660587071.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the action on the cash account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Ya3Rgdp-Ed-ak6NoX_4Aeg_1660587071")]
[Description(@"Specifies the action on the cash account.")]
[Derivations(typeof(UseCases1Code))]
// External derivations that should be provided by the proper interface are: 
public enum UseCasesCode
{
    /// <summary>
    /// Code indicating the opening of an account.
    /// Encoded/decoded by serializers as "OPEN".
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_Ya3Rgtp-Ed-ak6NoX_4Aeg_1759403756")]
    [Description(@"Code indicating the opening of an account.")]
    Opening,
    
    /// <summary>
    /// Code indicating the maintenance of an account.
    /// Encoded/decoded by serializers as "MNTN".
    /// </summary>
    [EnumMember(Value = "MNTN")]
    [IsoId("_Ya3Rg9p-Ed-ak6NoX_4Aeg_1772332772")]
    [Description(@"Code indicating the maintenance of an account.")]
    Maintenance,
    
    /// <summary>
    /// Code indicating the closing of an account.
    /// Encoded/decoded by serializers as "CLSG".
    /// </summary>
    [EnumMember(Value = "CLSG")]
    [IsoId("_Ya3RhNp-Ed-ak6NoX_4Aeg_1784340417")]
    [Description(@"Code indicating the closing of an account.")]
    Closing,
    
    /// <summary>
    /// Code indicating the view of an account.
    /// Encoded/decoded by serializers as "VIEW".
    /// </summary>
    [EnumMember(Value = "VIEW")]
    [IsoId("_Ya3Rhdp-Ed-ak6NoX_4Aeg_2026301994")]
    [Description(@"Code indicating the view of an account.")]
    View,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class UseCasesCodeMetadataExtensions
{
    private static readonly UseCasesCodeDropdownSource _dropdownSource = new UseCasesCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IUseCasesCodeDropdownRow GetMetadata(this UseCasesCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


