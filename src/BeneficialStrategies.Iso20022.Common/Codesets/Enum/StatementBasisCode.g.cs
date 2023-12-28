﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for StatementBasisCode.  ISO2002 ID# _ZQD0Itp-Ed-ak6NoX_4Aeg_836087748.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of balances on which the statement is prepared.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZQD0Itp-Ed-ak6NoX_4Aeg_836087748")]
[Description(@"Specifies the type of balances on which the statement is prepared.")]
[Derivations(typeof(StatementBasis1Code),typeof(StatementBasis2Code),typeof(StatementBasis3Code))]
// External derivations that should be provided by the proper interface are: 
public enum StatementBasisCode
{
    /// <summary>
    /// The statement is based on contractual settlement date irrespective of settled data positions.
    /// Encoded/decoded by serializers as "CONT".
    /// </summary>
    [EnumMember(Value = "CONT")]
    [IsoId("_ZQD0I9p-Ed-ak6NoX_4Aeg_1099290177")]
    [Description(@"The statement is based on contractual settlement date irrespective of settled data positions.")]
    Contractual,
    
    /// <summary>
    /// The statement is based on settled date positions to the knowledge of the sender at the time of the statement preparation.
    /// Encoded/decoded by serializers as "SETT".
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_ZQD0JNp-Ed-ak6NoX_4Aeg_1099290194")]
    [Description(@"The statement is based on settled date positions to the knowledge of the sender at the time of the statement preparation.")]
    Settled,
    
    /// <summary>
    /// The statement is based on trade date positions.
    /// Encoded/decoded by serializers as "TRAD".
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_ZQD0Jdp-Ed-ak6NoX_4Aeg_1099290212")]
    [Description(@"The statement is based on trade date positions.")]
    Traded,
    
    /// <summary>
    /// Mark-to-Market report sent after settlement. All transactions which have been initiated.
    /// Encoded/decoded by serializers as "EOSP".
    /// </summary>
    [EnumMember(Value = "EOSP")]
    [IsoId("_KGTm0MRxEeij-rSPpvD-Tw")]
    [Description(@"Mark-to-Market report sent after settlement. All transactions which have been initiated.")]
    EndOfSettlementPositions,
    
    /// <summary>
    /// Mark-to-market report taking into account collateral management actions which are still pending initiation and initiated transactions.
    /// Encoded/decoded by serializers as "FUTM".
    /// </summary>
    [EnumMember(Value = "FUTM")]
    [IsoId("_fhZ2cMRxEeij-rSPpvD-Tw")]
    [Description(@"Mark-to-market report taking into account collateral management actions which are still pending initiation and initiated transactions.")]
    FutureMarkToMarket,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class StatementBasisCodeMetadataExtensions
{
    private static readonly StatementBasisCodeDropdownSource _dropdownSource = new StatementBasisCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IStatementBasisCodeDropdownRow GetMetadata(this StatementBasisCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


