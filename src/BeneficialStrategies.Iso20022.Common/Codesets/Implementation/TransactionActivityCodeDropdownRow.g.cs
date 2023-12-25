﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TransactionActivityCode.  ISO2002 ID# _YrP25tp-Ed-ak6NoX_4Aeg_-41180042.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of activity to which this transaction relates.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TransactionActivityCodeDropdownSource"/>.
/// Implements <seealso cref="ITransactionActivityCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YrP25tp-Ed-ak6NoX_4Aeg_-41180042")]
public partial class TransactionActivityCodeDropdownRow : EnumMetadataItem<TransactionActivityCode>, ITransactionActivityCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of activity to which this transaction relates.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TransactionActivityCodeDropdownRow(TransactionActivityCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
