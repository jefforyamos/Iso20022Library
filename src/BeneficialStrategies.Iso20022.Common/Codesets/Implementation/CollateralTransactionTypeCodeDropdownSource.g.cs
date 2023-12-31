﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CollateralTransactionTypeCode.  ISO2002 ID# _cBwMgLwdEeivTd4NUfCi2g.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Collateral  transaction type expressed as an ISO 20022 code.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICollateralTransactionTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_cBwMgLwdEeivTd4NUfCi2g")]
public partial class CollateralTransactionTypeCodeDropdownSource : EnumMetadataManager<CollateralTransactionTypeCode,ICollateralTransactionTypeCodeDropdownRow,CollateralTransactionTypeCodeDropdownRow>
{
    public CollateralTransactionTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CollateralTransactionTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
