﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DiscountType1Code.  ISO2002 ID# _TQ3_sAEcEeCQm6a_G2yO_w_-1597992026.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of discount, that is, the reason why a discount is granted.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDiscountType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TQ3_sAEcEeCQm6a_G2yO_w_-1597992026")]
public partial class DiscountType1CodeDropdownSource : EnumMetadataManager<DiscountType1Code,IDiscountType1CodeDropdownRow,DiscountType1CodeDropdownRow>
{
    public DiscountType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DiscountType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
