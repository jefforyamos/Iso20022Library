﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MailAddress1.  ISO2002 ID# __InD0BrmEeyhRdHRjakS2w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Electronic and physical mail address.
/// </summary>
public partial record MailAddress1
     : IIsoXmlSerilizable<MailAddress1>
{
    #nullable enable
    
    /// <summary>
    /// Physical mail address for correspondance.
    /// </summary>
    public ValueList<PostalAddress1> Correspondence { get; init; } = [];
    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    public SimpleValueList<IsoMax256Text> EmailAddress { get; init; } = [];
    
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
        writer.WriteStartElement(null, "Crspdc", xmlNamespace );
        Correspondence.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "EmailAdr", xmlNamespace );
        EmailAddress.Serialize(writer, xmlNamespace, "Max256Text", SerializationFormatter.IsoMax256Text );
        writer.WriteEndElement();
    }
    public static MailAddress1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
