﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for StatementUpdateType1Code.  ISO2002 ID# _ZQM-F9p-Ed-ak6NoX_4Aeg_1112854815.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of a statement update, for example, it is a complete statement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZQM-F9p-Ed-ak6NoX_4Aeg_1112854815")]
[Description(@"Specifies the nature of a statement update, for example, it is a complete statement.")]
[DerivedFrom(typeof(StatementUpdateTypeV2Code))]
public enum StatementUpdateType1Code
{
    /// <summary>
    /// Statement is complete.
    /// Encoded/decoded by serializers as "Complete".
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_ZQM-GNp-Ed-ak6NoX_4Aeg_1368668707")]
    [Description(@"Statement is complete.")]
    Complete,
    
    /// <summary>
    /// Statement contains changes only.
    /// Encoded/decoded by serializers as "Delta".
    /// </summary>
    [EnumMember(Value = "DELT")]
    [IsoId("_ZQWvENp-Ed-ak6NoX_4Aeg_1368668708")]
    [Description(@"Statement contains changes only.")]
    Delta,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class StatementUpdateType1CodeMetadataExtensions
{
    private static readonly StatementUpdateType1CodeDropdownSource _dropdownSource = new StatementUpdateType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IStatementUpdateType1CodeDropdownRow GetMetadata(this StatementUpdateType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


