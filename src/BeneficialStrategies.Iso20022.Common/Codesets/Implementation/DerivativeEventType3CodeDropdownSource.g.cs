﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DerivativeEventType3Code.  ISO2002 ID# _Swc0sE2WEe2bQ-Ksk8mwQg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Explanation or reason for the action being taken on the transaction reporting.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDerivativeEventType3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Swc0sE2WEe2bQ-Ksk8mwQg")]
public partial class DerivativeEventType3CodeDropdownSource : EnumMetadataManager<DerivativeEventType3Code,IDerivativeEventType3CodeDropdownRow,DerivativeEventType3CodeDropdownRow>
{
    public DerivativeEventType3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DerivativeEventType3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
