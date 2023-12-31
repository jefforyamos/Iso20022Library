﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SaleCapabilities2Code.  ISO2002 ID# _6gewcN6mEeiwsev40qZGEQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of the Logical device located on a Sale Terminal or a POI Terminal, in term of class of information to output (display, print or store), or input (keyboard) for the Cashier 
/// or the Customer.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISaleCapabilities2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_6gewcN6mEeiwsev40qZGEQ")]
public partial class SaleCapabilities2CodeDropdownSource : EnumMetadataManager<SaleCapabilities2Code,ISaleCapabilities2CodeDropdownRow,SaleCapabilities2CodeDropdownRow>
{
    public SaleCapabilities2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SaleCapabilities2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
