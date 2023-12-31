﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for StatementStructure1Code.  ISO2002 ID# _ZQD0Jtp-Ed-ak6NoX_4Aeg_-1907403556.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of balances on which the statement is prepared.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZQD0Jtp-Ed-ak6NoX_4Aeg_-1907403556")]
[Description(@"Specifies the type of balances on which the statement is prepared.")]
[DerivedFrom(typeof(StatementStructureCode))]
public enum StatementStructure1Code
{
    /// <summary>
    /// Statement is sorted by status.
    /// Encoded/decoded by serializers as "Statuses".
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_ZQD0J9p-Ed-ak6NoX_4Aeg_-1906483117")]
    [Description(@"Statement is sorted by status.")]
    Statuses,
    
    /// <summary>
    /// Statement is sorted by transaction.
    /// Encoded/decoded by serializers as "Transactions".
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_ZQD0KNp-Ed-ak6NoX_4Aeg_-1906483092")]
    [Description(@"Statement is sorted by transaction.")]
    Transactions,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class StatementStructure1CodeMetadataExtensions
{
    private static readonly StatementStructure1CodeDropdownSource _dropdownSource = new StatementStructure1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IStatementStructure1CodeDropdownRow GetMetadata(this StatementStructure1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


