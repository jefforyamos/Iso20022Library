﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ATMServiceType3Code.  ISO2002 ID# _GHNZAIqvEeSIDtZ76p6McQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Describes the type of inquiry selected by the customer or the ATM.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IATMServiceType3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_GHNZAIqvEeSIDtZ76p6McQ")]
public partial class ATMServiceType3CodeDropdownSource : EnumMetadataManager<ATMServiceType3Code,IATMServiceType3CodeDropdownRow,ATMServiceType3CodeDropdownRow>
{
    public ATMServiceType3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ATMServiceType3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
