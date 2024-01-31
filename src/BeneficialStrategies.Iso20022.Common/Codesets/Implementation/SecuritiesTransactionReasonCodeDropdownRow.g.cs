﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SecuritiesTransactionReasonCode.  ISO2002 ID# _ZGOisNp-Ed-ak6NoX_4Aeg_464976126.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the reason why the transaction has a specific status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SecuritiesTransactionReasonCodeDropdownSource"/>.
/// Implements <seealso cref="ISecuritiesTransactionReasonCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZGOisNp-Ed-ak6NoX_4Aeg_464976126")]
public partial class SecuritiesTransactionReasonCodeDropdownRow : EnumMetadataItem<SecuritiesTransactionReasonCode>, ISecuritiesTransactionReasonCodeDropdownRow
{
    /// <summary>
    /// Identifies the reason why the transaction has a specific status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SecuritiesTransactionReasonCodeDropdownRow(SecuritiesTransactionReasonCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
