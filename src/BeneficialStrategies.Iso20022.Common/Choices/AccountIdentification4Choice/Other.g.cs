﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Other.  ISO2002 ID# _Pdwzo9p-Ed-ak6NoX_4Aeg_-1833657786.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice;

/// <summary>
/// Unique identification of an account, as assigned by the account servicer, using an identification scheme.
/// </summary>
public partial record Other : AccountIdentification4Choice_
     , IIsoXmlSerilizable<Other>
{
    #nullable enable
    
    /// <summary>
    /// Identification assigned by an institution.
    /// </summary>
    public required IsoMax34Text Identification { get; init; } 
    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    public AccountSchemeName1Choice_? SchemeName { get; init; } 
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    public IsoMax35Text? Issuer { get; init; } 
    
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
        writer.WriteValue(SerializationFormatter.IsoMax34Text(Identification)); // data type Max34Text System.String
        writer.WriteEndElement();
        if (SchemeName is AccountSchemeName1Choice_ SchemeNameValue)
        {
            writer.WriteStartElement(null, "SchmeNm", xmlNamespace );
            SchemeNameValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Issuer is IsoMax35Text IssuerValue)
        {
            writer.WriteStartElement(null, "Issr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(IssuerValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static new Other Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
