﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalInformation1.  ISO2002 ID# _RX8oYtp-Ed-ak6NoX_4Aeg_-2024158417.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional information about a request (e.g. financing request).
/// </summary>
public partial record AdditionalInformation1
     : IIsoXmlSerilizable<AdditionalInformation1>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of additional information.
    /// </summary>
    public required InformationType1Choice_ InformationType { get; init; } 
    /// <summary>
    /// Contents of the additional information.
    /// </summary>
    public required IsoMax350Text InformationValue { get; init; } 
    
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
        writer.WriteStartElement(null, "InfTp", xmlNamespace );
        InformationType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "InfVal", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax350Text(InformationValue)); // data type Max350Text System.String
        writer.WriteEndElement();
    }
    public static AdditionalInformation1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
