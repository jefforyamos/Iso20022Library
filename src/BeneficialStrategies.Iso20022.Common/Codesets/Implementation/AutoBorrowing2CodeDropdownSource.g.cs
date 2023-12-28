﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AutoBorrowing2Code.  ISO2002 ID# _bjuf4Np-Ed-ak6NoX_4Aeg_-875280899.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the condition under which automatic borrowing is allowed.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAutoBorrowing2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bjuf4Np-Ed-ak6NoX_4Aeg_-875280899")]
public partial class AutoBorrowing2CodeDropdownSource : EnumMetadataManager<AutoBorrowing2Code,IAutoBorrowing2CodeDropdownRow,AutoBorrowing2CodeDropdownRow>
{
    public AutoBorrowing2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AutoBorrowing2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}