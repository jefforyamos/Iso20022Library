﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DerivativeEventTypeCode.  ISO2002 ID# _-T9QACjAEeuKKc2MztSwPw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Explanation or reason for the action being taken on the transaction reporting.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDerivativeEventTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-T9QACjAEeuKKc2MztSwPw")]
public partial class DerivativeEventTypeCodeDropdownSource : EnumMetadataManager<DerivativeEventTypeCode,IDerivativeEventTypeCodeDropdownRow,DerivativeEventTypeCodeDropdownRow>
{
    public DerivativeEventTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new DerivativeEventTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}