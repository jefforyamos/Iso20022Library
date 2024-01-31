﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DepositType1Code.  ISO2002 ID# _YcMuSNp-Ed-ak6NoX_4Aeg_-543523872.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the deposit is fixed term or call/notice.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDepositType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YcMuSNp-Ed-ak6NoX_4Aeg_-543523872")]
public partial class DepositType1CodeDropdownSource : EnumMetadataManager<DepositType1Code,IDepositType1CodeDropdownRow,DepositType1CodeDropdownRow>
{
    public DepositType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DepositType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
