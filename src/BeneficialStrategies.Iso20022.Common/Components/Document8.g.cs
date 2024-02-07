﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Document8.  ISO2002 ID# _96iMRHltEeG7BsjMvd1mEw_-1196515553.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a document.
/// </summary>
public partial record Document8
     : IIsoXmlSerilizable<Document8>
{
    #nullable enable
    
    /// <summary>
    /// Type of document.
    /// </summary>
    public required PresentationDocumentFormat1Choice_ Type { get; init; } 
    /// <summary>
    /// Wording for document.
    /// </summary>
    public IsoMax20000Text? Wording { get; init; } 
    /// <summary>
    /// Details related to an electronic presentation.
    /// </summary>
    public Presentation3? ElectronicDetails { get; init; } 
    
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
        writer.WriteStartElement(null, "Tp", xmlNamespace );
        Type.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Wording is IsoMax20000Text WordingValue)
        {
            writer.WriteStartElement(null, "Wrdg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax20000Text(WordingValue)); // data type Max20000Text System.String
            writer.WriteEndElement();
        }
        if (ElectronicDetails is Presentation3 ElectronicDetailsValue)
        {
            writer.WriteStartElement(null, "ElctrncDtls", xmlNamespace );
            ElectronicDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Document8 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
