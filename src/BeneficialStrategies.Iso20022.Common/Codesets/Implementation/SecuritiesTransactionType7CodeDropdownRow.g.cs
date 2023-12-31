﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SecuritiesTransactionType7Code.  ISO2002 ID# _rKALgfvkEeCBQp5TnX1XKQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies underlying information regarding the type of settlement transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SecuritiesTransactionType7CodeDropdownSource"/>.
/// Implements <seealso cref="ISecuritiesTransactionType7CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_rKALgfvkEeCBQp5TnX1XKQ")]
public partial class SecuritiesTransactionType7CodeDropdownRow : EnumMetadataItem<SecuritiesTransactionType7Code>, ISecuritiesTransactionType7CodeDropdownRow
{
    /// <summary>
    /// Specifies underlying information regarding the type of settlement transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SecuritiesTransactionType7CodeDropdownRow(SecuritiesTransactionType7Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
