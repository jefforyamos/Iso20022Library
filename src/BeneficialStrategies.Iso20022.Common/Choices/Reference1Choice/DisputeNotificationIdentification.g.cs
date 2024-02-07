﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DisputeNotificationIdentification.  ISO2002 ID# _QmxqJ9p-Ed-ak6NoX_4Aeg_1843612560.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.Reference1Choice;

/// <summary>
/// Unique identifier of the dispute notification.
/// </summary>
public partial record DisputeNotificationIdentification : Reference1Choice_
     , IIsoXmlSerilizable<DisputeNotificationIdentification>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    public required IsoMax35Text Value { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "DsptNtfctnId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Value)); // data type Max35Text System.String
        writer.WriteEndElement();
    }
    public static new DisputeNotificationIdentification Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
