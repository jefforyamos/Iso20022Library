﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SecuritiesTransactionType1Code.  ISO2002 ID# _ZGXsoNp-Ed-ak6NoX_4Aeg_2037048643.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies underlying information regarding the type of settlement transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISecuritiesTransactionType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZGXsoNp-Ed-ak6NoX_4Aeg_2037048643")]
public partial class SecuritiesTransactionType1CodeDropdownSource : EnumMetadataManager<SecuritiesTransactionType1Code,ISecuritiesTransactionType1CodeDropdownRow,SecuritiesTransactionType1CodeDropdownRow>
{
    public SecuritiesTransactionType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SecuritiesTransactionType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
