﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OperationCode.  ISO2002 ID# _aO8eR9p-Ed-ak6NoX_4Aeg_336257253.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the relationship between two variables.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aO8eR9p-Ed-ak6NoX_4Aeg_336257253")]
[Description(@"Indicates the relationship between two variables.")]
public enum OperationCode
{
    /// <summary>
    /// Indicates a range delimited by two variables.
    /// Encoded/decoded by serializers as "TILL".
    /// </summary>
    [EnumMember(Value = "TILL")]
    [IsoId("_aPFoMNp-Ed-ak6NoX_4Aeg_336257262")]
    [Description(@"Indicates a range delimited by two variables.")]
    Till,
    
    /// <summary>
    /// Indicates either of two variables is valid, but not both.
    /// Encoded/decoded by serializers as "ORRR".
    /// </summary>
    [EnumMember(Value = "ORRR")]
    [IsoId("_aPFoMdp-Ed-ak6NoX_4Aeg_336257263")]
    [Description(@"Indicates either of two variables is valid, but not both.")]
    Or,
    
    /// <summary>
    /// Indicates that only when both variables are given, the operation is valid.
    /// Encoded/decoded by serializers as "ANDD".
    /// </summary>
    [EnumMember(Value = "ANDD")]
    [IsoId("_aPFoMtp-Ed-ak6NoX_4Aeg_336257264")]
    [Description(@"Indicates that only when both variables are given, the operation is valid.")]
    And,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OperationCodeMetadataExtensions
{
    private static readonly OperationCodeDropdownSource _dropdownSource = new OperationCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOperationCodeDropdownRow GetMetadata(this OperationCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

