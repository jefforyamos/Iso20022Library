﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Quantity4Code.  ISO2002 ID# _mxo5YQCgEeGqP72A5EmwKQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies quantity of a financial instrument.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IQuantity4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_mxo5YQCgEeGqP72A5EmwKQ")]
public partial class Quantity4CodeDropdownSource : EnumMetadataManager<Quantity4Code,IQuantity4CodeDropdownRow,Quantity4CodeDropdownRow>
{
    public Quantity4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Quantity4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}