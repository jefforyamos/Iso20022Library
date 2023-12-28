﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CSCManagementCode.  ISO2002 ID# _TWii4QEcEeCQm6a_G2yO_w_1480882734.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// CSC (Card Security Code) management associated with the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TWii4QEcEeCQm6a_G2yO_w_1480882734")]
[Description(@"CSC (Card Security Code) management associated with the transaction.")]
public enum CSCManagementCode
{
    /// <summary>
    /// Card security code present.
    /// Encoded/decoded by serializers as "PRST".
    /// </summary>
    [EnumMember(Value = "PRST")]
    [IsoId("_TWii4gEcEeCQm6a_G2yO_w_-86583445")]
    [Description(@"Card security code present.")]
    CSCPresent,
    
    /// <summary>
    /// Card security code by-passed or not provided by the merchant.
    /// Encoded/decoded by serializers as "BYPS".
    /// </summary>
    [EnumMember(Value = "BYPS")]
    [IsoId("_TWrswAEcEeCQm6a_G2yO_w_-1184407427")]
    [Description(@"Card security code by-passed or not provided by the merchant.")]
    CSCByPass,
    
    /// <summary>
    /// Card security code unreadable.
    /// Encoded/decoded by serializers as "UNRD".
    /// </summary>
    [EnumMember(Value = "UNRD")]
    [IsoId("_TWrswQEcEeCQm6a_G2yO_w_-1151247658")]
    [Description(@"Card security code unreadable.")]
    CSCUnread,
    
    /// <summary>
    /// No card security code imprint.
    /// Encoded/decoded by serializers as "NCSC".
    /// </summary>
    [EnumMember(Value = "NCSC")]
    [IsoId("_TWrswgEcEeCQm6a_G2yO_w_1063680011")]
    [Description(@"No card security code imprint.")]
    NoCSC,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CSCManagementCodeMetadataExtensions
{
    private static readonly CSCManagementCodeDropdownSource _dropdownSource = new CSCManagementCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICSCManagementCodeDropdownRow GetMetadata(this CSCManagementCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


