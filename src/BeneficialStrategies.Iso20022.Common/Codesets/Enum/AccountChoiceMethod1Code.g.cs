﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AccountChoiceMethod1Code.  ISO2002 ID# _f52cQHs7EeSTS7uHCe8FPQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Method used by the cardholder and the terminal for the choice of the account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_f52cQHs7EeSTS7uHCe8FPQ")]
[Description(@"Method used by the cardholder and the terminal for the choice of the account.")]
[DerivedFrom(typeof(AccountChoiceMethodCode))]
public enum AccountChoiceMethod1Code
{
    /// <summary>
    /// Account selected in an account list.
    /// Encoded/decoded by serializers as "ACSL".
    /// </summary>
    [EnumMember(Value = "ACSL")]
    [IsoId("_ojWosXs7EeSTS7uHCe8FPQ")]
    [Description(@"Account selected in an account list.")]
    AccountSelected = AccountChoiceMethodCode.AccountSelected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account identification is entered by the customer.
    /// Encoded/decoded by serializers as "ENTR".
    /// </summary>
    [EnumMember(Value = "ENTR")]
    [IsoId("_ot0MQ3s7EeSTS7uHCe8FPQ")]
    [Description(@"Account identification is entered by the customer.")]
    Entered = AccountChoiceMethodCode.Entered, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account is selected according to the configuration.
    /// Encoded/decoded by serializers as "IMAC".
    /// </summary>
    [EnumMember(Value = "IMAC")]
    [IsoId("_o4i1k3s7EeSTS7uHCe8FPQ")]
    [Description(@"Account is selected according to the configuration.")]
    ImplicitAccount = AccountChoiceMethodCode.ImplicitAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Type of account is selected according to the configuration.
    /// Encoded/decoded by serializers as "IMPL".
    /// </summary>
    [EnumMember(Value = "IMPL")]
    [IsoId("_o--0wXs7EeSTS7uHCe8FPQ")]
    [Description(@"Type of account is selected according to the configuration.")]
    ImplicitType = AccountChoiceMethodCode.ImplicitType, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account is not selected by the customer or a profile, but by the issuer.
    /// Encoded/decoded by serializers as "NOSL".
    /// </summary>
    [EnumMember(Value = "NOSL")]
    [IsoId("_pJsP83s7EeSTS7uHCe8FPQ")]
    [Description(@"Account is not selected by the customer or a profile, but by the issuer.")]
    NoSelection = AccountChoiceMethodCode.NoSelection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Type of account selected in a list.
    /// Encoded/decoded by serializers as "TPSL".
    /// </summary>
    [EnumMember(Value = "TPSL")]
    [IsoId("_pREDQ3s7EeSTS7uHCe8FPQ")]
    [Description(@"Type of account selected in a list.")]
    TypeSelected = AccountChoiceMethodCode.TypeSelected, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AccountChoiceMethod1CodeMetadataExtensions
{
    private static readonly AccountChoiceMethod1CodeDropdownSource _dropdownSource = new AccountChoiceMethod1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAccountChoiceMethod1CodeDropdownRow GetMetadata(this AccountChoiceMethod1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


