﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TransactionProcessingStatus3Code.  ISO2002 ID# _jWnSlO5NEeCisYr99QEiWA_732250051.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the processing status of a transaction (at account servicer level).
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TransactionProcessingStatus3CodeDropdownSource"/>.
/// Implements <seealso cref="ITransactionProcessingStatus3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_jWnSlO5NEeCisYr99QEiWA_732250051")]
public partial class TransactionProcessingStatus3CodeDropdownRow : EnumMetadataItem<TransactionProcessingStatus3Code>, ITransactionProcessingStatus3CodeDropdownRow
{
    /// <summary>
    /// Provides the processing status of a transaction (at account servicer level).
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TransactionProcessingStatus3CodeDropdownRow(TransactionProcessingStatus3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
