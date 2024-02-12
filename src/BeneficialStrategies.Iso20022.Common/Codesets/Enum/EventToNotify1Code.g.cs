﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for EventToNotify1Code.  ISO2002 ID# _jqpCIN6bEeiwsev40qZGEQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Event the POI notifies to the Sale System.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jqpCIN6bEeiwsev40qZGEQ")]
[Description(@"Event the POI notifies to the Sale System.")]
[DerivedFrom(typeof(EventToNotifyCode))]
public enum EventToNotify1Code
{
    /// <summary>
    /// One or several device request has been sent by the POI during the processing of a service requested by the Sale System. The processing is cancelled by the Customer or stopped by the POI. If the device response is not received by the POI, an event is sent to inform the Sale to abort internally these device requests.
    /// Encoded/decoded by serializers as "ABRT".
    /// </summary>
    [EnumMember(Value = "ABRT")]
    [IsoId("_l1SUwd6bEeiwsev40qZGEQ")]
    [Description(@"One or several device request has been sent by the POI during the processing of a service requested by the Sale System. The processing is cancelled by the Customer or stopped by the POI. If the device response is not received by the POI, an event is sent to inform the Sale to abort internally these device requests.")]
    Abort = EventToNotifyCode.Abort, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Begin of POI Maintenance.
    /// Encoded/decoded by serializers as "MAIB".
    /// </summary>
    [EnumMember(Value = "MAIB")]
    [IsoId("_l5T5Id6bEeiwsev40qZGEQ")]
    [Description(@"Begin of POI Maintenance.")]
    BeginMaintenance = EventToNotifyCode.BeginMaintenance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A card is inserted in the card reader (see Input request and NotifyCardInputFlag).
    /// Encoded/decoded by serializers as "CRDI".
    /// </summary>
    [EnumMember(Value = "CRDI")]
    [IsoId("_l9Dwsd6bEeiwsev40qZGEQ")]
    [Description(@"A card is inserted in the card reader (see Input request and NotifyCardInputFlag).")]
    CardInserted = EventToNotifyCode.CardInserted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An Abort request has been sent to abort a message which is already completed.
    /// Encoded/decoded by serializers as "COMP".
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_mHiiYd6bEeiwsev40qZGEQ")]
    [Description(@"An Abort request has been sent to abort a message which is already completed.")]
    Completed = EventToNotifyCode.Completed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A card is removed from the card reader.
    /// Encoded/decoded by serializers as "CRDR".
    /// </summary>
    [EnumMember(Value = "CRDR")]
    [IsoId("_mMMY4d6bEeiwsev40qZGEQ")]
    [Description(@"A card is removed from the card reader.")]
    CardRemoved = EventToNotifyCode.CardRemoved, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The customer has selected a different language on the POI.
    /// Encoded/decoded by serializers as "CUSL".
    /// </summary>
    [EnumMember(Value = "CUSL")]
    [IsoId("_mRSUQd6bEeiwsev40qZGEQ")]
    [Description(@"The customer has selected a different language on the POI.")]
    CustomerLanguage = EventToNotifyCode.CustomerLanguage, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// End of POI Maintenance.
    /// Encoded/decoded by serializers as "MAIE".
    /// </summary>
    [EnumMember(Value = "MAIE")]
    [IsoId("_mVZ_Qd6bEeiwsev40qZGEQ")]
    [Description(@"End of POI Maintenance.")]
    EndMaintenance = EventToNotifyCode.EndMaintenance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The POI Terminal or the POI System is now ready to work.
    /// Encoded/decoded by serializers as "INIT".
    /// </summary>
    [EnumMember(Value = "INIT")]
    [IsoId("_mZEXQd6bEeiwsev40qZGEQ")]
    [Description(@"The POI Terminal or the POI System is now ready to work.")]
    Initialised = EventToNotifyCode.Initialised, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The customer has pressed a specific key on the POI.
    /// Encoded/decoded by serializers as "KEYP".
    /// </summary>
    [EnumMember(Value = "KEYP")]
    [IsoId("_mcW70d6bEeiwsev40qZGEQ")]
    [Description(@"The customer has pressed a specific key on the POI.")]
    KeyPressed = EventToNotifyCode.KeyPressed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Maintenance required by the POI.
    /// Encoded/decoded by serializers as "MAIR".
    /// </summary>
    [EnumMember(Value = "MAIR")]
    [IsoId("_mgem0d6bEeiwsev40qZGEQ")]
    [Description(@"Maintenance required by the POI.")]
    MaintenanceRequired = EventToNotifyCode.MaintenanceRequired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The POI Terminal or the POI System cannot work.
    /// Encoded/decoded by serializers as "OODR".
    /// </summary>
    [EnumMember(Value = "OODR")]
    [IsoId("_mkaEkd6bEeiwsev40qZGEQ")]
    [Description(@"The POI Terminal or the POI System cannot work.")]
    OutOfOrder = EventToNotifyCode.OutOfOrder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The POI has performed, or want to perform an automatic administrative process, e.g. the reports at the end of day.
    /// Encoded/decoded by serializers as "SADM".
    /// </summary>
    [EnumMember(Value = "SADM")]
    [IsoId("_mstE8d6bEeiwsev40qZGEQ")]
    [Description(@"The POI has performed, or want to perform an automatic administrative process, e.g. the reports at the end of day.")]
    SaleAdmin = EventToNotifyCode.SaleAdmin, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A POI terminal requests the payment of the transaction identified by the content of EventDetails in the Event notification.
    /// Encoded/decoded by serializers as "SWUP".
    /// </summary>
    [EnumMember(Value = "SWUP")]
    [IsoId("_mwYEAd6bEeiwsev40qZGEQ")]
    [Description(@"A POI terminal requests the payment of the transaction identified by the content of EventDetails in the Event notification.")]
    SaleWakeUp = EventToNotifyCode.SaleWakeUp, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Problem of security.
    /// Encoded/decoded by serializers as "SECA".
    /// </summary>
    [EnumMember(Value = "SECA")]
    [IsoId("_m0Am0d6bEeiwsev40qZGEQ")]
    [Description(@"Problem of security.")]
    SecurityAlarm = EventToNotifyCode.SecurityAlarm, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The POI Terminal or the POI System is shutting down.
    /// Encoded/decoded by serializers as "SHUT".
    /// </summary>
    [EnumMember(Value = "SHUT")]
    [IsoId("_m30v0d6bEeiwsev40qZGEQ")]
    [Description(@"The POI Terminal or the POI System is shutting down.")]
    Shutdown = EventToNotifyCode.Shutdown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// When the Customer assistance is stopped, because the Customer has completed its input.
    /// Encoded/decoded by serializers as "SASS".
    /// </summary>
    [EnumMember(Value = "SASS")]
    [IsoId("_m8Chcd6bEeiwsev40qZGEQ")]
    [Description(@"When the Customer assistance is stopped, because the Customer has completed its input.")]
    StopAssistance = EventToNotifyCode.StopAssistance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A disconnection occurred.
    /// Encoded/decoded by serializers as "DISC".
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_DeM3we2tEei-V5h0ja04AA")]
    [Description(@"A disconnection occurred.")]
    Disconnected = EventToNotifyCode.Disconnected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Connection has been set up.
    /// Encoded/decoded by serializers as "CNTN".
    /// </summary>
    [EnumMember(Value = "CNTN")]
    [IsoId("_DkNZIe2tEei-V5h0ja04AA")]
    [Description(@"Connection has been set up.")]
    Connected = EventToNotifyCode.Connected, // same ordinal as derivation source for type conversions
    
}
