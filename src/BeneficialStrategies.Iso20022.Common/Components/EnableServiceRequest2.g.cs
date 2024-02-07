﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EnableServiceRequest2.  ISO2002 ID# _LIrhUQ0tEeqUVL7sB4m7NA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data to request to enable a service.
/// </summary>
public partial record EnableServiceRequest2
     : IIsoXmlSerilizable<EnableServiceRequest2>
{
    #nullable enable
    
    /// <summary>
    /// Action to realise on a transaction.
    /// </summary>
    public required TransactionAction1Code TransactionAction { get; init; } 
    /// <summary>
    /// Services enabled before the start-up of a transaction.
    /// </summary>
    public RetailerService2Code? ServicesEnabled { get; init; } 
    /// <summary>
    /// Prompt or welcome message.
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
        writer.WriteStartElement(null, "TxActn", xmlNamespace );
        writer.WriteValue(TransactionAction.ToString()); // Enum value
        writer.WriteEndElement();
        if (ServicesEnabled is RetailerService2Code ServicesEnabledValue)
        {
            writer.WriteStartElement(null, "SvcsNbld", xmlNamespace );
            writer.WriteValue(ServicesEnabledValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (DisplayOutput is ActionMessage7 DisplayOutputValue)
        {
            writer.WriteStartElement(null, "DispOutpt", xmlNamespace );
            DisplayOutputValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static EnableServiceRequest2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
