﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ATMServiceType9Code.  ISO2002 ID# _-atfIK4sEeWLdt0vLARX2Q.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Describes the type of fund transfer selected by the customer or the ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-atfIK4sEeWLdt0vLARX2Q")]
[Description(@"Describes the type of fund transfer selected by the customer or the ATM.")]
[DerivedFrom(typeof(ATMServiceTypeCode))]
public enum ATMServiceType9Code
{
    /// <summary>
    /// Funds transfer between accounts belonging to the customer in the same bank.
    /// Encoded/decoded by serializers as "TRFC".
    /// </summary>
    [EnumMember(Value = "TRFC")]
    [IsoId("_GTc9Aa4tEeWLdt0vLARX2Q")]
    [Description(@"Funds transfer between accounts belonging to the customer in the same bank.")]
    CustomerTransfer = ATMServiceTypeCode.CustomerTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Funds transfer to another customer.
    /// Encoded/decoded by serializers as "TRFI".
    /// </summary>
    [EnumMember(Value = "TRFI")]
    [IsoId("_GkSOUa4tEeWLdt0vLARX2Q")]
    [Description(@"Funds transfer to another customer.")]
    InterCustomerTransfer = ATMServiceTypeCode.InterCustomerTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Funds transfer to pay a third party.
    /// Encoded/decoded by serializers as "TRFP".
    /// </summary>
    [EnumMember(Value = "TRFP")]
    [IsoId("_PF0xka4tEeWLdt0vLARX2Q")]
    [Description(@"Funds transfer to pay a third party.")]
    Payment = ATMServiceTypeCode.Payment, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ATMServiceType9CodeMetadataExtensions
{
    private static readonly ATMServiceType9CodeDropdownSource _dropdownSource = new ATMServiceType9CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IATMServiceType9CodeDropdownRow GetMetadata(this ATMServiceType9Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


