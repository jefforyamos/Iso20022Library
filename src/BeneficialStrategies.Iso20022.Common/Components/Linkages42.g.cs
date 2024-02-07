﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Linkages42.  ISO2002 ID# _5PaGy5NLEeWGlc8L7oPDIg.
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
public partial record Linkages42
     : IIsoXmlSerilizable<Linkages42>
{
    #nullable enable
    
    /// <summary>
    /// When the transaction is to be executed relative to a linked transaction.
    /// </summary>
    public ProcessingPosition10Choice_? ProcessingPosition { get; init; } 
    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    public DocumentNumber6Choice_? MessageNumber { get; init; } 
    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    public required References50Choice_ Reference { get; init; } 
    /// <summary>
    /// Party that generates the reference.
    /// </summary>
    public PartyIdentification103Choice_? ReferenceOwner { get; init; } 
    
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
        if (ProcessingPosition is ProcessingPosition10Choice_ ProcessingPositionValue)
        {
            writer.WriteStartElement(null, "PrcgPos", xmlNamespace );
            ProcessingPositionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MessageNumber is DocumentNumber6Choice_ MessageNumberValue)
        {
            writer.WriteStartElement(null, "MsgNb", xmlNamespace );
            MessageNumberValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Ref", xmlNamespace );
        Reference.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ReferenceOwner is PartyIdentification103Choice_ ReferenceOwnerValue)
        {
            writer.WriteStartElement(null, "RefOwnr", xmlNamespace );
            ReferenceOwnerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Linkages42 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
