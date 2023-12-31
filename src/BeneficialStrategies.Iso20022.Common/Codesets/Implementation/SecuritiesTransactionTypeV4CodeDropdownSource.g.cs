﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SecuritiesTransactionTypeV4Code.  ISO2002 ID# _XodBUdEZEeiO-eodGv5iKQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies underlying information regarding the type of settlement transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISecuritiesTransactionTypeV4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_XodBUdEZEeiO-eodGv5iKQ")]
public partial class SecuritiesTransactionTypeV4CodeDropdownSource : EnumMetadataManager<SecuritiesTransactionTypeV4Code,ISecuritiesTransactionTypeV4CodeDropdownRow,SecuritiesTransactionTypeV4CodeDropdownRow>
{
    public SecuritiesTransactionTypeV4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SecuritiesTransactionTypeV4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
