﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OtherProductCategory.  ISO2002 ID# _RbrR2Np-Ed-ak6NoX_4Aeg_1819640744.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.ProductCategory1Choice;

/// <summary>
/// Specifies the type of product category not present in the code list.
/// </summary>
public partial record OtherProductCategory : ProductCategory1Choice_
     , IIsoXmlSerilizable<OtherProductCategory>
{
    #nullable enable
    
    /// <summary>
    /// Identifier issued to a person for which no specific identifier has been defined.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Specifies the nature of the identifier.|Usage: IdentificationType is used to specify what kind of identifier is used. It should be used in case the identifier is different from the identifiers listed in the pre-defined identifier list.
    /// </summary>
    public required IsoMax35Text IdentificationType { get; init; } 
    
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
        writer.WriteStartElement(null, "Id", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Identification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "IdTp", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(IdentificationType)); // data type Max35Text System.String
        writer.WriteEndElement();
    }
    public static new OtherProductCategory Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
