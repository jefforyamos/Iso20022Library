﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TransactionIndividualStatus1Code.  ISO2002 ID# _Yrsi2Np-Ed-ak6NoX_4Aeg_-1851702308.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a single payment transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TransactionIndividualStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="ITransactionIndividualStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Yrsi2Np-Ed-ak6NoX_4Aeg_-1851702308")]
public partial class TransactionIndividualStatus1CodeDropdownRow : EnumMetadataItem<TransactionIndividualStatus1Code>, ITransactionIndividualStatus1CodeDropdownRow
{
    /// <summary>
    /// Specifies the status of a single payment transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TransactionIndividualStatus1CodeDropdownRow(TransactionIndividualStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
