﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CashAccountTypeCode.  ISO2002 ID# _a3ed5tp-Ed-ak6NoX_4Aeg_-1826678245.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature, or use, of the cash account.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICashAccountTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a3ed5tp-Ed-ak6NoX_4Aeg_-1826678245")]
public partial class CashAccountTypeCodeDropdownSource : EnumMetadataManager<CashAccountTypeCode,ICashAccountTypeCodeDropdownRow,CashAccountTypeCodeDropdownRow>
{
    public CashAccountTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CashAccountTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
