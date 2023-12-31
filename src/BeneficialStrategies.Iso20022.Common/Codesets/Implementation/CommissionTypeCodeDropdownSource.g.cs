﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CommissionTypeCode.  ISO2002 ID# _VqbxSNp-Ed-ak6NoX_4Aeg_384306495.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of service for which the commission is asked or paid.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICommissionTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VqbxSNp-Ed-ak6NoX_4Aeg_384306495")]
public partial class CommissionTypeCodeDropdownSource : EnumMetadataManager<CommissionTypeCode,ICommissionTypeCodeDropdownRow,CommissionTypeCodeDropdownRow>
{
    public CommissionTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CommissionTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
