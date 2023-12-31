﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DTCCQuantitySoughtCode.  ISO2002 ID# _1oiLwzL3EeKU9IrkkToqcw_-1345943536.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the quantity sought type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDTCCQuantitySoughtCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1oiLwzL3EeKU9IrkkToqcw_-1345943536")]
public partial class DTCCQuantitySoughtCodeDropdownSource : EnumMetadataManager<DTCCQuantitySoughtCode,IDTCCQuantitySoughtCodeDropdownRow,DTCCQuantitySoughtCodeDropdownRow>
{
    public DTCCQuantitySoughtCodeDropdownSource()
        : base( (enumValue, memberInfo) => new DTCCQuantitySoughtCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
