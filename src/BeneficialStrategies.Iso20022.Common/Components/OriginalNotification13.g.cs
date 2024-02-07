﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalNotification13.  ISO2002 ID# _b49UwdcZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the original notification and to provide the status.
/// </summary>
public partial record OriginalNotification13
     : IIsoXmlSerilizable<OriginalNotification13>
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the original sender, to unambiguously identify the original notification to receive message.
    /// </summary>
    public required IsoMax35Text OriginalMessageIdentification { get; init; } 
    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    public IsoISODateTime? OriginalCreationDateTime { get; init; } 
    /// <summary>
    /// Identification of the original notification.
    /// </summary>
    public required IsoMax35Text OriginalNotificationIdentification { get; init; } 
    /// <summary>
    /// Specifies the status of the notification in a coded form.
    /// </summary>
    public NotificationStatus3Code? NotificationStatus { get; init; } 
    /// <summary>
    /// Further details of the notification status.
    /// </summary>
    public IsoMax140Text? AdditionalStatusInformation { get; init; } 
    /// <summary>
    /// Identifies the original notification item and provides the status.
    /// </summary>
    public OriginalNotificationReference11? OriginalNotificationReference { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "OrgnlMsgId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginalMessageIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (OriginalCreationDateTime is IsoISODateTime OriginalCreationDateTimeValue)
        {
            writer.WriteStartElement(null, "OrgnlCreDtTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(OriginalCreationDateTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "OrgnlNtfctnId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginalNotificationIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (NotificationStatus is NotificationStatus3Code NotificationStatusValue)
        {
            writer.WriteStartElement(null, "NtfctnSts", xmlNamespace );
            writer.WriteValue(NotificationStatusValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (AdditionalStatusInformation is IsoMax140Text AdditionalStatusInformationValue)
        {
            writer.WriteStartElement(null, "AddtlStsInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(AdditionalStatusInformationValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
        if (OriginalNotificationReference is OriginalNotificationReference11 OriginalNotificationReferenceValue)
        {
            writer.WriteStartElement(null, "OrgnlNtfctnRef", xmlNamespace );
            OriginalNotificationReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static OriginalNotification13 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
