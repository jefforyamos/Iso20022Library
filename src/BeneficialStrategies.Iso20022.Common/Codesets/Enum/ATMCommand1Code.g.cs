﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ATMCommand1Code.  ISO2002 ID# _FHH00IqKEeSRT5rEzcAHEw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of command to be performed by an ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FHH00IqKEeSRT5rEzcAHEw")]
[Description(@"Type of command to be performed by an ATM.")]
[DerivedFrom(typeof(ATMCommandCode))]
public enum ATMCommand1Code
{
    /// <summary>
    /// Provide the ATM counters, resetting those that are applicable.
    /// Encoded/decoded by serializers as "ATMBalance".
    /// </summary>
    [EnumMember(Value = "ABAL")]
    [IsoId("_LkXlEYqKEeSRT5rEzcAHEw")]
    [Description(@"Provide the ATM counters, resetting those that are applicable.")]
    ATMBalance,
    
    /// <summary>
    /// Status of the ATM required by the ATM manager.
    /// Encoded/decoded by serializers as "ATMStatusUpdate".
    /// </summary>
    [EnumMember(Value = "ASTS")]
    [IsoId("_LpbrQYqKEeSRT5rEzcAHEw")]
    [Description(@"Status of the ATM required by the ATM manager.")]
    ATMStatusUpdate,
    
    /// <summary>
    /// Update the ATM configuration parameters.
    /// Encoded/decoded by serializers as "ConfigurationUpdate".
    /// </summary>
    [EnumMember(Value = "CFGT")]
    [IsoId("_LuM2gYqKEeSRT5rEzcAHEw")]
    [Description(@"Update the ATM configuration parameters.")]
    ConfigurationUpdate,
    
    /// <summary>
    /// Request the value of the ATM counters.
    /// Encoded/decoded by serializers as "CountersInquiry".
    /// </summary>
    [EnumMember(Value = "CCNT")]
    [IsoId("_L0KUkYqKEeSRT5rEzcAHEw")]
    [Description(@"Request the value of the ATM counters.")]
    CountersInquiry,
    
    /// <summary>
    /// Perform a disconnection followed by a reconnection.
    /// Encoded/decoded by serializers as "Disconnect".
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_L47f0YqKEeSRT5rEzcAHEw")]
    [Description(@"Perform a disconnection followed by a reconnection.")]
    Disconnect,
    
    /// <summary>
    /// Send a specific message to initiate a process.
    /// Encoded/decoded by serializers as "SendMessage".
    /// </summary>
    [EnumMember(Value = "SNDM")]
    [IsoId("_L9_mAYqKEeSRT5rEzcAHEw")]
    [Description(@"Send a specific message to initiate a process.")]
    SendMessage,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ATMCommand1CodeMetadataExtensions
{
    private static readonly ATMCommand1CodeDropdownSource _dropdownSource = new ATMCommand1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IATMCommand1CodeDropdownRow GetMetadata(this ATMCommand1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


