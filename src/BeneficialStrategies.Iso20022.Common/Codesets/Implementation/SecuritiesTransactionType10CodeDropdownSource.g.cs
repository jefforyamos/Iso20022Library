﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SecuritiesTransactionType10Code.  ISO2002 ID# _0Oaigf8qEeCQ-IWv9MUPeQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies underlying information regarding the type of transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISecuritiesTransactionType10CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_0Oaigf8qEeCQ-IWv9MUPeQ")]
public partial class SecuritiesTransactionType10CodeDropdownSource : EnumMetadataManager<SecuritiesTransactionType10Code,ISecuritiesTransactionType10CodeDropdownRow,SecuritiesTransactionType10CodeDropdownRow>
{
    public SecuritiesTransactionType10CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SecuritiesTransactionType10CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
