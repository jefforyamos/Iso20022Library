﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for StatementUpdateTypeCode.  ISO2002 ID# _ZQWvEdp-Ed-ak6NoX_4Aeg_-1582551543.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of a statement update, eg, it is a complete statement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZQWvEdp-Ed-ak6NoX_4Aeg_-1582551543")]
[Description(@"Specifies the nature of a statement update, eg, it is a complete statement.")]
public enum StatementUpdateTypeCode
{
    /// <summary>
    /// Statement is complete.
    /// Encoded/decoded by serializers as "COMP".
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_ZQWvEtp-Ed-ak6NoX_4Aeg_-1582551317")]
    [Description(@"Statement is complete.")]
    Complete,
    
    /// <summary>
    /// Statement contains changes only.
    /// Encoded/decoded by serializers as "DELT".
    /// </summary>
    [EnumMember(Value = "DELT")]
    [IsoId("_ZQWvE9p-Ed-ak6NoX_4Aeg_-1582551316")]
    [Description(@"Statement contains changes only.")]
    Delta,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class StatementUpdateTypeCodeMetadataExtensions
{
    private static readonly StatementUpdateTypeCodeDropdownSource _dropdownSource = new StatementUpdateTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IStatementUpdateTypeCodeDropdownRow GetMetadata(this StatementUpdateTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


