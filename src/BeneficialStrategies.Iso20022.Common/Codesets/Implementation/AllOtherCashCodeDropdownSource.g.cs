﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AllOtherCashCode.  ISO2002 ID# _hzmK8CYHEeWJkOUkQWu90g.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if remaining assets are transferred as cash.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAllOtherCashCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_hzmK8CYHEeWJkOUkQWu90g")]
public partial class AllOtherCashCodeDropdownSource : EnumMetadataManager<AllOtherCashCode,IAllOtherCashCodeDropdownRow,AllOtherCashCodeDropdownRow>
{
    public AllOtherCashCodeDropdownSource()
        : base( (enumValue, memberInfo) => new AllOtherCashCodeDropdownRow(enumValue, memberInfo))
    {
    }
}