﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CollateralEntryType1Code.  ISO2002 ID# _O0zXoHvLEemW9qhOy0scyg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the quantity or amount is to be delivered or received.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICollateralEntryType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_O0zXoHvLEemW9qhOy0scyg")]
public partial class CollateralEntryType1CodeDropdownSource : EnumMetadataManager<CollateralEntryType1Code,ICollateralEntryType1CodeDropdownRow,CollateralEntryType1CodeDropdownRow>
{
    public CollateralEntryType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CollateralEntryType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
