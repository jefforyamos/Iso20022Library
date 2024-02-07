﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentTransaction58.  ISO2002 ID# _1sM8wY1EEeWsypzzYao74A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cancellation response from the acquirer.
/// </summary>
public partial record CardPaymentTransaction58
     : IIsoXmlSerilizable<CardPaymentTransaction58>
{
    #nullable enable
    
    /// <summary>
    /// Outcome of the authorisation, and actions to perform.
    /// </summary>
    public required AuthorisationResult12 AuthorisationResult { get; init; } 
    /// <summary>
    /// Set of actions to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    public Action6? Action { get; init; } 
    
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
        writer.WriteStartElement(null, "AuthstnRslt", xmlNamespace );
        AuthorisationResult.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Action is Action6 ActionValue)
        {
            writer.WriteStartElement(null, "Actn", xmlNamespace );
            ActionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CardPaymentTransaction58 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
