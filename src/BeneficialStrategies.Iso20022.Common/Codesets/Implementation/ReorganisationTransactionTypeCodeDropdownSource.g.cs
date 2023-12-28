﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ReorganisationTransactionTypeCode.  ISO2002 ID# _QcVdoMU9EeeWeZMpNX1JUQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of reorganisation transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IReorganisationTransactionTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_QcVdoMU9EeeWeZMpNX1JUQ")]
public partial class ReorganisationTransactionTypeCodeDropdownSource : EnumMetadataManager<ReorganisationTransactionTypeCode,IReorganisationTransactionTypeCodeDropdownRow,ReorganisationTransactionTypeCodeDropdownRow>
{
    public ReorganisationTransactionTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ReorganisationTransactionTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}