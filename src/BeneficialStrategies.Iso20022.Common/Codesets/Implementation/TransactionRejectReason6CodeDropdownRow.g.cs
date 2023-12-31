﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TransactionRejectReason6Code.  ISO2002 ID# _VxSAINp-Ed-ak6NoX_4Aeg_1027067779.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a transaction to be rejected or returned by an instructed agent or somebody acting on behalf of an instructed agent.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TransactionRejectReason6CodeDropdownSource"/>.
/// Implements <seealso cref="ITransactionRejectReason6CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VxSAINp-Ed-ak6NoX_4Aeg_1027067779")]
public partial class TransactionRejectReason6CodeDropdownRow : EnumMetadataItem<TransactionRejectReason6Code>, ITransactionRejectReason6CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason for a transaction to be rejected or returned by an instructed agent or somebody acting on behalf of an instructed agent.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TransactionRejectReason6CodeDropdownRow(TransactionRejectReason6Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
