﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RepurchaseType7Code.  ISO2002 ID# __vrhg9ojEeC60axPepSq7g_1563954315.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of repurchase transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRepurchaseType7CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__vrhg9ojEeC60axPepSq7g_1563954315")]
public partial class RepurchaseType7CodeDropdownSource : EnumMetadataManager<RepurchaseType7Code,IRepurchaseType7CodeDropdownRow,RepurchaseType7CodeDropdownRow>
{
    public RepurchaseType7CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RepurchaseType7CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
