﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SaleCapabilities2Code.  ISO2002 ID# _6gewcN6mEeiwsev40qZGEQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of the Logical device located on a Sale Terminal or a POI Terminal, in term of class of information to output (display, print or store), or input (keyboard) for the Cashier 
/// or the Customer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6gewcN6mEeiwsev40qZGEQ")]
[Description(@"Type of the Logical device located on a Sale Terminal or a POI Terminal, in term of class of information to output (display, print or store), or input (keyboard) for the Cashier  or the Customer.")]
[DerivedFrom(typeof(SaleCapabilitiesCode))]
public enum SaleCapabilities2Code
{
    /// <summary>
    /// Any kind of keyboard allowing all or part of the commands 	of the Input message request from the Sale System to the POI System (InputCommand data element). The output device attached to this input device is the CashierDisplay device.
    /// Encoded/decoded by serializers as "CashierInput".
    /// </summary>
    [EnumMember(Value = "CHIN")]
    [IsoId("_AwtYYd6nEeiwsev40qZGEQ")]
    [Description(@"Any kind of keyboard allowing all or part of the commands 	of the Input message request from the Sale System to the POI System (InputCommand data element). The output device attached to this input device is the CashierDisplay device.")]
    CashierInput,
    
    /// <summary>
    /// Any kind of keyboard allowing all or part of the commands 	of the Input message request from the Sale System to the POI System (InputCommand data element).
    /// Encoded/decoded by serializers as "CustomerInput".
    /// </summary>
    [EnumMember(Value = "CUIN")]
    [IsoId("_BTpGUd6nEeiwsev40qZGEQ")]
    [Description(@"Any kind of keyboard allowing all or part of the commands 	of the Input message request from the Sale System to the POI System (InputCommand data element).")]
    CustomerInput,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SaleCapabilities2CodeMetadataExtensions
{
    private static readonly SaleCapabilities2CodeDropdownSource _dropdownSource = new SaleCapabilities2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISaleCapabilities2CodeDropdownRow GetMetadata(this SaleCapabilities2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


