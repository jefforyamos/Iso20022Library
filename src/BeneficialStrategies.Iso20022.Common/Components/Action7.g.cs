﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Action7.  ISO2002 ID# _CShKUa2BEeWMg5rOByfExw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of actions to be performed by the card acceptor.
/// </summary>
public partial record Action7
     : IIsoXmlSerilizable<Action7>
{
    #nullable enable
    
    /// <summary>
    /// Type of action to be performed by the card acceptor.
    /// </summary>
    public required ActionType6Code ActionType { get; init; } 
    /// <summary>
    /// Information to display, print or log.
    /// </summary>
    public ActionMessage4? MessageToPresent { get; init; } 
    /// <summary>
    /// Message to send before the completion of the transaction.
    /// </summary>
    public MessageFunction11Code? RequestToPerform { get; init; } 
    
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
        writer.WriteStartElement(null, "ActnTp", xmlNamespace );
        writer.WriteValue(ActionType.ToString()); // Enum value
        writer.WriteEndElement();
        if (MessageToPresent is ActionMessage4 MessageToPresentValue)
        {
            writer.WriteStartElement(null, "MsgToPres", xmlNamespace );
            MessageToPresentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RequestToPerform is MessageFunction11Code RequestToPerformValue)
        {
            writer.WriteStartElement(null, "ReqToPrfrm", xmlNamespace );
            writer.WriteValue(RequestToPerformValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static Action7 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
