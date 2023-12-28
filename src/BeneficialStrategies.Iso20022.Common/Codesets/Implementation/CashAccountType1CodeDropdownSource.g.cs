﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CashAccountType1Code.  ISO2002 ID# _a24A8dp-Ed-ak6NoX_4Aeg_2050502101.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature, or use, of the cash account.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICashAccountType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a24A8dp-Ed-ak6NoX_4Aeg_2050502101")]
public partial class CashAccountType1CodeDropdownSource : EnumMetadataManager<CashAccountType1Code,ICashAccountType1CodeDropdownRow,CashAccountType1CodeDropdownRow>
{
    public CashAccountType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CashAccountType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}