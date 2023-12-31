﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BalanceTransferWindow1Code.  ISO2002 ID# _K2bYsH6qEeePx-IqKegQ8Q.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the processing window in which the balance transfer will be processed on the switch date.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_K2bYsH6qEeePx-IqKegQ8Q")]
[Description(@"Specifies the processing window in which the balance transfer will be processed on the switch date.")]
[DerivedFrom(typeof(BalanceTransferWindowCode))]
public enum BalanceTransferWindow1Code
{
    /// <summary>
    /// Indicates in business hours processing.
    /// Encoded/decoded by serializers as "InHours".
    /// </summary>
    [EnumMember(Value = "DAYH")]
    [IsoId("_MQ4kgX6qEeePx-IqKegQ8Q")]
    [Description(@"Indicates in business hours processing.")]
    InHours,
    
    /// <summary>
    /// Indicates out of business hours processing.
    /// Encoded/decoded by serializers as "OutOfHours".
    /// </summary>
    [EnumMember(Value = "EARL")]
    [IsoId("_MYPwwX6qEeePx-IqKegQ8Q")]
    [Description(@"Indicates out of business hours processing.")]
    OutOfHours,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BalanceTransferWindow1CodeMetadataExtensions
{
    private static readonly BalanceTransferWindow1CodeDropdownSource _dropdownSource = new BalanceTransferWindow1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBalanceTransferWindow1CodeDropdownRow GetMetadata(this BalanceTransferWindow1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


