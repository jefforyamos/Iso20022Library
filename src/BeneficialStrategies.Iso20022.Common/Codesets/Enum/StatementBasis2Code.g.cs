﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for StatementBasis2Code.  ISO2002 ID# _ZP6DKNp-Ed-ak6NoX_4Aeg_-1755152860.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of balances on which the statement is prepared.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZP6DKNp-Ed-ak6NoX_4Aeg_-1755152860")]
[Description(@"Specifies the type of balances on which the statement is prepared.")]
[DerivedFrom(typeof(StatementBasisCode))]
public enum StatementBasis2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Settled".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZQD0INp-Ed-ak6NoX_4Aeg_-1755151069")]
    [Description(@"??")]
    Settled,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Traded".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZQD0Idp-Ed-ak6NoX_4Aeg_-1755150482")]
    [Description(@"??")]
    Traded,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class StatementBasis2CodeMetadataExtensions
{
    private static readonly StatementBasis2CodeDropdownSource _dropdownSource = new StatementBasis2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IStatementBasis2CodeDropdownRow GetMetadata(this StatementBasis2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


