﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExtendedEventType6Code.  ISO2002 ID# _32I1Ub_pEeeb2ZBoAlSG1Q.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExtendedEventType6CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_32I1Ub_pEeeb2ZBoAlSG1Q")]
public partial class ExtendedEventType6CodeDropdownSource : EnumMetadataManager<ExtendedEventType6Code,IExtendedEventType6CodeDropdownRow,ExtendedEventType6CodeDropdownRow>
{
    public ExtendedEventType6CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExtendedEventType6CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
