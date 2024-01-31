﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for StatementStructureCode.  ISO2002 ID# _ZQM-ENp-Ed-ak6NoX_4Aeg_1615497688.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of balances on which the statement is prepared.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZQM-ENp-Ed-ak6NoX_4Aeg_1615497688")]
[Description(@"Specifies the type of balances on which the statement is prepared.")]
[Derivations(typeof(StatementStructure1Code))]
public enum StatementStructureCode
{
    /// <summary>
    /// Statement is sorted by status.
    /// Encoded/decoded by serializers as "STAT".
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_ZQM-Edp-Ed-ak6NoX_4Aeg_1615497706")]
    [Description(@"Statement is sorted by status.")]
    Statuses,
    
    /// <summary>
    /// Statement is sorted by transaction.
    /// Encoded/decoded by serializers as "TRAN".
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_ZQM-Etp-Ed-ak6NoX_4Aeg_1615497971")]
    [Description(@"Statement is sorted by transaction.")]
    Transactions,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class StatementStructureCodeMetadataExtensions
{
    private static readonly StatementStructureCodeDropdownSource _dropdownSource = new StatementStructureCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IStatementStructureCodeDropdownRow GetMetadata(this StatementStructureCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


