﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SaleCapabilities2Code.  ISO2002 ID# _6gewcN6mEeiwsev40qZGEQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of the Logical device located on a Sale Terminal or a POI Terminal, in term of class of information to output (display, print or store), or input (keyboard) for the Cashier 
/// or the Customer.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SaleCapabilities2CodeDropdownSource"/>.
/// Implements <seealso cref="ISaleCapabilities2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_6gewcN6mEeiwsev40qZGEQ")]
public partial class SaleCapabilities2CodeDropdownRow : EnumMetadataItem<SaleCapabilities2Code>, ISaleCapabilities2CodeDropdownRow
{
    /// <summary>
    /// Type of the Logical device located on a Sale Terminal or a POI Terminal, in term of class of information to output (display, print or store), or input (keyboard) for the Cashier 
    /// or the Customer.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SaleCapabilities2CodeDropdownRow(SaleCapabilities2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
