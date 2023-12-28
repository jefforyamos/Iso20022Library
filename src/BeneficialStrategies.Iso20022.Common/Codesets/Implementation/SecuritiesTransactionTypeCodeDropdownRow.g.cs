﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SecuritiesTransactionTypeCode.  ISO2002 ID# _ZIwSQtp-Ed-ak6NoX_4Aeg_-1421887384.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies underlying information regarding the type of settlement transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SecuritiesTransactionTypeCodeDropdownSource"/>.
/// Implements <seealso cref="ISecuritiesTransactionTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZIwSQtp-Ed-ak6NoX_4Aeg_-1421887384")]
public partial class SecuritiesTransactionTypeCodeDropdownRow : EnumMetadataItem<SecuritiesTransactionTypeCode>, ISecuritiesTransactionTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies underlying information regarding the type of settlement transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SecuritiesTransactionTypeCodeDropdownRow(SecuritiesTransactionTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}