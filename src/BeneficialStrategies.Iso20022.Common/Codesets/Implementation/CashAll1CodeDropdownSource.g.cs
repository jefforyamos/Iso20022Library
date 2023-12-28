﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CashAll1Code.  ISO2002 ID# _RAAqYM4FEeiAhd-njDxLnA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if all assets are encashed and transferred as cash.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICashAll1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_RAAqYM4FEeiAhd-njDxLnA")]
public partial class CashAll1CodeDropdownSource : EnumMetadataManager<CashAll1Code,ICashAll1CodeDropdownRow,CashAll1CodeDropdownRow>
{
    public CashAll1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CashAll1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}