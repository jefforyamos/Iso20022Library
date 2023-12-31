﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SecuritiesTransactionType18Code.  ISO2002 ID# _v5KIUYymEea-QrbCUXny2w.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies underlying information regarding the type of transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISecuritiesTransactionType18CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_v5KIUYymEea-QrbCUXny2w")]
public partial class SecuritiesTransactionType18CodeDropdownSource : EnumMetadataManager<SecuritiesTransactionType18Code,ISecuritiesTransactionType18CodeDropdownRow,SecuritiesTransactionType18CodeDropdownRow>
{
    public SecuritiesTransactionType18CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SecuritiesTransactionType18CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
