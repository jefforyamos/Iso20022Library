﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ConsolidationType1Code.  ISO2002 ID# _3fs5YCDVEeWCLu74WLgP4w.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the consolidation type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IConsolidationType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_3fs5YCDVEeWCLu74WLgP4w")]
public partial class ConsolidationType1CodeDropdownSource : EnumMetadataManager<ConsolidationType1Code,IConsolidationType1CodeDropdownRow,ConsolidationType1CodeDropdownRow>
{
    public ConsolidationType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ConsolidationType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
