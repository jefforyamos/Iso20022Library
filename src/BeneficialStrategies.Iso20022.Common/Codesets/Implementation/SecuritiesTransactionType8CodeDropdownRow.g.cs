﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SecuritiesTransactionType8Code.  ISO2002 ID# _rujNkfvlEeCBQp5TnX1XKQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies underlying information regarding the type of transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SecuritiesTransactionType8CodeDropdownSource"/>.
/// Implements <seealso cref="ISecuritiesTransactionType8CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_rujNkfvlEeCBQp5TnX1XKQ")]
public partial class SecuritiesTransactionType8CodeDropdownRow : EnumMetadataItem<SecuritiesTransactionType8Code>, ISecuritiesTransactionType8CodeDropdownRow
{
    /// <summary>
    /// Specifies underlying information regarding the type of transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SecuritiesTransactionType8CodeDropdownRow(SecuritiesTransactionType8Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
