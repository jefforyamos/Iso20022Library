﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AutoRoutingCode.  ISO2002 ID# _bj4Q59p-Ed-ak6NoX_4Aeg_686608073.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates whether an automatic routing system is involved.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAutoRoutingCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bj4Q59p-Ed-ak6NoX_4Aeg_686608073")]
public partial class AutoRoutingCodeDropdownSource : EnumMetadataManager<AutoRoutingCode,IAutoRoutingCodeDropdownRow,AutoRoutingCodeDropdownRow>
{
    public AutoRoutingCodeDropdownSource()
        : base( (enumValue, memberInfo) => new AutoRoutingCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
