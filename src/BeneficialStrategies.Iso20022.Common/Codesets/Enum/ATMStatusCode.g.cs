﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ATMStatusCode.  ISO2002 ID# _W1_04IqLEeSRT5rEzcAHEw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Required status of the ATM, parameters of the status update command.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_W1_04IqLEeSRT5rEzcAHEw")]
[Description(@"Required status of the ATM, parameters of the status update command.")]
[Derivations(typeof(ATMStatus1Code),typeof(ATMStatus2Code),typeof(ATMStatus3Code))]
// External derivations that should be provided by the proper interface are: 
public enum ATMStatusCode
{
    /// <summary>
    /// Component is in service.
    /// Encoded/decoded by serializers as "INSV".
    /// </summary>
    [EnumMember(Value = "INSV")]
    [IsoId("_a2vtgIqLEeSRT5rEzcAHEw")]
    [Description(@"Component is in service.")]
    InService,
    
    /// <summary>
    /// ATM out of service.
    /// Encoded/decoded by serializers as "OUTS".
    /// </summary>
    [EnumMember(Value = "OUTS")]
    [IsoId("_f0JboIqLEeSRT5rEzcAHEw")]
    [Description(@"ATM out of service.")]
    OutOfService,
    
    /// <summary>
    /// Component is activated and in operation.
    /// Encoded/decoded by serializers as "OPER".
    /// </summary>
    [EnumMember(Value = "OPER")]
    [IsoId("_a3AP8Ir-EeSvuOJS0mmL0g")]
    [Description(@"Component is activated and in operation.")]
    InOperation,
    
    /// <summary>
    /// Component has been stopped.
    /// Encoded/decoded by serializers as "STOP".
    /// </summary>
    [EnumMember(Value = "STOP")]
    [IsoId("_wnKYsItCEeSxlKlAGYErFg")]
    [Description(@"Component has been stopped.")]
    Stopped,
    
    /// <summary>
    /// Component has been loaded, but not yet activated.
    /// Encoded/decoded by serializers as "WACT".
    /// </summary>
    [EnumMember(Value = "WACT")]
    [IsoId("_6BC5MItCEeSxlKlAGYErFg")]
    [Description(@"Component has been loaded, but not yet activated.")]
    WaitingActivation,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ATMStatusCodeMetadataExtensions
{
    private static readonly ATMStatusCodeDropdownSource _dropdownSource = new ATMStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IATMStatusCodeDropdownRow GetMetadata(this ATMStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


