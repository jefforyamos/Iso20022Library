﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for StatementBasisAsDSS.  ISO2002 ID# _Q7Cp8tp-Ed-ak6NoX_4Aeg_-1630736025.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.StatementBasisCodeAndDSSCodeChoice;

/// <summary>
/// Statement basis expressed as a data source scheme and a code used within the data source scheme.
/// </summary>
public partial record StatementBasisAsDSS : StatementBasisCodeAndDSSCodeChoice_
     , IIsoXmlSerilizable<StatementBasisAsDSS>
{
    #nullable enable
    
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    public required IsoMax8Text Issuer { get; init; } 
    /// <summary>
    /// Proprietary information, often a code, issued by the data source scheme issuer.
    /// </summary>
    public required IsoMax35Text Information { get; init; } 
    
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
        writer.WriteStartElement(null, "Issr", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax8Text(Issuer)); // data type Max8Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Inf", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Information)); // data type Max35Text System.String
        writer.WriteEndElement();
    }
    public static new StatementBasisAsDSS Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
