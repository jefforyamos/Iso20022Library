﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SecuritiesTransactionType28Code.  ISO2002 ID# _YKldDAleEeuQ1MenzX1l-g.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies underlying information regarding the type of settlement transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISecuritiesTransactionType28CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YKldDAleEeuQ1MenzX1l-g")]
public partial class SecuritiesTransactionType28CodeDropdownSource : EnumMetadataManager<SecuritiesTransactionType28Code,ISecuritiesTransactionType28CodeDropdownRow,SecuritiesTransactionType28CodeDropdownRow>
{
    public SecuritiesTransactionType28CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SecuritiesTransactionType28CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
