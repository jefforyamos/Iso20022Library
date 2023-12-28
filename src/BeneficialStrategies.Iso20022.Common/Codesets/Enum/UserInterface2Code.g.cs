﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UserInterface2Code.  ISO2002 ID# _TUmCEgEcEeCQm6a_G2yO_w_-457047932.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of interface to display a message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TUmCEgEcEeCQm6a_G2yO_w_-457047932")]
[Description(@"Type of interface to display a message.")]
[DerivedFrom(typeof(UserInterfaceCode))]
public enum UserInterface2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MerchantDisplay".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_TUmCEwEcEeCQm6a_G2yO_w_-1877868390")]
    [Description(@"??")]
    MerchantDisplay,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CardholderDisplay".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_TUmCFAEcEeCQm6a_G2yO_w_-44704637")]
    [Description(@"??")]
    CardholderDisplay,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class UserInterface2CodeMetadataExtensions
{
    private static readonly UserInterface2CodeDropdownSource _dropdownSource = new UserInterface2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IUserInterface2CodeDropdownRow GetMetadata(this UserInterface2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


