﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SwapType1Code.  ISO2002 ID# _h8h1ECS1EeWsI5Sp3-B3zg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of an interest rate derivative when the contract type is a swap, a swaption, a future on a swap and / or a forward on a swap.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISwapType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_h8h1ECS1EeWsI5Sp3-B3zg")]
public partial class SwapType1CodeDropdownSource : EnumMetadataManager<SwapType1Code,ISwapType1CodeDropdownRow,SwapType1CodeDropdownRow>
{
    public SwapType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SwapType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
