﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DTCCSubEventType1Code.  ISO2002 ID# _15XdEDL3EeKU9IrkkToqcw_-1675841545.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined sub event types.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDTCCSubEventType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_15XdEDL3EeKU9IrkkToqcw_-1675841545")]
public partial class DTCCSubEventType1CodeDropdownSource : EnumMetadataManager<DTCCSubEventType1Code,IDTCCSubEventType1CodeDropdownRow,DTCCSubEventType1CodeDropdownRow>
{
    public DTCCSubEventType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DTCCSubEventType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}