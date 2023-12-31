﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for StatementBasis1Code.  ISO2002 ID# _ZP6DJNp-Ed-ak6NoX_4Aeg_-957087736.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of balances on which the statement is prepared.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZP6DJNp-Ed-ak6NoX_4Aeg_-957087736")]
[Description(@"Specifies the type of balances on which the statement is prepared.")]
[DerivedFrom(typeof(StatementBasisCode))]
public enum StatementBasis1Code
{
    /// <summary>
    /// The statement is based on contractual settlement date irrespective of settled data positions.
    /// Encoded/decoded by serializers as "Contractual".
    /// </summary>
    [EnumMember(Value = "CONT")]
    [IsoId("_ZP6DJdp-Ed-ak6NoX_4Aeg_-926610659")]
    [Description(@"The statement is based on contractual settlement date irrespective of settled data positions.")]
    Contractual,
    
    /// <summary>
    /// The statement is based on settled date positions to the knowledge of the sender at the time of the statement preparation.
    /// Encoded/decoded by serializers as "Settled".
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_ZP6DJtp-Ed-ak6NoX_4Aeg_-2028635093")]
    [Description(@"The statement is based on settled date positions to the knowledge of the sender at the time of the statement preparation.")]
    Settled,
    
    /// <summary>
    /// The statement is based on trade date positions.
    /// Encoded/decoded by serializers as "Traded".
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_ZP6DJ9p-Ed-ak6NoX_4Aeg_-2014783388")]
    [Description(@"The statement is based on trade date positions.")]
    Traded,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class StatementBasis1CodeMetadataExtensions
{
    private static readonly StatementBasis1CodeDropdownSource _dropdownSource = new StatementBasis1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IStatementBasis1CodeDropdownRow GetMetadata(this StatementBasis1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


