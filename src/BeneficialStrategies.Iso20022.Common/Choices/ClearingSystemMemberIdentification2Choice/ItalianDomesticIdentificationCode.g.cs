﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ItalianDomesticIdentificationCode.  ISO2002 ID# _TC8KmNp-Ed-ak6NoX_4Aeg_1989940263.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification2Choice;

/// <summary>
/// Italian Domestic Identification Code - identifies Italian financial institutions on the Italian national clearing system. The code is assigned by the Associazione Bancaria Italiana (ABI).
/// </summary>
public partial record ItalianDomesticIdentificationCode : ClearingSystemMemberIdentification2Choice_
     , IIsoXmlSerilizable<ItalianDomesticIdentificationCode>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Italian Domestic Identification Code. Identifies Italian financial institutions on the Italian national clearing system. The code is assigned by the Associazione Bancaria Italiana (ABI).
    /// </summary>
    public required IsoItalianDomesticIdentifier Value { get; init; } 
    
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
        writer.WriteStartElement(null, "ITNCC", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoItalianDomesticIdentifier(Value)); // data type ItalianDomesticIdentifier System.String
        writer.WriteEndElement();
    }
    public static new ItalianDomesticIdentificationCode Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
