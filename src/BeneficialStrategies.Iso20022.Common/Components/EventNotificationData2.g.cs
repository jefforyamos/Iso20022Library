﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EventNotificationData2.  ISO2002 ID# _HUBHcQ0uEeqUVL7sB4m7NA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the EventNotification message.
/// </summary>
public partial record EventNotificationData2
     : IIsoXmlSerilizable<EventNotificationData2>
{
    #nullable enable
    
    /// <summary>
    /// Content of the Retailer Event message.
    /// </summary>
    public required RetailerEvent2 RetailerEvent { get; init; } 
    /// <summary>
    /// Indicates if the occurred event requires maintenance call or action.
    /// </summary>
    public IsoTrueFalseIndicator? MaintenanceRequiredFlag { get; init; } 
    /// <summary>
    /// Language of the Customer
    /// </summary>
    public LanguageCode? CustomerLanguage { get; init; } 
    /// <summary>
    /// To display an event message
    /// </summary>
    public ActionMessage7? DisplayOutput { get; init; } 
    
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
        writer.WriteStartElement(null, "RtlrEvt", xmlNamespace );
        RetailerEvent.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (MaintenanceRequiredFlag is IsoTrueFalseIndicator MaintenanceRequiredFlagValue)
        {
            writer.WriteStartElement(null, "MntncReqrdFlg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(MaintenanceRequiredFlagValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (CustomerLanguage is LanguageCode CustomerLanguageValue)
        {
            writer.WriteStartElement(null, "CstmrLang", xmlNamespace );
            writer.WriteValue(CustomerLanguageValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (DisplayOutput is ActionMessage7 DisplayOutputValue)
        {
            writer.WriteStartElement(null, "DispOutpt", xmlNamespace );
            DisplayOutputValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static EventNotificationData2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
