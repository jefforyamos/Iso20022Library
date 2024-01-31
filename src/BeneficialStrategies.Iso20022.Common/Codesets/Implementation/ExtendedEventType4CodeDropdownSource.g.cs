﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExtendedEventType4Code.  ISO2002 ID# _-mm30ZESEeajS_7NioJdVA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExtendedEventType4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-mm30ZESEeajS_7NioJdVA")]
public partial class ExtendedEventType4CodeDropdownSource : EnumMetadataManager<ExtendedEventType4Code,IExtendedEventType4CodeDropdownRow,ExtendedEventType4CodeDropdownRow>
{
    public ExtendedEventType4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExtendedEventType4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
