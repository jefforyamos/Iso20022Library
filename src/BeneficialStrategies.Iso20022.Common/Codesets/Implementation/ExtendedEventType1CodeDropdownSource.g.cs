﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExtendedEventType1Code.  ISO2002 ID# _15EiJjL3EeKU9IrkkToqcw_-1452988738.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExtendedEventType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_15EiJjL3EeKU9IrkkToqcw_-1452988738")]
public partial class ExtendedEventType1CodeDropdownSource : EnumMetadataManager<ExtendedEventType1Code,IExtendedEventType1CodeDropdownRow,ExtendedEventType1CodeDropdownRow>
{
    public ExtendedEventType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExtendedEventType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
