﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SecuritiesTransactionType7Code.  ISO2002 ID# _rKALgfvkEeCBQp5TnX1XKQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies underlying information regarding the type of settlement transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISecuritiesTransactionType7CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_rKALgfvkEeCBQp5TnX1XKQ")]
public partial class SecuritiesTransactionType7CodeDropdownSource : EnumMetadataManager<SecuritiesTransactionType7Code,ISecuritiesTransactionType7CodeDropdownRow,SecuritiesTransactionType7CodeDropdownRow>
{
    public SecuritiesTransactionType7CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SecuritiesTransactionType7CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
