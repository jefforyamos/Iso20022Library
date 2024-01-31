﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ReorganisationWithdrawalTransactionType1Code.  ISO2002 ID# _Sxi5QMY0EeesocHIuVGr7g.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of withdrawal reorganisation transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IReorganisationWithdrawalTransactionType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Sxi5QMY0EeesocHIuVGr7g")]
public partial class ReorganisationWithdrawalTransactionType1CodeDropdownSource : EnumMetadataManager<ReorganisationWithdrawalTransactionType1Code,IReorganisationWithdrawalTransactionType1CodeDropdownRow,ReorganisationWithdrawalTransactionType1CodeDropdownRow>
{
    public ReorganisationWithdrawalTransactionType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ReorganisationWithdrawalTransactionType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
