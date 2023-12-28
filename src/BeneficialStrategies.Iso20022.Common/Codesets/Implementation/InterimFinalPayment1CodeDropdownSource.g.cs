﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InterimFinalPayment1Code.  ISO2002 ID# _1tcg9DL3EeKU9IrkkToqcw_710704652.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies payment type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInterimFinalPayment1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1tcg9DL3EeKU9IrkkToqcw_710704652")]
public partial class InterimFinalPayment1CodeDropdownSource : EnumMetadataManager<InterimFinalPayment1Code,IInterimFinalPayment1CodeDropdownRow,InterimFinalPayment1CodeDropdownRow>
{
    public InterimFinalPayment1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new InterimFinalPayment1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
