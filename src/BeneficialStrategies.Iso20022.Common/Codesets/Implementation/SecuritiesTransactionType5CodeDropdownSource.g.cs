﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SecuritiesTransactionType5Code.  ISO2002 ID# _ZIwSQNp-Ed-ak6NoX_4Aeg_1800982665.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies underlying information regarding the type of transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISecuritiesTransactionType5CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZIwSQNp-Ed-ak6NoX_4Aeg_1800982665")]
public partial class SecuritiesTransactionType5CodeDropdownSource : EnumMetadataManager<SecuritiesTransactionType5Code,ISecuritiesTransactionType5CodeDropdownRow,SecuritiesTransactionType5CodeDropdownRow>
{
    public SecuritiesTransactionType5CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SecuritiesTransactionType5CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
