﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TransactionRejectReason4Code.  ISO2002 ID# _Ytochtp-Ed-ak6NoX_4Aeg_702218812.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a transaction to be rejected or returned by an instructed agent or somebody acting on behalf of an instructed agent.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TransactionRejectReason4CodeDropdownSource"/>.
/// Implements <seealso cref="ITransactionRejectReason4CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Ytochtp-Ed-ak6NoX_4Aeg_702218812")]
public partial class TransactionRejectReason4CodeDropdownRow : EnumMetadataItem<TransactionRejectReason4Code>, ITransactionRejectReason4CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason for a transaction to be rejected or returned by an instructed agent or somebody acting on behalf of an instructed agent.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TransactionRejectReason4CodeDropdownRow(TransactionRejectReason4Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
