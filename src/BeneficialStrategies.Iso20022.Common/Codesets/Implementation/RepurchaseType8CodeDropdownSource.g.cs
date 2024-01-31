﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RepurchaseType8Code.  ISO2002 ID# _3qOF4I-QEeaVK-2bgpxeYw.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of repurchase transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRepurchaseType8CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_3qOF4I-QEeaVK-2bgpxeYw")]
public partial class RepurchaseType8CodeDropdownSource : EnumMetadataManager<RepurchaseType8Code,IRepurchaseType8CodeDropdownRow,RepurchaseType8CodeDropdownRow>
{
    public RepurchaseType8CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RepurchaseType8CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
