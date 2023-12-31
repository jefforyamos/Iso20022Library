﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DTCEntitlementCalculationMethod1Code.  ISO2002 ID# _1qnPYDL3EeKU9IrkkToqcw_744011491.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of calculation of entitlements.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDTCEntitlementCalculationMethod1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1qnPYDL3EeKU9IrkkToqcw_744011491")]
public partial class DTCEntitlementCalculationMethod1CodeDropdownSource : EnumMetadataManager<DTCEntitlementCalculationMethod1Code,IDTCEntitlementCalculationMethod1CodeDropdownRow,DTCEntitlementCalculationMethod1CodeDropdownRow>
{
    public DTCEntitlementCalculationMethod1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DTCEntitlementCalculationMethod1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
