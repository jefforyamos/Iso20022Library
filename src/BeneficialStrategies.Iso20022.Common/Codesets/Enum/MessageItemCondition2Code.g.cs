﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MessageItemCondition2Code.  ISO2002 ID# _axD3cXC8Ee2bmOA3bkVsMg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Rule to apply for the presence of a message item.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_axD3cXC8Ee2bmOA3bkVsMg")]
[Description(@"Rule to apply for the presence of a message item.")]
[DerivedFrom(typeof(MessageItemConditionCode))]
public enum MessageItemCondition2Code
{
    /// <summary>
    /// Message item must be present.
    /// Encoded/decoded by serializers as "Mandatory".
    /// </summary>
    [EnumMember(Value = "MNDT")]
    [IsoId("_a4Tu8XC8Ee2bmOA3bkVsMg")]
    [Description(@"Message item must be present.")]
    Mandatory,
    
    /// <summary>
    /// Message item must be present with the configured value.
    /// Encoded/decoded by serializers as "ConfiguredValue".
    /// </summary>
    [EnumMember(Value = "CFVL")]
    [IsoId("_a4Tu83C8Ee2bmOA3bkVsMg")]
    [Description(@"Message item must be present with the configured value.")]
    ConfiguredValue,
    
    /// <summary>
    /// Message item has the configured value if the item is absent.
    /// Encoded/decoded by serializers as "DefaultValue".
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_a4Tu9XC8Ee2bmOA3bkVsMg")]
    [Description(@"Message item has the configured value if the item is absent.")]
    DefaultValue,
    
    /// <summary>
    /// Message item must have one of the configured values.
    /// Encoded/decoded by serializers as "AllowedValues".
    /// </summary>
    [EnumMember(Value = "ALWV")]
    [IsoId("_a4Tu93C8Ee2bmOA3bkVsMg")]
    [Description(@"Message item must have one of the configured values.")]
    AllowedValues,
    
    /// <summary>
    /// Message item has to be present if available.
    /// Encoded/decoded by serializers as "IfAvailable".
    /// </summary>
    [EnumMember(Value = "IFAV")]
    [IsoId("_a4Tu-XC8Ee2bmOA3bkVsMg")]
    [Description(@"Message item has to be present if available.")]
    IfAvailable,
    
    /// <summary>
    /// Message item is present if it was present in a previous related message with the same value.
    /// Encoded/decoded by serializers as "Copy".
    /// </summary>
    [EnumMember(Value = "COPY")]
    [IsoId("_a4Tu-3C8Ee2bmOA3bkVsMg")]
    [Description(@"Message item is present if it was present in a previous related message with the same value.")]
    Copy,
    
    /// <summary>
    /// Message item is not supported and has to be absent.
    /// Encoded/decoded by serializers as "NotSupported".
    /// </summary>
    [EnumMember(Value = "UNSP")]
    [IsoId("_a4Tu_XC8Ee2bmOA3bkVsMg")]
    [Description(@"Message item is not supported and has to be absent.")]
    NotSupported,
    
    /// <summary>
    /// Minimum set of values to use in messages.
    /// Encoded/decoded by serializers as "ListMinimumValues".
    /// </summary>
    [EnumMember(Value = "LMNV")]
    [IsoId("_ediJMXC8Ee2bmOA3bkVsMg")]
    [Description(@"Minimum set of values to use in messages.")]
    ListMinimumValues,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MessageItemCondition2CodeMetadataExtensions
{
    private static readonly MessageItemCondition2CodeDropdownSource _dropdownSource = new MessageItemCondition2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMessageItemCondition2CodeDropdownRow GetMetadata(this MessageItemCondition2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


