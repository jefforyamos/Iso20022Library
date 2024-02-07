﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Linkages2.  ISO2002 ID# _Qr1wU9p-Ed-ak6NoX_4Aeg_2141729136.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a linked transaction.
/// </summary>
public partial record Linkages2
     : IIsoXmlSerilizable<Linkages2>
{
    #nullable enable
    
    /// <summary>
    /// When the transaction is to be executed relative to a linked transaction.
    /// </summary>
    public ProcessingPosition1Choice_? ProcessingPosition { get; init; } 
    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    public DocumentNumber1Choice_? MessageNumber { get; init; } 
    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    public required References1Choice_ Reference { get; init; } 
    
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
        if (ProcessingPosition is ProcessingPosition1Choice_ ProcessingPositionValue)
        {
            writer.WriteStartElement(null, "PrcgPos", xmlNamespace );
            ProcessingPositionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MessageNumber is DocumentNumber1Choice_ MessageNumberValue)
        {
            writer.WriteStartElement(null, "MsgNb", xmlNamespace );
            MessageNumberValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Ref", xmlNamespace );
        Reference.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static Linkages2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
