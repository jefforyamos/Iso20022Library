﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PortfolioTransferNotificationIdentification.  ISO2002 ID# _USz3B9p-Ed-ak6NoX_4Aeg_-1699094780.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.References3Choice;

/// <summary>
/// Identification of the portfolio transfer.
/// </summary>
public partial record PortfolioTransferNotificationIdentification : References3Choice_
     , IIsoXmlSerilizable<PortfolioTransferNotificationIdentification>
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
        writer.WriteStartElement(null, "PrtflTrfNtfctnId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Value)); // data type Max35Text System.String
        writer.WriteEndElement();
    }
    public static new PortfolioTransferNotificationIdentification Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
