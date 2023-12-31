﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TransactionReversalReason1Code.  ISO2002 ID# _YuFIdtp-Ed-ak6NoX_4Aeg_1201919260.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a transaction to be reversed by an instructed agent or somebody acting on behalf of an instructed agent.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TransactionReversalReason1CodeDropdownSource"/>.
/// Implements <seealso cref="ITransactionReversalReason1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YuFIdtp-Ed-ak6NoX_4Aeg_1201919260")]
public partial class TransactionReversalReason1CodeDropdownRow : EnumMetadataItem<TransactionReversalReason1Code>, ITransactionReversalReason1CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason for a transaction to be reversed by an instructed agent or somebody acting on behalf of an instructed agent.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TransactionReversalReason1CodeDropdownRow(TransactionReversalReason1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
