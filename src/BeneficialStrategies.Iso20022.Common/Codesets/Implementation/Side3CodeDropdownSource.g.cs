﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Side3Code.  ISO2002 ID# __x69MtojEeC60axPepSq7g_1543095306.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Side taken by a party on an order.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISide3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__x69MtojEeC60axPepSq7g_1543095306")]
public partial class Side3CodeDropdownSource : EnumMetadataManager<Side3Code,ISide3CodeDropdownRow,Side3CodeDropdownRow>
{
    public Side3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Side3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
