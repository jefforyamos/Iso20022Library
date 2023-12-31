﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OrderClassificationCode.  ISO2002 ID# _aQk199p-Ed-ak6NoX_4Aeg_336257331.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the classification and thus the restrictions associated with an order (for regulatory purposes).
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOrderClassificationCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aQk199p-Ed-ak6NoX_4Aeg_336257331")]
public partial class OrderClassificationCodeDropdownSource : EnumMetadataManager<OrderClassificationCode,IOrderClassificationCodeDropdownRow,OrderClassificationCodeDropdownRow>
{
    public OrderClassificationCodeDropdownSource()
        : base( (enumValue, memberInfo) => new OrderClassificationCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
