﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ATMServiceType8Code.  ISO2002 ID# _82-oEa4XEeW_TaP-ygI0SQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of service to be offered for a customer at an ATM.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IATMServiceType8CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_82-oEa4XEeW_TaP-ygI0SQ")]
public partial class ATMServiceType8CodeDropdownSource : EnumMetadataManager<ATMServiceType8Code,IATMServiceType8CodeDropdownRow,ATMServiceType8CodeDropdownRow>
{
    public ATMServiceType8CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ATMServiceType8CodeDropdownRow(enumValue, memberInfo))
    {
    }
}