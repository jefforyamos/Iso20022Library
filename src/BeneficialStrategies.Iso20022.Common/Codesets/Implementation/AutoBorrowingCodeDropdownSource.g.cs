﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AutoBorrowingCode.  ISO2002 ID# _bjuf5dp-Ed-ak6NoX_4Aeg_1205177778.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the condition under which automatic borrowing is allowed.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAutoBorrowingCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bjuf5dp-Ed-ak6NoX_4Aeg_1205177778")]
public partial class AutoBorrowingCodeDropdownSource : EnumMetadataManager<AutoBorrowingCode,IAutoBorrowingCodeDropdownRow,AutoBorrowingCodeDropdownRow>
{
    public AutoBorrowingCodeDropdownSource()
        : base( (enumValue, memberInfo) => new AutoBorrowingCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
