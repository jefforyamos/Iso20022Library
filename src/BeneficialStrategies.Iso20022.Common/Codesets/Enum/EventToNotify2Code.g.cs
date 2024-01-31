﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for EventToNotify2Code.  ISO2002 ID# _CXj_EQ0vEeqUVL7sB4m7NA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Event the POI notifies to the Sale System.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CXj_EQ0vEeqUVL7sB4m7NA")]
[Description(@"Event the POI notifies to the Sale System.")]
[DerivedFrom(typeof(EventToNotifyCode))]
public enum EventToNotify2Code
{
    /// <summary>
    /// One or several device request has been sent by the POI during the processing of a service requested by the Sale System. The processing is cancelled by the Customer or stopped by the POI. If the device response is not received by the POI, an event is sent to inform the Sale to abort internally these device requests.
    /// Encoded/decoded by serializers as "ABRT".
    /// </summary>
    [EnumMember(Value = "ABRT")]
    [IsoId("_CidngQ0vEeqUVL7sB4m7NA")]
    [Description(@"One or several device request has been sent by the POI during the processing of a service requested by the Sale System. The processing is cancelled by the Customer or stopped by the POI. If the device response is not received by the POI, an event is sent to inform the Sale to abort internally these device requests.")]
    Abort = EventToNotifyCode.Abort, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Begin of POI Maintenance.
    /// Encoded/decoded by serializers as "MAIB".
    /// </summary>
    [EnumMember(Value = "MAIB")]
    [IsoId("_Cidngw0vEeqUVL7sB4m7NA")]
    [Description(@"Begin of POI Maintenance.")]
    BeginMaintenance = EventToNotifyCode.BeginMaintenance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A card is inserted in the card reader (see Input request and NotifyCardInputFlag).
    /// Encoded/decoded by serializers as "CRDI".
    /// </summary>
    [EnumMember(Value = "CRDI")]
    [IsoId("_CidnhQ0vEeqUVL7sB4m7NA")]
    [Description(@"A card is inserted in the card reader (see Input request and NotifyCardInputFlag).")]
    CardInserted = EventToNotifyCode.CardInserted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An Abort request has been sent to abort a message which is already completed.
    /// Encoded/decoded by serializers as "COMP".
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_Cidnhw0vEeqUVL7sB4m7NA")]
    [Description(@"An Abort request has been sent to abort a message which is already completed.")]
    Completed = EventToNotifyCode.Completed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A card is removed from the card reader.
    /// Encoded/decoded by serializers as "CRDR".
    /// </summary>
    [EnumMember(Value = "CRDR")]
    [IsoId("_CidniQ0vEeqUVL7sB4m7NA")]
    [Description(@"A card is removed from the card reader.")]
    CardRemoved = EventToNotifyCode.CardRemoved, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The customer has selected a different language on the POI.
    /// Encoded/decoded by serializers as "CUSL".
    /// </summary>
    [EnumMember(Value = "CUSL")]
    [IsoId("_Cidniw0vEeqUVL7sB4m7NA")]
    [Description(@"The customer has selected a different language on the POI.")]
    CustomerLanguage = EventToNotifyCode.CustomerLanguage, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// End of POI Maintenance.
    /// Encoded/decoded by serializers as "MAIE".
    /// </summary>
    [EnumMember(Value = "MAIE")]
    [IsoId("_CidnjQ0vEeqUVL7sB4m7NA")]
    [Description(@"End of POI Maintenance.")]
    EndMaintenance = EventToNotifyCode.EndMaintenance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The POI Terminal or the POI System is now ready to work.
    /// Encoded/decoded by serializers as "INIT".
    /// </summary>
    [EnumMember(Value = "INIT")]
    [IsoId("_Cidnjw0vEeqUVL7sB4m7NA")]
    [Description(@"The POI Terminal or the POI System is now ready to work.")]
    Initialised = EventToNotifyCode.Initialised, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The customer has pressed a specific key on the POI.
    /// Encoded/decoded by serializers as "KEYP".
    /// </summary>
    [EnumMember(Value = "KEYP")]
    [IsoId("_CidnkQ0vEeqUVL7sB4m7NA")]
    [Description(@"The customer has pressed a specific key on the POI.")]
    KeyPressed = EventToNotifyCode.KeyPressed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Maintenance required by the POI.
    /// Encoded/decoded by serializers as "MAIR".
    /// </summary>
    [EnumMember(Value = "MAIR")]
    [IsoId("_Cidnkw0vEeqUVL7sB4m7NA")]
    [Description(@"Maintenance required by the POI.")]
    MaintenanceRequired = EventToNotifyCode.MaintenanceRequired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The POI Terminal or the POI System cannot work.
    /// Encoded/decoded by serializers as "OODR".
    /// </summary>
    [EnumMember(Value = "OODR")]
    [IsoId("_CidnlQ0vEeqUVL7sB4m7NA")]
    [Description(@"The POI Terminal or the POI System cannot work.")]
    OutOfOrder = EventToNotifyCode.OutOfOrder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The POI has performed, or want to perform an automatic administrative process, e.g. the reports at the end of day.
    /// Encoded/decoded by serializers as "SADM".
    /// </summary>
    [EnumMember(Value = "SADM")]
    [IsoId("_Cidnlw0vEeqUVL7sB4m7NA")]
    [Description(@"The POI has performed, or want to perform an automatic administrative process, e.g. the reports at the end of day.")]
    SaleAdmin = EventToNotifyCode.SaleAdmin, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A POI terminal requests the payment of the transaction identified by the content of EventDetails in the Event notification.
    /// Encoded/decoded by serializers as "SWUP".
    /// </summary>
    [EnumMember(Value = "SWUP")]
    [IsoId("_CidnmQ0vEeqUVL7sB4m7NA")]
    [Description(@"A POI terminal requests the payment of the transaction identified by the content of EventDetails in the Event notification.")]
    SaleWakeUp = EventToNotifyCode.SaleWakeUp, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Problem of security.
    /// Encoded/decoded by serializers as "SECA".
    /// </summary>
    [EnumMember(Value = "SECA")]
    [IsoId("_Cidnmw0vEeqUVL7sB4m7NA")]
    [Description(@"Problem of security.")]
    SecurityAlarm = EventToNotifyCode.SecurityAlarm, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The POI Terminal or the POI System is shutting down.
    /// Encoded/decoded by serializers as "SHUT".
    /// </summary>
    [EnumMember(Value = "SHUT")]
    [IsoId("_CidnnQ0vEeqUVL7sB4m7NA")]
    [Description(@"The POI Terminal or the POI System is shutting down.")]
    Shutdown = EventToNotifyCode.Shutdown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// When the Customer assistance is stopped, because the Customer has completed its input.
    /// Encoded/decoded by serializers as "SASS".
    /// </summary>
    [EnumMember(Value = "SASS")]
    [IsoId("_Cidnnw0vEeqUVL7sB4m7NA")]
    [Description(@"When the Customer assistance is stopped, because the Customer has completed its input.")]
    StopAssistance = EventToNotifyCode.StopAssistance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A disconnection occurred.
    /// Encoded/decoded by serializers as "DISC".
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_CidnoQ0vEeqUVL7sB4m7NA")]
    [Description(@"A disconnection occurred.")]
    Disconnected = EventToNotifyCode.Disconnected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Connection has been set up.
    /// Encoded/decoded by serializers as "CNTN".
    /// </summary>
    [EnumMember(Value = "CNTN")]
    [IsoId("_Cidnow0vEeqUVL7sB4m7NA")]
    [Description(@"Connection has been set up.")]
    Connected = EventToNotifyCode.Connected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been processed and approved by the POI.
    /// Encoded/decoded by serializers as "TNOK".
    /// </summary>
    [EnumMember(Value = "TNOK")]
    [IsoId("_U3cawQ0vEeqUVL7sB4m7NA")]
    [Description(@"Transaction has been processed and approved by the POI.")]
    TransactionApproved = EventToNotifyCode.TransactionApproved, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been processed but has been declined.
    /// Encoded/decoded by serializers as "TNKO".
    /// </summary>
    [EnumMember(Value = "TNKO")]
    [IsoId("_U9zhcQ0vEeqUVL7sB4m7NA")]
    [Description(@"Transaction has been processed but has been declined.")]
    TransactionDeclined = EventToNotifyCode.TransactionDeclined, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class EventToNotify2CodeMetadataExtensions
{
    private static readonly EventToNotify2CodeDropdownSource _dropdownSource = new EventToNotify2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IEventToNotify2CodeDropdownRow GetMetadata(this EventToNotify2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


