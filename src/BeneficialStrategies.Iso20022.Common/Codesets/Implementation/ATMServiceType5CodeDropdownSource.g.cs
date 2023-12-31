﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ATMServiceType5Code.  ISO2002 ID# _dWX-kYrAEeSgLpgNvMAP2g.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Describes the type of service selected by the customer.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IATMServiceType5CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_dWX-kYrAEeSgLpgNvMAP2g")]
public partial class ATMServiceType5CodeDropdownSource : EnumMetadataManager<ATMServiceType5Code,IATMServiceType5CodeDropdownRow,ATMServiceType5CodeDropdownRow>
{
    public ATMServiceType5CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ATMServiceType5CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
