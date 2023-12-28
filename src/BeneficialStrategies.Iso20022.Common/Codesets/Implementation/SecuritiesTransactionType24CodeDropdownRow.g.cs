﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SecuritiesTransactionType24Code.  ISO2002 ID# _etVX8NEkEeiO-eodGv5iKQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies underlying information regarding the type of settlement transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SecuritiesTransactionType24CodeDropdownSource"/>.
/// Implements <seealso cref="ISecuritiesTransactionType24CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_etVX8NEkEeiO-eodGv5iKQ")]
public partial class SecuritiesTransactionType24CodeDropdownRow : EnumMetadataItem<SecuritiesTransactionType24Code>, ISecuritiesTransactionType24CodeDropdownRow
{
    /// <summary>
    /// Specifies underlying information regarding the type of settlement transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SecuritiesTransactionType24CodeDropdownRow(SecuritiesTransactionType24Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}