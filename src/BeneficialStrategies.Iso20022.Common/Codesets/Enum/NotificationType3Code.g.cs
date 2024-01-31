﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for NotificationType3Code.  ISO2002 ID# _u-L_cK7PEemG7MmivSuE5g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of notification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_u-L_cK7PEemG7MmivSuE5g")]
[Description(@"Specifies a type of notification.")]
[DerivedFrom(typeof(CorporateActionNotificationTypeCode))]
public enum NotificationType3Code
{
    /// <summary>
    /// New notification.
    /// Encoded/decoded by serializers as "NEWM".
    /// </summary>
    [EnumMember(Value = "NEWM")]
    [IsoId("_1FTusa7PEemG7MmivSuE5g")]
    [Description(@"New notification.")]
    New = CorporateActionNotificationTypeCode.New, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Notification replacing a previously sent notification.
    /// Encoded/decoded by serializers as "REPL".
    /// </summary>
    [EnumMember(Value = "REPL")]
    [IsoId("_1SZvgq7PEemG7MmivSuE5g")]
    [Description(@"Notification replacing a previously sent notification.")]
    Replacement = CorporateActionNotificationTypeCode.Replacement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Notification sent as a reminder of an event taking place.
    /// Encoded/decoded by serializers as "RMDR".
    /// </summary>
    [EnumMember(Value = "RMDR")]
    [IsoId("_1avMIq7PEemG7MmivSuE5g")]
    [Description(@"Notification sent as a reminder of an event taking place.")]
    Reminder = CorporateActionNotificationTypeCode.Reminder, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class NotificationType3CodeMetadataExtensions
{
    private static readonly NotificationType3CodeDropdownSource _dropdownSource = new NotificationType3CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static INotificationType3CodeDropdownRow GetMetadata(this NotificationType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


