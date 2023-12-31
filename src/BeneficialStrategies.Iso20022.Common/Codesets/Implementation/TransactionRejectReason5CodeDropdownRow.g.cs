﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TransactionRejectReason5Code.  ISO2002 ID# _Yt7-gtp-Ed-ak6NoX_4Aeg_-68983603.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a transaction to be rejected or returned by an instructed agent or somebody acting on behalf of an instructed agent.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TransactionRejectReason5CodeDropdownSource"/>.
/// Implements <seealso cref="ITransactionRejectReason5CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Yt7-gtp-Ed-ak6NoX_4Aeg_-68983603")]
public partial class TransactionRejectReason5CodeDropdownRow : EnumMetadataItem<TransactionRejectReason5Code>, ITransactionRejectReason5CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason for a transaction to be rejected or returned by an instructed agent or somebody acting on behalf of an instructed agent.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TransactionRejectReason5CodeDropdownRow(TransactionRejectReason5Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
